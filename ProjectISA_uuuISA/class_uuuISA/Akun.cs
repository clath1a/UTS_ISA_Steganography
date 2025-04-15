using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectISA_uuuISA
{
    internal class Akun
    {
        int idAkun;
        string username;
        string password;
        Role idRole;

        public int IdAkun { get => idAkun; set => idAkun = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        internal Role IdRole { get => idRole; set => idRole = value; }
    }
}
