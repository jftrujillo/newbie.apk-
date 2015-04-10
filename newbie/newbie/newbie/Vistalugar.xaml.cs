using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using newbie.Models;
using newbie.Net;

namespace newbie
{
    public partial class Vistalugar : PhoneApplicationPage
    {
        public Vistalugar()
        {
            InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            if (NavigationContext.QueryString.ContainsKey("dato1"))
            {



                string dato1 = NavigationContext.QueryString["dato1"];
                int datoinit = Convert.ToInt16(dato1);
                var datodef = Math.Abs(datoinit);

                var list = Application.Current.Resources["ListaLugares"] as ListaLugares;
                mostrar.DataContext = list.Data[datodef];
            }

        }


    }
}