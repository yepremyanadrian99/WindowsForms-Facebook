using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFacebook
{
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) buttonOK.PerformClick();
        }
    }
}