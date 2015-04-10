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
    public partial class ListaEventos : PhoneApplicationPage, Mongo<Eventos>.IMongo 


    {
        
        Mongo<Eventos> mongoLunes;
        Mongo<Eventos> mongomartes;
        Mongo<Eventos> mongomiercoles;
        Mongo<Eventos> mongojueves;
        Mongo<Eventos> mongoviernes;

        
        public ListaEventos()
        {
            
            InitializeComponent();
            
            mongoLunes = new Mongo<Eventos>("LhKNFNvGBnePdXB4llfdnJEwbWPMEDM7", "newbie","ListaEventosLunes");
            mongoLunes.findAllDocumentsLunes(this);
            
            mongomartes = new Mongo<Eventos>("LhKNFNvGBnePdXB4llfdnJEwbWPMEDM7", "newbie", "ListaEventosMartes");
            mongomartes.findAllDocumentsMartes(this);

            mongomiercoles = new Mongo<Eventos>("LhKNFNvGBnePdXB4llfdnJEwbWPMEDM7", "newbie", "ListaEventosMiercoles");
            mongomiercoles.findAllDocumentsMiercoles(this);

            mongojueves = new Mongo<Eventos>("LhKNFNvGBnePdXB4llfdnJEwbWPMEDM7", "newbie", "ListaEventosJueves");
            mongojueves.findAllDocumentsJueves(this);

            mongoviernes = new Mongo<Eventos>("LhKNFNvGBnePdXB4llfdnJEwbWPMEDM7", "newbie", "ListaEventosViernes");
            mongoviernes.findAllDocumentsViernes(this);

            
           
        }

        public void loadDocumentsLunes(List<Eventos> documentsL)
        {
            
               ListaEventosLunes dataLunes = Application.Current.Resources["ListaEventosLunes"] as ListaEventosLunes;

                dataLunes.Data.Clear();

                for (int i = 0; i < documentsL.Count; i++)
                {
                    
                    dataLunes.Data.Add(documentsL.ElementAt(i));
                    

                }

                
         
        }
        public void loadDocumentsMartes(List<Eventos> documentsL)
        {

            ListaEventosMartes datamartes = Application.Current.Resources["ListaEventosMartes"] as ListaEventosMartes;

            datamartes.Data.Clear();

            for (int i = 0; i < documentsL.Count; i++)
            {

                datamartes.Data.Add(documentsL.ElementAt(i));


            }
        }

        public void loadDocumentsMiercoles(List<Eventos> documentsL)
        {

            ListaEventosMiercoles datamiercoles = Application.Current.Resources["ListaEventosMiercoles"] as ListaEventosMiercoles;

            datamiercoles.Data.Clear();

            for (int i = 0; i < documentsL.Count; i++)
            {

                datamiercoles.Data.Add(documentsL.ElementAt(i));


            }
        }

        public void loadDocumentsJueves(List<Eventos> documentsL)
        {

            ListaEventosJueves datajueves = Application.Current.Resources["ListaEventosJueves"] as ListaEventosJueves;

            datajueves.Data.Clear();

            for (int i = 0; i < documentsL.Count; i++)
            {

                datajueves.Data.Add(documentsL.ElementAt(i));


            }
        }

        public void loadDocumentsViernes(List<Eventos> documentsL)
        {

            ListaEventosViernes dataviernes = Application.Current.Resources["ListaEventosViernes"] as ListaEventosViernes;

            dataviernes.Data.Clear();

            for (int i = 0; i < documentsL.Count; i++)
            {

                dataviernes.Data.Add(documentsL.ElementAt(i));


            }
        }








        private void Vistagenralmartes(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var x = ListaMartes.SelectedIndex;
            NavigationService.Navigate(new Uri("/VistaGeneralEvento.xaml?dato2=" + x, UriKind.Relative));

        }

        private void Vistageneralmiercoles(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var x = ListaMiercoles.SelectedIndex;
            NavigationService.Navigate(new Uri("/VistaGeneralEvento.xaml?dato3=" + x, UriKind.Relative));

        }

        private void Vistageneraljueves(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var x = ListaJueves.SelectedIndex;
            NavigationService.Navigate(new Uri("/VistaGeneralEvento.xaml?dato4=" + x, UriKind.Relative));
        }

        private void VistaGeneralViernes(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var x = ListaViernes.SelectedIndex;
            NavigationService.Navigate(new Uri("/VistaGeneralEvento.xaml?dato5=" + x, UriKind.Relative));
        }

        private void irvistageneral(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var x = ListaLunes.SelectedIndex;
            NavigationService.Navigate(new Uri("/VistaGeneralEvento.xaml?dato1=" + x, UriKind.Relative));
        }
    }
}