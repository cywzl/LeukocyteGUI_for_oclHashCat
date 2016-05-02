using LeukocyteCore_for_oclHashcat.Interfaces;

namespace LeukocyteCore_for_oclHashcat.Classes
{
    public class CombinedCrackData : CrackDataSource, ICombinedCrackData
    {
        protected ICrackDataSource sourceBase;
        protected ICrackDataSource additionalSourceBase;

        public new string Source
        {
            get
            {
                return sourceBase.Source;
            }
            set
            {
                sourceBase.Source = value;
            }
        }
        public string AdditionalSource
        {
            get
            {
                return additionalSourceBase.Source;
            }
            set
            {
                additionalSourceBase.Source = value;
            }
        }
        public ICrackDataSource SourceBase
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
        public ICrackDataSource AdditionalSourceBase
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
    }
}
