
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonCloseArrow = new System.Windows.Forms.Button();
            this.buttonEndRhomb = new System.Windows.Forms.Button();
            this.buttonCloseArrowDash = new System.Windows.Forms.Button();
            this.buttonStartRhombBlack = new System.Windows.Forms.Button();
            this.buttonStartRhomb1 = new System.Windows.Forms.Button();
            this.buttonEndRhombBlack = new System.Windows.Forms.Button();
            this.buttonOpenArrow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTwoAngleLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(112, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(812, 542);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(29, 415);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(78, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonCloseArrow
            // 
            this.buttonCloseArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseArrow.BackgroundImage")));
            this.buttonCloseArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCloseArrow.Location = new System.Drawing.Point(19, 49);
            this.buttonCloseArrow.Name = "buttonCloseArrow";
            this.buttonCloseArrow.Size = new System.Drawing.Size(88, 40);
            this.buttonCloseArrow.TabIndex = 4;
            this.buttonCloseArrow.UseVisualStyleBackColor = true;
            this.buttonCloseArrow.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonEndRhomb
            // 
            this.buttonEndRhomb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEndRhomb.BackgroundImage")));
            this.buttonEndRhomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEndRhomb.Location = new System.Drawing.Point(19, 93);
            this.buttonEndRhomb.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEndRhomb.Name = "buttonEndRhomb";
            this.buttonEndRhomb.Size = new System.Drawing.Size(88, 40);
            this.buttonEndRhomb.TabIndex = 5;
            this.buttonEndRhomb.UseVisualStyleBackColor = true;
            this.buttonEndRhomb.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonCloseArrowDash
            // 
            this.buttonCloseArrowDash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseArrowDash.BackgroundImage")));
            this.buttonCloseArrowDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCloseArrowDash.Location = new System.Drawing.Point(19, 314);
            this.buttonCloseArrowDash.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCloseArrowDash.Name = "buttonCloseArrowDash";
            this.buttonCloseArrowDash.Size = new System.Drawing.Size(88, 40);
            this.buttonCloseArrowDash.TabIndex = 6;
            this.buttonCloseArrowDash.UseVisualStyleBackColor = true;
            this.buttonCloseArrowDash.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonStartRhombBlack
            // 
            this.buttonStartRhombBlack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartRhombBlack.BackgroundImage")));
            this.buttonStartRhombBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartRhombBlack.Location = new System.Drawing.Point(19, 228);
            this.buttonStartRhombBlack.Name = "buttonStartRhombBlack";
            this.buttonStartRhombBlack.Size = new System.Drawing.Size(88, 40);
            this.buttonStartRhombBlack.TabIndex = 7;
            this.buttonStartRhombBlack.UseVisualStyleBackColor = true;
            this.buttonStartRhombBlack.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonStartRhomb1
            // 
            this.buttonStartRhomb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartRhomb1.BackgroundImage")));
            this.buttonStartRhomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartRhomb1.Location = new System.Drawing.Point(19, 138);
            this.buttonStartRhomb1.Name = "buttonStartRhomb1";
            this.buttonStartRhomb1.Size = new System.Drawing.Size(88, 40);
            this.buttonStartRhomb1.TabIndex = 8;
            this.buttonStartRhomb1.UseVisualStyleBackColor = true;
            this.buttonStartRhomb1.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonEndRhombBlack
            // 
            this.buttonEndRhombBlack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEndRhombBlack.BackgroundImage")));
            this.buttonEndRhombBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEndRhombBlack.Location = new System.Drawing.Point(19, 183);
            this.buttonEndRhombBlack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEndRhombBlack.Name = "buttonEndRhombBlack";
            this.buttonEndRhombBlack.Size = new System.Drawing.Size(88, 40);
            this.buttonEndRhombBlack.TabIndex = 9;
            this.buttonEndRhombBlack.UseVisualStyleBackColor = true;
            this.buttonEndRhombBlack.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // buttonOpenArrow
            // 
            this.buttonOpenArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenArrow.BackgroundImage")));
            this.buttonOpenArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOpenArrow.Location = new System.Drawing.Point(19, 270);
            this.buttonOpenArrow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenArrow.Name = "buttonOpenArrow";
            this.buttonOpenArrow.Size = new System.Drawing.Size(88, 40);
            this.buttonOpenArrow.TabIndex = 10;
            this.buttonOpenArrow.UseVisualStyleBackColor = true;
            this.buttonOpenArrow.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(19, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 34);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // buttonTwoAngleLine
            // 
            this.buttonTwoAngleLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTwoAngleLine.BackgroundImage")));
            this.buttonTwoAngleLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTwoAngleLine.Location = new System.Drawing.Point(19, 359);
            this.buttonTwoAngleLine.Name = "buttonTwoAngleLine";
            this.buttonTwoAngleLine.Size = new System.Drawing.Size(88, 40);
            this.buttonTwoAngleLine.TabIndex = 12;
            this.buttonTwoAngleLine.UseVisualStyleBackColor = true;
            this.buttonTwoAngleLine.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(915, 562);
            this.Controls.Add(this.buttonTwoAngleLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOpenArrow);
            this.Controls.Add(this.buttonEndRhombBlack);
            this.Controls.Add(this.buttonStartRhomb1);
            this.Controls.Add(this.buttonStartRhombBlack);
            this.Controls.Add(this.buttonCloseArrowDash);
            this.Controls.Add(this.buttonEndRhomb);
            this.Controls.Add(this.buttonCloseArrow);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonCloseArrow;
        private System.Windows.Forms.Button buttonEndRhomb;
        private System.Windows.Forms.Button buttonCloseArrowDash;
        private System.Windows.Forms.Button buttonStartRhombBlack;
        private System.Windows.Forms.Button buttonStartRhomb1;
        private System.Windows.Forms.Button buttonEndRhombBlack;
        private System.Windows.Forms.Button buttonOpenArrow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonTwoAngleLine;
    }
}

