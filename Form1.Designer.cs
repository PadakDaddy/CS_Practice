namespace Practice
{
    partial class form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnIfResult = new System.Windows.Forms.Button();
            this.lblIfResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSwitchResult = new System.Windows.Forms.Button();
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.lblSwitchResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number2";
            // 
            // btnIfResult
            // 
            this.btnIfResult.Location = new System.Drawing.Point(342, 44);
            this.btnIfResult.Name = "btnIfResult";
            this.btnIfResult.Size = new System.Drawing.Size(133, 64);
            this.btnIfResult.TabIndex = 2;
            this.btnIfResult.Text = "Compare Number";
            this.btnIfResult.UseVisualStyleBackColor = true;
            this.btnIfResult.Click += new System.EventHandler(this.btnIfResult_Click);
            // 
            // lblIfResult
            // 
            this.lblIfResult.AutoSize = true;
            this.lblIfResult.Location = new System.Drawing.Point(43, 132);
            this.lblIfResult.Name = "lblIfResult";
            this.lblIfResult.Size = new System.Drawing.Size(17, 18);
            this.lblIfResult.TabIndex = 3;
            this.lblIfResult.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Day";
            // 
            // btnSwitchResult
            // 
            this.btnSwitchResult.Location = new System.Drawing.Point(342, 230);
            this.btnSwitchResult.Name = "btnSwitchResult";
            this.btnSwitchResult.Size = new System.Drawing.Size(133, 64);
            this.btnSwitchResult.TabIndex = 6;
            this.btnSwitchResult.Text = "Selected Day";
            this.btnSwitchResult.UseVisualStyleBackColor = true;
            this.btnSwitchResult.Click += new System.EventHandler(this.btnSwitchResult_Click);
            // 
            // nNumber1
            // 
            this.nNumber1.Location = new System.Drawing.Point(43, 65);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(120, 28);
            this.nNumber1.TabIndex = 7;
            // 
            // nNumber2
            // 
            this.nNumber2.Location = new System.Drawing.Point(190, 65);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(120, 28);
            this.nNumber2.TabIndex = 8;
            // 
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cboxDay.Location = new System.Drawing.Point(46, 250);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(121, 26);
            this.cboxDay.TabIndex = 9;
            // 
            // lblSwitchResult
            // 
            this.lblSwitchResult.AutoSize = true;
            this.lblSwitchResult.Location = new System.Drawing.Point(55, 324);
            this.lblSwitchResult.Name = "lblSwitchResult";
            this.lblSwitchResult.Size = new System.Drawing.Size(17, 18);
            this.lblSwitchResult.TabIndex = 10;
            this.lblSwitchResult.Text = "-";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 429);
            this.Controls.Add(this.lblSwitchResult);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.nNumber1);
            this.Controls.Add(this.btnSwitchResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIfResult);
            this.Controls.Add(this.btnIfResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIfResult;
        private System.Windows.Forms.Label lblIfResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSwitchResult;
        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.Label lblSwitchResult;
    }
}

