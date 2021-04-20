
namespace ArrowLine.Table.StringData
{
    public class Field : IDTO
    {
        private string _accessModifier;
        private string _name = "field";
        private string _typeToReturn;

        public Field(string accessModifier, string name, string typeToReturn)
        {
            _accessModifier = accessModifier;
            _name = name;
            _typeToReturn = typeToReturn;
        }

        public override string ToString()
        {
            return _accessModifier + " " + _name + " : " + _typeToReturn;
        }
    }
}
