using Newtonsoft.Json;
using System;
using System.IO;
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
        List<Produits> liste;
        string path = @"..*../../ListeProduit.json";
       
        public MainWindow()
        {
            InitializeComponent();
            liste = ConvertJsonList();
            ConvertJsonList();
            RemplirGrid();
        }

        public void RemplirGrid()
        {
            dgProduits.ItemsSource = liste;
        }

        public void EcrireFichier(List<Produits> li)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(li,Formatting.Indented));
        }

        private string LireFichier()
        {
            string chaine="";
            try
            {
                chaine = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception s'est produite : " + e.Message);
                Console.WriteLine("Entrez le Path : ");
                path = Console.ReadLine();
            }
            return chaine;
        }
        public List<Produits> ConvertJsonList()
        {
            string chaine = LireFichier();
            List<Produits> liste = JsonConvert.DeserializeObject<List<Produits>>(chaine);
            return liste;
        }
        private void BtnAjout_Click(object sender, RoutedEventArgs e)
        {
            string param = "Ajouter"; 
            this.Opacity = 0.5;
            FormAdd a = new FormAdd(param,this);

            a.ShowDialog();
            this.Opacity = 1;
           
        }
    }
}
