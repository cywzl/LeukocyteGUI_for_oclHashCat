﻿using System;
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
                    return leftSource.Length;
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
            attackMode = AttackModes.BruteForce;
        }

        public Mask CreateFromString(string maskString, string name)
        {
            Mask mask = new Mask(MaskTypes.String);
            mask.LeftSource = maskString;
            mask.Name = name;

            return mask;
        }
        public Mask CreateFromHcmask(string hcmaskFileName, string name)
        {
            Mask mask = new Mask(MaskTypes.Hcmask);
            mask.LeftSource = hcmaskFileName;
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
    }
}