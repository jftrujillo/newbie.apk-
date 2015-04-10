using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Devices.Geolocation;
using System.Diagnostics;
using newbie.Models;
using newbie.Net;



namespace newbie
{
    public partial class Page2 : PhoneApplicationPage, MongoLugares<lugares>.IMongo
    {
        MongoLugares<lugares> mongolugares;

        public Page2()
        {
            InitializeComponent();
            mongolugares = new MongoLugares<lugares>("LhKNFNvGBnePdXB4llfdnJEwbWPMEDM7", "newbie", "ListaLugares");
            mongolugares.findAllDocumentsLugares(this);
            Geolocator locator = new Geolocator()
            {
                DesiredAccuracy = PositionAccuracy.High,
                DesiredAccuracyInMeters = 0
            };
        }

        private async void gps(object sender, RoutedEventArgs e)
        {
          
        }

        public async void loadDocumentsLugares(List<lugares> documentsL)
        {
            Geolocator locator = new Geolocator() { DesiredAccuracy = PositionAccuracy.High, DesiredAccuracyInMeters = 10 };
            Geoposition posicion = await locator.GetGeopositionAsync();
            double latitud = posicion.Coordinate.Latitude;
            double longitud = posicion.Coordinate.Longitude;
            ListaLugares dataLugares = Application.Current.Resources["ListaLugares"] as ListaLugares;

            dataLugares.Data.Clear();

            for (int i = 0; i < documentsL.Count; i++)
            {
               
               var lugaractual = documentsL.ElementAt(i);
               double Altituddef = lugaractual.Altitud - latitud;
               double Al = Math.Abs(Altituddef);
               double longituddef = lugaractual.Longitud - longitud;
               double Lon = Math.Abs(longituddef);
                if ((Al <20) && (Lon <20))
               {
                   dataLugares.Data.Add(documentsL.ElementAt(i));

               }
                


            }


        }

        private void irvistagenerallugar(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var x = ListaLugares.SelectedIndex;
            NavigationService.Navigate(new Uri("/VistaLugar.xaml?dato1=" + x, UriKind.Relative));
        }
    }
}