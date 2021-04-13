
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
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripGroupButtons = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCloseArrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEndRhomb = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStartRhomb1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEndRhombBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStartRhombBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenArrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCloseArrowDash = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTwoAngleLine = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStripGroupButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(118, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(564, 440);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(12, 124);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(78, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackbar1_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 34);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // toolStripGroupButtons
            // 
            this.toolStripGroupButtons.AutoSize = false;
            this.toolStripGroupButtons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripGroupButtons.BackgroundImage")));
            this.toolStripGroupButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripGroupButtons.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripGroupButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripGroupButtons.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripGroupButtons.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.toolStripGroupButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCloseArrow,
            this.toolStripButtonEndRhomb,
            this.toolStripButtonStartRhomb1,
            this.toolStripButtonEndRhombBlack,
            this.toolStripButtonStartRhombBlack,
            this.toolStripButtonOpenArrow,
            this.toolStripButtonCloseArrowDash,
            this.toolStripButtonTwoAngleLine});
            this.toolStripGroupButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripGroupButtons.Location = new System.Drawing.Point(12, 62);
            this.toolStripGroupButtons.Name = "toolStripGroupButtons";
            this.toolStripGroupButtons.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripGroupButtons.Size = new System.Drawing.Size(88, 40);
            this.toolStripGroupButtons.Stretch = true;
            this.toolStripGroupButtons.TabIndex = 13;
            this.toolStripGroupButtons.Text = "ARROWS";
            // 
            // toolStripButtonCloseArrow
            // 
            this.toolStripButtonCloseArrow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonCloseArrow.AutoSize = false;
            this.toolStripButtonCloseArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCloseArrow.BackgroundImage")));
            this.toolStripButtonCloseArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonCloseArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCloseArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCloseArrow.Name = "toolStripButtonCloseArrow";
            this.toolStripButtonCloseArrow.Size = new System.Drawing.Size(88, 40);
            this.toolStripButtonCloseArrow.Text = "toolStripButton4";
            this.toolStripButtonCloseArrow.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // toolStripButtonEndRhomb
            // 
            this.toolStripButtonEndRhomb.AutoSize = false;
            this.toolStripButtonEndRhomb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEndRhomb.BackgroundImage")));
            this.toolStripButtonEndRhomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonEndRhomb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButtonEndRhomb.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEndRhomb.Image")));
            this.toolStripButtonEndRhomb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEndRhomb.Name = "toolStripButtonEndRhomb";
            this.toolStripButtonEndRhomb.Size = new System.Drawing.Size(88, 40);
            this.toolStripButtonEndRhomb.Text = "toolStripButton5";
            this.toolStripButtonEndRhomb.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // toolStripButtonStartRhomb1
            // 
            this.toolStripButtonStartRhomb1.AutoSize = false;
            this.toolStripButtonStartRhomb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartRhomb1.BackgroundImage")));
            this.toolStripButtonStartRhomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonStartRhomb1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButtonStartRhomb1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartRhomb1.Image")));
            this.toolStripButtonStartRhomb1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStartRhomb1.Name = "toolStripButtonStartRhomb1";
            this.toolStripButtonStartRhomb1.Size = new System.Drawing.Size(88, 40);
            this.toolStripButtonStartRhomb1.Text = "toolStripButton6";
            this.toolStripButtonStartRhomb1.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // toolStripButtonEndRhombBlack
            // 
            this.toolStripButtonEndRhombBlack.AutoSize = false;
            this.toolStripButtonEndRhombBlack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEndRhombBlack.BackgroundImage")));
            this.toolStripButtonEndRhombBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonEndRhombBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButtonEndRhombBlack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEndRhombBlack.Image")));
            this.toolStripButtonEndRhombBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEndRhombBlack.Name = "toolStripButtonEndRhombBlack";
            this.toolStripButtonEndRhombBlack.Size = new System.Drawing.Size(88, 40);
            this.toolStripButtonEndRhombBlack.Text = "toolStripButton7";
            this.toolStripButtonEndRhombBlack.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // toolStripButtonStartRhombBlack
            // 
            this.toolStripButtonStartRhombBlack.AutoSize = false;
            this.toolStripButtonStartRhombBlack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartRhombBlack.BackgroundImage")));
            this.toolStripButtonStartRhombBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonStartRhombBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButtonStartRhombBlack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartRhombBlack.Image")));
            this.toolStripButtonStartRhombBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStartRhombBlack.Name = "toolStripButtonStartRhombBlack";
            this.toolStripButtonStartRhombBlack.Size = new System.Drawing.Size(88, 40);
            this.toolStripButtonStartRhombBlack.Text = "toolStripButton8";
            this.toolStripButtonStartRhombBlack.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // toolStripButtonOpenArrow
            // 
            this.toolStripButtonOpenArrow.AutoSize = false;
            this.toolStripButtonOpenArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenArrow.BackgroundImage")));
            this.toolStripButtonOpenArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonOpenArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButtonOpenArrow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenArrow.Image")));
            this.toolStripButtonOpenArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenArrow.Name = "toolStripButtonOpenArrow";
            this.toolStripButtonOpenArrow.Size = new System.Drawing.Size(88, 40);
            this.toolStripButtonOpenArrow.Text = "toolStripButton2";
            this.toolStripButtonOpenArrow.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // toolStripButtonCloseArrowDash
            // 
            this.toolStripButtonCloseArrowDash.AutoSize = false;
            this.toolStripButtonCloseArrowDash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCloseArrowDash.BackgroundImage")));
            this.toolStripButtonCloseArrowDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonCloseArrowDash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButtonCloseArrowDash.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCloseArrowDash.Image")));
            this.toolStripButtonCloseArrowDash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCloseArrowDash.Name = "toolStripButtonCloseArrowDash";
            this.toolStripButtonCloseArrowDash.Size = new System.Drawing.Size(88, 40);
            this.toolStripButtonCloseArrowDash.Text = "toolStripButton3";
            this.toolStripButtonCloseArrowDash.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // toolStripButtonTwoAngleLine
            // 
            this.toolStripButtonTwoAngleLine.AutoSize = false;
            this.toolStripButtonTwoAngleLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTwoAngleLine.BackgroundImage")));
            this.toolStripButtonTwoAngleLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonTwoAngleLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButtonTwoAngleLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTwoAngleLine.Image")));
            this.toolStripButtonTwoAngleLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTwoAngleLine.Name = "toolStripButtonTwoAngleLine";
            this.toolStripButtonTwoAngleLine.Size = new System.Drawing.Size(88, 40);
            this.toolStripButtonTwoAngleLine.Text = "toolStripButton1";
            this.toolStripButtonTwoAngleLine.Click += new System.EventHandler(this.CheckButtonPressed_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 153);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CheckTableType_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 204);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Inter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toolStripGroupButtons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStripGroupButtons.ResumeLayout(false);
            this.toolStripGroupButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStripGroupButtons;
        private System.Windows.Forms.ToolStripButton toolStripButtonTwoAngleLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenArrow;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseArrowDash;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseArrow;
        private System.Windows.Forms.ToolStripButton toolStripButtonEndRhomb;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartRhomb1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEndRhombBlack;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartRhombBlack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

