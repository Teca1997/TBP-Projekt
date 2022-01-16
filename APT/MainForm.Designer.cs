
namespace APT
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.lblOsnovniPodatci = new System.Windows.Forms.Label();
            this.lblZadnjiLogin = new System.Windows.Forms.Label();
            this.lblTrajanjeSesije = new System.Windows.Forms.Label();
            this.timerSesije = new System.Windows.Forms.Timer(this.components);
            this.lblDaniDoTermina = new System.Windows.Forms.Label();
            this.btnSImptomi = new System.Windows.Forms.Button();
            this.btnTrudovi = new System.Windows.Forms.Button();
            this.btnPomaci = new System.Windows.Forms.Button();
            this.btnBiljeske = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdjaviSe.Location = new System.Drawing.Point(622, 12);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(150, 50);
            this.btnOdjaviSe.TabIndex = 3;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = false;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // lblOsnovniPodatci
            // 
            this.lblOsnovniPodatci.AutoSize = true;
            this.lblOsnovniPodatci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsnovniPodatci.Location = new System.Drawing.Point(12, 9);
            this.lblOsnovniPodatci.Name = "lblOsnovniPodatci";
            this.lblOsnovniPodatci.Size = new System.Drawing.Size(134, 20);
            this.lblOsnovniPodatci.TabIndex = 4;
            this.lblOsnovniPodatci.Text = "lblOsnovniPodatci";
            // 
            // lblZadnjiLogin
            // 
            this.lblZadnjiLogin.AutoSize = true;
            this.lblZadnjiLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZadnjiLogin.Location = new System.Drawing.Point(12, 29);
            this.lblZadnjiLogin.Name = "lblZadnjiLogin";
            this.lblZadnjiLogin.Size = new System.Drawing.Size(106, 20);
            this.lblZadnjiLogin.TabIndex = 5;
            this.lblZadnjiLogin.Text = "lblZadnjiLogin";
            // 
            // lblTrajanjeSesije
            // 
            this.lblTrajanjeSesije.AutoSize = true;
            this.lblTrajanjeSesije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrajanjeSesije.Location = new System.Drawing.Point(12, 49);
            this.lblTrajanjeSesije.Name = "lblTrajanjeSesije";
            this.lblTrajanjeSesije.Size = new System.Drawing.Size(123, 20);
            this.lblTrajanjeSesije.TabIndex = 6;
            this.lblTrajanjeSesije.Text = "lblTrajanjeSesije";
            // 
            // timerSesije
            // 
            this.timerSesije.Enabled = true;
            this.timerSesije.Interval = 1000;
            this.timerSesije.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDaniDoTermina
            // 
            this.lblDaniDoTermina.AutoSize = true;
            this.lblDaniDoTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaniDoTermina.Location = new System.Drawing.Point(12, 69);
            this.lblDaniDoTermina.Name = "lblDaniDoTermina";
            this.lblDaniDoTermina.Size = new System.Drawing.Size(135, 20);
            this.lblDaniDoTermina.TabIndex = 7;
            this.lblDaniDoTermina.Text = "lblDaniDoTermina";
            // 
            // btnSImptomi
            // 
            this.btnSImptomi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSImptomi.Location = new System.Drawing.Point(12, 399);
            this.btnSImptomi.Name = "btnSImptomi";
            this.btnSImptomi.Size = new System.Drawing.Size(150, 50);
            this.btnSImptomi.TabIndex = 8;
            this.btnSImptomi.Text = "Simptomi";
            this.btnSImptomi.UseVisualStyleBackColor = false;
            this.btnSImptomi.Click += new System.EventHandler(this.btnSImptomi_Click);
            // 
            // btnTrudovi
            // 
            this.btnTrudovi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrudovi.Location = new System.Drawing.Point(168, 399);
            this.btnTrudovi.Name = "btnTrudovi";
            this.btnTrudovi.Size = new System.Drawing.Size(150, 50);
            this.btnTrudovi.TabIndex = 9;
            this.btnTrudovi.Text = "Trudovi";
            this.btnTrudovi.UseVisualStyleBackColor = false;
            this.btnTrudovi.Click += new System.EventHandler(this.btnTrudovi_Click);
            // 
            // btnPomaci
            // 
            this.btnPomaci.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPomaci.Location = new System.Drawing.Point(324, 399);
            this.btnPomaci.Name = "btnPomaci";
            this.btnPomaci.Size = new System.Drawing.Size(150, 50);
            this.btnPomaci.TabIndex = 10;
            this.btnPomaci.Text = "Pomaci bebe";
            this.btnPomaci.UseVisualStyleBackColor = false;
            this.btnPomaci.Click += new System.EventHandler(this.btnPomaci_Click);
            // 
            // btnBiljeske
            // 
            this.btnBiljeske.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBiljeske.Location = new System.Drawing.Point(480, 399);
            this.btnBiljeske.Name = "btnBiljeske";
            this.btnBiljeske.Size = new System.Drawing.Size(150, 50);
            this.btnBiljeske.TabIndex = 11;
            this.btnBiljeske.Text = "Bilješke";
            this.btnBiljeske.UseVisualStyleBackColor = false;
            this.btnBiljeske.Click += new System.EventHandler(this.btnBiljeske_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APT.Properties.Resources.logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.ControlBox = false;
            this.Controls.Add(this.btnBiljeske);
            this.Controls.Add(this.btnPomaci);
            this.Controls.Add(this.btnTrudovi);
            this.Controls.Add(this.btnSImptomi);
            this.Controls.Add(this.lblDaniDoTermina);
            this.Controls.Add(this.lblTrajanjeSesije);
            this.Controls.Add(this.lblZadnjiLogin);
            this.Controls.Add(this.lblOsnovniPodatci);
            this.Controls.Add(this.btnOdjaviSe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacija za praćenje trudnoće";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Label lblOsnovniPodatci;
        private System.Windows.Forms.Label lblZadnjiLogin;
        private System.Windows.Forms.Label lblTrajanjeSesije;
        private System.Windows.Forms.Timer timerSesije;
        private System.Windows.Forms.Label lblDaniDoTermina;
        private System.Windows.Forms.Button btnSImptomi;
        private System.Windows.Forms.Button btnTrudovi;
        private System.Windows.Forms.Button btnPomaci;
        private System.Windows.Forms.Button btnBiljeske;
    }
}