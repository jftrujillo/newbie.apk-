using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbie.Models
{
    public class lugares
    {
        public Oid _id { get; set; }
        public String NombreLugar { get; set; }
        public String Descripcion { get; set; }
        public String BreveDescripcion { get; set; }
        public String Direccion { get; set; }
        public String Logotipo { get; set; }
        public String ImagenLugar { get; set; }
        public double Altitud { get; set; }
        public double Longitud { get; set; }

    }
}
