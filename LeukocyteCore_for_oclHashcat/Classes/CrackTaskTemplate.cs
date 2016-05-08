using System;

namespace LeukocyteCore_for_oclHashcat.Classes
{
    [Serializable()]
    public class CrackTaskTemplate
    {
        private CrackTask crackTask;
        private string name;

        public CrackTask CrackTask
        {
            get
            {
                return crackTask;
            }
            set
            {
                crackTask = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                name = value;
            }
        }

        public CrackTaskTemplate(CrackTask crackTask, string name)
        {
            CrackTask = crackTask;
            Name = name;
        }
    }
}
