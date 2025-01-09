using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

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

        enum Mode { Light, Dark };

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

        private void ChangeMode(Mode mode)
        {
            this.BackColor = mode == Mode.Light ? Color.White : Color.Black;
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.BackColor = mode == Mode.Light ? this.BackColor : Color.Gray;
            }
        }

        private void RdCheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Enabled == true)
            {
                if (rdLight.Checked)
                    ChangeMode(Mode.Light);
                else
                    ChangeMode(Mode.Dark);
            }
        }

        private void FillPictureBoxes()
        {
            pictureBoxes = new List<PictureBox>
            {
                pb1,
                pb2,
                pb3,
                pb4,
                pb5,
                pb6,
                pb7,
                pb8,
                pb9,
                pb10,
                pb11,
                pb12
            };
        }

        private void Timer1_Tick(object sender, EventArgs e)
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

        private void CbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpeed.Enabled == true)
                ChangeSpeed();
        }

        private void BtnStart_Click(object sender, EventArgs e)
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

        private void CbPicSet_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Pb_Click(object sender, EventArgs e)
        {
            if (((PictureBox)(sender)).Enabled == true)
            {
                PictureBoxClickHandler(sender, e);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
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

        private void BtnShowPictures_Click(object sender, EventArgs e)
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

        private void CbTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimer.Enabled == true)
            {
                ChangeTime();
            }
        }
    }
}
