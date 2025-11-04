using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanoiGrafico
{
    public partial class AskIndex : Form
    {
        public int num;
        public AskIndex()
        {
            InitializeComponent();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            num = (int)nmr_Q.Value;
            DialogResult = DialogResult.OK;
        }

    }
}
