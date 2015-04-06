using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbie.Models
{
    public class Eventos
    {
        public Oid _id { get; set; }
        public String NombreEvento { get; set; }
        public String Descripcion { get; set; }
        public String BreveDescripcion { get; set; }
        public String Hora { get; set; }
        public String Fecha { get; set; }
        public String ImagenLugarEvento { get; set; }
        public String LugarDelEvento { get; set; }

    }
}
