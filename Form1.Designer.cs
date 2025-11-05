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
            this.tboxResultBit = new System.Windows.Forms.TextBox();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.tboxResultAfter = new System.Windows.Forms.TextBox();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.tboxAndOr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxResultBit
            // 
            this.tboxResultBit.Enabled = false;
            this.tboxResultBit.Location = new System.Drawing.Point(13, 40);
            this.tboxResultBit.Name = "tboxResultBit";
            this.tboxResultBit.ReadOnly = true;
            this.tboxResultBit.Size = new System.Drawing.Size(139, 21);
            this.tboxResultBit.TabIndex = 2;
            this.tboxResultBit.Text = "0";
            this.tboxResultBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(13, 13);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(139, 21);
            this.tboxResult.TabIndex = 3;
            this.tboxResult.Text = "0";
            this.tboxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxResult.TextChanged += new System.EventHandler(this.tboxResult_TextChanged);
            // 
            // tboxResultAfter
            // 
            this.tboxResultAfter.Location = new System.Drawing.Point(190, 13);
            this.tboxResultAfter.Name = "tboxResultAfter";
            this.tboxResultAfter.Size = new System.Drawing.Size(139, 21);
            this.tboxResultAfter.TabIndex = 4;
            this.tboxResultAfter.Text = "0";
            this.tboxResultAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxResultAfter.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(13, 96);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(139, 21);
            this.tboxNumber.TabIndex = 5;
            this.tboxNumber.Text = "0";
            this.tboxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxAndOr
            // 
            this.tboxAndOr.Enabled = false;
            this.tboxAndOr.Location = new System.Drawing.Point(190, 96);
            this.tboxAndOr.Name = "tboxAndOr";
            this.tboxAndOr.ReadOnly = true;
            this.tboxAndOr.Size = new System.Drawing.Size(139, 21);
            this.tboxAndOr.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "+=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 52);
            this.button4.TabIndex = 10;
            this.button4.Text = "-=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 52);
            this.button5.TabIndex = 11;
            this.button5.Text = "++a";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(96, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 52);
            this.button6.TabIndex = 12;
            this.button6.Text = "a++";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(190, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 52);
            this.button7.TabIndex = 13;
            this.button7.Text = "&&";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(265, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 52);
            this.button8.TabIndex = 14;
            this.button8.Text = "||";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 312);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tboxAndOr);
            this.Controls.Add(this.tboxNumber);
            this.Controls.Add(this.tboxResultAfter);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.tboxResultBit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResultBit;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.TextBox tboxResultAfter;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.TextBox tboxAndOr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

