using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbie.Models
{
    public class ListaEventosLunes
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
                        NombreEvento = "Misa",
                        BreveDescripcion = "Se celebra en la capilla asdfadsfasfdsafadsaf",
                        Hora = "7:00 a.m."
                    };
                    Eventos item2 = new Eventos()
                    {
                        NombreEvento = "Conmemoracion X",
                        BreveDescripcion = "Recordamos el legado del papa",
                        Hora = "10:00 a.m."

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
            set {
                data = value;
            }
        }
    }
}
