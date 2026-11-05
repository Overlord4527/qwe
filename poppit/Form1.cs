using System;
using System.Drawing;
using System.Windows.Forms;

namespace poppit
{
    public partial class Form1 : Form
    {
        private string currentTurn = "X";

        public Form1()
        {
            InitializeComponent(); 
            StartNewGame();
        }

        private void StartNewGame()
        {
            currentTurn = "X";
            this.Text = "Крестики-Нолики";


            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";


            Font bigFont = new Font("Arial", 24, FontStyle.Bold);
            button1.Font = bigFont; button2.Font = bigFont; button3.Font = bigFont;
            button4.Font = bigFont; button5.Font = bigFont; button6.Font = bigFont;
            button7.Font = bigFont; button8.Font = bigFont; button9.Font = bigFont;
        }

  
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;


            if (clickedButton.Text != "") return;


            clickedButton.Text = currentTurn;


            if (CheckForWinner())
            {
                MessageBox.Show($"Игрок {currentTurn} победил", "Победа");
                StartNewGame();
                return;
            }


            if (CheckForDraw())
            {
                MessageBox.Show("Ничья", "Игра окончена");
                StartNewGame();
                return;
            }

            currentTurn = (currentTurn == "X") ? "O" : "X";
        }


        private bool CheckForWinner()
        {

            if (button1.Text == currentTurn && button2.Text == currentTurn && button3.Text == currentTurn) return true;
            if (button4.Text == currentTurn && button5.Text == currentTurn && button6.Text == currentTurn) return true;
            if (button7.Text == currentTurn && button8.Text == currentTurn && button9.Text == currentTurn) return true;

            if (button1.Text == currentTurn && button4.Text == currentTurn && button7.Text == currentTurn) return true;
            if (button2.Text == currentTurn && button5.Text == currentTurn && button8.Text == currentTurn) return true;
            if (button3.Text == currentTurn && button6.Text == currentTurn && button9.Text == currentTurn) return true;


            if (button1.Text == currentTurn && button5.Text == currentTurn && button9.Text == currentTurn) return true;
            if (button3.Text == currentTurn && button5.Text == currentTurn && button7.Text == currentTurn) return true;

            return false;
        }

        private bool CheckForDraw()
        {
            if (button1.Text == "" || button2.Text == "" || button3.Text == "" ||
                button4.Text == "" || button5.Text == "" || button6.Text == "" ||
                button7.Text == "" || button8.Text == "" || button9.Text == "")
            {
                return false; 
            }
            return true; 
        }
    }
}
