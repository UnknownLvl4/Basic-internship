namespace Sudoku
{
    partial class LeaderBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.score_txt = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score_txt
            // 
            this.score_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.score_txt.AutoSize = true;
            this.score_txt.BackColor = System.Drawing.Color.Transparent;
            this.score_txt.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_txt.ForeColor = System.Drawing.Color.SeaGreen;
            this.score_txt.Location = new System.Drawing.Point(595, 104);
            this.score_txt.Name = "score_txt";
            this.score_txt.Size = new System.Drawing.Size(0, 19);
            this.score_txt.TabIndex = 2;
            this.score_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_txt
            // 
            this.name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txt.AutoSize = true;
            this.name_txt.BackColor = System.Drawing.Color.Transparent;
            this.name_txt.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.ForeColor = System.Drawing.Color.SeaGreen;
            this.name_txt.Location = new System.Drawing.Point(137, 104);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(0, 19);
            this.name_txt.TabIndex = 1;
            this.name_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Magneto", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "LEADERBOARD";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Magneto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(665, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // LeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score_txt);
            this.Controls.Add(this.name_txt);
            this.Name = "LeaderBoard";
            this.Text = "LeaderBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label score_txt;
        private System.Windows.Forms.Label name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}