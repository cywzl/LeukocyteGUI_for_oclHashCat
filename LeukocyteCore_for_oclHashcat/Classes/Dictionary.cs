using System;
using System.IO;

namespace LeukocyteCore_for_oclHashcat
{
    [Serializable()]
    public class Dictionary : CrackDataSource
    {
        FileInfo fileInfo;

        public long Size
        {
            get
            {
                return (fileInfo == null ? 0 : fileInfo.Length);
            }
        }
        public string FormattedSize
        {
            get
            {
                if (fileInfo == null)
                {
                    return "N/I";
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
        public override string Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                LoadInfo();
            }
        }

        public Dictionary()
        {
            attackMode = AttackModes.Straight;
        }
        public Dictionary(string dictFileName) : this()
        {
            Source = dictFileName;
        }
        public Dictionary(string dictFileName, string name) : this(dictFileName)
        {
            this.name = name;
        }

        public void LoadInfo()
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new InvalidOperationException("Cannot load info when source is empty.");
            }

            try
            {
                fileInfo = new FileInfo(source);
            }
            catch (Exception e)
            {
                throw new Exception("Cannot load file info.", e);
            }
            
        }

        public override object Clone()
        {
            Dictionary clone = new Dictionary(source, name)
            {
                Description = string.Copy(description),
            };

            return clone;
        }
    }
}
