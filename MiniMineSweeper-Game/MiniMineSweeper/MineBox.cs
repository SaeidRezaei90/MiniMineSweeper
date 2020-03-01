using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMineSweeper
{

    public enum MineState
    {
        Close,
        Open,
        Flag,
        Question
    }
    public enum MineGameLevel
    {
        Beginner,
        Intermediate,
        Expert
    }
    public partial class MineBox : Button
    {

        public delegate void ClickNullHandler(int i, int j);
        public delegate void GameOverHandler();
        public delegate void SuccessEndGameHandler();
        public delegate void ClickFlagorQuestionHandler(bool Flag);

        private MineGameLevel _gameLevel;

        public MineGameLevel GameLevel
        {
            get { return _gameLevel; }
            set { _gameLevel = value; }
        }


        private bool _hasMine;
        public bool HasMine
        {
            get { return _hasMine; }
            set { _hasMine = value; }
        }

        private int _mineArround;
        public int MineArround
        {
            get { return _mineArround; }
            set { _mineArround = value; }
        }

        private int _index;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }


        private MineState _state;

        public MineState State
        {
            get { return _state; }
            set
            {
                _state = value;

                switch (_state)
                {
                    case MineState.Close:
                        this.Image = MiniMineSweeper.Properties.Resources.Button16;
                        break;
                    case MineState.Open:
                        if (_hasMine)
                        {
                            this.Image = MiniMineSweeper.Properties.Resources.bluebomb16;

                        }

                        else if (_mineArround == 0)
                            this.Image = MiniMineSweeper.Properties.Resources.open016;
                        else if (_mineArround == 1)
                            this.Image = MiniMineSweeper.Properties.Resources.open116;
                        else if (_mineArround == 2)
                            this.Image = MiniMineSweeper.Properties.Resources.open216;
                        else if (_mineArround == 3)
                            this.Image = MiniMineSweeper.Properties.Resources.open316;
                        else if (_mineArround == 4)
                            this.Image = MiniMineSweeper.Properties.Resources.open416;
                        else if (_mineArround == 5)
                            this.Image = MiniMineSweeper.Properties.Resources.open516;
                        else if (_mineArround == 6)
                            this.Image = MiniMineSweeper.Properties.Resources.open616;
                        else if (_mineArround == 7)
                            this.Image = MiniMineSweeper.Properties.Resources.open716;
                        else if (_mineArround == 8)
                            this.Image = MiniMineSweeper.Properties.Resources.open816;
                        break;
                    case MineState.Flag:
                        this.Image = MiniMineSweeper.Properties.Resources.Flag116;
                        break;
                    case MineState.Question:
                        this.Image = MiniMineSweeper.Properties.Resources.Question116;
                        break;
                    default:
                        break;
                }
            }
        }


        public event ClickNullHandler onClickNull;
        public event GameOverHandler OnGameOver;
        public event SuccessEndGameHandler onSuccessEndGame;
        public event ClickFlagorQuestionHandler OnClickFlagorQuestion;
        public MineBox()
        {
            InitializeComponent();
            this.MouseEnter += MineMouseEnter;
            this.MouseLeave += MineMouseLeave;
            this.MouseDown += MineMouseDown;

        }

        public void MineMouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && ((_state == MineState.Close || State == MineState.Question)))
            {
                if (_hasMine)
                {

                    if (OnGameOver != null)
                    {
                        SoundPlayer snd = new SoundPlayer(Path.Combine(Application.StartupPath, "Bomb.wav"));
                        snd.Play();
                        this.State = MineState.Open;
                        OnGameOver();

                    }
                }

                else if (_mineArround == 0)
                {
                    if (onClickNull != null && onSuccessEndGame != null)
                    {
                        this.State = MineState.Open;
                        if (_gameLevel == MineGameLevel.Beginner)
                            onClickNull(((this.Index - 1) / 9), ((this.Index - 1) % 9));
                        if (_gameLevel == MineGameLevel.Intermediate)
                            onClickNull(((this.Index - 1) / 16), ((this.Index - 1) % 16));
                        if (_gameLevel == MineGameLevel.Expert)
                            onClickNull(((this.Index - 1) / 25), ((this.Index - 1) % 25));

                        onSuccessEndGame();
                    }
                }

                else
                {
                    this.State = MineState.Open;
                    if (onSuccessEndGame != null)
                        onSuccessEndGame();
                }
        }

            else if ((e.Button == MouseButtons.Right) && (_state == MineState.Close))
            {
                if (onSuccessEndGame != null && OnClickFlagorQuestion != null)
                {
                    this.State = MineState.Flag;
                    onSuccessEndGame();
                    OnClickFlagorQuestion(true);
                }

    }
            else if ((e.Button == MouseButtons.Right) && (_state == MineState.Flag))
            {
                if(OnClickFlagorQuestion != null)
                {
                    OnClickFlagorQuestion(false);
                    this.State = MineState.Question;
                }

            }
            else if ((e.Button == MouseButtons.Right) && (_state == MineState.Question))
                this.State = MineState.Close;



    }


    private void MineMouseEnter(object sender, EventArgs e)
    {
        if (_state == MineState.Close)
            this.Image = MiniMineSweeper.Properties.Resources.ButtonHot16;
    }

    private void MineMouseLeave(object sender, EventArgs e)
    {
        if (_state == MineState.Close)
            this.Image = MiniMineSweeper.Properties.Resources.Button16;
    }


    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);
    }

    protected override void InitLayout()
    {
        base.InitLayout();
        this.Text = "";
        this.Width = this.Height = 20;
        this.Image = MiniMineSweeper.Properties.Resources.Button16;
        //this.BackColor = Color.MediumPurple;
        this.FlatStyle = FlatStyle.Flat;

    }

}
}
