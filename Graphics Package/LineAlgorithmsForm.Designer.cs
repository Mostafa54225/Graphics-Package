
namespace Graphics_Package
{
    partial class LineAlgorithmsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.point_x1 = new System.Windows.Forms.TextBox();
            this.point_y1 = new System.Windows.Forms.TextBox();
            this.point_x2 = new System.Windows.Forms.TextBox();
            this.point_y2 = new System.Windows.Forms.TextBox();
            this.panel_DDA = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_Bresenham = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BackToMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y1";
            // 
            // point_x1
            // 
            this.point_x1.Location = new System.Drawing.Point(103, 113);
            this.point_x1.Name = "point_x1";
            this.point_x1.Size = new System.Drawing.Size(100, 22);
            this.point_x1.TabIndex = 3;
            this.point_x1.TextChanged += new System.EventHandler(this.point_x1_TextChanged);
            // 
            // point_y1
            // 
            this.point_y1.Location = new System.Drawing.Point(265, 113);
            this.point_y1.Name = "point_y1";
            this.point_y1.Size = new System.Drawing.Size(100, 22);
            this.point_y1.TabIndex = 4;
            // 
            // point_x2
            // 
            this.point_x2.Location = new System.Drawing.Point(581, 113);
            this.point_x2.Name = "point_x2";
            this.point_x2.Size = new System.Drawing.Size(100, 22);
            this.point_x2.TabIndex = 5;
            // 
            // point_y2
            // 
            this.point_y2.Location = new System.Drawing.Point(739, 113);
            this.point_y2.Name = "point_y2";
            this.point_y2.Size = new System.Drawing.Size(100, 22);
            this.point_y2.TabIndex = 6;
            // 
            // panel_DDA
            // 
            this.panel_DDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_DDA.Location = new System.Drawing.Point(33, 208);
            this.panel_DDA.Name = "panel_DDA";
            this.panel_DDA.Size = new System.Drawing.Size(429, 435);
            this.panel_DDA.TabIndex = 7;
            this.panel_DDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_DDA_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "DDA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel_Bresenham
            // 
            this.panel_Bresenham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_Bresenham.Location = new System.Drawing.Point(485, 208);
            this.panel_Bresenham.Name = "panel_Bresenham";
            this.panel_Bresenham.Size = new System.Drawing.Size(429, 435);
            this.panel_Bresenham.TabIndex = 8;
            this.panel_Bresenham.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Bresenham_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bresenham";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 650);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 145);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(485, 650);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(429, 145);
            this.textBox2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Draw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BackToMainForm
            // 
            this.BackToMainForm.Location = new System.Drawing.Point(397, 38);
            this.BackToMainForm.Name = "BackToMainForm";
            this.BackToMainForm.Size = new System.Drawing.Size(166, 39);
            this.BackToMainForm.TabIndex = 14;
            this.BackToMainForm.Text = "Back To Main Page";
            this.BackToMainForm.UseVisualStyleBackColor = true;
            this.BackToMainForm.Click += new System.EventHandler(this.MainForm_Click);
            // 
            // LineAlgorithmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 807);
            this.Controls.Add(this.BackToMainForm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_Bresenham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_DDA);
            this.Controls.Add(this.point_y2);
            this.Controls.Add(this.point_x2);
            this.Controls.Add(this.point_y1);
            this.Controls.Add(this.point_x1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LineAlgorithmsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox point_x1;
        private System.Windows.Forms.TextBox point_y1;
        private System.Windows.Forms.TextBox point_x2;
        private System.Windows.Forms.TextBox point_y2;
        private System.Windows.Forms.Panel panel_DDA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_Bresenham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BackToMainForm;
    }
}

