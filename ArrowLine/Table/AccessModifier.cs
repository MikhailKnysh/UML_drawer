using System.ComponentModel;

namespace UMLDrawer.Table
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
