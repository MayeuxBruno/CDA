using projet_gnosys.Controller;
using projet_gnosys.Data.Dtos;
using projet_gnosys.Listes;
using projet_gnosys.Models;
using projet_gnosys.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

namespace projet_gnosys.Form
{
    /// <summary>
    /// Logique d'interaction pour FormClient.xaml
    /// </summary>
    public partial class FormClient : Window
    {

        string action;
        Clients ClientWindow;
        private Client client;
        int Id;
        private ClientsController _ClientsController { get; set; }
        public FormClient(string action, Clients win, Client client)
        {
            InitializeComponent();
            this.action = action;
            this.ClientWindow = win;
            this.client = client;
            this.Id = (client == null) ? 0 : client.Id;
            InitPage();
        }

        void InitPage()
        {
            labTitreFormulaire.Content = this.action + " un client";
            this._ClientsController = new ClientsController(new ClientServices());
            btn_Valider.Click += (s, e) => ActionClientAsync(); // On affecte la fonction au bouton
            btn_Valider.Content = this.action;

            switch(this.action)
            {
                case "Ajouter":
                    break;
                case "Modifier":
                    txbNom.Text = this.client.Nom;
                    txbPrenom.Text = this.client.Prenom;
                    txbAdresse.Text= this.client.Adresse;
                    txbCodePostal.Text = this.client.CodePostal;
                    txbVille.Text = this.client.Ville;
                    txbNumtel.Text = this.client.NumerosTelephone;
                    txbMail.Text = this.client.Email;
                    genre.SelectedItem  = genre.FindName(this.client.Genre);

                    break;
                case "Supprimer":
                    txbNom.Text = this.client.Nom;
                    txbPrenom.Text = this.client.Prenom;
                    txbAdresse.Text = this.client.Adresse;
                    txbCodePostal.Text = this.client.CodePostal;
                    txbVille.Text = this.client.Ville;
                    txbNumtel.Text = this.client.NumerosTelephone;
                    txbMail.Text = this.client.Email;
                    genre.SelectedItem = this.client.Genre;
                    txbNom.IsEnabled = false;
                    txbPrenom.IsEnabled = false;
                    txbAdresse.IsEnabled = false;
                    txbCodePostal.IsEnabled = false;
                    txbVille.IsEnabled = false;
                    txbNumtel.IsEnabled = false;
                    txbMail.IsEnabled = false;
                    genre.IsEnabled = false;
                    break;
            }
        }

        public async void ActionClientAsync()
        {

            Client newCli = new Client
            {
                Nom = txbNom.Text,
                Prenom = txbPrenom.Text,
                Adresse = txbAdresse.Text,
                CodePostal = txbCodePostal.Text,
                Ville = txbVille.Text,
                NumerosTelephone = txbNumtel.Text,
                Email = txbMail.Text,
                Genre = (string)genre.SelectionBoxItem,
                IsParticulier = true,
            };
            //this.ClientWindow.CreateProductAsync(newCli);
            //await _ClientsController.CreateClientAsync(newCli);
            await this.ClientWindow.ActionClientAsync(newCli, this.action, this.Id);

            Retour();

        }

        public void Retour(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Retour()
        {
            this.Close();
        }


    }
}
