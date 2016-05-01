using LeukocyteCore_for_oclHashcat.Interfaces;
using System.IO;

namespace LeukocyteCore_for_oclHashcat
{
    public class CrackDataSource : ICrackDataSource
    {
        protected AttackModes attackMode = AttackModes.Straight;
        protected string name = "";
        protected string description = "";
        protected string source = "";

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public string Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }
        public AttackModes AttackMode
        {
            get
            {
                return attackMode;
            }
        }

        public void GenerateDescription()
        {
            description = Path.GetFileNameWithoutExtension(source);
        }
    }
}
