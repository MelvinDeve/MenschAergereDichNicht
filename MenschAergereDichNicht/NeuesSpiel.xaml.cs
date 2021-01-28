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
            List<Player> Spieler = new List<Player>();

            if(TxtBxName1.Text!="Name" && TxtBxName1.Text != "")
            {
                Spieler.Add(new Player(TxtBxName1.Text, ColConst.col_blue));
            }
            if (TxtBxName2.Text != "Name" && TxtBxName2.Text != "")
            {
                Spieler.Add(new Player(TxtBxName2.Text, ColConst.col_red));
            }
            if (TxtBxName3.Text != "Name" && TxtBxName3.Text != "")
            {
                Spieler.Add(new Player(TxtBxName3.Text, ColConst.col_yellow));
            }
            if (TxtBxName4.Text != "Name" && TxtBxName4.Text != "")
            {
                Spieler.Add(new Player(TxtBxName4.Text, ColConst.col_green));
            }

            if (Spieler.Count > 0)
            {
                Spielfeld spielfeld = new Spielfeld(Spieler);
                this.Close();
                spielfeld.ShowDialog();
            }
            
        }
    }
}
