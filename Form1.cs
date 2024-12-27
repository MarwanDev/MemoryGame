using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static MemoryGame.clsGame;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private int totalTimeInSeconds, interval;
        private clsGame.enPictureSet pictureSet;
        private bool _isFirstClick;
        private string _currentTag;
        private PictureBox _Pb1, _Pb2;
        private List<PictureBox> pictureBoxes;
        private clsGame Game;
        public Form1()
        {
            InitializeComponent();
            cbTimer.Text = "1";
            cbSpeed.Text = "1";
            cbPicSet.Text = "Animals";
        }

        enum enMode { Light, Dark };

        private void InitiateGame()
        {
            pictureBoxes = new List<PictureBox>();
            FillPictureBoxes();
            timer1.Enabled = false;
            btnReset.Enabled = false;
            _currentTag = null;
            _isFirstClick = true;
            _Pb1 = null;
            _Pb2 = null;
            Game = new clsGame(pictureBoxes, pictureSet);
            pbScore.Maximum = 6;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitiateGame();
        }

        private void ChangeMode(enMode mode)
        {
            this.BackColor = mode == enMode.Light ? Color.White : Color.Black;
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.BackColor = mode == enMode.Light ? this.BackColor : Color.Gray;
            }
        }

        private void rdCheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Enabled == true)
            {
                if (rdLight.Checked)
                    ChangeMode(enMode.Light);
                else
                    ChangeMode(enMode.Dark);
            }
        }

        private void FillPictureBoxes()
        {
            pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pb1);
            pictureBoxes.Add(pb2);
            pictureBoxes.Add(pb3);
            pictureBoxes.Add(pb4);
            pictureBoxes.Add(pb5);
            pictureBoxes.Add(pb6);
            pictureBoxes.Add(pb7);
            pictureBoxes.Add(pb8);
            pictureBoxes.Add(pb9);
            pictureBoxes.Add(pb10);
            pictureBoxes.Add(pb11);
            pictureBoxes.Add(pb12);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = interval;
            int minutes = totalTimeInSeconds / 60;
            int seconds = totalTimeInSeconds % 60;
            lblTime.Text = $"{minutes:D2}:{seconds:D2}";
            if (totalTimeInSeconds > 0)
                totalTimeInSeconds--;
            else
            {
                timer1.Enabled = false;
                ShowTimeUpMessage();
            }
        }

        private void ChangeSpeed()
        {
            float speed = float.Parse(cbSpeed.Text);
            interval = speed == 1 ? 1000 :
                speed == 1.5 ? 750 : 500;
        }

        private void cbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpeed.Enabled == true)
                ChangeSpeed();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Enabled == true)
            {
                Game.StartGame();
                timer1.Enabled = true;
                btnReset.Enabled = true;
                btnStart.Enabled = false;
                btnShowPictures.Enabled = false;
                cbTimer.Enabled = false;
                cbSpeed.Enabled = false;
                cbPicSet.Enabled = false;
            }
        }

        private void cbPicSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPicSet.Enabled == true)
            {
                pictureSet = cbPicSet.Text == "Animals" ? clsGame.enPictureSet.Animals :
                    cbPicSet.Text == "Food" ? clsGame.enPictureSet.Food :
                    clsGame.enPictureSet.Cars;
                FillPictureBoxes();
                Game = new clsGame(pictureBoxes, pictureSet);
                Game.ChangePictureSet(pictureSet);
            }
        }

        private bool VerifyPictureBoxes(PictureBox pb1, PictureBox pb2)
        {
            return pb1.Tag == pb2.Tag;
        }

        private void AddMove()
        {
            Game.IncrementMoves();
            lblMoves.Text = Game.GetMoves().ToString();
            lblMoves.Refresh();
        }

        private void ShowTimeUpMessage()
        {
            if (
            MessageBox.Show(
                "Better Luck Next Time", "Time's Up!",
                MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information
            ) == DialogResult.OK)
            {
                Game.ChangeAllBoxesAbility();
                btnReset.Enabled = true;
            }
        }

        private void CheckIfGameIsOver()
        {
            if (totalTimeInSeconds > 0)
            {
                if (Game.IsGameOver())
                {
                    timer1.Enabled = false;
                    if (
                    MessageBox.Show(
                         "You Made It!", "Congratulations!",
                        MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Information
                    ) == DialogResult.OK)
                    {
                        Game.ChangeAllBoxesAbility();
                        btnReset.Enabled = true;
                    }
                }
            }
        }

        private void PictureBoxClickHandler(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = (Image)((PictureBox)sender).Tag;
            if (_isFirstClick)
            {
                _Pb1 = (PictureBox)sender;
                _currentTag = ((PictureBox)sender).Tag.ToString();
                _isFirstClick = false;
            }
            else
            {
                _Pb2 = (PictureBox)sender;
                _currentTag = null;
                _isFirstClick = true;
                Game.ChangeAllBoxesAbility();
                AddMove();
            }
            if (_Pb1 != null && _Pb2 != null)
            {
                if (VerifyPictureBoxes(_Pb1, _Pb2))
                {
                    Game.ChangeAllBoxesAbility(true);
                    _Pb1.Enabled = false;
                    _Pb2.Enabled = false;
                    UpdateProgressBar();
                    CheckIfGameIsOver();
                }
                else
                {
                    Thread.Sleep(500);
                    _Pb1.Image = Resources.question_mark_96;
                    _Pb1.Refresh();
                    _Pb2.Image = Resources.question_mark_96;
                    _Pb2.Refresh();
                    Game.ChangeAllBoxesAbility(true);
                }
                _Pb1 = null;
                _Pb2 = null;
            }
        }

        private void UpdateProgressBar()
        {
            Game.CountSuccessfulMoves();
            pbScore.Value = Math.Abs(((int)Math.Floor(Game.GetSuccessfulMoves() - 6)));
            pbScore.Refresh();
            lblScore.Text = Math.Abs(((int)Math.Floor(Game.GetSuccessfulMoves() - 6))).ToString() + "/6";
            lblScore.Refresh();
        }

        private void pb_Click(object sender, EventArgs e)
        {
            if (((PictureBox)(sender)).Enabled == true)
            {
                PictureBoxClickHandler(sender, e);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Image = Resources.question_mark_96;
            }
            InitiateGame();
            Game.ChangeAllBoxesAbility(false);
            lblTime.Text = "00:00";
            lblMoves.Text = "0";
            lblScore.Text = "0/6";
            cbTimer.Text = "1";
            pbScore.Value = 0;
            timer1.Enabled = false;
            btnStart.Enabled = true;
            btnShowPictures.Enabled = true;
            cbTimer.Enabled = true;
            cbSpeed.Enabled = true;
            cbPicSet.Enabled = true;
            ChangeTime();
        }

        private void btnShowPictures_Click(object sender, EventArgs e)
        {
            if (btnShowPictures.Enabled == true)
            {
                btnStart.Enabled = false;
                btnReset.Enabled = false;
                btnShowPictures.Enabled = false;
                if (Game.ShowImages())
                {
                    btnStart.Enabled = true;
                    btnShowPictures.Enabled = true;
                }
            }
        }

        private void ChangeTime()
        {
            totalTimeInSeconds = Int32.Parse(cbTimer.Text) * 60;
        }

        private void cbTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimer.Enabled == true)
            {
                ChangeTime();
            }
        }
    }
}
