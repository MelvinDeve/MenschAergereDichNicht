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

namespace MenschAergereDichNicht
{
    /// <summary>
    /// Interaction logic for NeuesSpiel.xaml
    /// </summary>
    public partial class NeuesSpiel : Window
    {
        public NeuesSpiel()
        {
            InitializeComponent();
        }

        private void BtnSpielStarten_Click(object sender, RoutedEventArgs e)
        {
            NeuesSpiel neuesSpiel = new NeuesSpiel();
            neuesSpiel.ShowDialog();
        }
    }
}
