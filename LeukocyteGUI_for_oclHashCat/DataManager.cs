using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LeukocyteGUI_for_oclHashCat
{
    public enum DataTypes
    {
        CrackTasks,
        Dictionaries,
        Masks,
        HashTypes
    }

    public static class DataManager
    {
        static CrackTask[] crackTasks = new CrackTask[0];
        static Dictionary[] dictionaries = new Dictionary[0];
        static Mask[] masks = new Mask[0];
        static HashType[] hashTypes = new HashType[0];
        static string crackTasksFile = "CrackTasks.dat";
        static string dictionariesFile = "Dictionaries.dat";
        static string masksFile = "Masks.dat";
        static string hashTypesFile = "HashTypes.dat";

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
        public static Dictionary[] Dictionaries
        {
            get
            {
                return dictionaries;
            }
            set
            {
                dictionaries = value;
            }
        }
        public static Mask[] Masks
        {
            get
            {
                return masks;
            }
            set
            {
                masks = value;
            }
        }
        public static HashType[] HashTypes
        {
            get
            {
                return hashTypes;
            }
            set
            {
                hashTypes = value;
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
        public static string DictionariesFile
        {
            get
            {
                return dictionariesFile;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Filename cannot be empty.", "CrackTasksFile");
                }

                dictionariesFile = value;
            }
        }
        public static string MasksFile
        {
            get
            {
                return masksFile;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Filename cannot be empty.", "CrackTasksFile");
                }

                masksFile = value;
            }
        }
        public static string HashTypesFile
        {
            get
            {
                return hashTypesFile;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Filename cannot be empty.", "CrackTasksFile");
                }

                hashTypesFile = value;
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

        public static void LoadData(DataTypes dataType)
        {
            switch(dataType)
            {
                case DataTypes.CrackTasks:
                    crackTasks = GetFromFile<CrackTask[]>(crackTasksFile);
                    break;
                case DataTypes.Dictionaries:
                    dictionaries = GetFromFile<Dictionary[]>(dictionariesFile);
                    break;
                case DataTypes.Masks:
                    masks = GetFromFile<Mask[]>(masksFile);
                    break;
                case DataTypes.HashTypes:
                    hashTypes = GetFromFile<HashType[]>(hashTypesFile);
                    break;
            }
        }
        public static void LoadData(DataTypes dataType, string fileName)
        {
            switch(dataType)
            {
                case DataTypes.CrackTasks:
                    CrackTasksFile = fileName;
                    break;
                case DataTypes.Dictionaries:
                    DictionariesFile = fileName;
                    break;
                case DataTypes.Masks:
                    MasksFile = fileName;
                    break;
                case DataTypes.HashTypes:
                    HashTypesFile = fileName;
                    break; 
            }

            LoadData(dataType);
        }
        public static void SaveData(DataTypes dataType, object data)
        {
            switch (dataType)
            {
                case DataTypes.CrackTasks:
                    SaveToFile(data, crackTasksFile);
                    break;
                case DataTypes.Dictionaries:
                    SaveToFile(data, dictionariesFile);
                    break;
                case DataTypes.Masks:
                    SaveToFile(data, masksFile);
                    break;
            }
        }
    }
}