using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication1
{
   abstract class Trabajo_2
    {
        public abstract int idTrabajo { get; set; }
        public abstract string trabajo { get; set; }
        public abstract string AreaTrabajo { get; set; }
        public abstract DateTime Fecha { get; set; }
        public abstract string EstadoTrabajo { get; set; }
        public abstract string Empleado { get; set; }
        public abstract string Cliente { get; set; }

        /*public abstract int FKidTrabajo { get; set; }


        public abstract DateTime Fecha2 { get; set; }
        public abstract string Trabajo { get; set; }
        public abstract string AreaTrabajo { get; set; }
        public abstract string EstadoTrabajo { get; set; }
        public abstract int idTrabajo { get; set; }*/

        public abstract bool Guardar();
        //public abstract bool Guardar2();
        public abstract bool Actualizar();
        public abstract DataTable reporte();
    }
}
