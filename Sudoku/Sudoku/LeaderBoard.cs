using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class LeaderBoard : Form
    {
        public LeaderBoard()
        {
            InitializeComponent();
            SetLearderBoard();
        }

        private void SetLearderBoard()
        {
            string path = "score.txt";
            if (!File.Exists(path)) return;
            List<string> lines = File.ReadLines(path).ToList();
            string names = "";
            string scores = "";
            lines.RemoveAt(0);
            foreach (string line in lines)
            {
                names += line.Split('-')[0] + "\n";
                scores += line.Split('-')[1] + "\n";
            }
            name_txt.Text = names;
            score_txt.Text = scores;
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            Main_Screen.instance.Show();
            this.Close();
        }
    }
}