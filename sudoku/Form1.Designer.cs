
namespace sudoku
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.Beginner = new System.Windows.Forms.RadioButton();
            this.Intermediate = new System.Windows.Forms.RadioButton();
            this.Adv = new System.Windows.Forms.RadioButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.plnMap = new System.Windows.Forms.Panel();
            this.pnlNumber = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(495, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 50);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Beginner
            // 
            this.Beginner.AutoSize = true;
            this.Beginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beginner.Location = new System.Drawing.Point(18, 30);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(50, 24);
            this.Beginner.TabIndex = 3;
            this.Beginner.TabStop = true;
            this.Beginner.Text = "Dễ";
            this.Beginner.UseVisualStyleBackColor = true;
            // 
            // Intermediate
            // 
            this.Intermediate.AutoSize = true;
            this.Intermediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intermediate.Location = new System.Drawing.Point(112, 30);
            this.Intermediate.Name = "Intermediate";
            this.Intermediate.Size = new System.Drawing.Size(112, 24);
            this.Intermediate.TabIndex = 4;
            this.Intermediate.TabStop = true;
            this.Intermediate.Text = "Trung bình";
            this.Intermediate.UseVisualStyleBackColor = true;
            // 
            // Adv
            // 
            this.Adv.AutoSize = true;
            this.Adv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adv.Location = new System.Drawing.Point(267, 30);
            this.Adv.Name = "Adv";
            this.Adv.Size = new System.Drawing.Size(58, 24);
            this.Adv.TabIndex = 5;
            this.Adv.TabStop = true;
            this.Adv.Text = "Khó";
            this.Adv.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(99, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(90, 50);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Gợi ý";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Blue;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(766, 293);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(345, 56);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Trò chơi mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(198, -1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 50);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Đặt lại";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(0, 0);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 50);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // plnMap
            // 
            this.plnMap.BackColor = System.Drawing.Color.White;
            this.plnMap.Location = new System.Drawing.Point(117, 204);
            this.plnMap.Name = "plnMap";
            this.plnMap.Size = new System.Drawing.Size(585, 585);
            this.plnMap.TabIndex = 8;
            // 
            // pnlNumber
            // 
            this.pnlNumber.Location = new System.Drawing.Point(766, 364);
            this.pnlNumber.Name = "pnlNumber";
            this.pnlNumber.Size = new System.Drawing.Size(345, 323);
            this.pnlNumber.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Adv);
            this.panel2.Controls.Add(this.Beginner);
            this.panel2.Controls.Add(this.Intermediate);
            this.panel2.Location = new System.Drawing.Point(766, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 73);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Độ khó";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Controls.Add(this.btnHelp);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Location = new System.Drawing.Point(117, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 50);
            this.panel3.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(397, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 50);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Hoàn tác";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(297, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimer);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(950, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 54);
            this.panel1.TabIndex = 12;
            // 
            // btnTimer
            // 
            this.btnTimer.BackgroundImage = global::sudoku.Properties.Resources.play;
            this.btnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.Location = new System.Drawing.Point(184, 16);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(23, 23);
            this.btnTimer.TabIndex = 15;
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click_1);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::sudoku.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(184, 16);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(23, 23);
            this.btnPause.TabIndex = 14;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(99, 18);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(79, 20);
            this.time.TabIndex = 13;
            this.time.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thời gian: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::sudoku.Properties.Resources.bgsudoku1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1250, 879);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1250, 879);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNumber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.plnMap);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUDOKU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Beginner;
        private System.Windows.Forms.RadioButton Intermediate;
        private System.Windows.Forms.RadioButton Adv;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel plnMap;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FlowLayoutPanel pnlNumber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
    }
}

