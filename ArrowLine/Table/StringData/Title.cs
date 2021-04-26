
namespace ArrowLine.Table.StringData
{
    public class Title : IDTO
    {
        private string _title;

        public Title(string title)
        {
            if (!(title.Equals(string.Empty)))
            {
                _title = title;
            }
            else
            {
                _title = "Title";
            }
        }

        public override string ToString()
        {
            return _title;
        }
    }
}
