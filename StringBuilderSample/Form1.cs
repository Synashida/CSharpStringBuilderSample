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
            progress.Init((int)loopLimit.Value);
            progress.Show();
            progress.NextMain();
            NormalLoop();

            progress.NextMain();
            StringBuilderLoop();

            progress.NextMain();
            PachimonStringBuilderLoop();

            progress.Hide();
            MessageBox.Show("Done.");
        }

        private void NormalLoop()
        {
            string lines = "";
            DateTime timer = DateTime.Now;

            for (long i = 0; i < loopLimit.Value; i++)
            {
                lines += string.Format("{0},data{1},{2}", i, i, DateTime.Now);
                progress.NextInFunction();
            }
            txtNormal.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
            Update();
        }

        private void StringBuilderLoop()
        {
            StringBuilder lines = new StringBuilder();
            DateTime timer = DateTime.Now;

            for (long i = 0; i < loopLimit.Value; i++)
            {
                lines.Append(i).Append(",").Append("data").Append(i).Append(",").Append(DateTime.Now);
                progress.NextInFunction();
            }
            txtStringBuilder.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
            Update();
        }

        private void PachimonStringBuilderLoop()
        {
            StringBuilder lines = new StringBuilder();
            DateTime timer = DateTime.Now;

            for (long i = 0; i < loopLimit.Value; i++)
            {
                lines.Append(string.Format("{0},data{1},{2}", i, i, DateTime.Now));
                progress.NextInFunction();
            }
            txtPachimon.Text = ((Double)(DateTime.Now.Ticks - timer.Ticks) / 10000000.0).ToString();
            Update();
        }
    }
}
