﻿
namespace ArrowLine.Table.StringData
{
    public class Method : IDTO
    {
        private string _accessModifier;
        private string _signature;
        private string _typeToReturn;

        public Method(string accessModifier, string name, string typeToReturn)
        {
            _accessModifier = accessModifier;

            if (!(name == string.Empty))
            {
                _signature = name;
            }
            else
            {
                _signature = "method";
            }

            _typeToReturn = typeToReturn;
        }

        public override string ToString()
        {
            return _accessModifier + " " + _signature + " : " + _typeToReturn;
        }
    }
}