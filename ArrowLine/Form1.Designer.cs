
namespace ArrowLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox_color = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonInheritanceArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(154, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 562);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button_Color
            // 
            this.button_Color.BackColor = System.Drawing.Color.Maroon;
            this.button_Color.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_Color.FlatAppearance.BorderSize = 0;
            this.button_Color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_Color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Color.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Color.Location = new System.Drawing.Point(12, 11);
            this.button_Color.Margin = new System.Windows.Forms.Padding(0);
            this.button_Color.Name = "button_Color";
            this.button_Color.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.button_Color.Size = new System.Drawing.Size(97, 35);
            this.button_Color.TabIndex = 1;
            this.button_Color.Text = "Change Color";
            this.button_Color.UseVisualStyleBackColor = false;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // pictureBox_color
            // 
            this.pictureBox_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_color.Location = new System.Drawing.Point(113, 17);
            this.pictureBox_color.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_color.Name = "pictureBox_color";
            this.pictureBox_color.Size = new System.Drawing.Size(16, 21);
            this.pictureBox_color.TabIndex = 2;
            this.pictureBox_color.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 61);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(78, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonInheritanceArrow
            // 
            this.buttonInheritanceArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInheritanceArrow.BackgroundImage")));
            this.buttonInheritanceArrow.Location = new System.Drawing.Point(12, 99);
            this.buttonInheritanceArrow.Name = "buttonInheritanceArrow";
            this.buttonInheritanceArrow.Size = new System.Drawing.Size(86, 39);
            this.buttonInheritanceArrow.TabIndex = 4;
            this.buttonInheritanceArrow.UseVisualStyleBackColor = true;
            this.buttonInheritanceArrow.Click += new System.EventHandler(this.buttonInheritanceArrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(915, 562);
            this.Controls.Add(this.buttonInheritanceArrow);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox_color);
            this.Controls.Add(this.button_Color);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox_color;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonInheritanceArrow;
    }
}

