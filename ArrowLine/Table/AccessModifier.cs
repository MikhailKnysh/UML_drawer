using System.ComponentModel;

namespace ArrowLine.Table
{
    public enum AccessModifier
    {
        [Description("+")]
        Public,
        [Description("#")]
        Protected,
        [Description("-")]
        Private
    }
}
