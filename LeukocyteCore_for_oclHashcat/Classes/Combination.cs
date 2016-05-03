using System;

namespace LeukocyteCore_for_oclHashcat.Classes
{
    [Serializable()]
    public class Combination : CombinedCrackData
    {
        private new Dictionary sourceBase;
        private new Dictionary additionalSourceBase;

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

        public Combination(Dictionary leftDictionary, Dictionary rightDictionary)
        {
            sourceBase = leftDictionary;
            additionalSourceBase = rightDictionary;
            attackMode = AttackModes.Combination;
        }

        public override object Clone()
        {
            Combination clone = new Combination(
                (Dictionary)sourceBase.Clone(),
                (Dictionary)additionalSourceBase.Clone())
            {
                Name = string.Copy(name),
                Description = string.Copy(description)
            };

            return clone;
        }
    }
}
