namespace ArrowLine.Table.StringData
{
    public class Property : IDTO
    {
        private string _accessModifier;
        private string _name = "property";
        private string _getAccessModifier;
        private string _setAccessModifier;

        public Property(string accessModifier, string name, string getAccessModifier, string setAccessModifier)
        {
            _accessModifier = accessModifier;
            _name = name;
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
