using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LeukocyteGUI_for_oclHashCat
{
    public static class DataManager
    {
        static CrackTask[] crackTasks = new CrackTask[0];
        static string crackTasksFile = "CrackTasks.dat";

        public static CrackTask[] CrackTasks
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
        public static string CrackTasksFile
        {
            get
            {
                return crackTasksFile;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Filename cannot be empty.", "CrackTasksFile");
                }

                crackTasksFile = value;
            }
        }

        /// <summary>
        /// Saves any serializable object to file.
        /// </summary>
        /// <param name="objectToSave">Serializable object to be saved.</param>
        /// <param name="fileName">File where specified object will be saved.</param>
        public static void SaveToFile(object objectToSave, string fileName)
        {
            Stream fileStream = File.Create(fileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fileStream, objectToSave);
            fileStream.Close();
        }
        /// <summary>
        /// Gets serialized and saved to file object from that file.
        /// </summary>
        /// <typeparam name="T">Type of an object in the file.</typeparam>
        /// <param name="fileName">File where an serialized object is stored.</param>
        /// <returns>Deserealized object of T type.</returns>
        public static T GetFromFile<T>(string fileName)
        {
            Stream fileStream = File.OpenRead(fileName);
            BinaryFormatter deserializer = new BinaryFormatter();
            T deserealizedObject = (T)deserializer.Deserialize(fileStream);

            return deserealizedObject;
        }

        public static void LoadCrackTasks()
        {
            crackTasks = GetFromFile<CrackTask[]>(crackTasksFile);
        }
        public static void LoadCrackTasks(string fileName)
        {
            crackTasksFile = fileName;
            LoadCrackTasks();
        }
        public static void SaveCrackTasks()
        {
            SaveToFile(crackTasks, crackTasksFile);
        }
        public static void SaveCrackTasks(string fileName)
        {
            crackTasksFile = fileName;
            SaveCrackTasks();
        }
    }
}