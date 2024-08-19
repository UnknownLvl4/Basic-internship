using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Main_Screen : Form
    {
        public static Main_Screen instance;
        public Main_Screen()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Level_Screen.instance == null)
            {
                Level_Screen lb = new Level_Screen();
                lb.Show();
            }
            else Level_Screen.instance.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeaderBoard lb = new LeaderBoard();
            lb.Show();
            this.Hide();
        }

        private void Main_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}