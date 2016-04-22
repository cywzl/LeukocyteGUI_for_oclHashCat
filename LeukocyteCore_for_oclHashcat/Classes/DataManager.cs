using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LeukocyteGUI_for_oclHashCat
{
    public enum DataTypes
    {
        CrackTasks,
        Dictionaries,
        Masks,
        HashTypes,
        CrackTaskTemplates
    }

    public static class DataManager
    {
        static CrackTask[] crackTasks = new CrackTask[0];
        static Dictionary[] dictionaries = new Dictionary[0];
        static Mask[] masks = new Mask[0];
        static HashType[] hashTypes = new HashType[0];
        static CrackTaskTemplate[] crackTaskTemplates = new CrackTaskTemplate[0];
        static string crackTasksFile = "CrackTasks.dat";
        static string dictionariesFile = "Dictionaries.dat";
        static string masksFile = "Masks.dat";
        static string hashTypesFile = "HashTypes.dat";
        static string crackTaskTemplatesFile = "CrackTaskTemplates.dat";

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
        public static CrackTaskTemplate[] CrackTaskTemplates
        {
            get
            {
                return crackTaskTemplates;
            }
            set
            {
                crackTaskTemplates = value;
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
                if (string.IsNullOrEmpty(value))
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
                    throw new ArgumentException("Filename cannot be empty.", "MasksFile");
                }

                hashTypesFile = value;
            }
        }
        public static string CrackTaskTemplatesFile
        {
            get
            {
                return crackTaskTemplatesFile;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Filename cannot be empty.", "CrackTaskTemplatesFile");
                }

                crackTaskTemplatesFile = value;
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
            switch (dataType)
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
                case DataTypes.CrackTaskTemplates:
                    crackTaskTemplates = GetFromFile<CrackTaskTemplate[]>(crackTaskTemplatesFile);
                    break;
            }
        }
        public static void LoadData(DataTypes dataType, string fileName)
        {
            switch (dataType)
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
                case DataTypes.CrackTaskTemplates:
                    CrackTaskTemplatesFile = fileName;
                    break;
            }

            LoadData(dataType);
        }
        public static void LoadAllAvailableData()
        {
            foreach (var dataType in Enum.GetValues(typeof(DataTypes)))
            {
                try
                {
                    LoadData((DataTypes)dataType);
                }
                catch { }
            }
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
                case DataTypes.HashTypes:
                    SaveToFile(data, hashTypesFile);
                    break;
                case DataTypes.CrackTaskTemplates:
                    SaveToFile(data, crackTaskTemplatesFile);
                    break;
            }
        }
        public static void SaveData(DataTypes dataType)
        {
            switch (dataType)
            {
                case DataTypes.CrackTasks:
                    SaveToFile(crackTasks, crackTasksFile);
                    break;
                case DataTypes.Dictionaries:
                    SaveToFile(dictionaries, dictionariesFile);
                    break;
                case DataTypes.Masks:
                    SaveToFile(masks, masksFile);
                    break;
                case DataTypes.HashTypes:
                    SaveToFile(hashTypes, hashTypesFile);
                    break;
                case DataTypes.CrackTaskTemplates:
                    SaveToFile(crackTaskTemplates, crackTaskTemplatesFile);
                    break;
            }
        }
        public static void SaveData(DataTypes dataType, string fileName)
        {
            switch (dataType)
            {
                case DataTypes.CrackTasks:
                    crackTasksFile = fileName;
                    break;
                case DataTypes.Dictionaries:
                    dictionariesFile = fileName;
                    break;
                case DataTypes.Masks:
                    masksFile = fileName;
                    break;
                case DataTypes.HashTypes:
                    hashTypesFile = fileName;
                    break;
                case DataTypes.CrackTaskTemplates:
                    crackTasksFile = fileName;
                    break;
            }

            SaveData(dataType);
        }
        public static void SaveAllData()
        {
            foreach (var dataType in Enum.GetValues(typeof(DataTypes)))
            {
                try
                {
                    SaveData((DataTypes)dataType);
                }
                catch { }
            }
        }
    }
}