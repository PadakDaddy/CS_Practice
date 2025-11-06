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
            this.tboxName = new System.Windows.Forms.TextBox();
            this.lboxDay = new System.Windows.Forms.ListBox();
            this.lboxTime = new System.Windows.Forms.ListBox();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.btnResult1 = new System.Windows.Forms.Button();
            this.btlResult2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(56, 30);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(144, 28);
            this.tboxName.TabIndex = 0;
            // 
            // lboxDay
            // 
            this.lboxDay.FormattingEnabled = true;
            this.lboxDay.ItemHeight = 18;
            this.lboxDay.Location = new System.Drawing.Point(56, 85);
            this.lboxDay.Name = "lboxDay";
            this.lboxDay.Size = new System.Drawing.Size(187, 166);
            this.lboxDay.TabIndex = 1;
            // 
            // lboxTime
            // 
            this.lboxTime.FormattingEnabled = true;
            this.lboxTime.ItemHeight = 18;
            this.lboxTime.Location = new System.Drawing.Point(267, 85);
            this.lboxTime.Name = "lboxTime";
            this.lboxTime.Size = new System.Drawing.Size(187, 166);
            this.lboxTime.TabIndex = 2;
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(56, 337);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.ReadOnly = true;
            this.tboxResult.Size = new System.Drawing.Size(398, 98);
            this.tboxResult.TabIndex = 3;
            // 
            // btnResult1
            // 
            this.btnResult1.Location = new System.Drawing.Point(56, 266);
            this.btnResult1.Name = "btnResult1";
            this.btnResult1.Size = new System.Drawing.Size(104, 49);
            this.btnResult1.TabIndex = 4;
            this.btnResult1.Text = "Result";
            this.btnResult1.UseVisualStyleBackColor = true;
            this.btnResult1.Click += new System.EventHandler(this.btnResult1_Click);
            // 
            // btlResult2
            // 
            this.btlResult2.Location = new System.Drawing.Point(166, 266);
            this.btlResult2.Name = "btlResult2";
            this.btlResult2.Size = new System.Drawing.Size(187, 49);
            this.btlResult2.TabIndex = 5;
            this.btlResult2.Text = "StringFormat Test";
            this.btlResult2.UseVisualStyleBackColor = true;
            this.btlResult2.Click += new System.EventHandler(this.btlResult2_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 468);
            this.Controls.Add(this.btlResult2);
            this.Controls.Add(this.btnResult1);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.lboxTime);
            this.Controls.Add(this.lboxDay);
            this.Controls.Add(this.tboxName);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.ListBox lboxDay;
        private System.Windows.Forms.ListBox lboxTime;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Button btnResult1;
        private System.Windows.Forms.Button btlResult2;
    }
}

