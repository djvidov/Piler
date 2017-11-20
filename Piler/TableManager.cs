using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piler.Controls;

namespace Piler
{
    public class TableManager : ITableManager
    {
        public Crane Crane { get; set; }

        public void Init()
        {
            
        }

        public void MoveBlockOnTable(Block block)
        {
            if (!Crane.IsReady)
                Crane.GoUp();
            Crane.MoveAboveBlock(block);
            Crane.GoDownAndTouchBlock(block);
            Crane.GetUpBlock(block);
        }
    }
}
