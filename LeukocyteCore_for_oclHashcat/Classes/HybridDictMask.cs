namespace LeukocyteCore_for_oclHashcat.Classes
{
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
        }
    }
}
