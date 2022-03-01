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

namespace project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Lista benne a kérdések számával
        // Tárolja a kérdéseket majd random beadja azokat
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 3 int ami mutatja az aktuális kérdést
        int qNum = 0;
        int i;
        int score;


        public MainWindow()
        {
            InitializeComponent();

            

            StartGame();
            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            // Itt a gombok hozzá vannak linkelve a canvasba
          

            Button senderButton = sender as Button; //  megnézi melyik gomb lett lenyomva

            // megnézi hogy meglett e nyova ha igen ad egy pontot
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            // reseteli a kérdések számát ha kevesebb mint nulla
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                // ha nagyobb mint egy hozzá ad egy számot
                qNum++;
            }

            // updateli a labelt ha meg lett nyomva a válasz
            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;

            // elindítja a következő kérdést
            NextQuestion();

        }

        private void RestartGame()
        {
            // mindent nulláz
            score = 0; 
            qNum = -1; 
            i = 0; 
            StartGame(); // és elkezdi újra
        }

        private void NextQuestion()
        {
            // ez megnézi melyik kérdés jön legközelebb

            // meg nézi hogy kevesebb hogy kevesebb a kérdés száma mint a max

            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                // hanem újraindítja
                RestartGame();
            }

            // megnézi a canvasban található gombokat és átrakja a tagját 0 meg a színét zöldre
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.Green;
            }


           


            // megnutatja a kérdéseket

            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Kérdés 1"; 

                    ans1.Content = "Válasz 1"; 
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";

                    ans2.Tag = "1"; 

                  

                    break; 

                case 2:

                    txtQuestion.Text = "Kérdés 2";

                    ans1.Content = "Válasz 1";
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";

                    ans1.Tag = "1";

                   

                    break;

                case 3:

                    txtQuestion.Text = "Kérdés 3";

                    ans1.Content = "Válasz 1";
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";

                    ans3.Tag = "1";

                    

                    break;

                case 4:

                    txtQuestion.Text = "Kérdés 4";

                    ans1.Content = "Válasz 1";
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";

                    ans4.Tag = "1";

                    

                    break;

                case 5:

                    txtQuestion.Text = "Kérdés 5";

                    ans1.Content = "Válasz 1";
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";

                    ans1.Tag = "1";

                    

                    break;
                case 6:

                    txtQuestion.Text = "Kérdés 6";

                    ans1.Content = "Válasz 1";
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";

                    ans3.Tag = "1";

                   

                    break;
                case 7:

                    txtQuestion.Text = "Kérdés 7";

                    ans1.Content = "Válasz 1";
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";

                    ans2.Tag = "1";

                    

                    break;
                case 8:

                    txtQuestion.Text = "Kérdés 8";

                    ans1.Content = "Válasz 1";
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";

                    ans4.Tag = "1";

                   

                    break;
                case 9:

                    txtQuestion.Text = "Kérdés 9";

                    ans1.Content = "Válasz 1";
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";
                    ans3.Tag = "1";

                    

                    break;

                case 10:

                    txtQuestion.Text = "Kérdés 10";

                    ans1.Content = "Válasz 1";
                    ans2.Content = "Válasz 2";
                    ans3.Content = "Válasz 3";
                    ans4.Content = "Válasz 4";

                    ans1.Tag = "1";

                   

                    break;
            }
        }

        private void StartGame()
        {
            // itt randomizálva lesznek a kérdések

            // random lista
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            // kiírja a kérdések közé hogy számolja
            questionNumbers = randomList;

            // nullázza a kérédések sorrendét
            questionOrder.Content = null;

            // kiírja a randomizált listát
            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }

        }
    }
}
