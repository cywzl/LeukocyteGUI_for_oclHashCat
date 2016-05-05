using System;

namespace LeukocyteCore_for_oclHashcat
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
        IncrementSettings incrementSettings = new IncrementSettings();
        CustomCharsetsSettings charsetsSettings = new CustomCharsetsSettings();

        public MaskTypes Type
        {
            get
            {
                return type;
            }
        }
        public IncrementSettings IncrementSettings
        {
            get
            {
                return incrementSettings;
            }
            set
            {
                incrementSettings = value;
            }
        }
        public CustomCharsetsSettings CharsetsSettings
        {
            get
            {
                return charsetsSettings;
            }
            set
            {
                charsetsSettings = value;
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
        public override string Source
        {
            get
            {
                return base.Source;
            }
            set
            {
                if (value.EndsWith(".hcmask"))
                {
                    type = MaskTypes.Hcmask;
                }
                else
                {
                    type = MaskTypes.String;
                }

                base.Source = value;
            }
        }

        public Mask()
        {
            attackMode = AttackModes.BruteForce;
        }
        public Mask(MaskTypes type) : this()
        {
            this.type = type;
        }
        public Mask(MaskTypes type, string name) : this(type)
        {
            this.name = name;
        }
        public Mask(string mask) : this()
        {
            Source = mask;
        }
        public Mask(string mask, string name) : this(mask)
        {
            this.name = name;
        }

        public override void GenerateDescription()
        {
            if (type == MaskTypes.Hcmask)
            {
                base.GenerateDescription();
            }
            else
            {
                string targetLength =
                    incrementSettings.Increment
                    ? (incrementSettings.IncrementMin + "-" + incrementSettings.IncrementMax)
                    : Lentgh.ToString();

                string charsets =
                    (charsetsSettings.UseCharset1 ? "" : ("[1]" + charsetsSettings.Charset1 + " ")) +
                    (charsetsSettings.UseCharset2 ? "" : ("[2]" + charsetsSettings.Charset2 + " ")) +
                    (charsetsSettings.UseCharset3 ? "" : ("[3]" + charsetsSettings.Charset3 + " ")) +
                    (charsetsSettings.UseCharset4 ? "" : ("[4]" + charsetsSettings.Charset4 + " "));

                description = "<" + targetLength + ">" + charsets;
            }
        }
        public override object Clone()
        {
            Mask clone = new Mask(type)
            {
                Name = string.Copy(name),
                Description = string.Copy(description),
                Source = string.Copy(source),
                IncrementSettings = incrementSettings.DeepCopy(),
                CharsetsSettings = charsetsSettings.DeepCopy()
            };

            return clone;
        }
    }
}
