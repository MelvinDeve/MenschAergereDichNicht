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
    /// Interaction logic for Spielfeld.xaml
    /// </summary>
    public partial class Spielfeld : Window
    {
        Positions fieldPositions = new Positions();
        int rolledDice = -1;
        public Spielfeld()
        {
            InitializeComponent();
        }

        private void btnFigGruen0_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGruen0, rolledDice, ColConst.col_green);
        }
        private void btnFigGruen1_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGruen1, rolledDice, ColConst.col_green);
        }
        private void btnFigGruen2_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGruen2, rolledDice, ColConst.col_green);
        }
        private void btnFigGruen3_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGruen3, rolledDice, ColConst.col_green);
        }

        private void btnFigBlau0_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigBlau0, rolledDice, ColConst.col_blue);
        }
        private void btnFigBlau1_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigBlau1, rolledDice, ColConst.col_blue);
        }
        private void btnFigBlau2_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigBlau2, rolledDice, ColConst.col_blue);
        }
        private void btnFigBlau3_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigBlau3, rolledDice, ColConst.col_blue);
        }

        private void btnFigGelb0_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGelb0, rolledDice, ColConst.col_yellow);
        }
        private void btnFigGelb1_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGelb1, rolledDice, ColConst.col_yellow);
        }
        private void btnFigGelb2_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGelb2, rolledDice, ColConst.col_yellow);
        }
        private void btnFigGelb3_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGelb3, rolledDice, ColConst.col_yellow);
        }

        private void btnFigRot0_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigRot0, rolledDice, ColConst.col_red);
        }
        private void btnFigRot1_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigRot1, rolledDice, ColConst.col_red);
        }
        private void btnFigRot2_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigRot2, rolledDice, ColConst.col_red);
        }
        private void btnFigRot3_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigRot3, rolledDice, ColConst.col_red);
        }

        private void moveFigure(Button figure, int diceNumber, int color)
        {
            if (diceNumber == -1)
            {
                return;
            }

            int currentPos = fieldPositions.GetPos(figure.Margin);
            if (currentPos == -1)
            {
                
            }

                int newPos = fieldPositions.incrementPosition(currentPos, 5);
                Pos newCoord = fieldPositions.GetCoord(newPos);
                figure.Margin = new Thickness(newCoord.xPos, newCoord.yPos, 0, 0);
            
        }
    }
}
