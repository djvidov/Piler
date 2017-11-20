using System;
using System.Threading;
using System.Windows.Forms;

namespace Piler.Controls
{
    public class Crane : Button
    {
        public Crane()
        {
            this.Size = new System.Drawing.Size(10, 100);
        }

        public bool IsReady
        {
            get
            {
                return Top == 0;
            }
        }

        public void MoveAboveBlock(Block block)
        {
            var targetPosition = block.Left + Convert.ToInt32(block.Width / 2 - Width / 2);
            do
            {
                if (targetPosition > Left)
                {
                    Left++;
                }
                else if (targetPosition < Left)
                {
                    Left--;
                }
                Thread.Sleep(5);
            } while (targetPosition != Left);
        }

        public void GoUp()
        {
            do
            {
                if (0 > Top)
                {
                    Top++;
                }
                else if (0 < Top)
                {
                    Top--;
                }
                Thread.Sleep(5);
            } while (Top != 0);
        }

        public void GoDownAndTouchBlock(Block block)
        {
            do
            {
                Top++;
                Thread.Sleep(5);
            } while (!TouchBlock(block));
        }
        public void GetUpBlock(Block block)
        {
            do
            {
                Top--;
                block.Top--;
                Thread.Sleep(5);
            } while (Top != 0);
        }

        private bool TouchBlock(Block block)
        {
            return Bounds.IntersectsWith(block.Bounds) ? true : false;
            
        }
    }
}
