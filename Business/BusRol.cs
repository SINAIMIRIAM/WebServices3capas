using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class BusRol
    {
        public List<EntRol> Mostrar()
        {
            List<EntRol> lst = new List<EntRol>();
            DatRol dat = new DatRol();
            DataTable dt = dat.Mostrar();

            foreach (DataRow dr in dt.Rows)
            {
                EntRol e = new EntRol(dr);
                lst.Add(e);
            }
            return lst;

        }

        public EntRol Detalles(int IdRol)
        {
            return new EntRol(new DatRol().Detalles(IdRol));

        }

        public void Agregar(EntRol r)
        {
            if (new DatRol().Agregar(r.Rol,r.Active) != 1)
                throw new ApplicationException("No se Agrego");

        }

        public void Eliminar(int IdRol)
        {
            if (new DatRol().Eliminar(IdRol) != 1)
                throw new ApplicationException("No se Elimino");

        }

        public void Actualizar(EntRol r)
        {
            if (new DatRol().Actualizar(r.Rol, r.Active, r.IdRol) != 1)
                throw new ApplicationException("No se Actualizo");

        }
    }
}
