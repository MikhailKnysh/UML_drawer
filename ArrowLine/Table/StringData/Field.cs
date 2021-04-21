
namespace ArrowLine.Table.StringData
{
    public class Field : IDTO
    {
        private string _accessModifier;
        private string _name;
        private string _typeToReturn;

        public Field(string accessModifier, string name, string typeToReturn)
        {
            _accessModifier = accessModifier;
            if (!(name == string.Empty))
            {
                _name = name;
                _typeToReturn = typeToReturn;
            }
            else
            {
                _name = "field";
                _typeToReturn = "type";
            }
        }

        public override string ToString()
        {
            return _accessModifier + " " + _name + " : " + _typeToReturn;
        }
    }
}
