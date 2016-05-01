using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace LeukocyteCore_for_oclHashcat
{
    public enum DataTypes
    {
        CrackTasks,
        Dictionaries,
        Masks,
        HashTypes,
        CrackTaskTemplates
    }

    public class DataLoadedSavedEventArgs : EventArgs
    {
        DataTypes dataType;
        string fileName;

        public DataTypes DataType
        {
            get
            {
                return dataType;
            }
        }
        public string FileName
        {
            get
            {
                return fileName;
            }
        }

        public DataLoadedSavedEventArgs(DataTypes dataType, string fileName) : base()
        {
            this.dataType = dataType;
            this.fileName = fileName;
        }
    }

    public static class DataManager
    {
        public delegate void DataLoadedSavedEventHandler(DataLoadedSavedEventArgs e);

        public static event DataLoadedSavedEventHandler DataLoaded = delegate { };
        public static event DataLoadedSavedEventHandler DataSaved = delegate { };
        
        /// <summary>
        /// List of CrackTasks.
        /// </summary>
        /// <see cref="CrackTask"/>
        public static List<CrackTask> CrackTasks
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
        private static List<CrackTask> crackTasks = new List<CrackTask>();

        /// <summary>
        /// List of Dictionaries.
        /// </summary>
        /// <see cref="Dictionary"/>
        public static List<Dictionary> Dictionaries
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
        private static List<Dictionary> dictionaries = new List<Dictionary>();

        /// <summary>
        /// List of Masks.
        /// </summary>
        /// <see cref="Mask"/>
        public static List<Mask> Masks
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
        private static List<Mask> masks = new List<Mask>();

        /// <summary>
        /// List of HashTypes.
        /// </summary>
        /// <see cref="HashType"/>
        public static List<HashType> HashTypes
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
        private static List<HashType> hashTypes = new List<HashType>();

        /// <summary>
        /// List of CrackTaskTemplates.
        /// </summary>
        /// <see cref="CrackTaskTemplate"/>
        public static List<CrackTaskTemplate> CrackTaskTemplates
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
        private static List<CrackTaskTemplate> crackTaskTemplates = new List<CrackTaskTemplate>();

        /// <summary>
        /// Name of the file where CrackTasks are stored.
        /// </summary>
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
        private static string crackTasksFile = "CrackTasks.dat";

        /// <summary>
        /// Name of the file where Dictionaries are stored.
        /// </summary>
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
        private static string dictionariesFile = "Dictionaries.dat";

        /// <summary>
        /// Name of the file where Masks are stored.
        /// </summary>
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
        private static string masksFile = "Masks.dat";

        /// <summary>
        /// Name of the file where HashTypes are stored.
        /// </summary>
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
        private static string hashTypesFile = "HashTypes.dat";

        /// <summary>
        /// Name of the file where CrackTaskTemplates are stored.
        /// </summary>
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
        private static string crackTaskTemplatesFile = "CrackTaskTemplates.dat";

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

        /// <summary>
        /// Loads data of the specified DataType from the current corresponding file.
        /// </summary>
        /// <param name="dataType">A type of data to be loaded</param>
        public static void LoadData(DataTypes dataType)
        {
            string fileName = "";

            switch (dataType)
            {
                case DataTypes.CrackTasks:
                    crackTasks = new List<CrackTask>(GetFromFile<CrackTask[]>(crackTasksFile));
                    fileName = crackTasksFile;
                    break;
                case DataTypes.Dictionaries:
                    dictionaries = new List<Dictionary>(GetFromFile<Dictionary[]>(dictionariesFile));
                    fileName = dictionariesFile;
                    break;
                case DataTypes.Masks:
                    masks = new List<Mask>(GetFromFile<Mask[]>(masksFile));
                    fileName = masksFile;
                    break;
                case DataTypes.HashTypes:
                    hashTypes = new List<HashType>(GetFromFile<HashType[]>(hashTypesFile));
                    fileName = hashTypesFile;
                    break;
                case DataTypes.CrackTaskTemplates:
                    crackTaskTemplates = new List<CrackTaskTemplate>(GetFromFile<CrackTaskTemplate[]>(crackTaskTemplatesFile));
                    fileName = crackTaskTemplatesFile;
                    break;
            }

            DataLoaded(new DataLoadedSavedEventArgs(dataType, fileName));
        }
        /// <summary>
        /// Loads data of the specified DataType from the specified file (saving that filename for the further usage).
        /// </summary>
        /// <param name="dataType">A type of data to be loaded</param>
        /// <param name="fileName">A name of a file from which data is loaded</param>
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
        /// <summary>
        /// Tries to load data of all DataTypes from existing corresponding files.
        /// </summary>
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
        /// <summary>
        /// Saves specified data of the specified DataType to the corresponding file.
        /// </summary>
        /// <param name="dataType">A type of data to be saved.</param>
        /// <param name="data">Data to be saved.</param>
        public static void SaveData(DataTypes dataType, object data)
        {
            string fileName = "";

            switch (dataType)
            {
                case DataTypes.CrackTasks:
                    SaveToFile(data, crackTasksFile);
                    fileName = crackTasksFile;
                    break;
                case DataTypes.Dictionaries:
                    SaveToFile(data, dictionariesFile);
                    fileName = dictionariesFile;
                    break;
                case DataTypes.Masks:
                    SaveToFile(data, masksFile);
                    fileName = masksFile;
                    break;
                case DataTypes.HashTypes:
                    SaveToFile(data, hashTypesFile);
                    fileName = hashTypesFile;
                    break;
                case DataTypes.CrackTaskTemplates:
                    SaveToFile(data, crackTaskTemplatesFile);
                    fileName = crackTaskTemplatesFile;
                    break;
            }

            DataSaved(new DataLoadedSavedEventArgs(dataType, fileName));
        }
        /// <summary>
        /// Saves data of the specified DataType to the corresponding file.
        /// </summary>
        /// <param name="dataType">A type of data to be saved.</param>
        public static void SaveData(DataTypes dataType)
        {
            string fileName = "";

            switch (dataType)
            {
                case DataTypes.CrackTasks:
                    SaveToFile(crackTasks, crackTasksFile);
                    fileName = crackTasksFile;
                    break;
                case DataTypes.Dictionaries:
                    SaveToFile(dictionaries, dictionariesFile);
                    fileName = dictionariesFile;
                    break;
                case DataTypes.Masks:
                    SaveToFile(masks, masksFile);
                    fileName = masksFile;
                    break;
                case DataTypes.HashTypes:
                    SaveToFile(hashTypes, hashTypesFile);
                    fileName = hashTypesFile;
                    break;
                case DataTypes.CrackTaskTemplates:
                    SaveToFile(crackTaskTemplates, crackTaskTemplatesFile);
                    fileName = crackTaskTemplatesFile;
                    break;
            }

            DataSaved(new DataLoadedSavedEventArgs(dataType, fileName));
        }
        /// <summary>
        /// Saves data of the specified DataType to the specified file.
        /// </summary>
        /// <param name="dataType">A type of data to be saved.</param>
        /// <param name="fileName">A name of a file to which data is saved.</param>
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
        /// <summary>
        /// Tries to save all existsing data to the corresponding files.
        /// </summary>
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

        /// <summary>
        /// Adds specified data of the specified DataType.
        /// </summary>
        /// <param name="dataType">A type of a data to be added.</param>
        /// <param name="data">Data to be added.</param>
        public static void AddData(DataTypes dataType, object data)
        {
            switch (dataType)
            {
                case DataTypes.CrackTasks:
                    crackTasks.Add((CrackTask)data);
                    break;
                case DataTypes.CrackTaskTemplates:
                    crackTaskTemplates.Add((CrackTaskTemplate)data);
                    break;
                case DataTypes.HashTypes:
                    hashTypes.Add((HashType)data);
                    break;
                case DataTypes.Masks:
                    masks.Add((Mask)data);
                    break;
                case DataTypes.Dictionaries:
                    dictionaries.Add((Dictionary)data);
                    break;
            }
        }
    }
}