namespace StringBuilderSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.lblLoop = new System.Windows.Forms.Label();
            this.loopLimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.txtStringBuilder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPachimon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loopLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "String Add";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(215, 11);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 1;
            this.btnExec.Text = "Exec";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // lblLoop
            // 
            this.lblLoop.AutoSize = true;
            this.lblLoop.Location = new System.Drawing.Point(24, 17);
            this.lblLoop.Name = "lblLoop";
            this.lblLoop.Size = new System.Drawing.Size(29, 12);
            this.lblLoop.TabIndex = 2;
            this.lblLoop.Text = "Loop";
            // 
            // loopLimit
            // 
            this.loopLimit.Location = new System.Drawing.Point(65, 15);
            this.loopLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.loopLimit.Name = "loopLimit";
            this.loopLimit.Size = new System.Drawing.Size(120, 19);
            this.loopLimit.TabIndex = 3;
            this.loopLimit.Value = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "String Builder";
            // 
            // txtNormal
            // 
            this.txtNormal.Location = new System.Drawing.Point(107, 88);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(100, 19);
            this.txtNormal.TabIndex = 5;
            // 
            // txtStringBuilder
            // 
            this.txtStringBuilder.Location = new System.Drawing.Point(107, 145);
            this.txtStringBuilder.Name = "txtStringBuilder";
            this.txtStringBuilder.Size = new System.Drawing.Size(100, 19);
            this.txtStringBuilder.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "sec.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "sec.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "sec.";
            // 
            // txtPachimon
            // 
            this.txtPachimon.Location = new System.Drawing.Point(107, 203);
            this.txtPachimon.Name = "txtPachimon";
            this.txtPachimon.Size = new System.Drawing.Size(100, 19);
            this.txtPachimon.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "偽 Builder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "lines += string.Format(\"{0},data{1},{2}\", i, i, DateTime.Now);";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(460, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "lines.Append(i).Append(\",\").Append(\"data\").Append(i).Append(\",\").Append(DateTime." +
    "Now);";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "lines.Append(string.Format(\"{0},data{1},{2}\", i, i, DateTime.Now));";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 308);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPachimon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStringBuilder);
            this.Controls.Add(this.txtNormal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loopLimit);
            this.Controls.Add(this.lblLoop);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loopLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label lblLoop;
        private System.Windows.Forms.NumericUpDown loopLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.TextBox txtStringBuilder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPachimon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

