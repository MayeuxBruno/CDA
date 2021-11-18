using System;
using System.Collections.Generic;
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

namespace GestionProduits
{
    /// <summary>
    /// Logique d'interaction pour FormAdd.xaml
    /// </summary>
    public partial class FormAdd : Window
    {
        MainWindow Fenetre;
        public string Param { get; set; }
        public FormAdd(string param, MainWindow fenetre)
        {
            this.Param = param;
            this.Fenetre = fenetre;
            InitializeComponent();
            MiseEnPage();
        }

        public void MiseEnPage()
        {
            Titre.Content = Param + " un produit";
            //action.Content = Param;
        }

        public void BtnAction_Click(object sender, RoutedEventArgs e)
        {
            Produits prod = new Produits(Convert.ToInt32(IdProduit.Text),LibelleProduit.Text,((ComboBoxItem)(Categorie.SelectedValue)).Content.ToString() ,((ComboBoxItem)(Rayon.SelectedItem)).Content.ToString());
            List<Produits> liste = Fenetre.ConvertJsonList();
            liste.Add(prod);
            Fenetre.EcrireFichier(liste);
            this.Close();
        }

        private void BtnAnnule_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
