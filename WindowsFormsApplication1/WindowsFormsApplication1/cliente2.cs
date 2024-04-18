using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication1
{
    abstract class cliente2
    {
        public abstract int idCliente { get; set; }
        public abstract string nomCliente { get; set; }
        public abstract string Domicilio { get; set; }
        public abstract string Telefono { get; set; }
        public abstract DateTime Fecha { get; set; }
        
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
