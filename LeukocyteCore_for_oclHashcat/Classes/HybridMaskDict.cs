namespace LeukocyteCore_for_oclHashcat.Classes
{
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
        }
    }
}
