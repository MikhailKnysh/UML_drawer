
namespace ArrowLine.Table.StringData
{
    public class Method : IDTO
    {
        private string _accessModifier;
        private string _signature = "method";
        private string _typeToReturn;

        public Method(string accessModifier, string name, string typeToReturn)
        {
            _accessModifier = accessModifier;
            _signature = name;
            _typeToReturn = typeToReturn;
        }

        public override string ToString()
        {
            return _accessModifier + " " + _signature + " : " + _typeToReturn;
        }
    }
}
