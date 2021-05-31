
namespace Graphics_Package
{
    partial class EllipseForm
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
            this.EllipseFormBack = new System.Windows.Forms.Button();
            this.Xcenter = new System.Windows.Forms.TextBox();
            this.Ycenter = new System.Windows.Forms.TextBox();
            this.Rx = new System.Windows.Forms.TextBox();
            this.Ry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Draw_Ellipse = new System.Windows.Forms.Button();
            this.panel_Ellipse = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EllipseFormBack
            // 
            this.EllipseFormBack.Location = new System.Drawing.Point(397, 38);
            this.EllipseFormBack.Name = "EllipseFormBack";
            this.EllipseFormBack.Size = new System.Drawing.Size(166, 39);
            this.EllipseFormBack.TabIndex = 0;
            this.EllipseFormBack.Text = "Back To Main Page";
            this.EllipseFormBack.UseVisualStyleBackColor = true;
            this.EllipseFormBack.Click += new System.EventHandler(this.EllipseFormBack_Click_1);
            // 
            // Xcenter
            // 
            this.Xcenter.Location = new System.Drawing.Point(45, 144);
            this.Xcenter.Name = "Xcenter";
            this.Xcenter.Size = new System.Drawing.Size(100, 22);
            this.Xcenter.TabIndex = 1;
            // 
            // Ycenter
            // 
            this.Ycenter.Location = new System.Drawing.Point(223, 144);
            this.Ycenter.Name = "Ycenter";
            this.Ycenter.Size = new System.Drawing.Size(100, 22);
            this.Ycenter.TabIndex = 2;
            // 
            // Rx
            // 
            this.Rx.Location = new System.Drawing.Point(568, 144);
            this.Rx.Name = "Rx";
            this.Rx.Size = new System.Drawing.Size(100, 22);
            this.Rx.TabIndex = 3;
            // 
            // Ry
            // 
            this.Ry.Location = new System.Drawing.Point(736, 144);
            this.Ry.Name = "Ry";
            this.Ry.Size = new System.Drawing.Size(100, 22);
            this.Ry.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "X_Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y_Center";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "R_X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(752, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "R_Y";
            // 
            // Draw_Ellipse
            // 
            this.Draw_Ellipse.Location = new System.Drawing.Point(417, 173);
            this.Draw_Ellipse.Name = "Draw_Ellipse";
            this.Draw_Ellipse.Size = new System.Drawing.Size(75, 23);
            this.Draw_Ellipse.TabIndex = 9;
            this.Draw_Ellipse.Text = "Draw";
            this.Draw_Ellipse.UseVisualStyleBackColor = true;
            this.Draw_Ellipse.Click += new System.EventHandler(this.Draw_Ellipse_Click);
            // 
            // panel_Ellipse
            // 
            this.panel_Ellipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_Ellipse.Location = new System.Drawing.Point(70, 217);
            this.panel_Ellipse.Name = "panel_Ellipse";
            this.panel_Ellipse.Size = new System.Drawing.Size(778, 384);
            this.panel_Ellipse.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 660);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 114);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(532, 660);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 114);
            this.textBox2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Region 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Region 2";
            // 
            // EllipseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 793);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel_Ellipse);
            this.Controls.Add(this.Draw_Ellipse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ry);
            this.Controls.Add(this.Rx);
            this.Controls.Add(this.Ycenter);
            this.Controls.Add(this.Xcenter);
            this.Controls.Add(this.EllipseFormBack);
            this.Name = "EllipseForm";
            this.Text = "EllipseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EllipseFormBack;
        private System.Windows.Forms.TextBox Xcenter;
        private System.Windows.Forms.TextBox Ycenter;
        private System.Windows.Forms.TextBox Rx;
        private System.Windows.Forms.TextBox Ry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Draw_Ellipse;
        private System.Windows.Forms.Panel panel_Ellipse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}