
namespace Graphics_Package
{
    partial class MainForm
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
            this.LineAlgorithmsForm = new System.Windows.Forms.Button();
            this.CircleButtonForm = new System.Windows.Forms.Button();
            this.EllipseButtonForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LineAlgorithmsForm
            // 
            this.LineAlgorithmsForm.Location = new System.Drawing.Point(333, 46);
            this.LineAlgorithmsForm.Name = "LineAlgorithmsForm";
            this.LineAlgorithmsForm.Size = new System.Drawing.Size(144, 60);
            this.LineAlgorithmsForm.TabIndex = 0;
            this.LineAlgorithmsForm.Text = "Line Algorithms (DDA, Bresenham)";
            this.LineAlgorithmsForm.UseVisualStyleBackColor = true;
            this.LineAlgorithmsForm.Click += new System.EventHandler(this.LineAlgorithmsForm_Click);
            // 
            // CircleButtonForm
            // 
            this.CircleButtonForm.Location = new System.Drawing.Point(333, 112);
            this.CircleButtonForm.Name = "CircleButtonForm";
            this.CircleButtonForm.Size = new System.Drawing.Size(144, 60);
            this.CircleButtonForm.TabIndex = 1;
            this.CircleButtonForm.Text = "Circle Generating Algorithm";
            this.CircleButtonForm.UseVisualStyleBackColor = true;
            this.CircleButtonForm.Click += new System.EventHandler(this.CircleButtonForm_Click);
            // 
            // EllipseButtonForm
            // 
            this.EllipseButtonForm.Location = new System.Drawing.Point(333, 178);
            this.EllipseButtonForm.Name = "EllipseButtonForm";
            this.EllipseButtonForm.Size = new System.Drawing.Size(144, 60);
            this.EllipseButtonForm.TabIndex = 2;
            this.EllipseButtonForm.Text = "Ellipse Generating Algorithm";
            this.EllipseButtonForm.UseVisualStyleBackColor = true;
            this.EllipseButtonForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EllipseButtonForm);
            this.Controls.Add(this.CircleButtonForm);
            this.Controls.Add(this.LineAlgorithmsForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LineAlgorithmsForm;
        private System.Windows.Forms.Button CircleButtonForm;
        private System.Windows.Forms.Button EllipseButtonForm;
    }
}