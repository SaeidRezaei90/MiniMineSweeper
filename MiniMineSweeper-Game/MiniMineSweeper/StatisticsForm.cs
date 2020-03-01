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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        

        public bool Beginnerradiobotton     
        {
            get { return BeginnerradioButton1.Checked; }
            set { BeginnerradioButton1.Checked = value; }
        }
        public bool Intermediateradiobotton
        {
            get { return IntermediateradioButton2.Checked; }
            set { IntermediateradioButton2.Checked = value; }
        }
        public bool Expertradiobotton
        {
            get { return ExpertradioButton3.Checked; }
            set { ExpertradioButton3.Checked = value; }
        }
        public string BestTime
        {
            get { return Besttimetxt.Text; }
            set { Besttimetxt.Text = value; }
        }

        public string NumberofGameplayed
        {
            get { return numofgmaeplayedlbl.Text; }
            set { numofgmaeplayedlbl.Text = value; }
        }
        public string WinPercentage1
        {
            get { return WinPercentagelbl1.Text; }
            set { WinPercentagelbl1.Text = value; }
        }

        public string NumberofGameWon
        {
            get { return Numberofgamewonlbl.Text; }
            set { Numberofgamewonlbl.Text = value; }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
