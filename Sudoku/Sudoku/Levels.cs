using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Level_Screen : Form
    {
        public static Level_Screen instance;

        public Level_Screen()
        {
            InitializeComponent();
            instance = this;
        }

        private void Easy_btn_Click(object sender, EventArgs e)
        {
            Easy_Screen lb = new Easy_Screen();
            lb.Show();
            this.Hide();
        }

        private void Medium_btn_Click(object sender, EventArgs e)
        {
            Medium_Screen lb = new Medium_Screen();
            lb.Show();
            this.Hide();
        }

        private void Hard_btn_Click(object sender, EventArgs e)
        {
            Hard_Screen lb = new Hard_Screen();
            lb.Show();
            this.Hide();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            Main_Screen.instance.Show();
            this.Hide();
        }

        private void Level_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}