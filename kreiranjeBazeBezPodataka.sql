create sequence trudnica_id_seq
	as integer;

create sequence simptom_id_seq
	as integer;

create sequence simptomi_id_seq
	as integer;

create sequence dnevnik_login_logout_id_seq
	as integer;

create table if not exists mama
(
	id integer default nextval('trudnica_id_seq'::regclass) not null
		constraint trudnica_pk
			primary key,
	ime varchar(20) not null,
	prezime varchar(30) not null,
	email varchar(40) not null,
	hash_lozinke text not null,
	termin_poroda date not null,
	zadnji_login timestamp
);

alter sequence trudnica_id_seq owned by mama.id;

create unique index if not exists trudnica_id_uindex
	on mama (id);

create table if not exists bol
(
	id serial
		constraint bol_pk
			primary key,
	bol varchar(10) not null
);

create table if not exists trud
(
	id serial
		constraint trud_pk
			primary key,
	id_mame integer not null
		constraint trud_mama_id_fk
			references mama,
	vrijeme time not null,
	trajanje integer not null,
	id_bol integer not null
		constraint trud_bol_id_fk
			references bol,
	datum date not null
);

create unique index if not exists trud_id_uindex
	on trud (id);

create unique index if not exists bol_id_uindex
	on bol (id);

create table if not exists simptom
(
	id integer default nextval('simptomi_id_seq'::regclass) not null
		constraint simptomi_pk
			primary key,
	naziv text not null
);

alter sequence simptomi_id_seq owned by simptom.id;

create table if not exists simptom_mama
(
	id integer default nextval('simptom_id_seq'::regclass) not null
		constraint simptom_pk
			primary key,
	id_simptom integer not null
		constraint simptom_mama_simptom_id_fk
			references simptom,
	datum date not null,
	id_mame integer not null
		constraint simptom_mama_id_fk
			references mama
);

alter sequence simptom_id_seq owned by simptom_mama.id;

create unique index if not exists simptom_id_uindex
	on simptom_mama (id);

create unique index if not exists simptomi_id_uindex
	on simptom (id);

create table if not exists pomak
(
	id serial
		constraint pomak_pk
			primary key,
	id_mame integer not null
		constraint pomak_mama_id_fk
			references mama,
	vrijeme time not null,
	datum date not null
);

create unique index if not exists pomak_id_uindex
	on pomak (id);

create table if not exists biljeska
(
	id serial
		constraint biljeska_pk
			primary key,
	id_mame integer not null
		constraint biljeska_mama_id_fk
			references mama,
	biljeska text not null,
	vrijeme_kreiranja timestamp default CURRENT_TIMESTAMP not null
);

create unique index if not exists biljeska_id_uindex
	on biljeska (id);

create table if not exists "dnevnik_CUD"
(
	id serial
		constraint dnevnik_cud_pk
			primary key,
	id_mame integer
		constraint dnevnik_cud_mama_id_fk
			references mama,
	dogadaj text not null,
	vrijeme timestamp default CURRENT_TIMESTAMP not null
);

create unique index if not exists dnevnik_cud_id_uindex
	on "dnevnik_CUD" (id);

create table if not exists dnevnik_login_logout
(
	id_mame integer not null
		constraint dnevnik_login_logout_mama_id_fk
			references mama,
	vrijeme_login timestamp default CURRENT_TIMESTAMP not null,
	vrijeme_logout timestamp,
	trajanje_sesije interval,
	constraint dnevnik_login_logout_pk
		primary key (vrijeme_login, id_mame)
);

create or replace function provjera_formata_emaila() returns trigger
	language plpgsql
as $$
BEGIN
        IF NEW.email LIKE '%@°%.__' OR NEW.email LIKE '%@°%.___' THEN
            RETURN NEW;
        ELSE
            RAISE EXCEPTION 'E-mail adresa ne sadrzi znak @ ili nije u formatu x@gmail.com/x@foi.hr';
        END IF;
    END
$$;

create trigger provjera_formata_emaila_trigger
	before insert
	on mama
	for each row
	execute procedure provjera_formata_emaila();

create or replace function provjera_dostupnosti_emaila() returns trigger
	language plpgsql
as $$
DECLARE brojZapisa integer;
    BEGIN
        brojZapisa := 0;
        SELECT count(*) INTO brojZapisa FROM mama m WHERE m.email like NEW.email;
        IF brojZapisa>0 THEN
            RAISE EXCEPTION 'E-mail adresa već se koristi';
        ELSE
            raise notice 'dodan';
            return NEW;
        END IF;
    END;
$$;

create trigger provjera_dostupnosti_emaila_trigger
	before insert
	on mama
	for each row
	execute procedure provjera_dostupnosti_emaila();

create or replace function provjera_termina_poroda() returns trigger
	language plpgsql
as $$
BEGIN
        IF NEW.termin_poroda<CURRENT_TIMESTAMP THEN
            RAISE EXCEPTION 'Termin poroda ne može biti prije trenutnog datuma';
        ELSE
            return NEW;
        END IF;
    END;
$$;

create trigger provjera_termina_poroda_trigger
	before insert
	on mama
	for each row
	execute procedure provjera_termina_poroda();

create or replace function provjera_simptoma_mame() returns trigger
	language plpgsql
as $$
BEGIN
        IF exists(select * from simptom_mama where id_mame=new.id_mame and datum=new.datum and id_simptom=new.id_simptom) THEN
            return null;
        ELSE
            return new;
        end if;
    END
$$;

create trigger provjera_simptoma_mame_trigger
	before insert
	on simptom_mama
	for each row
	execute procedure provjera_simptoma_mame();

create or replace function provjera_truda() returns trigger
	language plpgsql
as $$
BEGIN
        IF NEW.trajanje>0 THEN
            IF exists(select * from trud where datum=NEW.datum AND vrijeme=NEW.vrijeme AND id_mame=NEW.id_mame AND trajanje=NEW.trajanje AND id_bol=NEW.id_bol) THEN
                raise exception 'Vec postoji';
            ELSE
                return  NEW;
            END IF;
        ELSE
            raise exception 'Trajanje truda nemože biti 0 sekundi';
        end if;
    END
$$;

create trigger provjera_truda_trigger
	before insert
	on trud
	for each row
	execute procedure provjera_truda();

create or replace function provjera_biljeske() returns trigger
	language plpgsql
as $$
BEGIN
        IF NEW.biljeska like 'Unesite bilješku' THEN
            raise exception 'Polje bilješka ne može biti prazno!';
        ELSE
            return NEW;
        END IF;
    END
$$;

create trigger provjera_biljeske_trigger
	before insert
	on biljeska
	for each row
	execute procedure provjera_biljeske();

create or replace function provjera_pomaka() returns trigger
	language plpgsql
as $$
BEGIN
        IF exists(select * from pomak where id_mame=NEW.id_mame and vrijeme=new.vrijeme and datum=new.datum) THEN
            raise exception 'Već postoji';
        ELSE
            return new;
        END IF;
    END
$$;

create trigger provjera_pomaka_trigger
	before insert
	on pomak
	for each row
	execute procedure provjera_pomaka();

create or replace function zapis_u_dnevnik_simptom_mama() returns trigger
	language plpgsql
as $$
BEGIN
        IF TG_OP = 'INSERT' THEN
            insert into "dnevnik_CUD" (id_mame, dogadaj) VALUES (new.id_mame, concat('Dodaje novi simptom. ID=', new.id));
        ELSEIF TG_OP = 'DELETE' THEN
            insert into "dnevnik_CUD" (id_mame, dogadaj) VALUES (old.id_mame, concat('Briše simptom. ID=', old.id));
        END IF;
        return null;
    END
$$;

create trigger zapis_u_dnevnik_simptom_mama_trigger
	after insert or delete
	on simptom_mama
	for each row
	execute procedure zapis_u_dnevnik_simptom_mama();

create or replace function zapis_u_dnevnik_trud() returns trigger
	language plpgsql
as $$
BEGIN
        IF TG_OP = 'INSERT' THEN
            insert into "dnevnik_CUD" (id_mame, dogadaj) VALUES (new.id_mame, concat('Dodaje novi trud. ID=', new.id));
        ELSEIF TG_OP = 'DELETE' THEN
            insert into "dnevnik_CUD" (id_mame, dogadaj) VALUES (old.id_mame, concat('Briše trud. ID=', old.id));
        END IF;
        return null;
    END
$$;

create trigger zapis_u_dnevnik_trud_trigger
	after insert or delete
	on trud
	for each row
	execute procedure zapis_u_dnevnik_trud();

create or replace function zapis_u_dnevnik_biljeska() returns trigger
	language plpgsql
as $$
BEGIN
        IF TG_OP = 'INSERT' THEN
            insert into "dnevnik_CUD" (id_mame, dogadaj) VALUES (new.id_mame, concat('Dodaje novu bilješku. ID=', new.id));
        ELSEIF TG_OP = 'DELETE' THEN
            insert into "dnevnik_CUD" (id_mame, dogadaj) VALUES (old.id_mame, concat('Briše bilješku. ID=', old.id));
        ELSEIF TG_OP = 'UPDATE' THEN
            insert into "dnevnik_CUD" (id_mame, dogadaj) VALUES (old.id_mame, concat('Ažurira bilješku. ID=', old.id));
        END IF;
        return null;
    END
$$;

create trigger zapis_u_dnevnik_biljeska_trigger
	after insert or update or delete
	on biljeska
	for each row
	execute procedure zapis_u_dnevnik_biljeska();

create or replace function zapis_u_dnevnik_pomak() returns trigger
	language plpgsql
as $$
BEGIN
        IF TG_OP = 'INSERT' THEN
            insert into "dnevnik_CUD" (id_mame, dogadaj) VALUES (new.id_mame, concat('Dodaje novi pomak. ID=', new.id));
        ELSEIF TG_OP = 'DELETE' THEN
            insert into "dnevnik_CUD" (id_mame, dogadaj) VALUES (old.id_mame, concat('Briše pomak. ID=', old.id));
        END IF;
        return null;
    END
$$;

create trigger zapis_u_dnevnik_pomak_trigger
	after insert or update or delete
	on pomak
	for each row
	execute procedure zapis_u_dnevnik_pomak();

create or replace function trajanje_sesije() returns trigger
	language plpgsql
as $$
BEGIN
        update dnevnik_login_logout set trajanje_sesije=new.vrijeme_logout-new.vrijeme_login WHERE id_mame=new.id_mame AND vrijeme_login=new.vrijeme_login;
        return new;
    END
$$;

create trigger trajanje_sesije_trigger
	after update
	of vrijeme_logout
	on dnevnik_login_logout
	for each row
	execute procedure trajanje_sesije();

