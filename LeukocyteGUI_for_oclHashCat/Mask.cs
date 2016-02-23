using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeukocyteGUI_for_oclHashCat
{
    public enum MaskTypes
    {
        String,
        Hcmask
    }

    [Serializable()]
    public class Mask : CrackDataSource
    {
        MaskTypes type = MaskTypes.String;
        string charset1 = "";
        string charset2 = "";
        string charset3 = "";
        string charset4 = "";
        bool incrementMode;
        byte incrementMin;
        byte incrementMax;

        public MaskTypes Type
        {
            get
            {
                return type;
            }
        }
        public string Charset1
        {
            get
            {
                return charset1;
            }
            set
            {
                charset1 = value;
            }
        }
        public string Charset2
        {
            get
            {
                return charset2;
            }
            set
            {
                charset2 = value;
            }
        }
        public string Charset3
        {
            get
            {
                return charset3;
            }
            set
            {
                charset3 = value;
            }
        }
        public string Charset4
        {
            get
            {
                return charset4;
            }
            set
            {
                charset4 = value;
            }
        }
        public bool IncrementMode
        {
            get
            {
                return incrementMode;
            }
            set
            {
                incrementMode = value;
            }
        }
        public byte IncrementMin
        {
            get
            {
                return incrementMin;
            }
            set
            {
                incrementMin = value;
            }
        }
        public byte IncrementMax
        {
            get
            {
                return incrementMax;
            }
            set
            {
                incrementMax = value;
            }
        }
        public new string Source
        {
            get
            {
                return source;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Source cannot be empty.", "Source");
                }

                if ((type == MaskTypes.Hcmask) && (!File.Exists(value)))
                {
                    throw new ArgumentException("Source file does not exist.", "Source");
                }

                source = value;
            }
        }
        public int Lentgh
        {
            get
            {
                if (type == MaskTypes.String)
                {
                    return source.Length;
                }
                else
                {
                    return 0;
                }
            }
        }

        private Mask(MaskTypes type)
        {
            this.type = type;
        }

        public Mask CreateFromString(string maskString, string name)
        {
            Mask mask = new Mask(MaskTypes.String);
            mask.Source = maskString;
            mask.Name = name;

            return mask;
        }
        public Mask CreateFromHcmask(string hcmaskFileName, string name)
        {
            Mask mask = new Mask(MaskTypes.Hcmask);
            mask.Source = hcmaskFileName;
            mask.Name = name;

            return mask;
        }

        public new void GenerateDescription()
        {
            if (type == MaskTypes.Hcmask)
            {
                base.GenerateDescription();
            }
            else
            {
                string targetLength = incrementMode ? (incrementMin + "-" + IncrementMax) : Lentgh.ToString();
                string charsets = (string.IsNullOrEmpty(charset1) ? "" : ("[1]" + charset1 + " ")) +
                    (string.IsNullOrEmpty(charset2) ? "" : ("[2]" + charset2 + " ")) +
                    (string.IsNullOrEmpty(charset3) ? "" : ("[3]" + charset3 + " ")) +
                    (string.IsNullOrEmpty(charset4) ? "" : ("[4]" + charset4 + " "));

                description = "<" + targetLength + ">" + charsets;
            }
        }
    }
}
