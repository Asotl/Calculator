namespace WindowsFormsApplication4
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
            this.result = new System.Windows.Forms.RichTextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.equolly = new System.Windows.Forms.Button();
            this.One_B = new System.Windows.Forms.Button();
            this.Two_B = new System.Windows.Forms.Button();
            this.Three_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(13, 13);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(259, 51);
            this.result.TabIndex = 0;
            this.result.Text = "";
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(197, 70);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 23);
            this.Plus.TabIndex = 1;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // equolly
            // 
            this.equolly.Location = new System.Drawing.Point(196, 100);
            this.equolly.Name = "equolly";
            this.equolly.Size = new System.Drawing.Size(75, 23);
            this.equolly.TabIndex = 2;
            this.equolly.Text = "=";
            this.equolly.UseVisualStyleBackColor = true;
            this.equolly.Click += new System.EventHandler(this.equolly_Click);
            // 
            // One_B
            // 
            this.One_B.Location = new System.Drawing.Point(13, 71);
            this.One_B.Name = "One_B";
            this.One_B.Size = new System.Drawing.Size(75, 23);
            this.One_B.TabIndex = 3;
            this.One_B.Text = "1";
            this.One_B.UseVisualStyleBackColor = true;
            this.One_B.Click += new System.EventHandler(this.One_Click);
            // 
            // Two_B
            // 
            this.Two_B.Location = new System.Drawing.Point(13, 101);
            this.Two_B.Name = "Two_B";
            this.Two_B.Size = new System.Drawing.Size(75, 23);
            this.Two_B.TabIndex = 4;
            this.Two_B.Text = "2";
            this.Two_B.UseVisualStyleBackColor = true;
            // 
            // Three_B
            // 
            this.Three_B.Location = new System.Drawing.Point(13, 131);
            this.Three_B.Name = "Three_B";
            this.Three_B.Size = new System.Drawing.Size(75, 23);
            this.Three_B.TabIndex = 5;
            this.Three_B.Text = "3";
            this.Three_B.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.Three_B);
            this.Controls.Add(this.Two_B);
            this.Controls.Add(this.One_B);
            this.Controls.Add(this.equolly);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button equolly;
        private System.Windows.Forms.Button One_B;
        private System.Windows.Forms.Button Two_B;
        private System.Windows.Forms.Button Three_B;
    }
}

