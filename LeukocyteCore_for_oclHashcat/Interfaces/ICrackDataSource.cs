using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeukocyteGUI_for_oclHashCat
{
    public interface ICrackDataSource
    {
        string Name { get; set; }
        string Description { get; set; }
        string Source { get; set; }
    }
}
