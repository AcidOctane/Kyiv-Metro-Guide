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

namespace KyivMteroGuide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // for refreshing
            textBlock3.Text = " ";
            // for equal stations
            if (comboBox1.Text == comboBox2.Text)
            {
                textBlock3.Text = "You are on the spot";
            }
             //red line 
            //for Akademmistechko station
            if (comboBox1.Text == "Akademmistechko")
            { 
                if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "27 min(11 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "9 min (4 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "39 min (16 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "37 min (15 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = " 29 min (12 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = " 32 min (13 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = " 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = " 42 min (17 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "34 min (14 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "16 min (6 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "13 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "23 min (9 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "22 min (8 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "20 min (7 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min(11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "23 min (9 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }


                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "24 min (10 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }

            }
            //for Arsenalna station
            if (comboBox1.Text == "Arsenalna")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "27 min(11 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "18 min (7 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "9 min (4 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "20 min (8 stops) ";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "15 min (6 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "21 min (9 stops) ";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "9 min (4 stops) ";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "25 min (10 stops) ";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "3 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Beresteiska station
            if (comboBox1.Text == "Beresteiska")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "9 min (4 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "18 min (7 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = " 27 min (11 stops) ";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "19 min (8 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "15 min (6 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "32 min (13 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "25 min (10 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "6 min (2 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "14 min (5 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "11 min (4 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "9 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "14 min (5 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "15 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Chernihivska station
            if (comboBox1.Text == "Chernihivska")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "39 min (16 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "32 min (13 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "24 min (10 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "26 min (11 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "33 min (14 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "37 min (15 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "16 min (7 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "14 min (6 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Darnytsia station
            if (comboBox1.Text == "Darnytsia")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "37 min (15 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "9 min (4 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "27 min (11 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "21 min (9 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "21 min (9 stops) ";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "24 min (10 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "31 min (13 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "17 min (8 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "35 min (14 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "28 min (11 stops) - Teatralna \n transfer to Zoloti Vorota \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "14 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "28 min (11 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "12 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Dnipro station
            if (comboBox1.Text == "Dnipro")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "19 min (8 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "22 min (9 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "22 min (9 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "24 min (10 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "27 min (11 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "6 min (3 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "4 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Hidropark station
            if (comboBox1.Text == "Hidropark")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "32 min (13 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "22 min (9 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = " 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "10 min (4 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = " 3 min (non-stop)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "24 min (10 stops)";
                }        
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "26 min (11 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = " 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "8 min (4 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Khreshchatyk station
            if (comboBox1.Text == "Khreshchatyk")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "22 min (9 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "1 min (non- stop) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = " transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Lisova station
            if (comboBox1.Text == "Lisova")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "42 min (17 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "32 min (13 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "10 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = " 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "33 min (14 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "26 min (11 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "28 min (12 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "36 min (15 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "20 min (9 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "39 min (16 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Livoberezhna station
            if (comboBox1.Text == "Livoberezhna")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "34 min (14 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "25 min (10 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = " 3 min (non-stop)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "27 min (11 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "21 min (9 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "32 min (13 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "10 min (4 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Nyvky station
            if (comboBox1.Text == "Nyvky")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "20 min (8 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "32 min (13 stop";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "22 min (9 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "24 min (10 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "17 min (7 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "33 min (14 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "27 min (11 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "16 min (6 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "12 min (4 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "12 min (4 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "15 min (6 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "17 min (7 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Politekhnichnyi Instytut station
            if (comboBox1.Text == "Politekhnichnyi Instytut")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "16 min (6 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "6 min (2 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "24 min (10 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "21 min (9 stops) ";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "26 min (11 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "4 min (non-stop)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "13 min (5 stops) ";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "11 min (5 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "4 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Shuliavska station
            if (comboBox1.Text == "Shuliavska")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "13 min (5 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "15 min (6 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "26 min (11 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "24 min (10 stops) ";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "28 min (12 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "21 min (9 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "6 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "10 min (4 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "11 min (5 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Sviatoshyn station
            if (comboBox1.Text == "Sviatoshyn")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "21 min (9 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "26 min (11 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "31 min (13 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "24 min (10 stops";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "26 min (11 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "36 min (15 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "18 min (7 stops";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "15 min (6 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "13 min (5 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "17 min (7 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "19 min (8 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Teatralna station
            if (comboBox1.Text == "Teatralna")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = " 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "18 min (7 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "21 min (8 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text =  "transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "1 min (non-stop) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Universytet station
            if (comboBox1.Text == "Universytet")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "22 min (8 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "11 min (4 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = " 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "20 min (9 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "13 min (5 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "15 min (6 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "19 min (7 stops)";
                }


                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "2 min (non-stop) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "3 min (2 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }

            }
            //for Vokzalna station
            if (comboBox1.Text == "Vokzalna")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "20 min (7 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "9 min (4 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "9 min (3 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "17 min (8 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "12 min (4 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "4 min (non-stop)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "6 min (2 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "13 min (5 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "3 min (2 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "17 min (6 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "4 min (2 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "5 min (3 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }
            //for Zhytomyrska station
            if (comboBox1.Text == "Zhytomyrska")
            {
                if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "25 min (10 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "11 min (5 stops))";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "37 min (15 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "35 min (14 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "27 min (11 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "29 min (12 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "22 min (9 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "39 min (16 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "32 min (13 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "13 min (5 stops) ";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "21 min (8 stops)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "19 min (7 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "17 min (6 stops)";
                }

                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 5 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 17 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 13 min (3 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "21 min (8 stops) - Teatralna \n transfer to Zoloti Vorota)";
                }

                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 7 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "22 min (9 stops) - Khreshchatyk \n transfer to Maidan Nezalezhnosti \n 17 min (8 stops)";
                }
            }

             //green line 
            //for Boryspilska station
            if (comboBox1.Text == "Boryspilska")
            {
                if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "38 min (13 stops) ";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = " 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "34 min (12 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "9 min (4 stops) ";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = " 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "23 min (8 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "42 min (14 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "42 min (14 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "6 min (6 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "28 min (11 stops)";
                }

                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "28 min (11 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "26 min (10 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Chervony Khutir station
            if (comboBox1.Text == "Chervony Khutir")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "40 min (14 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "22 min (8 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "27 min (10 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "35 min (13 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "29 min (11 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "24 min (9 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "9 min (4 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "43 min (15 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "19 min (7 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "30 min (12 stops)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "30 min (12 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "28 min (11 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }

            }
            //for Dorohozhychi station
            if (comboBox1.Text == "Dorohozhychi")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "38 min (13 stops) ";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "40 min (14 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "19 min (6 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "34 min (11 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "14 min (4 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "27 min (8 stops) ";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "11 min (3 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "16 min (5 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "32 min (10 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "27 min (8 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "21 min (7 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = " 36 min (12 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "10 min (2 stops)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "10 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "12 min (3 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Druzhby Narodiv station
            if (comboBox1.Text == "Druzhby Narodiv")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "22 min (8 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "19 min (6 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "16 min (5 stops) ";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "13 min (5 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "11 min (3 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "13 min (4 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "9 min (2 stops) ";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "21 min (7 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "4 min (non-stop) ";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "17 min (6 stops) ";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "8 min (4 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "6 min (3 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Kharkivska station
            if (comboBox1.Text == "Kharkivska")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "34 min (11 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "16 min (5 stops) ";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "20 min (7 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "29 min (10 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "22 min (8 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "17 min (6 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "37 min (12 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "13 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "24 min (9 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "24 min (9 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }


                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "22 min (8 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Klovska station
            if (comboBox1.Text == "Klovska")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "24 min (9 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "27 min (10 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "14 min (4 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "20 min (7 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "9 min (3 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "16 min (5 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "18 min (6 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "13 min (4 stops) ";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "17 min (5 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "8 min (3 stops) ";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "22 min (8 stops) ";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "3 min (2 stops) ";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "3 min (2 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }


                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "2 min (1 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Lukianivska station
            if (comboBox1.Text == "Lukianivska")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "34 min (12 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "35 min (13 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "5 min (non-stop)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "13 min (5 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "29 min (10 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "9 min (3 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "24 min (8 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "7 min (2 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "11 min (4 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "27 min (9 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "23 min (7 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "7 min (2 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "17 min (6 stops) ";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "31 min (11 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "5 min (non-stop)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "5 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "7 min (2 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Osokorky station
            if (comboBox1.Text == "Osokorky")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "9 min (4 stops) ";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = " 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "27 min (8 stops) ";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "11 min (3 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "16 min (5 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "24 min (8 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = " 13 min (4 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = " 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = " 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "32 min (10 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = " 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "19 min (7 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "19 min (7 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }
                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "17 min (6 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Palats Sportu station
            if (comboBox1.Text == "Palats Sportu")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = " 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "1 min (non-stop) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }
                
                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = " transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Pecherska station
            if (comboBox1.Text == "Pecherska")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "23 min (8 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "24 min (9 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "16 min (5 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "17 min (6 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "11 min (4 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = " 13 min (4 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "16 min (5 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "19 min (6 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "20 min (7 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "6 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "4 min (2 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Pozniaky station
            if (comboBox1.Text == "Pozniaky")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "9 min (4 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "32 min (10 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "13 min (4 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "18 min (6 stops) ";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "27 min (9 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "16 min (5 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "34 min (11 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "9 min (3 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "21 min (8 stops)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "21 min (8 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "20 min (7 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Slavutych station
            if (comboBox1.Text == "Slavutych")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "27 min (8 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "9 min (2 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "13 min (4 stops) ";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "23 min (7 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "15 min (5 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = " 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "30 min (9 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "5 min (non-stop) ";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "9 min (4 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "17 min (6 stops) ";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "17 min (6 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "16 min (5 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Syrets station
            if (comboBox1.Text == "Syrets")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "42 min (14 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "43 min (15 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "21 min (7 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "37 min (12 stops) ";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "17 min (5 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "7 min (2 stops) ";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "32 min (10 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "19 min (6 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "34 min (11 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "30 min (9 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "25 min (8 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "39 min (13 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "14 min (3 stops)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "13 min (3 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "15 min (4 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Vydubychi station
            if (comboBox1.Text == "Vydubychi")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "6 min (6 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "19 min (7 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "21 min (7 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "4 min (non-stop) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "13 min (4 stops) ";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "8 min (3 stops) ";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "17 min (6 stops) ";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = " 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "9 min (3 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "5 min (non-stop) ";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "25 min (8 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "14 min (5 stops) ";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "11 min (5 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }

                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "10 min (4 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Vyrlytsia station
            if (comboBox1.Text == "Vyrlytsia")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "36 min (12 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "17 min (6 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "22 min (8 stops)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "31 min (11 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "24 min (9 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "20 min (7 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = " 9 min (4 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "25 min (8 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "14 min (5 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "26 min (10 stops)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "26 min (10 stops) - Zoloti Vorota \n transfer to Teatralna \n 21 min (8 stops)";
                }


                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "24 min (9 stops) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }
            //for Zoloti Vorota station
            if (comboBox1.Text == "Zoloti Vorota")
            {
                if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "28 min (11 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "30 min (12 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "10 min (2 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "24 min (9 stops) ";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "3 min (2 stops) ";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "5 min (non-stop)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "19 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Sportu")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "21 min (8 stops)";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "17 min (6 stops) ";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }

                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = " transfer to Teatralna \n 23 min (9 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = " transfer to Teatralna \n 4 min (2 stops) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = " transfer to Teatralna \n 14 min (5 stops)";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = " transfer to Teatralna \n 16 min (7 stops)";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = " transfer to Teatralna \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = " transfer to Teatralna \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = " transfer to Teatralna \n 8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = " transfer to Teatralna \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = " transfer to Teatralna \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = " transfer to Teatralna \n 12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = " transfer to Teatralna \n 16 min (6 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = " transfer to Teatralna \n 8 min (3 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = " transfer to Teatralna \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = " transfer to Teatralna \n 18 min (7 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = " transfer to Teatralna";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = " transfer to Teatralna \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = " transfer to Teatralna \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = " transfer to Teatralna \n 21 min (8 stops)";
                }


                //
                else if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu \n transfer to Ploshcha Lva Tolstoho \n 15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "1 min (non-stop) - Palats Sportu\n transfer to Ploshcha Lva Tolstoho";
                }
            }

             //blue line 
            //for Demiivska station
            if (comboBox1.Text == "Demiivska")
            {
                if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "27 min (12 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = " 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "9 min (4 stops) ";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "14 min (7 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = " 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "24 min (11 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "5 min (3 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "3 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }

                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "10 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }

                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "8 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }

            }
            //for Heroiv Dnipra station
            if (comboBox1.Text == "Heroiv Dnipra")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "27 min (12 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "29 min (13 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "36 min (16 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "24 min (11 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = " 21 min (9 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "23 min (10 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "39 min (17 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = " 31 min (14 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "34 min (15 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "17 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "19 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }

            }
            //for Holosiivska station
            if (comboBox1.Text == "Holosiivska")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = " 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "29 min (13 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "16 min (8 stops) ";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "12 min (6 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "26 min (12 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "24 min (11 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "9 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "14 min (7 stops) ";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "18 min (9 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = " 10 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "12 min (6 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "10 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Ipodrom station
            if (comboBox1.Text == "Ipodrom")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "9 min (4 stops) ";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "36 min (16 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "7 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "23 min (11 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "33 min (15 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "32 min (14 stops) ";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "29 min (13 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "17 min (8 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "26 min (12 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "19 min (9 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "17 min (8 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Kontraktova Ploshcha station
            if (comboBox1.Text == "Kontraktova Ploshcha")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "14 min (7 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "16 min (8 stops) ";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "23 min (11 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "12 min (6 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = " 5 min (2 stops) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "8 min (3 stops) ";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "11 min (5 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = " 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = " 27 min (12 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "21 min (10 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Lybidska station
            if (comboBox1.Text == "Lybidska")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "3 min (non-stop)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "24 min (11 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "12 min (6 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "7 min (4 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "1 min (non-stop)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "17 min (8 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "14 min (7 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "8 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "6 min (3 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Maidan Nezalezhnosti station
            if (comboBox1.Text == "Maidan Nezalezhnosti")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = " 9 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "12 min (6 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "7 min (4 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "1 min (non-stop)";  
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "17 min (8 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = " transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = " transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "1 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Minska station
            if (comboBox1.Text == "Minska")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = " 24 min (11 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "26 min (12 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = " 33 min (15 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "20 min (9 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "5 min (2 stops) ";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "17 min (7 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "36 min (16 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "29 min (13 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "32 min (14 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "6 min (14 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "17 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Obolon station
            if (comboBox1.Text == "Obolon")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "24 min (11 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "32 min (14 stops) ";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = " 8 min (3 stops) ";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "19 min (8 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "10 min (4 stops) ";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "6 min (2 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "35 min (15 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "27 min (12 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "29 min (13 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "12 min (5 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "14 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Olimpiiska station
            if (comboBox1.Text == "Olimpiiska")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "5 min (3 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = " 21 min (9 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "8 min (4 stops) ";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "13 min (6 stops) ";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "7 min (3 stops) ";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "14 min (6 stops) ";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "4 min (2 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "2 min (non-stop) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Palats Ukrayina station
            if (comboBox1.Text == "Palats Ukrayina")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "3 min (2 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "23 min (10 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "11 min (5 stops) ";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "1 min (non-stop)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "20 min (9 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "19 min (8 stops) ";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "9 min (4 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "9 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "12 min (5 stops) ";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Petrivka station
            if (comboBox1.Text == "Petrivka")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "29 min (13 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "17 min (8 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "7 min (3 stops";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = " 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "31 min (14 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = " 24 min (11 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "27 min (12 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "9 min (4 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "11 min (5 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Ploshcha Lva Tolstoho station
            if (comboBox1.Text == "Ploshcha Lva Tolstoho")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = " 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "9 min (5 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "17 min (8 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "6 min (3 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = " 1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "17 min (7 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "1 min (non-stop) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "15 min (7 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = " transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = " transfer to Palats Soprtu";
                }
            }
            //for Poshtova Ploshcha station
            if (comboBox1.Text == "Poshtova Ploshcha")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "14 min (6 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "14 min (7 stops) ";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "10 min (4 stops) ";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "7 min (3 stops) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = " 9 min (4 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "25 min (11 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = " 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "20 min (9 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "2 min (non-stop) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "4 min (2 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Tarasa Shevchenka station
            if (comboBox1.Text == "Tarasa Shevchenka")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "18 min (9 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "26 min (12 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "2 min (non-stop) ";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "14 min (7 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = " 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "8 min (3 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = " 6 min (2 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "11 min (5 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = " 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "8 min (4 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "28 min (13 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "21 min (10 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "24 min (11 stops) ";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "6 min (3 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "9 min (4 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Teremky station
            if (comboBox1.Text == "Teremky")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "12 min (5 stops) ";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "39 min (17 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "10 min (4 stops) ";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "27 min (12 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "22 min (10 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "36 min (16 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "35 min (15 stops) ";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "18 min (8 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "16 min (7 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "31 min (14 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "20 min (9 stops) ";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "25 min (11 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "28 min (13 stops) ";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "22 min (10 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "20 min (9 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Vasylkivska station
            if (comboBox1.Text == "Vasylkivska")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = " 31 min (14 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = " 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "4 min (2 stops)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "19 min (9 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "29 min (13 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "29 min (13 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "27 min (12 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "10 min (5 stops)";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "9 min (4 stops) ";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "24 min (11 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "13 min (6 stops)";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = " 17 min (8 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "21 min (10 stops)";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Vystavkovyi Tsentr")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "15 min (7 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "13 min (6 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
            //for Vystavkovyi Tsentr station
            if (comboBox1.Text == "Vystavkovyi Tsentr")
            {
                if (comboBox2.Text == "Demiivska")
                {
                    textBlock3.Text = "7 min (3 stops)";
                }
                else if (comboBox2.Text == "Heroiv Dnipra")
                {
                    textBlock3.Text = "34 min (15 stops)";
                }
                else if (comboBox2.Text == "Holosiivska")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Ipodrom")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                else if (comboBox2.Text == "Kontraktova Ploshcha")
                {
                    textBlock3.Text = "21 min (10 stops)";
                }
                else if (comboBox2.Text == "Lybidska")
                {
                    textBlock3.Text = "10 min (4 stops)";
                }
                else if (comboBox2.Text == "Maidan Nezalezhnosti")
                {
                    textBlock3.Text = "17 min (8 stops)";
                }
                else if (comboBox2.Text == "Minska")
                {
                    textBlock3.Text = "32 min (14 stops)";
                }
                else if (comboBox2.Text == "Obolon")
                {
                    textBlock3.Text = "29 min (13 stops)";
                }
                else if (comboBox2.Text == "Olimpiiska")
                {
                    textBlock3.Text = "14 min (6 stops) ";
                }
                else if (comboBox2.Text == "Palats Ukrayina")
                {
                    textBlock3.Text = "12 min (5 stops)";
                }
                else if (comboBox2.Text == "Petrivka")
                {
                    textBlock3.Text = "27 min (12 stops)";
                }
                else if (comboBox2.Text == "Ploshcha Lva Tolstoho")
                {
                    textBlock3.Text = "15 min (7 stops";
                }
                else if (comboBox2.Text == "Poshtova Ploshcha")
                {
                    textBlock3.Text = "20 min (9 stops)";
                }
                else if (comboBox2.Text == "Tarasa Shevchenka")
                {
                    textBlock3.Text = "24 min (11 stops) ";
                }
                else if (comboBox2.Text == "Teremky")
                {
                    textBlock3.Text = "5 min (2 stops)";
                }
                else if (comboBox2.Text == "Vasylkivska")
                {
                    textBlock3.Text = "2 min (non-stop)";
                }
                //
                else if (comboBox2.Text == "Akademmistechko")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 25 min (10 stops)";
                }
                else if (comboBox2.Text == "Arsenalna")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (non-stop) ";
                }
                else if (comboBox2.Text == "Beresteiska")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Chernihivska")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 15 min (6 stops) ";
                }
                else if (comboBox2.Text == "Darnytsia")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 12 min (5 stops)";
                }
                else if (comboBox2.Text == "Dnipro")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 5 min (2 stops)";
                }
                else if (comboBox2.Text == "Hidropark")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 7 min (3 stops)";
                }
                else if (comboBox2.Text == "Lisova")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops) ";
                }
                else if (comboBox2.Text == "Livoberezhna")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Nyvky")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 17 min (7 stops)";
                }
                else if (comboBox2.Text == "Politekhnichnyi Instytut")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 8 min (4 stops)";
                }
                else if (comboBox2.Text == "Shuliavska")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 11 min (5 stops)";
                }
                else if (comboBox2.Text == "Sviatoshyn")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 18 min (8 stops)";
                }
                else if (comboBox2.Text == "Teatralna")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 1 min (non-stop)";
                }
                else if (comboBox2.Text == "Universytet")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 3 min (2 stops)";
                }
                else if (comboBox2.Text == "Vokzalna")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 6 min (3 stops)";
                }
                else if (comboBox2.Text == "Zhytomyrska")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk \n 22 min (9 stops)";
                }
                else if (comboBox2.Text == "Khreshchatyk")
                {
                    textBlock3.Text = "17 min (8 stops) -  Maidan Nezalezhnosti \n transfer to Khreshchatyk";
                }
                //
                else if (comboBox2.Text == "Boryspilska")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 27 min (10 stops)";
                }
                else if (comboBox2.Text == "Chervony Khutir")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 29 min (11 stops)";
                }
                else if (comboBox2.Text == "Dorohozhychi")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 11 min (3 stops)";
                }
                else if (comboBox2.Text == "Druzhby Narodiv")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 6 min (3 stops) ";
                }
                else if (comboBox2.Text == "Kharkivska")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 22 min (8 stops)";
                }
                else if (comboBox2.Text == "Klovska")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Lukianivska")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 7 min (2 stops)";
                }
                else if (comboBox2.Text == "Osokorky")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 18 min (6 stops)";
                }
                else if (comboBox2.Text == "Pecherska")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 4 min (2 stops)";
                }
                else if (comboBox2.Text == "Pozniaky")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 20 min (7 stops) ";
                }
                else if (comboBox2.Text == "Slavutych")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (5 stops)";
                }
                else if (comboBox2.Text == "Syrets")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 15 min (4 stops) ";
                }
                else if (comboBox2.Text == "Vydubychi")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 10 min (4 stops)";
                }
                else if (comboBox2.Text == "Vyrlytsia")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 24 min (9 stops)";
                }
                else if (comboBox2.Text == "Zoloti Vorota")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu \n 2 min (non-stop)";
                }
                else if (comboBox2.Text == "Palats Soprtu")
                {
                    textBlock3.Text = "15 min (7 stops) - Ploshcha Lva Tolstoho \n transfer to Palats Soprtu";
                }
            }
        }
    }
}
