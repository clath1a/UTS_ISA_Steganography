using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uuuISA_Class
{
    public class Status_Peminjaman
    {
        private int idStatus;
        private string name;

        public Status_Peminjaman(int idStatus, string name)
        {
            IdStatus = idStatus;
            Name = name;
        }

        public int IdStatus { get => idStatus; set => idStatus = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return name;
        }
    }
}
