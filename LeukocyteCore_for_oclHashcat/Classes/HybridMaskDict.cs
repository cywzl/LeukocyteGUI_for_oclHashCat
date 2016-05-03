using System;

namespace LeukocyteCore_for_oclHashcat.Classes
{
    [Serializable()]
    public class HybridMaskDict : CombinedCrackData
    {
        private new Mask sourceBase;
        private new Dictionary additionalSourceBase;

        public new Mask SourceBase
        {
            get
            {
                return sourceBase;
            }
            set
            {
                sourceBase = value;
            }
        }
        public new Dictionary AdditionalSourceBase
        {
            get
            {
                return additionalSourceBase;
            }
            set
            {
                additionalSourceBase = value;
            }
        }

        public HybridMaskDict(Mask leftMask, Dictionary rightDictionary)
        {
            sourceBase = leftMask;
            additionalSourceBase = rightDictionary;
            attackMode = AttackModes.MaskPlusDict;
        }

        public override object Clone()
        {
            HybridMaskDict clone = new HybridMaskDict(
                (Mask)sourceBase.Clone(),
                (Dictionary)additionalSourceBase.Clone())
            {
                Name = string.Copy(name),
                Description = string.Copy(description)
            };

            return clone;
        }
    }
}
