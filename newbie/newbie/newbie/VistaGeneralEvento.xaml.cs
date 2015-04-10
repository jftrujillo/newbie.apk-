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
    public partial class Page1 : PhoneApplicationPage
    {
        
        public Page1()
        {
            InitializeComponent();
            
            
        }

        

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
            if (NavigationContext.QueryString.ContainsKey("dato1")) 
            {


                ContentPanel.DataContext = Application.Current.Resources["ListaEventosLunes"] as ListaEventosLunes;
                string dato1 = NavigationContext.QueryString["dato1"];
                int datoinit = Convert.ToInt16(dato1);
                var datodef = Math.Abs(datoinit);
                
                var list = Application.Current.Resources["ListaEventosLunes"] as ListaEventosLunes;
                mostrar.DataContext = list.Data[datodef];         
            }

            if (NavigationContext.QueryString.ContainsKey("dato2"))
            {


                ContentPanel.DataContext = Application.Current.Resources["ListaEventosMartes"] as ListaEventosMartes;
                string dato2 = NavigationContext.QueryString["dato2"];
                int datoinit = Convert.ToInt16(dato2);
                var datodef = Math.Abs(datoinit);

                var list = Application.Current.Resources["ListaEventosMartes"] as ListaEventosMartes;
                mostrar.DataContext = list.Data[datodef];





            }
            if (NavigationContext.QueryString.ContainsKey("dato3"))
            {


                ContentPanel.DataContext = Application.Current.Resources["ListaEventosMiercoles"] as ListaEventosMiercoles;
                string dato3 = NavigationContext.QueryString["dato3"];
                int datoinit = Convert.ToInt16(dato3);
                var datodef = Math.Abs(datoinit);

                var list = Application.Current.Resources["ListaEventosMiercoles"] as ListaEventosMiercoles;
                mostrar.DataContext = list.Data[datodef];
            }
            if (NavigationContext.QueryString.ContainsKey("dato4"))
            {


                ContentPanel.DataContext = Application.Current.Resources["ListaEventosJueves"] as ListaEventosJueves;
                string dato4 = NavigationContext.QueryString["dato4"];
                int datoinit = Convert.ToInt16(dato4);
                var datodef = Math.Abs(datoinit);

                var list = Application.Current.Resources["ListaEventosJueves"] as ListaEventosJueves;
                mostrar.DataContext = list.Data[datodef];
            }

            if (NavigationContext.QueryString.ContainsKey("dato5"))
            {


                ContentPanel.DataContext = Application.Current.Resources["ListaEventosViernes"] as ListaEventosViernes;
                string dato5 = NavigationContext.QueryString["dato5"];
                int datoinit = Convert.ToInt16(dato5);
                var datodef = Math.Abs(datoinit);

                var list = Application.Current.Resources["ListaEventosViernes"] as ListaEventosViernes;
                mostrar.DataContext = list.Data[datodef];
            }



        }
    }
}