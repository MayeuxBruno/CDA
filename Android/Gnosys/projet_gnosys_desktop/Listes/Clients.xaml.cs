using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using projet_gnosys.Controller;
using projet_gnosys.Data.Dtos;
using projet_gnosys.Form;
using projet_gnosys.Models;
using projet_gnosys.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;



namespace projet_gnosys.Listes
{
    /// <summary>
    /// Logique d'interaction pour Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        private MainWindow _FenetreMere { get; }

        private ClientServices _ClientServices { get; set; }
        private ClientsController _clientController { get;  set; }

        
      


        public Clients(MainWindow parent)
        {
            InitializeComponent();
            this._FenetreMere = parent;
            Init();
        }

        private void Init()
        {
            this._ClientServices = new ClientServices();
            this._clientController = new ClientsController(this._ClientServices);

            RefreshDGAsync();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            if (this.Left != this._FenetreMere.Left || this.Top != this._FenetreMere.Top)
            {
                this._FenetreMere.Left = this.Left;
                this._FenetreMere.Top = this.Top;
            }
            this.Close();
        }

        private void Button_Action(object sender, RoutedEventArgs e)
        {
            string nom = (string)((Button)sender).Content;
            Client client=new Client();
            if (nom!="Ajouter")
            {
                client = (Client)dg.SelectedItem;
            }
            if (client == null && (nom == "Modifier" || nom == "Supprimer"))
            {
                MessageBox.Show("Vous devez sélectionner une ligne", "Erreur de sélection", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                FormClient action = new FormClient(nom, this, client);
                this.Opacity = 0.7;
                action.ShowDialog();
                this.Opacity = 1;
                RefreshDGAsync();
            }
        }

        public async void RefreshDGAsync()
        {
            this.dg.ItemsSource = await _ClientServices.GetAllClientAsync();
        }

        public async Task ActionClientAsync (Client client, string action, int id)
        {
            switch (action)
            {
                case "Ajouter":
                    await _clientController.CreateClientAsync(client);
                    break;
                case "Modifier":
                    await _clientController.UpdateClientAsync(client, id);
                    break;
                case "Supprimer":
                    await _clientController.DeleteClientAsync(id);
                    break;
            }
            RefreshDGAsync();
        }
       


    }
}
