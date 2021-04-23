using ArrowLine.Table;
using ArrowLine.Table.StringData;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ArrowLine
{
    public partial class StringDataForm : Form
    {
        private string _labelData;

        public StringDataForm(string labelData)
        {
            InitializeComponent();

            _labelData = labelData;
        }

        public IDTO Create()
        {
            if (_labelData.Equals("Title"))
            {
                return new Title(textBoxTitle.Text);
            }
            else if (_labelData.Equals("Field"))
            {
                return new Field(comboBoxAccessModifier.Text, textBoxSignature.Text,
                    textBoxTypeToReturn.Text);
            }
            else if(_labelData.Equals("Property"))
            {
                return new Property(comboBoxPropAccessModifier.Text, textBoxPropName.Text,
                    comboBoxGetAccessModifier.Text, comboBoxSetAccessModifier.Text);
            }
            else
            {
                return new Method(comboBoxAccessModifier.Text, textBoxSignature.Text,
                    textBoxTypeToReturn.Text);
            }
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

            if (_labelData.Equals("Title"))
            {
                groupBoxFieldOrMethod.Visible = false;
                groupBoxProperty.Visible = false;
            }
            else if (_labelData.Equals("Property"))
            {
                groupBoxFieldOrMethod.Visible = false;
                groupBoxTitle.Visible = false;
            }
            else
            {
                groupBoxProperty.Visible = false;
                groupBoxTitle.Visible = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
