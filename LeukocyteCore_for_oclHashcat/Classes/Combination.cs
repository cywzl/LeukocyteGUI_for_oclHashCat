namespace LeukocyteCore_for_oclHashcat.Classes
{
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
        }
    }
}
