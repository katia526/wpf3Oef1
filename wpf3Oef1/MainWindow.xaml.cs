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

namespace wpf3Oef1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string g;
        string c;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void Geslacht_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             
            

        }

        public void categorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
       

        public void btnDruk_Click(object sender, RoutedEventArgs e)
        {
           g = ((ComboBoxItem)Geslacht.SelectedItem).Content.ToString();
            c = ((ComboBoxItem)categorie.SelectedItem).Content.ToString();
            MessageBox.Show($"De persoon is een {g} en is {c}");

         
        }
    }
}
