using LeukocyteCore_for_oclHashcat.Interfaces;
using System.IO;

namespace LeukocyteCore_for_oclHashcat.Classes
{
    public class CombinedCrackData : CrackDataSource, ICombinedCrackData
    {
        protected ICrackDataSource sourceBase;
        protected ICrackDataSource additionalSourceBase;

        public override string Source
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

        public override void GenerateDescription()
        {
            description = Path.GetFileNameWithoutExtension(sourceBase.Source) +
                " + " + Path.GetFileNameWithoutExtension(additionalSourceBase.Source);
        }

        public override object Clone()
        {
            CombinedCrackData clone = new CombinedCrackData()
            {
                Name = string.Copy(name),
                Description = string.Copy(description),
                AttackMode = attackMode,
                SourceBase = (ICrackDataSource)sourceBase.Clone(),
                AdditionalSourceBase = (ICrackDataSource)additionalSourceBase.Clone(),
            };
            
            return clone;
        }
    }
}
