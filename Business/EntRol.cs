using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
 public  class EntRol
    {
        public EntRol()
        {
        }

        public int IdRol { get; set; }
        public string Rol { get; set; }
        public bool Active { get; set; }


        public EntRol(DataRow r)
        {
            IdRol = Convert.ToInt32(r["IdRol"]);
            Rol = Convert.ToString(r["Rol"]);
            Active = Convert.ToBoolean(r["Active"]);
        }

    }
}
