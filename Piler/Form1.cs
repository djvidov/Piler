using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piler
{
    public partial class Form1 : Form
    {
        TableManager tableManager = null;
        public Form1()
        {
            InitializeComponent();
            tableManager = new TableManager
            {
                Crane = crane1
            };
            tableManager.Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableManager.MoveBlockOnTable(block1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableManager.MoveBlockOnTable(block2);
        }
    }
}
