namespace Sudoku
{
    partial class Level_Screen
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
            this.Easy_btn = new System.Windows.Forms.Button();
            this.Hard_btn = new System.Windows.Forms.Button();
            this.Medium_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Return_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Easy_btn
            // 
            this.Easy_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Easy_btn.Font = new System.Drawing.Font("Magneto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy_btn.ForeColor = System.Drawing.Color.IndianRed;
            this.Easy_btn.Location = new System.Drawing.Point(334, 97);
            this.Easy_btn.Name = "Easy_btn";
            this.Easy_btn.Size = new System.Drawing.Size(142, 74);
            this.Easy_btn.TabIndex = 0;
            this.Easy_btn.Text = "Easy 4x4";
            this.Easy_btn.UseVisualStyleBackColor = true;
            this.Easy_btn.Click += new System.EventHandler(this.Easy_btn_Click);
            // 
            // Hard_btn
            // 
            this.Hard_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hard_btn.Font = new System.Drawing.Font("Magneto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hard_btn.ForeColor = System.Drawing.Color.IndianRed;
            this.Hard_btn.Location = new System.Drawing.Point(334, 384);
            this.Hard_btn.Name = "Hard_btn";
            this.Hard_btn.Size = new System.Drawing.Size(142, 72);
            this.Hard_btn.TabIndex = 1;
            this.Hard_btn.Text = "Hard 9x9";
            this.Hard_btn.UseVisualStyleBackColor = true;
            this.Hard_btn.Click += new System.EventHandler(this.Hard_btn_Click);
            // 
            // Medium_btn
            // 
            this.Medium_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Medium_btn.Font = new System.Drawing.Font("Magneto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium_btn.ForeColor = System.Drawing.Color.IndianRed;
            this.Medium_btn.Location = new System.Drawing.Point(334, 240);
            this.Medium_btn.Name = "Medium_btn";
            this.Medium_btn.Size = new System.Drawing.Size(142, 77);
            this.Medium_btn.TabIndex = 2;
            this.Medium_btn.Text = "Medium 6x6";
            this.Medium_btn.UseVisualStyleBackColor = true;
            this.Medium_btn.Click += new System.EventHandler(this.Medium_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(260, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHOSE LEVEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Return_btn
            // 
            this.Return_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Return_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Return_btn.Font = new System.Drawing.Font("Magneto", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_btn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Return_btn.Location = new System.Drawing.Point(661, 23);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(108, 32);
            this.Return_btn.TabIndex = 4;
            this.Return_btn.Text = "Return";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // Level_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(803, 498);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Medium_btn);
            this.Controls.Add(this.Hard_btn);
            this.Controls.Add(this.Easy_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Level_Screen";
            this.Text = "Levels";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level_Screen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Easy_btn;
        private System.Windows.Forms.Button Hard_btn;
        private System.Windows.Forms.Button Medium_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Return_btn;
    }
}