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
        public Spielfeld()
        {
            InitializeComponent();
        }

        private void btnFigGruen0_Click(object sender, RoutedEventArgs e)
        {
            //btnFigGruen0.Margin = new Thickness(224 + 9, -6,0,0);
            //MessageBox.Show(btnFigGruen0.Margin.Top.ToString());
            moveFigure(btnFigGruen0);
        }

        private void Dice_Click(object sender, RoutedEventArgs e)
        {

            Random dice = new Random();
            int number;
            
           number = dice.Next(1, 7);

            switch (number)
            {
                case 1:
                    ImgDice1.Source = new BitmapImage(new Uri(@"Assets/dieWhite_border1.png", UriKind.Relative)); 
                    break;
                case 2:
                    ImgDice1.Source = new BitmapImage(new Uri(@"Assets/dieWhite_border2.png", UriKind.Relative));
                    break;
                case 3:
                    ImgDice1.Source = new BitmapImage(new Uri(@"Assets/dieWhite_border3.png", UriKind.Relative));
                    break;
                case 4:
                    ImgDice1.Source = new BitmapImage(new Uri(@"Assets/dieWhite_border4.png", UriKind.Relative));
                    break;
                case 5:
                    ImgDice1.Source = new BitmapImage(new Uri(@"Assets/dieWhite_border5.png", UriKind.Relative));
                    break;
                case 6:
                    ImgDice1.Source = new BitmapImage(new Uri(@"Assets/dieWhite_border6.png", UriKind.Relative));
                    break;
            }

        }




        private void moveFigure(Button figure)
        {
            int currentPos = fieldPositions.GetPos(figure.Margin);
            int newPos = fieldPositions.incrementPosition(currentPos, 5);
            Pos newCoord = fieldPositions.GetCoord(newPos);
            figure.Margin = new Thickness(newCoord.xPos, newCoord.yPos, 0, 0);
        }
    }
}
