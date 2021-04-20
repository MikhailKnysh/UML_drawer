namespace ArrowLine.Table.StringData
{
    public class Property : IDTO
    {
        private string _accessModifier;
        private string _name;
        private string _getAccessModifier;
        private string _setAccessModifier;

        public Property(string accessModifier, string name, string getAccessModifier, string setAccessModifier)
        {
            _accessModifier = accessModifier;
            if (!(name == string.Empty))
            {
                _name = name;
            }
            else
            {
                _name = "property";
            }

            _getAccessModifier = getAccessModifier;
            _setAccessModifier = setAccessModifier;
        }

        public override string ToString()
        {
            return _accessModifier + " " + _name + " {" + _getAccessModifier
                + "get; " + _setAccessModifier + "set; }";
        }
    }
}
