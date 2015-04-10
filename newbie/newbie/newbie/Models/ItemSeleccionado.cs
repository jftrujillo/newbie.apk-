using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbie.Models
{
    public class ItemSeleccionado
    {
        private ObservableCollection<Eventos> item;
        public ObservableCollection<Eventos> Item
        {
            get {
                if (item == null) {

                    item = new ObservableCollection<Eventos>();
                
                }
                return item;
            
            }
            set {
                item = value;
            
            }


        }
    }
}
