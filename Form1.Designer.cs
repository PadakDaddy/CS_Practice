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
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxNum1 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btlMulti = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.tboxNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxResult
            // 
            this.tboxResult.Enabled = false;
            this.tboxResult.Location = new System.Drawing.Point(12, 25);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(484, 28);
            this.tboxResult.TabIndex = 0;
            this.tboxResult.Text = "0";
            // 
            // tboxNum1
            // 
            this.tboxNum1.Location = new System.Drawing.Point(12, 75);
            this.tboxNum1.Name = "tboxNum1";
            this.tboxNum1.Size = new System.Drawing.Size(213, 28);
            this.tboxNum1.TabIndex = 3;
            this.tboxNum1.Text = "0";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(13, 142);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 81);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(150, 142);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 81);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btlMulti
            // 
            this.btlMulti.Location = new System.Drawing.Point(283, 142);
            this.btlMulti.Name = "btlMulti";
            this.btlMulti.Size = new System.Drawing.Size(75, 81);
            this.btlMulti.TabIndex = 6;
            this.btlMulti.Text = "*";
            this.btlMulti.UseVisualStyleBackColor = true;
            this.btlMulti.Click += new System.EventHandler(this.btlMulti_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(411, 142);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 81);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // tboxNum2
            // 
            this.tboxNum2.Location = new System.Drawing.Point(283, 75);
            this.tboxNum2.Name = "tboxNum2";
            this.tboxNum2.Size = new System.Drawing.Size(213, 28);
            this.tboxNum2.TabIndex = 8;
            this.tboxNum2.Text = "0";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 307);
            this.Controls.Add(this.tboxNum2);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btlMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tboxNum1);
            this.Controls.Add(this.tboxResult);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxNum1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btlMulti;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.TextBox tboxNum2;
    }
}

