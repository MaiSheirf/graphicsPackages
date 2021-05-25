
namespace WinFormsApp1
{
    partial class lineDDA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.x1label = new System.Windows.Forms.Label();
            this.y1label = new System.Windows.Forms.Label();
            this.x2label = new System.Windows.Forms.Label();
            this.y2label = new System.Windows.Forms.Label();
            this.x1textBox = new System.Windows.Forms.TextBox();
            this.y1textBox = new System.Windows.Forms.TextBox();
            this.x2textBox = new System.Windows.Forms.TextBox();
            this.y2textBox = new System.Windows.Forms.TextBox();
            this.drawbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(331, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 274);
            this.panel1.TabIndex = 0;
            // 
            // x1label
            // 
            this.x1label.AutoSize = true;
            this.x1label.Location = new System.Drawing.Point(121, 77);
            this.x1label.Name = "x1label";
            this.x1label.Size = new System.Drawing.Size(20, 15);
            this.x1label.TabIndex = 1;
            this.x1label.Text = "X1";
            // 
            // y1label
            // 
            this.y1label.AutoSize = true;
            this.y1label.Location = new System.Drawing.Point(121, 170);
            this.y1label.Name = "y1label";
            this.y1label.Size = new System.Drawing.Size(20, 15);
            this.y1label.TabIndex = 2;
            this.y1label.Text = "Y1";
            // 
            // x2label
            // 
            this.x2label.AutoSize = true;
            this.x2label.Location = new System.Drawing.Point(121, 253);
            this.x2label.Name = "x2label";
            this.x2label.Size = new System.Drawing.Size(20, 15);
            this.x2label.TabIndex = 3;
            this.x2label.Text = "X2";
            // 
            // y2label
            // 
            this.y2label.AutoSize = true;
            this.y2label.Location = new System.Drawing.Point(121, 336);
            this.y2label.Name = "y2label";
            this.y2label.Size = new System.Drawing.Size(20, 15);
            this.y2label.TabIndex = 4;
            this.y2label.Text = "Y2";
            // 
            // x1textBox
            // 
            this.x1textBox.Location = new System.Drawing.Point(198, 77);
            this.x1textBox.Name = "x1textBox";
            this.x1textBox.Size = new System.Drawing.Size(100, 23);
            this.x1textBox.TabIndex = 5;
            // 
            // y1textBox
            // 
            this.y1textBox.Location = new System.Drawing.Point(198, 170);
            this.y1textBox.Name = "y1textBox";
            this.y1textBox.Size = new System.Drawing.Size(100, 23);
            this.y1textBox.TabIndex = 6;
            // 
            // x2textBox
            // 
            this.x2textBox.Location = new System.Drawing.Point(198, 253);
            this.x2textBox.Name = "x2textBox";
            this.x2textBox.Size = new System.Drawing.Size(100, 23);
            this.x2textBox.TabIndex = 7;
            // 
            // y2textBox
            // 
            this.y2textBox.Location = new System.Drawing.Point(198, 328);
            this.y2textBox.Name = "y2textBox";
            this.y2textBox.Size = new System.Drawing.Size(100, 23);
            this.y2textBox.TabIndex = 8;
            // 
            // drawbutton
            // 
            this.drawbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.drawbutton.Location = new System.Drawing.Point(476, 382);
            this.drawbutton.Name = "drawbutton";
            this.drawbutton.Size = new System.Drawing.Size(116, 42);
            this.drawbutton.TabIndex = 9;
            this.drawbutton.Text = "Draw";
            this.drawbutton.UseVisualStyleBackColor = false;
            this.drawbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // lineDDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawbutton);
            this.Controls.Add(this.y2textBox);
            this.Controls.Add(this.x2textBox);
            this.Controls.Add(this.y1textBox);
            this.Controls.Add(this.x1textBox);
            this.Controls.Add(this.y2label);
            this.Controls.Add(this.x2label);
            this.Controls.Add(this.y1label);
            this.Controls.Add(this.x1label);
            this.Controls.Add(this.panel1);
            this.Name = "lineDDA";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label x1label;
        private System.Windows.Forms.Label y1label;
        private System.Windows.Forms.Label x2label;
        private System.Windows.Forms.Label y2label;
        private System.Windows.Forms.TextBox x1textBox;
        private System.Windows.Forms.TextBox y1textBox;
        private System.Windows.Forms.TextBox x2textBox;
        private System.Windows.Forms.TextBox y2textBox;
        private System.Windows.Forms.Button drawbutton;
    }
}

