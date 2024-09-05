using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressQuest
{
    class Piece : PictureBox // internal - член доступен только в пределах текущей сборки
    {
        public int bullLandCount = 0, bullDownSpeed = 2;
        public Piece(int width, int height)
        {
            // свойства класса
            Width = width;
            Height = height;
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;
        }
    }
}