
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
            this.buttonCloseArrow = new System.Windows.Forms.Button();
            this.buttonEndRhomb = new System.Windows.Forms.Button();
            this.buttonCloseArrowDash = new System.Windows.Forms.Button();
            this.buttonStartRhombBlack = new System.Windows.Forms.Button();
            this.buttonStartRhomb1 = new System.Windows.Forms.Button();
            this.buttonEndRhombBlack = new System.Windows.Forms.Button();
            this.buttonOpenArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(205, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1017, 692);
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
            this.button_Color.Location = new System.Drawing.Point(16, 14);
            this.button_Color.Margin = new System.Windows.Forms.Padding(0);
            this.button_Color.Name = "button_Color";
            this.button_Color.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Color.Size = new System.Drawing.Size(129, 43);
            this.button_Color.TabIndex = 1;
            this.button_Color.Text = "Change Color";
            this.button_Color.UseVisualStyleBackColor = false;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // pictureBox_color
            // 
            this.pictureBox_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_color.Location = new System.Drawing.Point(151, 21);
            this.pictureBox_color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_color.Name = "pictureBox_color";
            this.pictureBox_color.Size = new System.Drawing.Size(21, 26);
            this.pictureBox_color.TabIndex = 2;
            this.pictureBox_color.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 75);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonCloseArrow
            // 
            this.buttonCloseArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseArrow.BackgroundImage")));
            this.buttonCloseArrow.Location = new System.Drawing.Point(16, 122);
            this.buttonCloseArrow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCloseArrow.Name = "buttonCloseArrow";
            this.buttonCloseArrow.Size = new System.Drawing.Size(89, 48);
            this.buttonCloseArrow.TabIndex = 4;
            this.buttonCloseArrow.Text = "buttonCloseArrow";
            this.buttonCloseArrow.UseVisualStyleBackColor = true;
            this.buttonCloseArrow.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonEndRhomb
            // 
            this.buttonEndRhomb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEndRhomb.BackgroundImage")));
            this.buttonEndRhomb.Location = new System.Drawing.Point(28, 176);
            this.buttonEndRhomb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEndRhomb.Name = "buttonEndRhomb";
            this.buttonEndRhomb.Size = new System.Drawing.Size(77, 49);
            this.buttonEndRhomb.TabIndex = 5;
            this.buttonEndRhomb.Text = "buttonEndRhomb";
            this.buttonEndRhomb.UseVisualStyleBackColor = true;
            this.buttonEndRhomb.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonCloseArrowDash
            // 
            this.buttonCloseArrowDash.Location = new System.Drawing.Point(30, 559);
            this.buttonCloseArrowDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCloseArrowDash.Name = "buttonCloseArrowDash";
            this.buttonCloseArrowDash.Size = new System.Drawing.Size(118, 48);
            this.buttonCloseArrowDash.TabIndex = 6;
            this.buttonCloseArrowDash.Text = "buttonCloseArrowDash";
            this.buttonCloseArrowDash.UseVisualStyleBackColor = true;
            this.buttonCloseArrowDash.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonStartRhombBlack
            // 
            this.buttonStartRhombBlack.Location = new System.Drawing.Point(13, 415);
            this.buttonStartRhombBlack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartRhombBlack.Name = "buttonStartRhombBlack";
            this.buttonStartRhombBlack.Size = new System.Drawing.Size(125, 46);
            this.buttonStartRhombBlack.TabIndex = 7;
            this.buttonStartRhombBlack.Text = "buttonStartRhombBlack";
            this.buttonStartRhombBlack.UseVisualStyleBackColor = true;
            this.buttonStartRhombBlack.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonStartRhomb1
            // 
            this.buttonStartRhomb1.Location = new System.Drawing.Point(20, 352);
            this.buttonStartRhomb1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartRhomb1.Name = "buttonStartRhomb1";
            this.buttonStartRhomb1.Size = new System.Drawing.Size(125, 55);
            this.buttonStartRhomb1.TabIndex = 8;
            this.buttonStartRhomb1.Text = "buttonStartRhomb";
            this.buttonStartRhomb1.UseVisualStyleBackColor = true;
            this.buttonStartRhomb1.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonEndRhombBlack
            // 
            this.buttonEndRhombBlack.Location = new System.Drawing.Point(20, 230);
            this.buttonEndRhombBlack.Name = "buttonEndRhombBlack";
            this.buttonEndRhombBlack.Size = new System.Drawing.Size(108, 43);
            this.buttonEndRhombBlack.TabIndex = 9;
            this.buttonEndRhombBlack.Text = "buttonEndRhombBlack";
            this.buttonEndRhombBlack.UseVisualStyleBackColor = true;
            this.buttonEndRhombBlack.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonOpenArrow
            // 
            this.buttonOpenArrow.Location = new System.Drawing.Point(28, 501);
            this.buttonOpenArrow.Name = "buttonOpenArrow";
            this.buttonOpenArrow.Size = new System.Drawing.Size(108, 53);
            this.buttonOpenArrow.TabIndex = 10;
            this.buttonOpenArrow.Text = "buttonOpenArrow";
            this.buttonOpenArrow.UseVisualStyleBackColor = true;
            this.buttonOpenArrow.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1220, 692);
            this.Controls.Add(this.buttonOpenArrow);
            this.Controls.Add(this.buttonEndRhombBlack);
            this.Controls.Add(this.buttonStartRhomb1);
            this.Controls.Add(this.buttonStartRhombBlack);
            this.Controls.Add(this.buttonCloseArrowDash);
            this.Controls.Add(this.buttonEndRhomb);
            this.Controls.Add(this.buttonCloseArrow);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox_color);
            this.Controls.Add(this.button_Color);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonCloseArrow;
        private System.Windows.Forms.Button buttonEndRhomb;
        private System.Windows.Forms.Button buttonCloseArrowDash;
        private System.Windows.Forms.Button buttonStartRhombBlack;
        private System.Windows.Forms.Button buttonStartRhomb1;
        private System.Windows.Forms.Button buttonEndRhombBlack;
        private System.Windows.Forms.Button buttonOpenArrow;
    }
}

