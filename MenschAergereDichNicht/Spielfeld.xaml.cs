﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
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
        int prevnum = -1;
        List<Player> Spieler = new List<Player>();
        Positions fieldPositions = new Positions();
        Spielzug aktZug = new Spielzug();
        Figure[] greenFigures;
        Figure[] redFigures;
        Figure[] blueFigures;
        Figure[] yellowFigures;
        Zugkontrolle zugkontrolle;

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
            //zugkontrolle = new Zugkontrolle(greenFigures, redFigures, blueFigures, yellowFigures);
            InitializeComponent();
           
        }

        
        /// <summary>
        ///  If you click on the dice, it will roll a number for you. This number is shown to you on the dice, and in a label above there is a text with it aswell.
        ///  If you roll the same number twice, it say it to you
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                rolledDice = number;
                
                if(number != prevnum)
                LblAusgabe.Content = "Es wurde eine " + number + " gewürfelt!";
                else
                LblAusgabe.Content = "Schon wieder eine " + number + "!";
                 
               
                 prevnum = number;

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
            
        }
    }
}
