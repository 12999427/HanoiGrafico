namespace HanoiGrafico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_Canvas = new Panel();
            pnl_Torre3 = new Panel();
            pnl_Torre2 = new Panel();
            pnl_Torre1 = new Panel();
            pnl_Canvas.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Canvas
            // 
            pnl_Canvas.Controls.Add(pnl_Torre3);
            pnl_Canvas.Controls.Add(pnl_Torre2);
            pnl_Canvas.Controls.Add(pnl_Torre1);
            pnl_Canvas.Location = new Point(12, 12);
            pnl_Canvas.Name = "pnl_Canvas";
            pnl_Canvas.Size = new Size(776, 426);
            pnl_Canvas.TabIndex = 0;
            // 
            // pnl_Torre3
            // 
            pnl_Torre3.BackColor = Color.FromArgb(64, 64, 0);
            pnl_Torre3.Location = new Point(613, 133);
            pnl_Torre3.Name = "pnl_Torre3";
            pnl_Torre3.Size = new Size(35, 293);
            pnl_Torre3.TabIndex = 1;
            // 
            // pnl_Torre2
            // 
            pnl_Torre2.BackColor = Color.FromArgb(64, 64, 0);
            pnl_Torre2.Location = new Point(365, 133);
            pnl_Torre2.Name = "pnl_Torre2";
            pnl_Torre2.Size = new Size(35, 293);
            pnl_Torre2.TabIndex = 1;
            // 
            // pnl_Torre1
            // 
            pnl_Torre1.BackColor = Color.FromArgb(64, 64, 0);
            pnl_Torre1.Location = new Point(125, 133);
            pnl_Torre1.Name = "pnl_Torre1";
            pnl_Torre1.Size = new Size(35, 293);
            pnl_Torre1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_Canvas);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Form1";
            pnl_Canvas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Canvas;
        private Panel pnl_Torre2;
        private Panel pnl_Torre1;
        private Panel pnl_Torre3;
    }
}