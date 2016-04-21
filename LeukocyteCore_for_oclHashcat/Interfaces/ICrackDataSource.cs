using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeukocyteGUI_for_oclHashCat
{
    public interface ICrackDataSource
    {
        string Name { get; }
        string Description { get; }
        string Source { get; }
        AttackModes AttackMode { get; }
    }
}
