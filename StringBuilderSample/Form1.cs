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
    public partial class Form1 : Form
    {
        Progress progress = new Progress();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            NormalLoop();
            StringBuilderLoop();
            PachimonStringBuilderLoop();
            MessageBox.Show("Done.");
        }

        private void NormalLoop()
        {
            string lines = "";
            DateTime timer = DateTime.Now;
            long loopMax = (long)loopLimit.Value;

            for (long i = 0; i < loopMax; i++)
            {
                lines += string.Format("{0},data{1},{2}{3}", i, i, DateTime.Now, System.Environment.NewLine);
            }
            txtNormal.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
        }

        private void StringBuilderLoop()
        {
            StringBuilder lines = new StringBuilder(32 * (int)loopLimit.Value);
            DateTime timer = DateTime.Now;
            long loopMax = (long)loopLimit.Value;

            for (long i = 0; i < loopMax; i++)
            {
                lines.Append(i).Append(",").Append("data").Append(i).Append(",").Append(DateTime.Now);
            }
            txtStringBuilder.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
        }

        private void PachimonStringBuilderLoop()
        {
            StringBuilder lines = new StringBuilder(32 * (int)loopLimit.Value);
            DateTime timer = DateTime.Now;
            long loopMax = (long)loopLimit.Value;

            for (long i = 0; i < loopMax; i++)
            {
              lines.Append(string.Format("{0},data{1},{2}{3}", i, i, DateTime.Now, System.Environment.NewLine));
            }
            txtPachimon.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
        }
    }
}
