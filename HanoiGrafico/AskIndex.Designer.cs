namespace HanoiGrafico
{
    partial class AskIndex
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
            btn_C = new Button();
            nmr_Q = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmr_Q).BeginInit();
            SuspendLayout();
            // 
            // btn_C
            // 
            btn_C.Location = new Point(40, 74);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(75, 23);
            btn_C.TabIndex = 0;
            btn_C.Text = "OK";
            btn_C.UseVisualStyleBackColor = true;
            btn_C.Click += btn_C_Click;
            // 
            // nmr_Q
            // 
            nmr_Q.Location = new Point(40, 28);
            nmr_Q.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_Q.Name = "nmr_Q";
            nmr_Q.Size = new Size(120, 23);
            nmr_Q.TabIndex = 1;
            nmr_Q.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AskIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 126);
            Controls.Add(nmr_Q);
            Controls.Add(btn_C);
            Name = "AskIndex";
            Text = "AskIndex";
            ((System.ComponentModel.ISupportInitialize)nmr_Q).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_C;
        private NumericUpDown nmr_Q;
    }
}