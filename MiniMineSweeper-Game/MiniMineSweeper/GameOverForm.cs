using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMineSweeper
{
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();
        }


        public string TimeLbl
        {
            get { return Timelbl.Text; }
            set { Timelbl.Text = value; }
        }

        public string NumberofGameWon
        {
            get { return Numberofgamewonlbl.Text; }
            set { Numberofgamewonlbl.Text = value; }
        }

        public string Datetime
        {
            get { return Datetimelbl.Text; }
            set { Datetimelbl.Text = value; }
        }


        public string NumberofGameplayed
        {
            get { return numofgmaeplayedlbl.Text; }
            set { numofgmaeplayedlbl.Text = value; }
        }

        public string BestRecord
        {
            get { return bestrecordlbl.Text; }
            set { bestrecordlbl.Text = value; }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
