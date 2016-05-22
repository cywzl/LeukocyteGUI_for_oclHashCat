using LeukocyteCore_for_oclHashcat.Interfaces;
using LeukocyteCore_for_oclHashcat.Classes;
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
        public static ListViewItem ToListViewItem(this CrackTask crackTask, int id = 0)
        {
            return new ListViewItem(new string[]
                {
                    /* #         */ (id + 1).ToString(),
                    /* HashType  */ crackTask.HashType.Name,
                    /* Target    */ crackTask.CrackTarget,
                    /* Plain     */ crackTask.Plain,
                    /* Length    */ crackTask.CurrentLength.ToString(),
                    /* Progress  */ crackTask.Progress.ToString(),
                    /* Estimated */ crackTask.TimeEstimated,
                    /* Mask/Dict */ crackTask.CrackDataSourceLeft +
                                        (!string.IsNullOrEmpty(crackTask.CrackDataSourceRight)
                                        ? " + " + crackTask.CrackDataSourceRight : ""),
                    /* Started   */ crackTask.Started.ToString(),
                    /* Finished  */ crackTask.Finished.ToString(),
                    /* Session   */ crackTask.SessionSettings.Session
                })
            {
                Tag = crackTask
            };
        }
    }
}
