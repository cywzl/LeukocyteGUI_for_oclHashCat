using LeukocyteCore_for_oclHashcat.Interfaces;
using System.Linq;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashcat.Classes
{
    public static class Converter
    {
        public static ListViewItem ToListViewItem(this ICrackDataSource source, int id = 0)
        {
            return new ListViewItem(new string[]
                {
                    id.ToString(),
                    source.GetType().ToString().Split('.').Last(),
                    source.Name,
                    source.Description
                })
            {
                Tag = source
            };
        }
    }
}
