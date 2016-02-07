using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeukocyteGUI_for_oclHashCat
{
    class Cracker
    {
        CrackTasksList crackTasks;
        Process cracker;

        public CrackTasksList CrackTasks
        {
            get
            {
                return crackTasks;
            }
            set
            {
                crackTasks = value;
            }
        }
        public string CrackerFile
        {
            get
            {
                return cracker.StartInfo.FileName;
            }
            set
            {
                cracker.StartInfo.FileName = value;
            }
        }
        public string WorkingDirectory
        {
            get
            {
                return cracker.StartInfo.WorkingDirectory;
            }
            set
            {
                cracker.StartInfo.WorkingDirectory = value;
            }
        }

        public Cracker()
        {
            crackTasks = new CrackTasksList();
            cracker = new Process();
            cracker.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = true
            };
            cracker.EnableRaisingEvents = true;
            cracker.ErrorDataReceived += Cracker_ErrorDataReceived;
            cracker.Exited += Cracker_Exited;
            cracker.OutputDataReceived += Cracker_OutputDataReceived;
        }
        public Cracker(string crackerFile, string workingDirectory = "") : this()
        {
            cracker.StartInfo.FileName = crackerFile;
            cracker.StartInfo.WorkingDirectory = workingDirectory;
        }

        private void Cracker_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Cracker_Exited(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Cracker_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
