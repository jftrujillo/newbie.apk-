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
        Mongo<Eventos> mongo;
        public ListaEventos()
        {
            InitializeComponent();
            mongo = new Mongo<Eventos>("LhKNFNvGBnePdXB4llfdnJEwbWPMEDM7", "newbie","ListaEventosLunes");
            mongo.findAllDocuments(this);
        }

        public void loadDocuments(List<Eventos> documents)
        {
            ListaEventosLunes dataM = Application.Current.Resources["ListaEventosLunes"] as ListaEventosLunes;
            for (int i = 0; i < documents.Count; i++) {
                dataM.Data.Add(documents.ElementAt(i));
            
            }
        }
    }
}