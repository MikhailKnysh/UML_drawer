using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowLine.Table.StringData
{
    public class Property : IDTO
    {
        public string AccessModifier { get; set; }
        public string Name { get; set; }
        public string GetAccessModifier { get; set; }
        public string SetAccessModifier { get; set; }

        public Property()
        {
        }

        public override string ToString()
        {
            return string.Empty;
        }
    }
}
