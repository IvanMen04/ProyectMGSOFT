using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    abstract class Emplea2
    {
        public abstract int idEmpleado { get; set; }
        public abstract string nomEmpleado { get; set; }
        public abstract string Domicilio { get; set; }
        public abstract string Telefono { get; set; }
        public abstract string Correo { get; set; }
        public abstract string EstadoEmpleado { get; set; }
        // public abstract string lbArea { get; set; }

        public abstract bool Guardar();
        public abstract bool Actualizar();
    }
}
