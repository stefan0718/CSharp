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

namespace _3_Card_Poker
{
    /// <summary>
    /// Interaction logic for TablePage.xaml
    /// </summary>
    public partial class TablePage : Page
    {

        private List<ThreePokerCards> tpcs;
        private Cards c;
        private List<Label> labels1, labels2;
        private List<Rectangle> rectangles1, rectangles2;

        public TablePage()
        {
            InitializeComponent();
            // get the player name from mainwindow
            tb_player1.Text = "Player 1: " + ((MainWindow)Application.Current.MainWindow).tb_name.Text;
            tpcs = new List<ThreePokerCards>();
            c = new Cards();
            labels1 = new List<Label>();
            labels1.Add(p1_card1);
            labels1.Add(p1_card2);
            labels1.Add(p1_card3);
            rectangles1 = new List<Rectangle>();
            rectangles1.Add(p1_rectangle1);
            rectangles1.Add(p1_rectangle2);
            rectangles1.Add(p1_rectangle3);
            labels2 = new List<Label>();
            labels2.Add(p2_card1);
            labels2.Add(p2_card2);
            labels2.Add(p2_card3);
            rectangles2 = new List<Rectangle>();
            rectangles2.Add(p2_rectangle1);
            rectangles2.Add(p2_rectangle2);
            rectangles2.Add(p2_rectangle3);
        }

        private void expose_Click(object sender, RoutedEventArgs e)
        {
            if (tpcs.Count == 0)
                tpcs = c.getSetsOfThreeCards();  // otherwise there is no need to deal new cards
            c.exposeThreeCards(tpcs[0], labels1, rectangles1);
            hide.IsEnabled = false;  // disable the hide button
            expose.IsEnabled = false;  // disable the expose button
            fold.IsEnabled = true;  // enable the fold button
            showdown.IsEnabled = true;  // enable the showdown button
            newgame.IsEnabled = false;  // disable the newgame button
            handrank1.Text = c.showHandRank(tpcs[0]);  // show player1's handrank
        }

        private void hide_Click(object sender, RoutedEventArgs e)
        {
            tpcs = c.getSetsOfThreeCards();
            hide.IsEnabled = false;  // disable the hide button
            fold.IsEnabled = true;  // enable the fold button
            showdown.IsEnabled = true;  // enable the showdown button
            newgame.IsEnabled = false;  // disable the newgame button
        }

        private void fold_Click(object sender, RoutedEventArgs e)
        {
            c.exposeThreeCards(tpcs[0], labels1, rectangles1);  // show player1's hand
            c.exposeThreeCards(tpcs[1], labels2, rectangles2);  // show player2's hand
            handrank1.Text = c.showHandRank(tpcs[0]);  // show player1's handrank
            handrank2.Text = c.showHandRank(tpcs[1]);  // show player2's handrank
            hide.IsEnabled = false;  // disable the hide button
            expose.IsEnabled = false;  // disable the expose button
            fold.IsEnabled = false;  // disable the fold button
            showdown.IsEnabled = false;  // disable the showdown button
            newgame.IsEnabled = true;  // enable the newgame button
            winorlose.Text = "YOU LOSE!";
        }

        private void showdown_Click(object sender, RoutedEventArgs e)
        {
            c.exposeThreeCards(tpcs[0], labels1, rectangles1);  // show player1's hand
            c.exposeThreeCards(tpcs[1], labels2, rectangles2);  // show player2's hand
            handrank1.Text = c.showHandRank(tpcs[0]);  // show player1's handrank
            handrank2.Text = c.showHandRank(tpcs[1]);  // show player2's handrank
            hide.IsEnabled = false;  // disable the hide button
            expose.IsEnabled = false;  // disable the expose button
            fold.IsEnabled = false;  // disable the fold button
            showdown.IsEnabled = false;  // disable the showdown button
            newgame.IsEnabled = true;  // enable the newgame button
            if (c.compareCards(tpcs[0], tpcs[1]))
                winorlose.Text = "YOU WIN!";
            else
                winorlose.Text = "YOU LOSE!";
        }

        private void newgame_Click(object sender, RoutedEventArgs e)
        {
            tpcs = new List<ThreePokerCards>();  // empty folded cards
            c.hideThreeCards(labels1, rectangles1);  // hide player1's hand
            c.hideThreeCards(labels2, rectangles2);  // hide player2's hand
            winorlose.Text = "";
            handrank1.Text = "";  // empty player1's handrank
            handrank2.Text = "";  // empty player2's handrank
            hide.IsEnabled = true;  // enable the hide button
            expose.IsEnabled = true;  // enable the expose button
            fold.IsEnabled = false;  // disable the fold button
            showdown.IsEnabled = false;  // disable the showdown button
            newgame.IsEnabled = false;  // disable the newgame button
        }
    }
}
