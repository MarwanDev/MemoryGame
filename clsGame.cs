using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MemoryGame.clsGame;

namespace MemoryGame
{
    internal class clsGame
    {
        private byte _Time;
        private byte _Speed;
        public enum enPictureSet
        {
            Animals,
            Cars,
            Food
        }
        private enPictureSet _PictureSet;
        private List<PictureBox> _PictureBoxes;
        private byte _Moves;
        private decimal _SuccessfulMoves;

        private void FillImagesList(ref List<Image> Images)
        {
            switch (_PictureSet)
            {
                case enPictureSet.Animals:
                    Images = new List<Image>
                {
                    Resources.lion,
                    Resources.panda,
                    Resources.penguin,
                    Resources.chick,
                    Resources.giraffe,
                    Resources.eyeglases
                };
                    break;
                case enPictureSet.Cars:
                    Images = new List<Image>
                {
                    Resources.red_car,
                    Resources.orange_car,
                    Resources.blue_car,
                    Resources.transport,
                    Resources.green_car,
                    Resources.yellow_car
                };
                    break;
                default:
                    Images = new List<Image>
                {
                    Resources.fish,
                    Resources.cheese,
                    Resources.cherries,
                    Resources.chicken,
                    Resources.noodles,
                    Resources.cupcake
                };
                    break;
            }
        }

        public void ChangePictureSet(enPictureSet pictureSet)
        {
            _PictureSet = pictureSet;
            FillImagesList(ref _Images);
        }

        private List<Image> _Images;

        private void FillPictureBoxesList(List<PictureBox> pictureBoxes)
        {
            _PictureBoxes = pictureBoxes;
        }

        public clsGame(
            List<PictureBox> pictureBoxes,
            enPictureSet pictureSet = enPictureSet.Animals,
            byte time = 1,
            byte speed = 1
        )
        {
            _PictureSet = pictureSet;
            FillImagesList(ref _Images);
            _Time = time;
            _Speed = speed;
            _Moves = 0;
            _SuccessfulMoves = 0;
            FillPictureBoxesList(pictureBoxes);
            ArrangeImages();
            ChangeAllBoxesAbility();
        }

        private short GetRandomNumber(short min = 0, short max = 5)
        {
            if (min > max)
                throw new ArgumentException("min must be less than or equal to max");

            Random random = new Random();
            return (short)random.Next(min, max + 1);
        }

        private bool CanImageBeAdded(Image image)
        {
            byte counter = 0;
            foreach (PictureBox pictureBox in _PictureBoxes)
            {
                if (pictureBox.Tag == null)
                    break;
                if (pictureBox.Tag == image)
                    counter++;
            }
            return counter < 2;
        }

        public void ChangeAllBoxesAbility(bool isEnabled = false)
        {
            foreach (PictureBox pictureBox in _PictureBoxes)
            {
                pictureBox.Enabled = isEnabled;
            }
        }

        private void ArrangeImages()
        {
            Image lastImage = null;
            foreach (PictureBox pictureBox in _PictureBoxes)
            {
                Image selectedImage;
                if (GetRandomNumber(0, 8) == 0)
                {
                    do
                    {
                        selectedImage = _Images[GetRandomNumber()];
                    }
                    while (!CanImageBeAdded(selectedImage));
                }
                else
                {
                    do
                    {
                        selectedImage = _Images[GetRandomNumber()];
                    }
                    while (!CanImageBeAdded(selectedImage) || selectedImage == lastImage);
                }
                pictureBox.Tag = selectedImage;
                lastImage = selectedImage;
            }
        }

        private void ChangePictureBoxImage(PictureBox pictureBox, Image image)
        {
            pictureBox.Image = image;
            pictureBox.Refresh();
        }

        public bool ShowImages()
        {
            foreach(PictureBox pictureBox in _PictureBoxes)
            {
                ChangePictureBoxImage(pictureBox, (Image)pictureBox.Tag);
            }
            Thread.Sleep(3000);
            foreach (PictureBox pictureBox in _PictureBoxes)
            {
                ChangePictureBoxImage(pictureBox, Resources.question_mark_96);
            }
            return true;
        }

        public void StartGame()
        {
            ChangeAllBoxesAbility(true);
        }

        public byte GetMoves()
        {
            return _Moves;
        }

        public void IncrementMoves()
        {
            _Moves++;
        }

        public decimal GetSuccessfulMoves()
        {
            return _SuccessfulMoves;
        }

        public void CountSuccessfulMoves()
        {
            _SuccessfulMoves = 0;
            foreach (PictureBox pictureBox in _PictureBoxes)
            {
                if (pictureBox.Image != pictureBox.Tag)
                    _SuccessfulMoves += (decimal)(0.5);
            }
        }

        public bool IsGameOver()
        {
            foreach (PictureBox pictureBox in _PictureBoxes)
            {
                if (pictureBox.Image != pictureBox.Tag)
                    return false;
            }
            return true;
        }
    }
}
