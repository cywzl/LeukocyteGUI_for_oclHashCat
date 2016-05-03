using System;

namespace LeukocyteCore_for_oclHashcat.Classes
{
    [Serializable()]
    public class HybridDictMask : CombinedCrackData
    {
        private new Dictionary sourceBase;
        private new Mask additionalSourceBase;

        public new Dictionary SourceBase
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
        public new Mask AdditionalSourceBase
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

        public HybridDictMask(Dictionary leftDictionary, Mask rightMask)
        {
            sourceBase = leftDictionary;
            additionalSourceBase = rightMask;
            attackMode = AttackModes.DictPlusMask;
        }

        public override object Clone()
        {
            HybridDictMask clone = new HybridDictMask(
                (Dictionary)sourceBase.Clone(),
                (Mask)additionalSourceBase.Clone())
            {
                Name = string.Copy(name),
                Description = string.Copy(description)
            };

            return clone;
        }
    }
}
