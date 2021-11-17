using Newtonsoft.Json;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionProduits
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Produits> liste = new List<Produits>();
        
        public MainWindow()
        {
            InitializeComponent();
            liste = CreerListe();
            RemplirGrid();
        }

        public void RemplirGrid()
        {
            dgProduits.ItemsSource = liste;
        }

        private List<Produits> CreerListe()
        {
            for (int i = 0; i < 15; i++)
            {
                Produits p = new Produits(i, "Produit " + i, "Catégorie " + i * 2, "Rayon " + i * 3);
                liste.Add(p);
            }
            return liste;
        }

        private void btnAjout_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Show();

        }
        


    }
}
