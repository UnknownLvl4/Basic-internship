using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Easy_Screen : Form
    {
        private int CHESS_SIZE = 4;
        private int CHESS_ROW = 2;
        private int CHESS_COL = 2;
        private int CHESS_HIDDEN = 0;
        //Solved Sudoku Chess
        private int[,] Chess =         
                    {
                        {0, 0, 0, 0},
                        {0, 0, 0, 0},
                        {0, 0, 0, 0},
                        {0, 0, 0, 0},
                    };
        //Show Sudoku Chess
        private int[,] PlayChess =
                    {
                        {0, 0, 0, 0},
                        {0, 0, 0, 0},
                        {0, 0, 0, 0},
                        {0, 0, 0, 0},
                    };
        //Mark chess is generated
        private bool isDone = false;
        public Easy_Screen()
        {
            InitializeComponent();
            CreateChess();
            MappingChessToTextBoxes();
        }

        private void CreateChess()
        {
            RandomChess(new int[CHESS_SIZE, CHESS_SIZE], 0, 0);
            PlayChess = HiddenChess(Chess);
        }

        void RandomChess(int[,] chess, int x, int y)
        {     
            if (isDone == true) return;
            if (y == CHESS_SIZE)
            {
                if (x == CHESS_SIZE - 1)
                {
                    for (int i = 0; i < CHESS_SIZE; i++)
                    {
                        for (int j = 0; j < CHESS_SIZE; j++)
                        {
                            int value = chess[i, j];
                            Chess[i, j] = value;
                        }
                    }

                    isDone = true;
                }
                else
                {
                    RandomChess(chess, x + 1, 0);
                }
            }
            else if (chess[x, y] == 0)
            {
                for (int k = 1; k <= CHESS_SIZE; k++)
                {
                    if (CheckValid(chess, x, y, k))
                    {
                        chess[x, y] = k;
                        RandomChess(chess, x, y + 1);
                        chess[x, y] = 0;
                    }
                }
            }
            RandomChess(chess, x, y + 1);
        }

        bool CheckValid(int[,] chess, int x, int y, int k)
        {
            //check value
            if (k > CHESS_SIZE || k < 1) return false;
            //check row
            for (int i = 0; i < CHESS_SIZE; i++)
            {
                if (chess[x, i] == k) return false;
            }
            //check col
            for (int i = 0; i < CHESS_SIZE; i++)
            {
                if (chess[i, y] == k) return false;
            }
            //check area
            int a = x / CHESS_ROW, b = y / CHESS_COL;
            for (int i = CHESS_ROW * a; i < CHESS_ROW * a + CHESS_ROW; i++)
            {
                for (int j = CHESS_COL * b; j < CHESS_COL * b + CHESS_COL; j++)
                {
                    if (chess[i, j] == k) return false;
                }
            }
            return true;
        }

        bool CheckChess(int[,] chess)
        {
            for (int i = 0; i < CHESS_SIZE; i++)
                for (int j = 0; j < CHESS_SIZE; j++)
                {
                    int tmp = chess[i, j];
                    chess[i, j] = 0;
                    if (!CheckValid(chess, i, j, tmp)) return false;
                    chess[i, j] = tmp;
                }
            return true;
        }

        private int[,] HiddenChess(int[,] chess)
        {
            Random rnd = new Random();
            int[] positions = Enumerable.Range(0, (CHESS_SIZE * CHESS_SIZE) - 1).OrderBy(x => rnd.Next()).Take(CHESS_HIDDEN).ToArray();
            for (int i = 0; i < CHESS_HIDDEN; i++)
            {
                int row = (int)Math.Floor((positions[i]) / CHESS_SIZE * 1.0);
                chess[row, positions[i] - row * CHESS_SIZE] = 0;
            }
            return chess;
        }

        private void MappingChessToTextBoxes()
        {
            for (int i = 0; i < CHESS_SIZE; i++)
            {
                for (int j = 0; j < CHESS_SIZE; j++)
                {
                    TextBox textBox = this.Controls.Find("textBox" + i.ToString() + j.ToString(), true).FirstOrDefault() as TextBox;
                    if (textBox != null)
                    {
                        if (PlayChess[i, j] != 0)
                        {
                            // Disabled cells
                            textBox.Text = PlayChess[i, j].ToString();
                            textBox.Enabled = false;
                            textBox.BackColor = Color.Aqua;
                        }
                        else
                        {
                            // Enable cells
                            textBox.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void exam_btn_Click(object sender, EventArgs e)
        {
            //check user input is not a number
            int[,] chess = new int[CHESS_SIZE, CHESS_SIZE];
            for (int i = 0; i < CHESS_SIZE; i++)
            {
                for (int j = 0; j < CHESS_SIZE; j++)
                {
                    TextBox textBox = this.Controls.Find("textBox" + i.ToString() + j.ToString(), true).FirstOrDefault() as TextBox;
                    if (textBox != null)
                    {
                        string content = textBox.Text;
                        if (!Regex.IsMatch(content, @"^\d+$"))
                        {
                            MessageBox.Show("Input not a number");
                            return;
                        }
                        chess[i, j] = int.Parse(content);
                    }
                }
            }
            //check whole chess is valid
            if (CheckChess(chess))
            {
                WinnerForm f = new WinnerForm();
                f.ShowDialog();
                this.Hide();
            }
            else MessageBox.Show("You lose");
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            Level_Screen.instance.Show();
            this.Hide();
        }

        private void Easy_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}