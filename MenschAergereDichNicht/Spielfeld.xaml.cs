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
        List<Player> Spieler = new List<Player>();
        Positions fieldPositions = new Positions();
        Spielzug aktZug = new Spielzug();
        Figure[] greenFigures;
        Figure[] redFigures;
        Figure[] blueFigures;
        Figure[] yellowFigures;

        Button[] greenButtons;
        Button[] redButtons;
        Button[] blueButtons;
        Button[] yellowButtons;

        Zugkontrolle zugkontrolle = new Zugkontrolle();
        int prevnum = -1;

        int rolledDice = -1;
        internal Spielfeld(List<Player> player)
        {
            Spieler = player;
            aktZug.spieler = 0;
            greenFigures = new Figure[4] { new Figure(-1, ColConst.col_green), new Figure(-2, ColConst.col_green), new Figure(-3, ColConst.col_green), new Figure(-4, ColConst.col_green) };
            redFigures = new Figure[4] { new Figure(-1, ColConst.col_red), new Figure(-2, ColConst.col_red), new Figure(-3, ColConst.col_red), new Figure(-4, ColConst.col_red) };
            blueFigures = new Figure[4] { new Figure(-1, ColConst.col_blue), new Figure(-2, ColConst.col_blue), new Figure(-3, ColConst.col_blue), new Figure(-4, ColConst.col_blue) };
            yellowFigures = new Figure[4] { new Figure(-1, ColConst.col_yellow), new Figure(-2, ColConst.col_yellow), new Figure(-3, ColConst.col_yellow), new Figure(-4, ColConst.col_yellow) };
          
            InitializeComponent();
            greenButtons = new Button[4] { btnFigGruen0, btnFigGruen1, btnFigGruen2, btnFigGruen3 };
            redButtons = new Button[4] { btnFigRot0, btnFigRot1, btnFigRot2, btnFigRot3 };
            blueButtons = new Button[4] { btnFigBlau0, btnFigBlau1, btnFigBlau2, btnFigBlau3 };
            yellowButtons = new Button[4] { btnFigGelb0, btnFigGelb1, btnFigGelb2, btnFigGelb3 };
            aktSpielerLabel.Content = Spieler[aktZug.spieler].Name;
            aktSpielerLabel.Foreground = ColConst.getColorBrush(Spieler[aktZug.spieler].Farbe);
        }


        private void nextPlayer()
        {
            if(aktZug.spieler >= Spieler.Count - 1) {
                aktZug.spieler = 0;
            }
            else
            {
                aktZug.spieler++;
            }
            aktSpielerLabel.Content = Spieler[aktZug.spieler].Name;
            aktSpielerLabel.Foreground = ColConst.getColorBrush(Spieler[aktZug.spieler].Farbe);
            LblAusgabe.Content = "Du bist dran";
        }

        /// <summary>
        ///  If you click on the dice, it will roll a number for you. This number is shown to you on the dice, and in a label above there is a text with it aswell.
        ///  If you roll the same number twice, it say it to you
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dice_Click(object sender, RoutedEventArgs e)
        {
            
            if (aktZug.zugstatus <= Zugstatus.hausVoll3 && aktZug.zugstatus>Zugstatus.spielVorbei)
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

                if (number != prevnum)
                {
                    LblAusgabe.Content = "Es wurde eine " + number + " gewürfelt!";
                }
                else
                {
                    LblAusgabe.Content = "Schon wieder eine " + number + "!";
                }

                zugkontrolle.checkWurf(aktZug, rolledDice, getAktFigures());
                if (aktZug.zugstatus == Zugstatus.naechsterSpieler)
                {
                    aktZug.zugstatus = Zugstatus.ersterWurf;
                    nextPlayer();
                }
                aktSpielerLabel.Content = Spieler[aktZug.spieler].Name;
                aktSpielerLabel.Foreground = ColConst.getColorBrush(Spieler[aktZug.spieler].Farbe);

                


                prevnum = number;

            }

        }

        private Figure[] getAktFigures()
        {
            switch (Spieler[aktZug.spieler].Farbe)
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
            if (aktZug.zugstatus == Zugstatus.spielVorbei)
            {
                return;
            }
            if (aktZug.zugstatus > Zugstatus.hausVoll3 && color == Spieler[aktZug.spieler].Farbe) { 
            int selectedFigure = fieldPositions.whichFigure(getAktFigures(), figure.Margin);
                if (aktZug.zugstatus == Zugstatus.rausgehen)
                {
                    if (getAktFigures()[selectedFigure].relPos < 0)
                    {
                        getAktFigures()[selectedFigure].relPos = 0;
                        drawFigure(figure, selectedFigure);
                        aktZug.zugstatus = Zugstatus.ersterWurf;
                    }
                    else
                    {
                        //nachricht: du musst raus
                    }
                }
                else if (aktZug.zugstatus == Zugstatus.vorHausWegziehen)
                {
                    if (getAktFigures()[selectedFigure].relPos == 0)
                    {
                        getAktFigures()[selectedFigure].relPos += rolledDice;
                        drawFigure(figure, selectedFigure);
                        if (rolledDice != 6)
                        {
                            aktZug.zugstatus = Zugstatus.naechsterSpieler;
                        }
                        else
                        {
                            aktZug.zugstatus = Zugstatus.ersterWurf;
                        }
                    }
                    else
                    {
                        //nachricht: du musst weg vorm Haus
                    }
                }
                else if (aktZug.zugstatus == Zugstatus.ziehen)
                {
                    if (getAktFigures()[selectedFigure].relPos > 0 && (getAktFigures()[selectedFigure].relPos + rolledDice) < 40
                        && !fieldPositions.checkSameColPos(getAktFigures(), getAktFigures()[selectedFigure].relPos + rolledDice))
                    {
                        getAktFigures()[selectedFigure].relPos += rolledDice;
                        drawFigure(figure, selectedFigure);
                        if (rolledDice == 6)
                        {
                            aktZug.zugstatus = Zugstatus.ersterWurf;
                        }
                        else
                        {
                            aktZug.zugstatus = Zugstatus.naechsterSpieler;
                        }
                    }
                    else if ((getAktFigures()[selectedFigure].relPos+rolledDice) > 39 && (getAktFigures()[selectedFigure].relPos + rolledDice) < 44)
                    {
                        int tempPos;
                        bool zulaessigInGarage = true;
                        if (getAktFigures()[selectedFigure].relPos + 1<40)
                        {
                            tempPos = 40;
                        }
                        else
                        {
                            tempPos = getAktFigures()[selectedFigure].relPos+1;
                        }

                        while (tempPos <= getAktFigures()[selectedFigure].relPos + rolledDice)
                        {
                            if (fieldPositions.checkSameColPos(getAktFigures(), tempPos))
                            {
                                zulaessigInGarage = false;
                            }
                            tempPos++;
                        }
                        if (zulaessigInGarage)
                        {
                            getAktFigures()[selectedFigure].relPos += rolledDice;
                            drawFigure(figure, selectedFigure);
                            if (aktZug.zugstatus == Zugstatus.spielVorbei)
                            {
                                return;
                            }else if (rolledDice == 6)
                            {
                                aktZug.zugstatus = Zugstatus.ersterWurf;
                            }
                            else
                            {
                                aktZug.zugstatus = Zugstatus.naechsterSpieler;
                            }
                        }
                    }
                }
                if (aktZug.zugstatus == Zugstatus.naechsterSpieler)
                {
                    nextPlayer();
                    aktZug.zugstatus = Zugstatus.ersterWurf;
                }
            }
            aktSpielerLabel.Content = Spieler[aktZug.spieler].Name;
            aktSpielerLabel.Foreground = ColConst.getColorBrush(Spieler[aktZug.spieler].Farbe);
        }

        public void drawFigure(Button figure, int selectedFigure)
        {
            Pos targetPos = fieldPositions.GetCoord(getAktFigures()[selectedFigure]);
            figure.Margin = new Thickness(targetPos.xPos, targetPos.yPos, 0, 0);
            Figure toBeKicked = fieldPositions.maybeSendHome(blueFigures, redFigures, yellowFigures, greenFigures, getAktFigures()[selectedFigure]);
            Pos sendHomePos;
            if (toBeKicked!=null)
            {
                
                switch (toBeKicked.color)
                {
                    case ColConst.col_blue:
                        sendHomePos = fieldPositions.SendHome(blueFigures, fieldPositions.maybeSendHome(blueFigures, redFigures, yellowFigures, greenFigures, getAktFigures()[selectedFigure]));
                        foreach (Button btn in blueButtons)
                        {
                            if(btn.Margin.Left==targetPos.xPos && btn.Margin.Top == targetPos.yPos)
                            {
                                btn.Margin = new Thickness(sendHomePos.xPos, sendHomePos.yPos, 0, 0);
                            }
                        }                        
                        break;
                    case ColConst.col_red:
                        sendHomePos = fieldPositions.SendHome(redFigures, fieldPositions.maybeSendHome(blueFigures, redFigures, yellowFigures, greenFigures, getAktFigures()[selectedFigure]));
                        foreach (Button btn in redButtons)
                        {
                            if (btn.Margin.Left == targetPos.xPos && btn.Margin.Top == targetPos.yPos)
                            {
                                btn.Margin = new Thickness(sendHomePos.xPos, sendHomePos.yPos, 0, 0);
                            }
                        }
                        break;
                    case ColConst.col_yellow:
                        sendHomePos = fieldPositions.SendHome(yellowFigures, fieldPositions.maybeSendHome(blueFigures, redFigures, yellowFigures, greenFigures, getAktFigures()[selectedFigure]));
                        foreach (Button btn in yellowButtons)
                        {
                            if (btn.Margin.Left == targetPos.xPos && btn.Margin.Top == targetPos.yPos)
                            {
                                btn.Margin = new Thickness(sendHomePos.xPos, sendHomePos.yPos, 0, 0);
                            }
                        }
                        break;
                    case ColConst.col_green:
                        sendHomePos = fieldPositions.SendHome(greenFigures, fieldPositions.maybeSendHome(blueFigures, redFigures, yellowFigures, greenFigures, getAktFigures()[selectedFigure]));
                        foreach (Button btn in greenButtons)
                        {
                            if (btn.Margin.Left == targetPos.xPos && btn.Margin.Top == targetPos.yPos)
                            {
                                btn.Margin = new Thickness(sendHomePos.xPos, sendHomePos.yPos, 0, 0);
                            }
                        }
                        break;
                }
                //fieldPositions.maybeSendHome(blueFigures, redFigures, yellowFigures, greenFigures, getAktFigures()[selectedFigure]);
            }

            int winSum = 0;
            foreach(Figure figure1 in getAktFigures())
            {
                winSum += figure1.relPos;
            }

            if (winSum == 166)
            {
                aktSpielerLabel.Content = Spieler[aktZug.spieler].Name + " hat Gewonnen!!!!!!!!";
                aktZug.zugstatus = Zugstatus.spielVorbei;
            }
        }

    }
}
