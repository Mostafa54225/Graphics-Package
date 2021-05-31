
namespace Graphics_Package
{
    partial class CircleForm
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
            this.center_xTextbox = new System.Windows.Forms.TextBox();
            this.center_YTextbox = new System.Windows.Forms.TextBox();
            this.radius_Textbox = new System.Windows.Forms.TextBox();
            this.midPoint_Circle_panel = new System.Windows.Forms.Panel();
            this.DrawMidpointCicrle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Center_X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Center_Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(747, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Radius";
            // 
            // center_xTextbox
            // 
            this.center_xTextbox.Location = new System.Drawing.Point(110, 155);
            this.center_xTextbox.Name = "center_xTextbox";
            this.center_xTextbox.Size = new System.Drawing.Size(100, 22);
            this.center_xTextbox.TabIndex = 3;
            // 
            // center_YTextbox
            // 
            this.center_YTextbox.Location = new System.Drawing.Point(432, 155);
            this.center_YTextbox.Name = "center_YTextbox";
            this.center_YTextbox.Size = new System.Drawing.Size(100, 22);
            this.center_YTextbox.TabIndex = 4;
            // 
            // radius_Textbox
            // 
            this.radius_Textbox.Location = new System.Drawing.Point(753, 155);
            this.radius_Textbox.Name = "radius_Textbox";
            this.radius_Textbox.Size = new System.Drawing.Size(100, 22);
            this.radius_Textbox.TabIndex = 5;
            // 
            // midPoint_Circle_panel
            // 
            this.midPoint_Circle_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.midPoint_Circle_panel.Location = new System.Drawing.Point(110, 246);
            this.midPoint_Circle_panel.Name = "midPoint_Circle_panel";
            this.midPoint_Circle_panel.Size = new System.Drawing.Size(715, 393);
            this.midPoint_Circle_panel.TabIndex = 6;
            // 
            // DrawMidpointCicrle
            // 
            this.DrawMidpointCicrle.Location = new System.Drawing.Point(445, 202);
            this.DrawMidpointCicrle.Name = "DrawMidpointCicrle";
            this.DrawMidpointCicrle.Size = new System.Drawing.Size(75, 23);
            this.DrawMidpointCicrle.TabIndex = 7;
            this.DrawMidpointCicrle.Text = "Draw";
            this.DrawMidpointCicrle.UseVisualStyleBackColor = true;
            this.DrawMidpointCicrle.Click += new System.EventHandler(this.DrawMidpointCicrle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back To Main Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 645);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 145);
            this.textBox1.TabIndex = 9;
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 807);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DrawMidpointCicrle);
            this.Controls.Add(this.midPoint_Circle_panel);
            this.Controls.Add(this.radius_Textbox);
            this.Controls.Add(this.center_YTextbox);
            this.Controls.Add(this.center_xTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox center_xTextbox;
        private System.Windows.Forms.TextBox center_YTextbox;
        private System.Windows.Forms.TextBox radius_Textbox;
        private System.Windows.Forms.Panel midPoint_Circle_panel;
        private System.Windows.Forms.Button DrawMidpointCicrle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}