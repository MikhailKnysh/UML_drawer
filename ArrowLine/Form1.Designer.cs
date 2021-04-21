
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
            this.components = new System.ComponentModel.Container();
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
            this.F = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddField = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddMethod = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStripGroupButtons.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(118, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(872, 565);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(12, 124);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Maximum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(78, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
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
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 173);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 109);
            this.button2.TabIndex = 14;
            this.button2.Text = "Прямокутник";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CheckTableType_Click);
            // 
            // F
            // 
            this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.F.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.F.Location = new System.Drawing.Point(2, 308);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(111, 25);
            this.F.TabIndex = 15;
            this.F.Text = "Add field";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(2, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "Add prop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(2, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 25);
            this.button5.TabIndex = 17;
            this.button5.TabStop = false;
            this.button5.Text = "Add method";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddField,
            this.toolStripMenuItemAddProperty,
            this.toolStripMenuItemAddMethod});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 70);
            // 
            // toolStripMenuItemAddField
            // 
            this.toolStripMenuItemAddField.Name = "toolStripMenuItemAddField";
            this.toolStripMenuItemAddField.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemAddField.Text = "Add field";
            this.toolStripMenuItemAddField.Click += new System.EventHandler(this.toolStripMenuItemAddField_Click);
            // 
            // toolStripMenuItemAddProperty
            // 
            this.toolStripMenuItemAddProperty.Name = "toolStripMenuItemAddProperty";
            this.toolStripMenuItemAddProperty.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemAddProperty.Text = "Add property";
            this.toolStripMenuItemAddProperty.Click += new System.EventHandler(this.toolStripMenuItemAddProperty_Click);
            // 
            // toolStripMenuItemAddMethod
            // 
            this.toolStripMenuItemAddMethod.Name = "toolStripMenuItemAddMethod";
            this.toolStripMenuItemAddMethod.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemAddMethod.Text = "Add method";
            this.toolStripMenuItemAddMethod.Click += new System.EventHandler(this.toolStripMenuItemAddMethod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(987, 561);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.F);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toolStripGroupButtons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStripGroupButtons.ResumeLayout(false);
            this.toolStripGroupButtons.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddField;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddProperty;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddMethod;
    }
}

