namespace MiniMineSweeper
{
    partial class StatisticsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BeginnerradioButton1 = new System.Windows.Forms.RadioButton();
            this.IntermediateradioButton2 = new System.Windows.Forms.RadioButton();
            this.ExpertradioButton3 = new System.Windows.Forms.RadioButton();
            this.Besttimetxt = new System.Windows.Forms.TextBox();
            this.Numberofgamewonlbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.WinPercentagelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numofgmaeplayedlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WinPercentagelbl1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BeginnerradioButton1);
            this.groupBox1.Controls.Add(this.IntermediateradioButton2);
            this.groupBox1.Controls.Add(this.ExpertradioButton3);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Level";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Besttimetxt);
            this.groupBox2.Location = new System.Drawing.Point(203, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Best Records";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WinPercentagelbl1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.WinPercentagelbl);
            this.groupBox3.Controls.Add(this.numofgmaeplayedlbl);
            this.groupBox3.Controls.Add(this.Numberofgamewonlbl);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(343, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Information";
            // 
            // BeginnerradioButton1
            // 
            this.BeginnerradioButton1.AutoSize = true;
            this.BeginnerradioButton1.Location = new System.Drawing.Point(6, 18);
            this.BeginnerradioButton1.Name = "BeginnerradioButton1";
            this.BeginnerradioButton1.Size = new System.Drawing.Size(67, 17);
            this.BeginnerradioButton1.TabIndex = 2;
            this.BeginnerradioButton1.TabStop = true;
            this.BeginnerradioButton1.Text = "Beginner";
            this.BeginnerradioButton1.UseVisualStyleBackColor = true;
            // 
            // IntermediateradioButton2
            // 
            this.IntermediateradioButton2.AutoSize = true;
            this.IntermediateradioButton2.Location = new System.Drawing.Point(6, 41);
            this.IntermediateradioButton2.Name = "IntermediateradioButton2";
            this.IntermediateradioButton2.Size = new System.Drawing.Size(87, 17);
            this.IntermediateradioButton2.TabIndex = 3;
            this.IntermediateradioButton2.TabStop = true;
            this.IntermediateradioButton2.Text = "Intermediate";
            this.IntermediateradioButton2.UseVisualStyleBackColor = true;
            // 
            // ExpertradioButton3
            // 
            this.ExpertradioButton3.AutoSize = true;
            this.ExpertradioButton3.Location = new System.Drawing.Point(6, 64);
            this.ExpertradioButton3.Name = "ExpertradioButton3";
            this.ExpertradioButton3.Size = new System.Drawing.Size(57, 17);
            this.ExpertradioButton3.TabIndex = 4;
            this.ExpertradioButton3.TabStop = true;
            this.ExpertradioButton3.Text = "Expert";
            this.ExpertradioButton3.UseVisualStyleBackColor = true;
            // 
            // Besttimetxt
            // 
            this.Besttimetxt.Enabled = false;
            this.Besttimetxt.Location = new System.Drawing.Point(3, 17);
            this.Besttimetxt.Multiline = true;
            this.Besttimetxt.Name = "Besttimetxt";
            this.Besttimetxt.ReadOnly = true;
            this.Besttimetxt.Size = new System.Drawing.Size(118, 77);
            this.Besttimetxt.TabIndex = 0;
            // 
            // Numberofgamewonlbl
            // 
            this.Numberofgamewonlbl.AutoSize = true;
            this.Numberofgamewonlbl.Location = new System.Drawing.Point(67, 46);
            this.Numberofgamewonlbl.Name = "Numberofgamewonlbl";
            this.Numberofgamewonlbl.Size = new System.Drawing.Size(13, 13);
            this.Numberofgamewonlbl.TabIndex = 21;
            this.Numberofgamewonlbl.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Game Won:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Game Played:";
            // 
            // WinPercentagelbl
            // 
            this.WinPercentagelbl.AutoSize = true;
            this.WinPercentagelbl.Location = new System.Drawing.Point(96, 68);
            this.WinPercentagelbl.Name = "WinPercentagelbl";
            this.WinPercentagelbl.Size = new System.Drawing.Size(0, 13);
            this.WinPercentagelbl.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Win Percentage:";
            // 
            // numofgmaeplayedlbl
            // 
            this.numofgmaeplayedlbl.AutoSize = true;
            this.numofgmaeplayedlbl.Location = new System.Drawing.Point(79, 22);
            this.numofgmaeplayedlbl.Name = "numofgmaeplayedlbl";
            this.numofgmaeplayedlbl.Size = new System.Drawing.Size(13, 13);
            this.numofgmaeplayedlbl.TabIndex = 21;
            this.numofgmaeplayedlbl.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WinPercentagelbl1
            // 
            this.WinPercentagelbl1.AutoSize = true;
            this.WinPercentagelbl1.Location = new System.Drawing.Point(96, 68);
            this.WinPercentagelbl1.Name = "WinPercentagelbl1";
            this.WinPercentagelbl1.Size = new System.Drawing.Size(13, 13);
            this.WinPercentagelbl1.TabIndex = 24;
            this.WinPercentagelbl1.Text = "0";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 153);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MineSweeper Statistics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BeginnerradioButton1;
        private System.Windows.Forms.RadioButton IntermediateradioButton2;
        private System.Windows.Forms.RadioButton ExpertradioButton3;
        private System.Windows.Forms.TextBox Besttimetxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WinPercentagelbl;
        private System.Windows.Forms.Label Numberofgamewonlbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label numofgmaeplayedlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WinPercentagelbl1;
    }
}