namespace MiniMineSweeper
{
    partial class GameWon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWon));
            this.Playageinbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timelbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Numberofgamewonlbl = new System.Windows.Forms.Label();
            this.numofgmaeplayedlbl = new System.Windows.Forms.Label();
            this.bestrecordlbl = new System.Windows.Forms.Label();
            this.Datetimelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Playageinbtn
            // 
            this.Playageinbtn.Location = new System.Drawing.Point(104, 175);
            this.Playageinbtn.Name = "Playageinbtn";
            this.Playageinbtn.Size = new System.Drawing.Size(69, 23);
            this.Playageinbtn.TabIndex = 13;
            this.Playageinbtn.Text = "Play Again";
            this.Playageinbtn.UseVisualStyleBackColor = true;
            this.Playageinbtn.Click += new System.EventHandler(this.Playageinbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Datetimelbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bestrecordlbl);
            this.groupBox2.Controls.Add(this.numofgmaeplayedlbl);
            this.groupBox2.Controls.Add(this.Numberofgamewonlbl);
            this.groupBox2.Controls.Add(this.timelbl);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Location = new System.Drawing.Point(16, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 132);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Informations";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(39, 26);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(0, 13);
            this.timelbl.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(93, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Secound";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Best Record:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Game Won:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Secound";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Game Played:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Time: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, -25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Time: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(92, -25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Secound";
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(14, 175);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(69, 23);
            this.Exitbtn.TabIndex = 11;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Congratulation, You won the game";
            // 
            // Numberofgamewonlbl
            // 
            this.Numberofgamewonlbl.AutoSize = true;
            this.Numberofgamewonlbl.Location = new System.Drawing.Point(67, 70);
            this.Numberofgamewonlbl.Name = "Numberofgamewonlbl";
            this.Numberofgamewonlbl.Size = new System.Drawing.Size(0, 13);
            this.Numberofgamewonlbl.TabIndex = 15;
            this.Numberofgamewonlbl.Click += new System.EventHandler(this.Numberofgamewonlbl_Click);
            // 
            // numofgmaeplayedlbl
            // 
            this.numofgmaeplayedlbl.AutoSize = true;
            this.numofgmaeplayedlbl.Location = new System.Drawing.Point(77, 48);
            this.numofgmaeplayedlbl.Name = "numofgmaeplayedlbl";
            this.numofgmaeplayedlbl.Size = new System.Drawing.Size(0, 13);
            this.numofgmaeplayedlbl.TabIndex = 16;
            // 
            // bestrecordlbl
            // 
            this.bestrecordlbl.AutoSize = true;
            this.bestrecordlbl.Location = new System.Drawing.Point(77, 92);
            this.bestrecordlbl.Name = "bestrecordlbl";
            this.bestrecordlbl.Size = new System.Drawing.Size(0, 13);
            this.bestrecordlbl.TabIndex = 17;
            // 
            // Datetimelbl
            // 
            this.Datetimelbl.AutoSize = true;
            this.Datetimelbl.Location = new System.Drawing.Point(69, 116);
            this.Datetimelbl.Name = "Datetimelbl";
            this.Datetimelbl.Size = new System.Drawing.Size(0, 13);
            this.Datetimelbl.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date time:";
            // 
            // GameWon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.Playageinbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game won";
            this.Load += new System.EventHandler(this.GameWon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playageinbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label bestrecordlbl;
        private System.Windows.Forms.Label numofgmaeplayedlbl;
        private System.Windows.Forms.Label Numberofgamewonlbl;
        private System.Windows.Forms.Label Datetimelbl;
        private System.Windows.Forms.Label label2;
    }
}