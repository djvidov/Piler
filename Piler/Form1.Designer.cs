namespace Piler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.table1 = new Piler.Controls.Table();
            this.crane1 = new Piler.Controls.Crane();
            this.block1 = new Piler.Controls.Block();
            this.block2 = new Piler.Controls.Block();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // table1
            // 
            this.table1.Location = new System.Drawing.Point(151, 214);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(200, 50);
            this.table1.TabIndex = 0;
            this.table1.Text = "table1";
            this.table1.UseVisualStyleBackColor = true;
            // 
            // crane1
            // 
            this.crane1.Location = new System.Drawing.Point(239, 12);
            this.crane1.Name = "crane1";
            this.crane1.Size = new System.Drawing.Size(10, 100);
            this.crane1.TabIndex = 1;
            this.crane1.Text = "crane1";
            this.crane1.UseVisualStyleBackColor = true;
            // 
            // block1
            // 
            this.block1.Location = new System.Drawing.Point(12, 224);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(30, 30);
            this.block1.TabIndex = 2;
            this.block1.Text = "1";
            this.block1.UseVisualStyleBackColor = true;
            // 
            // block2
            // 
            this.block2.Location = new System.Drawing.Point(49, 224);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(30, 30);
            this.block2.TabIndex = 3;
            this.block2.Text = "2";
            this.block2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "M 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "M 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.block1);
            this.Controls.Add(this.crane1);
            this.Controls.Add(this.table1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Table table1;
        private Controls.Crane crane1;
        private Controls.Block block1;
        private Controls.Block block2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

