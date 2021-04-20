using ArrowLine.Table;
using EnumsNET;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArrowLine
{
    public partial class StringDataForm : Form
    {
        private string _labelData;
        private StringBuilder _stringBuilder;

        public StringDataForm(/*string labelData*/)
        {
            InitializeComponent();

            _stringBuilder = new StringBuilder();
            this._labelData = "Property";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var items = Enum.GetValues(typeof(AccessModifier))
                .Cast<AccessModifier>()
                .Select(x => x.GetEnumDescription());

            comboBoxAccessModifier.Items.AddRange(items.Cast<object>().ToArray());
            comboBoxPropAccessModifier.Items.AddRange(items.Cast<object>().ToArray());
            comboBoxGetAccessModifier.Items.AddRange(items.Cast<object>().ToArray());
            comboBoxSetAccessModifier.Items.AddRange(items.Cast<object>().ToArray());

            labelTitle.Text = _labelData;

            comboBoxAccessModifier.SelectedIndex = 0;
            comboBoxPropAccessModifier.SelectedIndex = 0;
            comboBoxGetAccessModifier.SelectedIndex = 0;
            comboBoxSetAccessModifier.SelectedIndex = 0;

            if (_labelData.Equals("Property"))
            {
                groupBoxFieldOrMethod.Visible = false;
            }
            else
            {
                groupBoxProperty.Visible = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (_labelData.Equals("Property"))
            {
                _stringBuilder
                    .Append(comboBoxPropAccessModifier.Text)
                    .Append(textBoxPropName.Text)
                    .Append(labelOpenBkt.Text)
                    .Append(comboBoxGetAccessModifier.Text)
                    .Append(labelGet.Text)
                    .Append(comboBoxSetAccessModifier.Text)
                    .Append(labelSet.Text);
            }
            else
            {
                _stringBuilder
                    .Append(comboBoxAccessModifier.Text)
                    .Append(textBoxSignature.Text)
                    .Append(labelColon.Text)
                    .Append(textBoxTypeToReturn.Text);
            }
        }

        //private string 
    }
}
