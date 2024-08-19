using System;
using System.IO;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class WinnerForm : Form
    {
        public WinnerForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string userName = name_txt.Text;
            Random rnd = new Random();
            File.AppendAllText(@"score.txt", '\n' + userName + '-' + rnd.Next(50, 1000));
            Main_Screen.instance.Show();
            this.Close();
        }
    }
}