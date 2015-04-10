using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newbie.Models
{
    public class ListaLugares
    {
        private ObservableCollection<lugares> data;
        public ObservableCollection<lugares> Data
        {
            get
            {
                if (data == null)
                {
                    data = new ObservableCollection<lugares>();

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