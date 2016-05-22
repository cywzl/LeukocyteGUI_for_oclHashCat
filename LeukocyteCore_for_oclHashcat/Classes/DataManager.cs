using LeukocyteCore_for_oclHashcat.Interfaces;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace LeukocyteCore_for_oclHashcat.Classes
{
    public enum DataTypes
    {
        CrackTasks,
        HashTypes,
        CrackTaskTemplates,
        Dictionaries,
        Masks,
        Combinations,
        HybridDictMask,
        HybridMaskDict
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
        public class DataHolder
        {
            public IList StoredData
            {
                get
                {
                    return storedData;
                }
                set
                {
                    storedData.Clear();

                    foreach (var entry in value)
                    {
                        storedData.Add(entry);
                    }
                }
            }
            private IList storedData;

            public string FileName
            {
                get
                {
                    return fileName;
                }
                set
                {
                    fileName = value;
                }
            }
            private string fileName = "";

            public DataTypes DataType
            {
                get
                {
                    return dataType;
                }
                set
                {
                    dataType = value;
                }
            }
            private DataTypes dataType;

            public DataHolder(IList storedData, DataTypes dataType, string fileName)
            {
                this.storedData = storedData;
                this.fileName = fileName;
                this.dataType = dataType;
            }
        }

        public delegate void DataLoadedSavedEventHandler(DataLoadedSavedEventArgs e);

        public static event DataLoadedSavedEventHandler DataLoaded = delegate { };
        public static event DataLoadedSavedEventHandler DataSaved = delegate { };


        /// <summary>
        /// List of CrackTasks.
        /// </summary>
        /// <see cref="CrackTask"/>
        public static CrackTasksList CrackTasks
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
        private static CrackTasksList crackTasks = new CrackTasksList();

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
        /// List of Combinations.
        /// </summary>
        /// <see cref="Combinations"/>
        public static List<Combination> Combinations
        {
            get
            {
                return combinations;
            }
            set
            {
                combinations = value;
            }
        }
        private static List<Combination> combinations = new List<Combination>();

        /// <summary>
        /// List of HybridDictMasks.
        /// </summary>
        /// <see cref="Combinations"/>
        public static List<HybridDictMask> HybridDictMasks
        {
            get
            {
                return hybridDictMasks;
            }
            set
            {
                hybridDictMasks = value;
            }
        }
        private static List<HybridDictMask> hybridDictMasks = new List<HybridDictMask>();

        /// <summary>
        /// List of HybridDictMasks.
        /// </summary>
        /// <see cref="Combinations"/>
        public static List<HybridMaskDict> HybridMaskDicts
        {
            get
            {
                return hybridMaskDicts;
            }
            set
            {
                hybridMaskDicts = value;
            }
        }
        private static List<HybridMaskDict> hybridMaskDicts = new List<HybridMaskDict>();

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
        /// List of all CrackDataSources
        /// </summary>
        public static List<ICrackDataSource> CrackDataSources
        {
            get
            {
                List<ICrackDataSource> union = new List<ICrackDataSource>();
                union.AddRange(dictionaries);
                union.AddRange(masks);
                union.AddRange(combinations);
                union.AddRange(hybridDictMasks);
                union.AddRange(hybridMaskDicts);

                return union;
            }
        }

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
        /// Name of the file where Combinations are stored.
        /// </summary>
        public static string CombinationsFile
        {
            get
            {
                return combinationsFile;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Filename cannot be empty.", "CombinationsFile");
                }

                combinationsFile = value;
            }
        }
        private static string combinationsFile = "Combinations.dat";

        /// <summary>
        /// Name of the file where HybridDictMasks are stored.
        /// </summary>
        public static string HybridDictMasksFile
        {
            get
            {
                return hybridDictMasksFile;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Filename cannot be empty.", "HybridDictMasksFile");
                }

                hybridDictMasksFile = value;
            }
        }
        private static string hybridDictMasksFile = "HybridDictMasks.dat";

        /// <summary>
        /// Name of the file where Masks are stored.
        /// </summary>
        public static string HybridMaskDictsFile
        {
            get
            {
                return hybridMaskDictsFile;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Filename cannot be empty.", "HybridMaskDictsFile");
                }

                hybridMaskDictsFile = value;
            }
        }
        private static string hybridMaskDictsFile = "HybridMaskDicts.dat";

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

        private static DataHolder[] dataMapper = new DataHolder[]
        {
            new DataHolder(crackTasks,            DataTypes.CrackTasks,          crackTasksFile),
            new DataHolder(hashTypes,             DataTypes.HashTypes,           hashTypesFile),
            new DataHolder(crackTaskTemplates,    DataTypes.CrackTaskTemplates,  crackTaskTemplatesFile),
            new DataHolder(dictionaries,          DataTypes.Dictionaries,        dictionariesFile),
            new DataHolder(masks,                 DataTypes.Masks,               masksFile),
            new DataHolder(combinations,          DataTypes.Combinations,        combinationsFile),
            new DataHolder(hybridDictMasks,       DataTypes.HybridDictMask,      hybridDictMasksFile),
            new DataHolder(hybridMaskDicts,       DataTypes.HybridMaskDict,      hybridMaskDictsFile)
        };

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
        /// Gets serialized object from a file.
        /// </summary>
        /// <param name="fileName">File where serialized object is stored</param>
        /// <returns></returns>
        public static object GetFromFile(string fileName)
        {
            using (Stream fileStream = File.OpenRead(fileName))
            {
                try
                {
                    return new BinaryFormatter().Deserialize(fileStream);
                }
                catch (Exception e)
                {
                    throw new Exception("Cannot get data from the file.", e);
                }
            }
        }

        /// <summary>
        /// Gets serialized object from a file.
        /// </summary>
        /// <typeparam name="T">Type of an object in the file.</typeparam>
        /// <param name="fileName">File where serialized object is stored.</param>
        /// <returns>Deserealized object of T type.</returns>
        public static T GetFromFile<T>(string fileName)
        {
            return (T)GetFromFile(fileName);
        }

        /// <summary>
        /// Loads data for the specified DataHolder.
        /// </summary>
        /// <param name="dataHolder">DataHolder that data is associated with.</param>
        public static void LoadData(DataHolder dataHolder)
        {
            dataHolder.StoredData = (IList)GetFromFile(dataHolder.FileName);
            DataLoaded(new DataLoadedSavedEventArgs(dataHolder.DataType, dataHolder.FileName));
        }

        /// <summary>
        /// Loads data of the specified DataType from the current corresponding file.
        /// </summary>
        /// <param name="dataType">A type of data to be loaded</param>
        public static void LoadData(DataTypes dataType)
        {
            LoadData(dataMapper[(int)dataType]);
        }

        /// <summary>
        /// Loads data of the specified DataType from the specified file (saving that filename for the further usage).
        /// </summary>
        /// <param name="dataType">A type of data to be loaded</param>
        /// <param name="fileName">A name of a file from which data is loaded</param>
        public static void LoadData(DataTypes dataType, string fileName)
        {
            DataHolder dataHolder = dataMapper[(int)dataType];
            dataHolder.FileName = fileName;
            LoadData(dataHolder);
        }

        /// <summary>
        /// Tries to load data of all DataTypes from existing corresponding files.
        /// </summary>
        public static void LoadAllAvailableData()
        {
            foreach (var dataHolder in dataMapper)
            {
                try
                {
                    LoadData(dataHolder);
                }
                catch { }
            }
        }

        /// <summary>
        /// Saves data associated with the specified DataHolder
        /// </summary>
        /// <param name="dataHolder">DataHolder that the data is associated with.</param>
        public static void SaveData(DataHolder dataHolder)
        {
            if (dataHolder.DataType == DataTypes.CrackTasks)
            {
                CrackTasks.ClearEvents();
            }

            SaveToFile(dataHolder.StoredData, dataHolder.FileName);
            DataSaved(new DataLoadedSavedEventArgs(dataHolder.DataType, dataHolder.FileName));
        }

        /// <summary>
        /// Saves data of the specified DataType to the corresponding file.
        /// </summary>
        /// <param name="dataType">A type of data to be saved.</param>
        public static void SaveData(DataTypes dataType)
        {
            SaveData(dataMapper[(int)dataType]);
        }

        /// <summary>
        /// Saves data of the specified DataType to the specified file.
        /// </summary>
        /// <param name="dataType">A type of data to be saved.</param>
        /// <param name="fileName">A name of a file to which data is saved.</param>
        public static void SaveData(DataTypes dataType, string fileName)
        {
            DataHolder dataHolder = dataMapper[(int)dataType];
            dataHolder.FileName = fileName;
            SaveData(dataHolder);
        }

        /// <summary>
        /// Tries to save all existsing data to the corresponding files.
        /// </summary>
        public static void SaveAllData()
        {
            foreach (var dataHolder in dataMapper)
            {
                SaveData(dataHolder);
            }
        }

        /// <summary>
        /// Adds specified data of the specified DataType.
        /// </summary>
        /// <param name="dataType">A type of a data to be added.</param>
        /// <param name="data">Data to be added.</param>
        public static void AddData(DataTypes dataType, object data)
        {
            dataMapper[(int)dataType].StoredData.Add(data);
        }
    }
}