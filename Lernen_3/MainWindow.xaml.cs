using Lernen_3.Klassen;
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

namespace Lernen_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Pizza> Pizzas { get; set; }

        public MainWindow()
        {
            Pizzas = new ObservableCollection<Pizza>();
            Pizzas.Add(new Pizza("Meine Pizza", 3));
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double diameter = Double.Parse(PizzaDiameter.Text);
            Pizza pizza = new Pizza(PizzaName.Text, diameter);
            Pizzas.Add(pizza);
            //Anzeige.Content = pizza.Name + " hat einen Durchmesser von " + pizza.Diameter + "cm und einen Umfang von " + Math.Round(pizza.Range, 2) + "cm.";
        }
    }
}
