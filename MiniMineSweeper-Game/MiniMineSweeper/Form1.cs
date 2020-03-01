using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMineSweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DetermineGameLevel();
        }

        #region Introduce Objects and variables
        GameOverForm GameOverForm = new GameOverForm();
        GameWon GamewonForm = new GameWon();
        MineBox mine = new MineBox();
        StatisticsForm statisticF = new StatisticsForm();
        List<int> bestRecord = new List<int>();

        //MineBox[,] mi = new MineBox[8,8];
        List<int> mineNumbers;
        int _numberofWin = 0;
        int _numberofGames = -1;
        int _bestRecord;
        bool time = false;
        int _numofFlags;
        #endregion

        public string GameLevelCmbBox
        {
            get { return GameLevelComboBox1.Text; }
            set { GameLevelComboBox1.Text = value; }
        }


        private void ByeSound()
        {
            SoundPlayer snd = new SoundPlayer(Path.Combine(Application.StartupPath, "bye-bye-1.wav"));
            snd.Play();
        }
        /// <summary>
        /// This function determine a successfully end game
        /// </summary>
        private void SuccessGameEnd()
        {
            time = true;

            if (OpenorFlag())
            {
                SoundPlayer snd = new SoundPlayer(Path.Combine(Application.StartupPath, "gameWin.wav"));
                snd.Play();
                time = false;
                GamewonForm.TimeLbl = timetoolStripStatusLabel3.Text;
                _numberofWin += 1;
                GamewonForm.NumberofGameWon = _numberofWin.ToString();
                GamewonForm.NumberofGameplayed = _numberofGames.ToString();
                //GamewonForm.BestRecord = 
                GamewonForm.Datetime = DateTime.Now.ToString();

                bestRecord.Add(int.Parse(timetoolStripStatusLabel3.Text));
                bestRecord.Sort();
                _bestRecord = bestRecord[0];
                GamewonForm.BestRecord = _bestRecord.ToString();


                if (GamewonForm.ShowDialog() == DialogResult.OK)
                    DetermineGameLevel();
                else
                {
                    ByeSound();
                    Thread.Sleep(800);
                    this.Close();
                }
            }

        }
        /// <summary>
        /// This Function determine that whether all of the states are open/flag, or not
        /// </summary>
        /// <returns></returns>
        private bool OpenorFlag()
        {
            bool ok = false;
            foreach (MineBox ctrl in GamePanel.Controls)
            {
                if (ctrl.State == MineState.Open || ctrl.State == MineState.Flag)
                    ok = true;
                else
                {
                    ok = false;
                    return false;
                }
            }
            return ok;

        }

        //System.Threading.Timer tm = new System.Windows.Forms.Timer();

        /// <summary>
        /// This Function reveals all blank and numbers 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>


        private void ClickaNullBox(int i, int j)
        {
            _hasnull(i - 1, j - 1);
            _hasnull(i, j - 1);
            _hasnull(i + 1, j - 1);

            _hasnull(i - 1, j);
            _hasnull(i + 1, j);

            _hasnull(i - 1, j + 1);
            _hasnull(i, j + 1);
            _hasnull(i + 1, j + 1);
        }

        private void _hasnull(int i, int j)
        {
            int row, column;
            if (mine.GameLevel == MineGameLevel.Beginner)
            {
                row = 9;
                column = 9;
            }

            else if (mine.GameLevel == MineGameLevel.Intermediate)
            {
                row = 16;
                column = 16;
            }
            else
            {
                row = 25;
                column = 25;
            }

            if (i < 0 || i > row - 1)
                return;
            if (j < 0 || j > column - 1)
                return;
            int _indexofCurrentPlace = (i * row) + (j + 1);
            MineBox index = ((MineBox)GamePanel.Controls[((i * row) + (j + 1)) - 1]);
            //if ((index.State == MineState.Close || index.State == MineState.Question) && (index.MineArround == 1 || index.MineArround == 2 || index.MineArround == 3 || index.MineArround == 4 ||
            //  index.MineArround == 5 || index.MineArround == 6 || index.MineArround == 7 || index.MineArround == 8))
            if ((index.State == MineState.Close || index.State == MineState.Question) && (index.MineArround != 0))
            {
                ((MineBox)GamePanel.Controls[_indexofCurrentPlace - 1]).State = MineState.Open;
                //SoundPlayer snd = new SoundPlayer(Path.Combine(Application.StartupPath, "click.wav"));
                //snd.Play();
                return;
            }
            else if ((index.State == MineState.Close || index.State == MineState.Question) && !index.HasMine)
            {
                ((MineBox)GamePanel.Controls[_indexofCurrentPlace - 1]).State = MineState.Open;
                ClickaNullBox(i, j);
            }
            else
                return;
            //((MineBox)GamePanel.Controls[_indexofCurrentPlace - 1]).State = MineState.Open;


            //int index = ((i * 9) + (j + 1));
            //if(((MineBox)GamePanel.Controls[index - 1]).State == MineState.Close );

            //return ((MineBox)GamePanel.Controls[index - 1]).HasMine;
            //return mi[i, j].HasMine;      
        }

        /// <summary>
        /// This Function reveals all mines
        /// </summary>
        public void GameOver()
        {
            time = false;
            foreach (MineBox ctrl in GamePanel.Controls)
            {

                if (ctrl.HasMine)
                    ctrl.State = MineState.Open;
                //GamePanel.Enabled = false;
            }
            this.GameOverForm.TimeLbl = timetoolStripStatusLabel3.Text;
            GameOverForm.TimeLbl = timetoolStripStatusLabel3.Text;
            GameOverForm.NumberofGameWon = _numberofWin.ToString();
            GameOverForm.NumberofGameplayed = _numberofGames.ToString();
            GameOverForm.BestRecord = _bestRecord.ToString();
            GameOverForm.Datetime = DateTime.Now.ToString();

            //GamewonForm.BestRecord = 

            if (GameOverForm.ShowDialog() == DialogResult.OK)

                DetermineGameLevel();
            else
            {
                ByeSound();
                Thread.Sleep(800);
                this.Close();
            }
        }

        /// <summary>
        /// Determine game level and their rows and columns (Beginner(9*9), Intermediate(16*16) and Exper(16*30))
        /// </summary>
        /// <returns></returns>
        private void DetermineGameLevel()
        {
            if (GameLevelComboBox1.Text == "Beginner")
            {
                this.Height = this.Width = 315;
                GamePanel.Width = GamePanel.Height = 185;
                FlagtoolStripStatusLabel3.Text = "10";
                _numofFlags = 10;
                StartGame(9, 9, 10, MineGameLevel.Beginner);
            }
            else if (GameLevelComboBox1.Text == "Intermediate")
            {
                GameLevelCmbBox = "Intermediate";
                this.Height = 460;
                this.Width = 430;
                GamePanel.Width = GamePanel.Height = 325;
                FlagtoolStripStatusLabel3.Text = "32";
                _numofFlags = 32;
                StartGame(16, 16, 32, MineGameLevel.Intermediate);
            }
            else if (GameLevelComboBox1.Text == "Expert")
            {
                GameLevelCmbBox = "Expert";
                this.Height = 630;
                this.Width = 630;
                GamePanel.Width = 505;
                GamePanel.Height = 505;
                FlagtoolStripStatusLabel3.Text = "75";
                _numofFlags = 75;
                StartGame(25, 25, 75, MineGameLevel.Expert);
            }
        }

        private List<int> GuessMineNumbers(int row, int column, int mine)
        {
            List<int> list = new List<int>();
            while (list.Count < mine)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, (row * column) + 1);
                if (list.IndexOf(number) >= 0)
                    continue;
                list.Add(number);
            }
            return list;
        }

        private void StartGame(int row, int column, int mines, MineGameLevel gameLevel)
        {
            time1 = 0;
            time = false;
            _numberofGames += 1;
            timetoolStripStatusLabel3.Text = "0";
            GamePanel.Controls.Clear();
            mineNumbers = GuessMineNumbers(row, column, mines);


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    mine = new MineBox()
                    {
                        //Width = 20,
                        //Height = 20,
                        Left = j * 20,
                        Top = i * 20,
                        Index = (i * row) + (j + 1),
                        State = MineState.Close,
                        GameLevel = (MineGameLevel)gameLevel
                    };
                    mine.OnGameOver += GameOver;
                    mine.onClickNull += ClickaNullBox;
                    mine.onSuccessEndGame += SuccessGameEnd;
                    mine.OnClickFlagorQuestion += NumberofFlags;

                    mine.HasMine = (mineNumbers.IndexOf(mine.Index) >= 0);

                    GamePanel.Controls.Add(mine);
                    //mi[i, j] = mine;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    int neighbors = 0;
                    if (_hasMine(row, column, i - 1, j - 1)) neighbors++;
                    if (_hasMine(row, column, i, j - 1)) neighbors++;
                    if (_hasMine(row, column, i + 1, j - 1)) neighbors++;

                    if (_hasMine(row, column, i - 1, j)) neighbors++;
                    if (_hasMine(row, column, i + 1, j)) neighbors++;

                    if (_hasMine(row, column, i - 1, j + 1)) neighbors++;
                    if (_hasMine(row, column, i, j + 1)) neighbors++;
                    if (_hasMine(row, column, i + 1, j + 1)) neighbors++;

                    int index = ((i * row) + (j + 1));
                    ((MineBox)GamePanel.Controls[index - 1]).MineArround = neighbors;
                    //mi[i, j].MineArround = neighbors;
                }
            }
        }

        private void NumberofFlags(bool numofFlag)
        {
            int x = _numofFlags;
            if (numofFlag == true && _numofFlags > 0)
            {

                FlagtoolStripStatusLabel3.Text = (Convert.ToInt32(FlagtoolStripStatusLabel3.Text) - 1).ToString();
                _numofFlags -= 1;
            }
            else if (numofFlag == false && _numofFlags <= x)
            {
                FlagtoolStripStatusLabel3.Text = (Convert.ToInt32(FlagtoolStripStatusLabel3.Text) + 1).ToString();
                _numofFlags += 1;
            }

        }



        /// <summary>
        /// Determine whether a Button is mine or not
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        private bool _hasMine(int row, int column, int i, int j)
        {
            if (i < 0 || i > row - 1)
                return false;
            if (j < 0 || j > column - 1)
                return false;

            int index = ((i * row) + (j + 1));
            return ((MineBox)GamePanel.Controls[index - 1]).HasMine;
            //return mi[i, j].HasMine;

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetermineGameLevel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightSeaGreen;
            GamePanel.BackColor = Color.LightSeaGreen;
            //GamePanel.Left = 5;
            //GamePanel.Top = 5;
            GameLevelComboBox1.Items.Add("Beginner");
            GameLevelComboBox1.Items.Add("Intermediate");
            GameLevelComboBox1.Items.Add("Expert");
            GameLevelComboBox1.Text = "Beginner";

            GameLevelComboBox1.SelectedIndex = 1;
            DetermineGameLevel();
            //SoundPlayer snd = new SoundPlayer(Path.Combine(Application.StartupPath, "Bomb.wav"));
            //snd.PlayLooping();
        }
        int time1 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == true)
            {
                time1 += 1;
                timetoolStripStatusLabel3.Text = time1.ToString();
            }
        }

        private void GameLevelComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GameLevelComboBox1.SelectedIndex;
            if (index == 0 || index == 1 || index == 2 || index == 3)
                DetermineGameLevel();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bestRecord.Count != 0)
            {                
                 if (bestRecord.Count == 1)
                    statisticF.BestTime = $"1: {bestRecord[0]} Second";
                else if (bestRecord.Count == 2)
                    statisticF.BestTime = $"1: {bestRecord[0]} Second \n 2: {bestRecord[1]} Second";
                else if (bestRecord.Count == 3)
                    statisticF.BestTime = $"1: {bestRecord[0]} Second \n 2: {bestRecord[1]} Second 3: {bestRecord[2]} Second";
                else if (bestRecord.Count == 4)
                    statisticF.BestTime = $"1: {bestRecord[0]} Second \n 2: {bestRecord[1]} Second 3: {bestRecord[2]} Second 4: {bestRecord[3]} Second";
            } 
            if (mine.GameLevel == MineGameLevel.Beginner)
                statisticF.Beginnerradiobotton = true;
            else if (mine.GameLevel == MineGameLevel.Intermediate)
                statisticF.Intermediateradiobotton = true;
            else if (mine.GameLevel == MineGameLevel.Expert)
                statisticF.Expertradiobotton = true;
            statisticF.NumberofGameplayed = _numberofGames.ToString();
            statisticF.NumberofGameWon = _numberofWin.ToString();
            statisticF.WinPercentage1 = (_numberofWin / _numberofGames * 100).ToString();


            if (statisticF.ShowDialog() == DialogResult.OK)
                return;

        }
    }
}
