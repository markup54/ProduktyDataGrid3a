using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;

namespace ProduktyDataGrid3a
{
    /// <summary>
    /// Logika interakcji dla klasy ZplikuXMLWindow.xaml
    /// </summary>
    public partial class ZplikuXMLWindow : Window
    {
        private string plik1 = @"..\..\..\dane\Produkty.xml";
        private XElement wykazProduktow;
        public ZplikuXMLWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }
        private void PrzygotujWiazanie()
        {
            if (File.Exists(plik1))
            {
                //otwieranie pliku ładowanie danych
                wykazProduktow = XElement.Load(plik1);
                dataGridProdukty.DataContext = wykazProduktow;
            }
            else
            {
                MessageBox.Show("plik nie istnieje");
            }
        }
    }
}
