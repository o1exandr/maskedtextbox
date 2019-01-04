using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maskedtextbox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void msMask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.Text = string.Format("Помилка: {0}", e.RejectionHint);
        }

        private void msMask_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = "MaskedTextBox";
        }
    }
}
