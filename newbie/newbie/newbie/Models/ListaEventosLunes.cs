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
                        Hora = "7:00 a.m.",
                        Descripcion = "evento por el cual una gran cantidad de gente se congrega para adorar a dios en su maxima expresion. lo cual cuenta con una hermosa seremonia ideal para todos los creyentes asfdasdfasdfsdfasfadsfads holih holi holi holi y con esto acaba asfdasdfasdfadsfasdfasfasfsafadfasfadsfadsfasfasdfsafasfasfasfadsfasf",
                        Fecha="24 de marzo",
                        ImagenLugarEvento = "http://img.eltiempo.com/Multimedia/galeria_fotos/viajar/IMAGEN/IMAGEN-13531035-2.png",
                        LugarDelEvento="Catedral principal y aledañas adsfasdfadsfasdfadsfasdf"
                    };
                    Eventos item2 = new Eventos()
                    {
                        NombreEvento = "Conmemoracion X",
                        BreveDescripcion = "Recordamos el legado del papa",
                        Hora = "10:00 a.m.",
                        Descripcion = "Recordamos la llegada del papa a colombia y con el gran cantidad de enseñanzas para la vida",
                        Fecha="24 de marzo",
                        ImagenLugarEvento = "http://static.panoramio.com/photos/large/31370879.jpg",
                        LugarDelEvento="Coliseo la Estancia"
                        

                    };

                    Eventos item3 = new Eventos()
                    {
                        NombreEvento = "Platos tipicos X",
                        BreveDescripcion = "Comida tipica de Popayan",
                        Hora = "4:00 p.m.",
                        Descripcion="Deliciosa muestra de platos tipicos donde las delicias payanesas haces su aparicion a nivel mundial",
                        Fecha="24 de marzo",
                        ImagenLugarEvento = "http://upload.wikimedia.org/wikipedia/commons/thumb/9/9d/Whitecity.jpg/220px-Whitecity.jpg",
                        LugarDelEvento="Parque Caldas"
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
