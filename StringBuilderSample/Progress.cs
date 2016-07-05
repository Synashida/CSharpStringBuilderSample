using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilderSample
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void Progress_Load(object sender, EventArgs e)
        {

        }

        public int MaxValueInFunction;

        public void Init(int maxValue)
        {
            pgbMain.Maximum = 3;
            pgbMain.Value = 0;
            pgbInFunction.Maximum = maxValue;
            lblMain.Text = "Main 0/3";
            lblInFunction.Text = string.Format("In Function 0/{0}", maxValue);
            Update();
        }

        public void NextMain()
        {
            pgbMain.Value++;
            pgbInFunction.Value = 0;
            lblMain.Text = string.Format("Main {0}/3", pgbMain.Value);
            Update();
        }

        public void NextInFunction()
        {
            pgbInFunction.Value++;
            lblInFunction.Text = string.Format("In Function {0}/{1}", pgbInFunction.Value, pgbInFunction.Maximum);
            Update();
        }
    }
}
