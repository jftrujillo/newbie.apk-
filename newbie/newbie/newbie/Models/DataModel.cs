using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbie.Models
{
    public class DataModel
    {
        private ObservableCollection<Eventos> data;
        public ObservableCollection<Eventos> Data
        {
            get  {
                if (data == null)
                {
                    data = new ObservableCollection<Eventos>();
                    
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

                