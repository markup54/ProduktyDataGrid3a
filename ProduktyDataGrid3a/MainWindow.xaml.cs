using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ProduktyDataGrid3a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> listaProduktow = null;
        private ObservableCollection<string> listaKategorii = null;
        public MainWindow()
        {
            InitializeComponent();
            przygotujWiazanie();
        }
        private void przygotujWiazanie()
        {
            listaKategorii = new ObservableCollection<string>() { "buty", "ubrania", "dodatki" };
            katagorieComboBox.ItemsSource = listaKategorii;
            listaProduktow = new ObservableCollection<Produkt>();
            listaProduktow.Add(new Produkt("trampki", 50, true, "buty"));
            listaProduktow.Add(new Produkt("spodnie", 50, true, "ubrania"));
            listaProduktow.Add(new Produkt("rękawiczki", 30, true, "dodatki"));
            listaProduktow.Add(new Produkt("okulary słoneczne", 130, false, "dodatki"));
            listaProduktow.Add(new Produkt("kozaki", 150, false, "buty"));
            dataGridProdukty.ItemsSource = listaProduktow;
        }
    }
}
