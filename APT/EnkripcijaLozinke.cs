using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt;
using System.Collections;
using System.Windows.Forms;

namespace APT
{
    public static class EnkripcijaLozinke
    {
        public static string GenerateSaltedHash(string lozinka, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(lozinka, salt);
        }
        public static string GenerateSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt();
        }

        public static bool ProvjeriLozinku(string lozinka, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(lozinka, hash);
        }
    }
}
