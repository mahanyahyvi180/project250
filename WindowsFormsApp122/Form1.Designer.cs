namespace WindowsFormsApp122
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
            this.button1 = new System.Windows.Forms.Button();
            this.fButton1 = new WindowsFormsApp122.FButton();
            this.next2 = new WindowsFormsApp122.Next();
            this.next1 = new WindowsFormsApp122.Next();
            this.fButton2 = new WindowsFormsApp122.FButton();
            this.fButton3 = new WindowsFormsApp122.FButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(425, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(680, 170);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fButton1
            // 
            this.fButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fButton1.Location = new System.Drawing.Point(491, 486);
            this.fButton1.Name = "fButton1";
            this.fButton1.Size = new System.Drawing.Size(501, 144);
            this.fButton1.TabIndex = 3;
            this.fButton1.Text = "ثبت";
            this.fButton1.UseVisualStyleBackColor = false;
            this.fButton1.Click += new System.EventHandler(this.fButton1_Click);
            // 
            // next2
            // 
            this.next2.Location = new System.Drawing.Point(349, 291);
            this.next2.Multiline = true;
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(789, 58);
            this.next2.TabIndex = 1;
            // 
            // next1
            // 
            this.next1.Location = new System.Drawing.Point(349, 148);
            this.next1.Multiline = true;
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(789, 58);
            this.next1.TabIndex = 0;
            this.next1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.next1_KeyPress);
            // 
            // fButton2
            // 
            this.fButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fButton2.Location = new System.Drawing.Point(534, 48);
            this.fButton2.Name = "fButton2";
            this.fButton2.Size = new System.Drawing.Size(372, 71);
            this.fButton2.TabIndex = 4;
            this.fButton2.Text = "ثبت";
            this.fButton2.UseVisualStyleBackColor = false;
            // 
            // fButton3
            // 
            this.fButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fButton3.Location = new System.Drawing.Point(555, 368);
            this.fButton3.Name = "fButton3";
            this.fButton3.Size = new System.Drawing.Size(364, 90);
            this.fButton3.TabIndex = 5;
            this.fButton3.Text = "ثبت";
            this.fButton3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 857);
            this.Controls.Add(this.fButton3);
            this.Controls.Add(this.fButton2);
            this.Controls.Add(this.fButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.next2);
            this.Controls.Add(this.next1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Next next1;
        private Next next2;
        private System.Windows.Forms.Button button1;
        private FButton fButton1;
        private FButton fButton2;
        private FButton fButton3;
    }
}

