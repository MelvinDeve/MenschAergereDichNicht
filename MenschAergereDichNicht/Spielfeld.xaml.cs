﻿using System;
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
        List<Player> Spieler = new List<Player>();
        Positions fieldPositions = new Positions();
        Spielzug aktZug = new Spielzug();
        Figure[] greenFigures;
        Figure[] redFigures;
        Figure[] blueFigures;
        Figure[] yellowFigures;
        Zugkontrolle zugkontrolle = new Zugkontrolle();

        int rolledDice = -1;
        public Spielfeld()
        {
            Spieler.Add(new Player("Hans", ColConst.col_green));
            Spieler.Add(new Player("Frank", ColConst.col_blue));
            aktZug.spieler = Spieler[0];
            greenFigures = new Figure[4] { new Figure(-1, ColConst.col_green), new Figure(-2, ColConst.col_green), new Figure(-3, ColConst.col_green), new Figure(-4, ColConst.col_green) };
            redFigures = new Figure[4] { new Figure(-1, ColConst.col_red), new Figure(-2, ColConst.col_red), new Figure(-3, ColConst.col_red), new Figure(-4, ColConst.col_red) };
            blueFigures = new Figure[4] { new Figure(-1, ColConst.col_blue), new Figure(-2, ColConst.col_blue), new Figure(-3, ColConst.col_blue), new Figure(-4, ColConst.col_blue) };
            yellowFigures = new Figure[4] { new Figure(-1, ColConst.col_yellow), new Figure(-2, ColConst.col_yellow), new Figure(-3, ColConst.col_yellow), new Figure(-4, ColConst.col_yellow) };
          
            InitializeComponent();
        }

        private void Dice_Click(object sender, RoutedEventArgs e)
        {
            if (aktZug.zugstatus < Zugstatus.hausVoll3)
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

                rolledDice = number;

                zugkontrolle.checkWurf(aktZug, rolledDice, getAktFigures());

            }
        }

        private Figure[] getAktFigures()
        {
            switch (aktZug.spieler.Farbe)
            {
                case ColConst.col_blue:
                    return blueFigures;
                case ColConst.col_green:
                    return greenFigures;
                case ColConst.col_red:
                    return redFigures;
                case ColConst.col_yellow:
                    return yellowFigures;
                default:
                    return blueFigures;
            }
        }

        private void btnFigGruen0_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGruen0, ColConst.col_green);
        }
        private void btnFigGruen1_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGruen1, ColConst.col_green);
        }
        private void btnFigGruen2_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGruen2, ColConst.col_green);
        }
        private void btnFigGruen3_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGruen3, ColConst.col_green);
        }

        private void btnFigBlau0_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigBlau0, ColConst.col_blue);
        }
        private void btnFigBlau1_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigBlau1, ColConst.col_blue);
        }
        private void btnFigBlau2_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigBlau2, ColConst.col_blue);
        }
        private void btnFigBlau3_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigBlau3, ColConst.col_blue);
        }

        private void btnFigGelb0_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGelb0, ColConst.col_yellow);
        }
        private void btnFigGelb1_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGelb1, ColConst.col_yellow);
        }
        private void btnFigGelb2_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGelb2, ColConst.col_yellow);
        }
        private void btnFigGelb3_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigGelb3, ColConst.col_yellow);
        }

        private void btnFigRot0_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigRot0, ColConst.col_red);
        }
        private void btnFigRot1_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigRot1, ColConst.col_red);
        }
        private void btnFigRot2_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigRot2, ColConst.col_red);
        }
        private void btnFigRot3_Click(object sender, RoutedEventArgs e)
        {
            moveFigure(btnFigRot3, ColConst.col_red);

        }

        private void moveFigure(Button figure,  int color)
        {
            int selectedFigure;
            if(aktZug.zugstatus == Zugstatus.rausgehen)
            {
                /*
                 *if(geklickteFigurImHaus){
                 *   geklickteFigur.relPos = 0;
                 *}
                 */
            }
            /*
            if (aktZug.zugstatus == Zugstatus.ziehen)
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
            */
            
        }
    }
}
