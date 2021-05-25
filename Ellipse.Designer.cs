
namespace graphicsPackages
{
    partial class Ellipse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xRadiustextBox = new System.Windows.Forms.TextBox();
            this.yctextBox = new System.Windows.Forms.TextBox();
            this.yradiustextBox = new System.Windows.Forms.TextBox();
            this.xctextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(364, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 230);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(505, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "XC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "YC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xradius";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yradius";
            // 
            // xRadiustextBox
            // 
            this.xRadiustextBox.Location = new System.Drawing.Point(178, 210);
            this.xRadiustextBox.Name = "xRadiustextBox";
            this.xRadiustextBox.Size = new System.Drawing.Size(100, 23);
            this.xRadiustextBox.TabIndex = 6;
            // 
            // yctextBox
            // 
            this.yctextBox.Location = new System.Drawing.Point(178, 146);
            this.yctextBox.Name = "yctextBox";
            this.yctextBox.Size = new System.Drawing.Size(100, 23);
            this.yctextBox.TabIndex = 7;
            // 
            // yradiustextBox
            // 
            this.yradiustextBox.Location = new System.Drawing.Point(178, 269);
            this.yradiustextBox.Name = "yradiustextBox";
            this.yradiustextBox.Size = new System.Drawing.Size(100, 23);
            this.yradiustextBox.TabIndex = 8;
            // 
            // xctextBox
            // 
            this.xctextBox.Location = new System.Drawing.Point(178, 62);
            this.xctextBox.Name = "xctextBox";
            this.xctextBox.Size = new System.Drawing.Size(100, 23);
            this.xctextBox.TabIndex = 9;
            // 
            // Ellipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xctextBox);
            this.Controls.Add(this.yradiustextBox);
            this.Controls.Add(this.yctextBox);
            this.Controls.Add(this.xRadiustextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Ellipse";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xRadiustextBox;
        private System.Windows.Forms.TextBox yctextBox;
        private System.Windows.Forms.TextBox yradiustextBox;
        private System.Windows.Forms.TextBox xctextBox;
    }
}