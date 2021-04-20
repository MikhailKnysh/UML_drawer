
namespace ArrowLine
{
    partial class StringDataForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxSignature = new System.Windows.Forms.TextBox();
            this.comboBoxAccessModifier = new System.Windows.Forms.ComboBox();
            this.labelColon = new System.Windows.Forms.Label();
            this.textBoxTypeToReturn = new System.Windows.Forms.TextBox();
            this.comboBoxPropAccessModifier = new System.Windows.Forms.ComboBox();
            this.textBoxPropName = new System.Windows.Forms.TextBox();
            this.comboBoxGetAccessModifier = new System.Windows.Forms.ComboBox();
            this.comboBoxSetAccessModifier = new System.Windows.Forms.ComboBox();
            this.labelOpenBkt = new System.Windows.Forms.Label();
            this.labelGet = new System.Windows.Forms.Label();
            this.labelSet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxFieldOrMethod = new System.Windows.Forms.GroupBox();
            this.groupBoxProperty = new System.Windows.Forms.GroupBox();
            this.groupBoxFieldOrMethod.SuspendLayout();
            this.groupBoxProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(51, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(51, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "label1";
            // 
            // textBoxSignature
            // 
            this.textBoxSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSignature.Location = new System.Drawing.Point(46, 19);
            this.textBoxSignature.Name = "textBoxSignature";
            this.textBoxSignature.Size = new System.Drawing.Size(200, 26);
            this.textBoxSignature.TabIndex = 1;
            // 
            // comboBoxAccessModifier
            // 
            this.comboBoxAccessModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAccessModifier.FormattingEnabled = true;
            this.comboBoxAccessModifier.Items.AddRange(new object[] {
            "+",
            "#",
            "-"});
            this.comboBoxAccessModifier.Location = new System.Drawing.Point(4, 19);
            this.comboBoxAccessModifier.Name = "comboBoxAccessModifier";
            this.comboBoxAccessModifier.Size = new System.Drawing.Size(36, 26);
            this.comboBoxAccessModifier.TabIndex = 2;
            // 
            // labelColon
            // 
            this.labelColon.AutoSize = true;
            this.labelColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColon.Location = new System.Drawing.Point(252, 21);
            this.labelColon.Name = "labelColon";
            this.labelColon.Size = new System.Drawing.Size(24, 20);
            this.labelColon.TabIndex = 3;
            this.labelColon.Text = " : ";
            // 
            // textBoxTypeToReturn
            // 
            this.textBoxTypeToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTypeToReturn.Location = new System.Drawing.Point(282, 19);
            this.textBoxTypeToReturn.Name = "textBoxTypeToReturn";
            this.textBoxTypeToReturn.Size = new System.Drawing.Size(200, 26);
            this.textBoxTypeToReturn.TabIndex = 4;
            // 
            // comboBoxPropAccessModifier
            // 
            this.comboBoxPropAccessModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPropAccessModifier.FormattingEnabled = true;
            this.comboBoxPropAccessModifier.Location = new System.Drawing.Point(4, 20);
            this.comboBoxPropAccessModifier.Name = "comboBoxPropAccessModifier";
            this.comboBoxPropAccessModifier.Size = new System.Drawing.Size(36, 26);
            this.comboBoxPropAccessModifier.TabIndex = 5;
            // 
            // textBoxPropName
            // 
            this.textBoxPropName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPropName.Location = new System.Drawing.Point(46, 19);
            this.textBoxPropName.Name = "textBoxPropName";
            this.textBoxPropName.Size = new System.Drawing.Size(200, 26);
            this.textBoxPropName.TabIndex = 6;
            // 
            // comboBoxGetAccessModifier
            // 
            this.comboBoxGetAccessModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGetAccessModifier.FormattingEnabled = true;
            this.comboBoxGetAccessModifier.Items.AddRange(new object[] {
            "+",
            "#",
            "-"});
            this.comboBoxGetAccessModifier.Location = new System.Drawing.Point(282, 20);
            this.comboBoxGetAccessModifier.Name = "comboBoxGetAccessModifier";
            this.comboBoxGetAccessModifier.Size = new System.Drawing.Size(36, 26);
            this.comboBoxGetAccessModifier.TabIndex = 7;
            // 
            // comboBoxSetAccessModifier
            // 
            this.comboBoxSetAccessModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSetAccessModifier.FormattingEnabled = true;
            this.comboBoxSetAccessModifier.Items.AddRange(new object[] {
            "+",
            "#",
            "-"});
            this.comboBoxSetAccessModifier.Location = new System.Drawing.Point(370, 20);
            this.comboBoxSetAccessModifier.Name = "comboBoxSetAccessModifier";
            this.comboBoxSetAccessModifier.Size = new System.Drawing.Size(36, 26);
            this.comboBoxSetAccessModifier.TabIndex = 8;
            // 
            // labelOpenBkt
            // 
            this.labelOpenBkt.AutoSize = true;
            this.labelOpenBkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenBkt.Location = new System.Drawing.Point(252, 20);
            this.labelOpenBkt.Name = "labelOpenBkt";
            this.labelOpenBkt.Size = new System.Drawing.Size(22, 20);
            this.labelOpenBkt.TabIndex = 9;
            this.labelOpenBkt.Text = " { ";
            // 
            // labelGet
            // 
            this.labelGet.AutoSize = true;
            this.labelGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGet.Location = new System.Drawing.Point(324, 19);
            this.labelGet.Name = "labelGet";
            this.labelGet.Size = new System.Drawing.Size(40, 20);
            this.labelGet.TabIndex = 10;
            this.labelGet.Text = "get; ";
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSet.Location = new System.Drawing.Point(416, 20);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(44, 20);
            this.labelSet.TabIndex = 11;
            this.labelSet.Text = "set; }";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(294, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBoxFieldOrMethod
            // 
            this.groupBoxFieldOrMethod.Controls.Add(this.textBoxTypeToReturn);
            this.groupBoxFieldOrMethod.Controls.Add(this.textBoxSignature);
            this.groupBoxFieldOrMethod.Controls.Add(this.comboBoxAccessModifier);
            this.groupBoxFieldOrMethod.Controls.Add(this.labelColon);
            this.groupBoxFieldOrMethod.Location = new System.Drawing.Point(12, 44);
            this.groupBoxFieldOrMethod.Name = "groupBoxFieldOrMethod";
            this.groupBoxFieldOrMethod.Size = new System.Drawing.Size(500, 60);
            this.groupBoxFieldOrMethod.TabIndex = 13;
            this.groupBoxFieldOrMethod.TabStop = false;
            // 
            // groupBoxProperty
            // 
            this.groupBoxProperty.Controls.Add(this.textBoxPropName);
            this.groupBoxProperty.Controls.Add(this.comboBoxPropAccessModifier);
            this.groupBoxProperty.Controls.Add(this.comboBoxGetAccessModifier);
            this.groupBoxProperty.Controls.Add(this.labelSet);
            this.groupBoxProperty.Controls.Add(this.comboBoxSetAccessModifier);
            this.groupBoxProperty.Controls.Add(this.labelGet);
            this.groupBoxProperty.Controls.Add(this.labelOpenBkt);
            this.groupBoxProperty.Location = new System.Drawing.Point(12, 44);
            this.groupBoxProperty.Name = "groupBoxProperty";
            this.groupBoxProperty.Size = new System.Drawing.Size(500, 60);
            this.groupBoxProperty.TabIndex = 14;
            this.groupBoxProperty.TabStop = false;
            // 
            // StringDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 162);
            this.Controls.Add(this.groupBoxProperty);
            this.Controls.Add(this.groupBoxFieldOrMethod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTitle);
            this.Name = "StringDataForm";
            this.Text = "StringDataForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxFieldOrMethod.ResumeLayout(false);
            this.groupBoxFieldOrMethod.PerformLayout();
            this.groupBoxProperty.ResumeLayout(false);
            this.groupBoxProperty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxSignature;
        private System.Windows.Forms.ComboBox comboBoxAccessModifier;
        private System.Windows.Forms.Label labelColon;
        private System.Windows.Forms.TextBox textBoxTypeToReturn;
        private System.Windows.Forms.ComboBox comboBoxPropAccessModifier;
        private System.Windows.Forms.TextBox textBoxPropName;
        private System.Windows.Forms.ComboBox comboBoxGetAccessModifier;
        private System.Windows.Forms.ComboBox comboBoxSetAccessModifier;
        private System.Windows.Forms.Label labelOpenBkt;
        private System.Windows.Forms.Label labelGet;
        private System.Windows.Forms.Label labelSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxFieldOrMethod;
        private System.Windows.Forms.GroupBox groupBoxProperty;
    }
}