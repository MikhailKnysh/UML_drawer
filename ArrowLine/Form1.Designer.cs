
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
            this.toolStripGroupButtonsArrow = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCloseArrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEndRhomb = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStartRhomb1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEndRhombBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStartRhombBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenArrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCloseArrowDash = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTwoAngleLine = new System.Windows.Forms.ToolStripButton();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddField = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGroupButtonsTable = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClassTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInterfaceTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStackTable = new System.Windows.Forms.ToolStripButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStripGroupButtonsArrow.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStripGroupButtonsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(152, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(1161, 694);
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
            this.trackBar1.Location = new System.Drawing.Point(19, 140);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackbar1_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(54, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 42);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // toolStripGroupButtonsArrow
            // 
            this.toolStripGroupButtonsArrow.AutoSize = false;
            this.toolStripGroupButtonsArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripGroupButtonsArrow.BackgroundImage")));
            this.toolStripGroupButtonsArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripGroupButtonsArrow.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripGroupButtonsArrow.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripGroupButtonsArrow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripGroupButtonsArrow.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.toolStripGroupButtonsArrow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCloseArrow,
            this.toolStripButtonEndRhomb,
            this.toolStripButtonStartRhomb1,
            this.toolStripButtonEndRhombBlack,
            this.toolStripButtonStartRhombBlack,
            this.toolStripButtonOpenArrow,
            this.toolStripButtonCloseArrowDash,
            this.toolStripButtonTwoAngleLine});
            this.toolStripGroupButtonsArrow.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripGroupButtonsArrow.Location = new System.Drawing.Point(16, 76);
            this.toolStripGroupButtonsArrow.Name = "toolStripGroupButtonsArrow";
            this.toolStripGroupButtonsArrow.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripGroupButtonsArrow.Size = new System.Drawing.Size(117, 49);
            this.toolStripGroupButtonsArrow.Stretch = true;
            this.toolStripGroupButtonsArrow.TabIndex = 13;
            this.toolStripGroupButtonsArrow.Text = "ARROWS";
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
            this.toolStripButtonCloseArrow.Click += new System.EventHandler(this.CheckArrowButtonPressed_Click);
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
            this.toolStripButtonEndRhomb.Click += new System.EventHandler(this.CheckArrowButtonPressed_Click);
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
            this.toolStripButtonStartRhomb1.Click += new System.EventHandler(this.CheckArrowButtonPressed_Click);
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
            this.toolStripButtonEndRhombBlack.Click += new System.EventHandler(this.CheckArrowButtonPressed_Click);
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
            this.toolStripButtonStartRhombBlack.Click += new System.EventHandler(this.CheckArrowButtonPressed_Click);
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
            this.toolStripButtonOpenArrow.Click += new System.EventHandler(this.CheckArrowButtonPressed_Click);
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
            this.toolStripButtonCloseArrowDash.Click += new System.EventHandler(this.CheckArrowButtonPressed_Click);
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
            this.toolStripButtonTwoAngleLine.Click += new System.EventHandler(this.CheckArrowButtonPressed_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(32, 306);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(101, 66);
            this.buttonSelect.TabIndex = 15;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddField,
            this.toolStripMenuItemAddProperty,
            this.toolStripMenuItemAddMethod,
            this.toolStripSeparator1,
            this.toolStripMenuItemRename});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 106);
            // 
            // toolStripMenuItemAddField
            // 
            this.toolStripMenuItemAddField.Name = "toolStripMenuItemAddField";
            this.toolStripMenuItemAddField.Size = new System.Drawing.Size(167, 24);
            this.toolStripMenuItemAddField.Text = "Add field";
            this.toolStripMenuItemAddField.Click += new System.EventHandler(this.toolStripMenuItemAddField_Click);
            // 
            // toolStripMenuItemAddProperty
            // 
            this.toolStripMenuItemAddProperty.Name = "toolStripMenuItemAddProperty";
            this.toolStripMenuItemAddProperty.Size = new System.Drawing.Size(167, 24);
            this.toolStripMenuItemAddProperty.Text = "Add property";
            this.toolStripMenuItemAddProperty.Click += new System.EventHandler(this.toolStripMenuItemAddProperty_Click);
            // 
            // toolStripMenuItemAddMethod
            // 
            this.toolStripMenuItemAddMethod.Name = "toolStripMenuItemAddMethod";
            this.toolStripMenuItemAddMethod.Size = new System.Drawing.Size(167, 24);
            this.toolStripMenuItemAddMethod.Text = "Add method";
            this.toolStripMenuItemAddMethod.Click += new System.EventHandler(this.toolStripMenuItemAddMethod_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // toolStripMenuItemRename
            // 
            this.toolStripMenuItemRename.Name = "toolStripMenuItemRename";
            this.toolStripMenuItemRename.Size = new System.Drawing.Size(167, 24);
            this.toolStripMenuItemRename.Text = "Rename";
            this.toolStripMenuItemRename.Click += new System.EventHandler(this.toolStripMenuItemRename_Click);
            // 
            // toolStripGroupButtonsTable
            // 
            this.toolStripGroupButtonsTable.AutoSize = false;
            this.toolStripGroupButtonsTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripGroupButtonsTable.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripGroupButtonsTable.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStripGroupButtonsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClassTable,
            this.toolStripButtonInterfaceTable,
            this.toolStripButtonStackTable});
            this.toolStripGroupButtonsTable.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripGroupButtonsTable.Location = new System.Drawing.Point(16, 198);
            this.toolStripGroupButtonsTable.Name = "toolStripGroupButtonsTable";
            this.toolStripGroupButtonsTable.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripGroupButtonsTable.Size = new System.Drawing.Size(133, 74);
            this.toolStripGroupButtonsTable.TabIndex = 13;
            this.toolStripGroupButtonsTable.Text = "toolStrip1";
            // 
            // toolStripButtonClassTable
            // 
            this.toolStripButtonClassTable.AutoSize = false;
            this.toolStripButtonClassTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClassTable.BackgroundImage")));
            this.toolStripButtonClassTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonClassTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClassTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClassTable.Name = "toolStripButtonClassTable";
            this.toolStripButtonClassTable.Size = new System.Drawing.Size(100, 60);
            this.toolStripButtonClassTable.Text = "toolStripButtonClassTable";
            this.toolStripButtonClassTable.Click += new System.EventHandler(this.CheckButtonPressedTable_Click);
            // 
            // toolStripButtonInterfaceTable
            // 
            this.toolStripButtonInterfaceTable.AutoSize = false;
            this.toolStripButtonInterfaceTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInterfaceTable.BackgroundImage")));
            this.toolStripButtonInterfaceTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonInterfaceTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInterfaceTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInterfaceTable.Name = "toolStripButtonInterfaceTable";
            this.toolStripButtonInterfaceTable.Size = new System.Drawing.Size(100, 60);
            this.toolStripButtonInterfaceTable.Text = "toolStripButtonInterfaceTable";
            this.toolStripButtonInterfaceTable.Click += new System.EventHandler(this.CheckButtonPressedTable_Click);
            // 
            // toolStripButtonStackTable
            // 
            this.toolStripButtonStackTable.AutoSize = false;
            this.toolStripButtonStackTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStackTable.BackgroundImage")));
            this.toolStripButtonStackTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonStackTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStackTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStackTable.Name = "toolStripButtonStackTable";
            this.toolStripButtonStackTable.Size = new System.Drawing.Size(100, 60);
            this.toolStripButtonStackTable.Text = "toolStripButtonStackTable";
            this.toolStripButtonStackTable.Click += new System.EventHandler(this.CheckButtonPressedTable_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(19, 378);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 47);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(9, 576);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(143, 48);
            this.buttonOpen.TabIndex = 17;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "UmlDiagrams|*.smst";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "UmlDiagrams|*.smst";
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(33, 449);
            this.buttonSaveImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveImage.TabIndex = 18;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 8);
            this.button3.TabIndex = 20;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 52);
            this.button2.TabIndex = 19;
            this.button2.Text = "УНИЧТОЖИТЬ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1437, 919);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.toolStripGroupButtonsTable);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.toolStripGroupButtonsArrow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "UML Drawer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStripGroupButtonsArrow.ResumeLayout(false);
            this.toolStripGroupButtonsArrow.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStripGroupButtonsTable.ResumeLayout(false);
            this.toolStripGroupButtonsTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStripGroupButtonsArrow;
        private System.Windows.Forms.ToolStripButton toolStripButtonTwoAngleLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenArrow;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseArrowDash;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseArrow;
        private System.Windows.Forms.ToolStripButton toolStripButtonEndRhomb;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartRhomb1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEndRhombBlack;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartRhombBlack;
        private System.Windows.Forms.Button buttonSelect;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddField;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddProperty;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddMethod;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRename;
        private System.Windows.Forms.ToolStrip toolStripGroupButtonsTable;
        private System.Windows.Forms.ToolStripButton toolStripButtonInterfaceTable;
        private System.Windows.Forms.ToolStripButton toolStripButtonStackTable;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.ToolStripButton toolStripButtonClassTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

