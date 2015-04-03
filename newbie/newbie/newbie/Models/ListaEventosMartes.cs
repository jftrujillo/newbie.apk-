using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbie.Models
{
    public class ListaEventosMartes
    {
        private ObservableCollection<Eventos> data;
        public ObservableCollection<Eventos> Data
        {
            get
            {
                if (data == null)
                {
                    data = new ObservableCollection<Eventos>();
                    Eventos item1 = new Eventos()
                    {
                        NombreEvento = "MisaMartes",
                        BreveDescripcion = "Se celebra en la capilla principal",
                        Hora = "8:00 a.m."
                    };
                    Eventos item2 = new Eventos()
                    {
                        NombreEvento = "Conmemoracion XM",
                        BreveDescripcion = "Recordamos el segundo legado del papa",
                        Hora = "12:00 a.m."

                    };

                    Eventos item3 = new Eventos()
                    {
                        NombreEvento = "Platos tipicos X",
                        BreveDescripcion = "Comida tipica de Popayan",
                        Hora = "4:00 p.m."

                    };
                    data.Add(item1);
                    data.Add(item2);
                    data.Add(item3);
                }
                return data;
            }
            set
            {
                data = value;
            }
        }
    }
}