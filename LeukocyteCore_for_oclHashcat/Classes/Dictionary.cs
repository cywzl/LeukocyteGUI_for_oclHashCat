using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeukocyteGUI_for_oclHashCat
{
    [Serializable()]
    public class Dictionary : CrackDataSource
    {
        FileInfo fileInfo;

        public long Size
        {
            get
            {
                return fileInfo.Length;
            }
        }
        public string FormattedSize
        {
            get
            {
                if (fileInfo == null)
                {

                }

                int length = fileInfo.Length.ToString().Length;

                if (length < 3)
                {
                    return fileInfo.Length.ToString() + " B";
                }
                else if (length < 6)
                {
                    return Math.Round(fileInfo.Length / 1024.0, 1).ToString() + " KB";
                }
                else if (length < 9)
                {
                    return Math.Round(fileInfo.Length / 1048576.0, 1).ToString() + " MB";
                }
                else if (length < 12)
                {
                    return Math.Round(fileInfo.Length / 1073741824.0, 1).ToString() + " GB";
                }
                else
                {
                    return Math.Round(fileInfo.Length / 1099511627776.0, 1).ToString() + " TB";
                }
            }
        }

        public Dictionary(string dictFileName, string name)
        {
            source = dictFileName;
            this.name = name;
            attackMode = AttackModes.Straight;
        }

        public void LoadInfo()
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new InvalidOperationException("Source cannot be empty.");
            }

            fileInfo = new FileInfo(source);
        }
    }
}
