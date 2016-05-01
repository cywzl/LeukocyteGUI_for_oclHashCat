using System;
using System.Collections.Generic;

namespace LeukocyteGUI_for_oclHashcat
{
    public enum CrackStatuses
    {
        Stopped,
        Paused,
        Cracking,
        Cracked,
        Exausted,
        Queued
    }
    public enum AttackModes
    {
        Straight = 0,
        Combination = 1,
        BruteForce = 3,
        DictPlusMask = 6,
        MaskPlusDict = 7
    }
    public enum WorkloadProfiles
    {
        Reduced = 1,
        Default = 2,
        Tuned = 3
    }
    public enum DebugModes
    {
        NoDebug = 0,
        SaveFindingRule = 1,
        SaveOriginalWord = 2,
        SaveOriginalWordAndRule = 3,
        SaveOriginalWordRuleAndModifiedPlain = 4
    }

    [Serializable()]
    public class HashType
    {
        /// <summary>
        /// An oclHashcat HashType name or description
        /// </summary>
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
        private string name;

        /// <summary>
        /// An oclHashcat HashType code
        /// </summary>
        public int Code
        {
            get
            {
                return code;
            }
            set
            {
                if(code < 0)
                {
                    throw new ArgumentOutOfRangeException("HashType Code must be 0 or bigger.");
                }

                code = value;
            }
        }
        private int code;

        public HashType(string name, int code)
        {
            Name = name;
            Code = code;
        }
    }
    [Serializable()]
    public class MiscSettings
    {
        /// <summary>
        /// Assume charset is given in hex
        /// </summary>
        public bool HexCharset
        {
            get
            {
                return hexCharset;
            }
            set
            {
                hexCharset = value;
            }
        }
        private bool hexCharset;

        /// <summary>
        /// Assume salt is given in hex
        /// </summary>
        public bool HexSalt
        {
            get
            {
                return hexSalt;
            }
            set
            {
                hexSalt = value;
            }
        }
        private bool hexSalt;

        /// <summary>
        /// Assume words in wordlist is given in hex
        /// </summary>
        public bool HexWordlist
        {
            get
            {
                return hexWordlist;
            }
            set
            {
                hexWordlist = value;
            }
        }
        private bool hexWordlist;

        /// <summary>
        /// Ignore warnings
        /// </summary>
        public bool Force
        {
            get
            {
                return force;
            }
            set
            {
                force = value;
            }
        }
        private bool force;

        /// <summary>
        /// Add new plains to induct directory
        /// </summary>
        public bool Loopback
        {
            get
            {
                return loopback;
            }
            set
            {
                loopback = value;
            }
        }
        private bool loopback;

        /// <summary>
        /// Threshold when to stop checking for weak hashes, default is 100 salts
        /// </summary>
        public int WeakHashThreshold
        {
            get
            {
                return weakHashThreshold;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("WeakHashThreshold should be a positive integer value or -1 if not used.");
                }

                weakHashThreshold = value;
            }
        }
        private int weakHashThreshold = -1;

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>MiscSettings objects</returns>
        public MiscSettings DeepCopy()
        {
            return (MiscSettings)MemberwiseClone();
        }
    }
    [Serializable()]
    public class MarkovSettings
    {
        /// <summary>
        /// Specify hcstat file to use, default is hashcat.hcstat
        /// </summary>
        public string MarkovHcstat
        {
            get
            {
                return markovHcstat;
            }
            set
            {
                markovHcstat = value;
            }
        }
        private string markovHcstat = "";

        /// <summary>
        /// Disables markov-chains, emulates classic brute-force
        /// </summary>
        public bool MarkovDisable
        {
            get
            {
                return markovDisable;
            }
            set
            {
                markovDisable = value;
            }
        }
        private bool markovDisable;

        /// <summary>
        /// Enables classic markov-chains, no per-position enhancement
        /// </summary>
        public bool MarkovClassic
        {
            get
            {
                return markovClassic;
            }
            set
            {
                markovClassic = value;
            }
        }
        private bool markovClassic;

        /// <summary>
        /// Threshold when to stop accepting new markov-chains
        /// </summary>
        public int MarkovThreshold
        {
            get
            {
                return markovThreshold;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("MarkovThreshold should be a positive integer value or -1 if not used.");
                }

                markovThreshold = value;
            }
        }
        private int markovThreshold = -1;

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>MarkovSettings object</returns>
        public MarkovSettings DeepCopy()
        {
            return (MarkovSettings)MemberwiseClone();
        }
    }
    [Serializable()]
    public class SessionSettings
    {
        /// <summary>
        /// Abort session after NUM seconds of runtime
        /// </summary>
        public int RunTime
        {
            get
            {
                return runTime;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("RunTime should be a positive integer value or -1 if not used.");
                }

                runTime = value;
            }
        }
        private int runTime = -1;

        /// <summary>
        /// Define specific session name
        /// </summary>
        public string Session
        {
            get
            {
                return session;
            }
            set
            {
                session = value;
            }
        }
        private string session = "";

        /// <summary>
        /// Restore session from <see cref="Session"/>
        /// </summary>
        public bool Restore
        {
            get
            {
                return restore;
            }
            set
            {
                restore = value;
            }
        }
        private bool restore;

        /// <summary>
        /// Do not write restore file
        /// </summary>
        public bool RestoreDisable
        {
            get
            {
                return restoreDisable;
            }
            set
            {
                restoreDisable = value;
            }
        }
        private bool restoreDisable;

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>SessionSettings object</returns>
        public SessionSettings DeepCopy()
        {
            return (SessionSettings)MemberwiseClone();
        }
    }
    [Serializable()]
    public class FilesSettings
    {
        /// <summary>
        /// Define outfile for recovered hash
        /// </summary>
        public string OutFile
        {
            get
            {
                return outFile;
            }
            set
            {
                outFile = value;
            }
        }
        private string outFile = "";

        /// <summary>
        /// Define outfile-format for recovered hash
        /// </summary>
        public int OutFileFormat
        {
            get
            {
                return outFileFormat;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("OutFileFormat should be a positive integer value or -1 if not used.");
                }

                outFileFormat = value;
            }
        }
        private int outFileFormat = -1;

        /// <summary>
        /// Disable the use of $HEX[] in output plains
        /// </summary>
        public bool OutFileAutoHexDisable
        {
            get
            {
                return outFileAutoHexDisable;
            }
            set
            {
                outFileAutoHexDisable = value;
            }
        }
        private bool outFileAutoHexDisable;

        /// <summary>
        /// Seconds between outfile checks
        /// </summary>
        public int OutFileCheckTimer
        {
            get
            {
                return outFileCheckTimer;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("OutFileCheckTimer should be a positive integer value or -1 if not used.");
                }

                outFileCheckTimer = value;
            }
        }
        private int outFileCheckTimer = -1;

        /// <summary>
        /// Separator char for hashlists and outfile
        /// </summary>
        public char Separator
        {
            get
            {
                return separator;
            }
            set
            {
                separator = value;
            }
        }
        private char separator;

        /// <summary>
        /// Show cracked passwords only
        /// </summary>
        public bool ShowCrackedPasswordsOnly
        {
            get
            {
                return showCrackedPasswordsOnly;
            }
            set
            {
                showCrackedPasswordsOnly = value;
            }
        }
        private bool showCrackedPasswordsOnly;

        /// <summary>
        /// Show un-cracked passwords only
        /// </summary>
        public bool ShowUncrackedPasswordsOnly
        {
            get
            {
                return showUncrackedPasswordsOnly;
            }
            set
            {
                showUncrackedPasswordsOnly = value;
            }
        }
        private bool showUncrackedPasswordsOnly;

        /// <summary>
        /// Enable ignoring of usernames in hashfile (recommended: also use <see cref="ShowCrackedPasswordsOnly"/>)
        /// </summary>
        public bool EnableIgnoringUsernames
        {
            get
            {
                return enableIgnoringUsernames;
            }
            set
            {
                enableIgnoringUsernames = value;
            }
        }
        private bool enableIgnoringUsernames;

        /// <summary>
        /// Enable remove of hash once it is cracked
        /// </summary>
        public bool RemoveCrackedHashes
        {
            get
            {
                return removeCrackedHashes;
            }
            set
            {
                removeCrackedHashes = value;
            }
        }
        private bool removeCrackedHashes;

        /// <summary>
        /// Update input hash file each NUM seconds
        /// </summary>
        public int RemoveTimer
        {
            get
            {
                return removeTimer;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("RemoveTimer should be a positive integer value or -1 if not used.");
                }

                removeTimer = value;
            }
        }
        private int removeTimer = -1;

        /// <summary>
        /// Do not write potfile
        /// </summary>
        public bool PotfileDisable
        {
            get
            {
                return potfileDisable;
            }
            set
            {
                potfileDisable = value;
            }
        }
        private bool potfileDisable;

        /// <summary>
        /// Defines the debug mode (hybrid only by using rules)
        /// </summary>
        public DebugModes DebugMode
        {
            get
            {
                return debugMode;
            }
            set
            {
                debugMode = value;
            }
        }
        private DebugModes debugMode = DebugModes.NoDebug;

        /// <summary>
        /// Output file for debugging rules
        /// </summary>
        /// <seealso cref="DebugMode"/>
        public string DebugFile
        {
            get
            {
                return debugFile;
            }
            set
            {
                debugFile = value;
            }
        }
        private string debugFile = "";

        /// <summary>
        /// Specify induction directory to use, default is $session.induct
        /// </summary>
        public string InductionDir
        {
            get
            {
                return inductionDir;
            }
            set
            {
                inductionDir = value;
            }
        }
        private string inductionDir = "";

        /// <summary>
        /// Specify the outfile directory which should be monitored, default is $session.outfiles
        /// </summary>
        public string OutFileCheckDir
        {
            get
            {
                return outFileCheckDir;
            }
            set
            {
                outFileCheckDir = value;
            }
        }
        private string outFileCheckDir = "";

        /// <summary>
        /// Disable the logfile
        /// </summary>
        public bool LogFileDisable
        {
            get
            {
                return logFileDisable;
            }
            set
            {
                logFileDisable = value;
            }
        }
        private bool logFileDisable;

        /// <summary>
        /// Keyfiles used
        /// </summary>
        public List<string> TrueCryptKeyFiles
        {
            get
            {
                return trueCryptKeyFiles;
            }
            set
            {
                trueCryptKeyFiles = value;
            }
        }
        private List<string> trueCryptKeyFiles = new List<string>();

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>FilesSettings object</returns>
        public FilesSettings DeepCopy()
        {
            return (FilesSettings)MemberwiseClone();
        }
    }
    [Serializable()]
    public class ResourcesSettings
    {
        /// <summary>
        /// Size in MB to cache from the wordfile
        /// </summary>
        public int SegmentSize
        {
            get
            {
                return segmentSize;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("SegmentSize should be a positive integer value or -1 if not used.");
                }

                segmentSize = value;
            }
        }
        private int segmentSize = -1;

        /// <summary>
        /// Minimum number of bits allowed for bitmaps
        /// </summary>
        public int BitmapMin
        {
            get
            {
                return bitmapMin;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("BitmapMin should be a positive integer value.");
                }

                bitmapMin = value;
            }
        }
        private int bitmapMin = -1;

        /// <summary>
        /// Maximum number of bits allowed for bitmaps
        /// </summary>
        public int BitmapMax
        {
            get
            {
                return bitmapMax;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("BitmapMax should be a positive integer value or -1 if not used.");
                }

                bitmapMax = value;
            }
        }
        private int bitmapMax = -1;

        /// <summary>
        /// Locks to CPU devices
        /// </summary>
        public List<string> CpuAffinity
        {
            get
            {
                return cpuAffinity;
            }
            set
            {
                cpuAffinity = value;
            }
        }
        private List<string> cpuAffinity = new List<string>();

        /// <summary>
        /// Use non-blocking async calls (NV only)
        /// </summary>
        public bool GpuAsync
        {
            get
            {
                return gpuAsync;
            }
            set
            {
                gpuAsync = value;
            }
        }
        private bool gpuAsync;

        /// <summary>
        /// Devices to use
        /// </summary>
        public List<string> GpuDevices
        {
            get
            {
                return gpuDevices;
            }
            set
            {
                gpuDevices = value;
            }
        }
        private List<string> gpuDevices = new List<string>();

        /// <summary>
        /// Enable a specific workload profile
        /// </summary>
        public WorkloadProfiles WorkloadProfile
        {
            get
            {
                return workloadProfile;
            }
            set
            {
                workloadProfile = value;
            }
        }
        private WorkloadProfiles workloadProfile = WorkloadProfiles.Default;

        /// <summary>
        /// Workload tuning: 1, 8, 40, 80, 160
        /// </summary>
        public int GpuAcceleration
        {
            get
            {
                return gpuAcceleration;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GpuAcceleration should be a positive integer value or -1 if not used.");
                }

                gpuAcceleration = value;
            }
        }
        private int gpuAcceleration = -1;

        /// <summary>
        /// Workload fine-tuning: 8 - 1024
        /// </summary>
        public int GpuLoops
        {
            get
            {
                return gpuLoops;
            }
            set
            {
                if (((value < 8) || (value > 1024)) && (value != -1))
                {
                    throw new ArgumentOutOfRangeException("GpuLoops should be from 8 to 1024 or -1 if not used.");
                }

                gpuLoops = value;
            }
        }
        private int gpuLoops = -1;

        /// <summary>
        /// Disable temperature and fanspeed readings and triggers
        /// </summary>
        public bool GpuTempDisable
        {
            get
            {
                return gpuTempDisable;
            }
            set
            {
                gpuTempDisable = value;
            }
        }
        private bool gpuTempDisable;

        /// <summary>
        /// Abort session if GPU temperature reaches NUM degrees celsius
        /// </summary>
        public int GpuTempAbort
        {
            get
            {
                return gpuTempAbort;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GpuTempAbort should be a positive integer value or -1 if not used.");
                }

                gpuTempAbort = value;
            }
        }
        private int gpuTempAbort = -1;

        /// <summary>
        /// Try to retain GPU temperature at NUM degrees celsius (AMD only)
        /// </summary>
        public int GpuTempRetain
        {
            get
            {
                return gpuTempRetain;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GpuTempRetain should be a positive integer value or -1 if not used.");
                }

                gpuTempRetain = value;
            }
        }
        private int gpuTempRetain = -1;

        /// <summary>
        /// Enable automatic power tuning option (AMD OverDrive 6 only)
        /// </summary>
        public bool PowertuneEnable
        {
            get
            {
                return powertuneEnable;
            }
            set
            {
                powertuneEnable = value;
            }
        }
        private bool powertuneEnable;

        /// <summary>
        /// Manually override automatically calculated TMTO value for scrypt
        /// </summary>
        public int ScriptTMTO
        {
            get
            {
                return scriptTMTO;
            }
            set
            {
                scriptTMTO = value;
            }
        }
        private int scriptTMTO = -1;

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>ResourcesSettings object</returns>
        public ResourcesSettings DeepCopy()
        {
            return (ResourcesSettings)MemberwiseClone();
        }
    }
    [Serializable()]
    public class DistributedSettings
    {
        /// <summary>
        /// Skip number of words
        /// </summary>
        public int Skip
        {
            get
            {
                return skip;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("Skip should be a positive integer value or -1 if not used.");
                }

                skip = value;
            }
        }
        private int skip = -1;

        /// <summary>
        /// Limit number of words
        /// </summary>
        public int Limit
        {
            get
            {
                return limit;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("Limit should be a positive integer value or -1 if not used.");
                }

                limit = value;
            }
        }
        private int limit = -1;

        /// <summary>
        /// Show keyspace base:mod values and quit
        /// </summary>
        public bool Keyspace
        {
            get
            {
                return keyspace;
            }
            set
            {
                keyspace = value;
            }
        }
        private bool keyspace;

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>DistributedSettings object</returns>
        public DistributedSettings DeepCopy()
        {
            return (DistributedSettings)MemberwiseClone();
        }
    }
    [Serializable()]
    public class RulesSettings
    {
        /// <summary>
        /// Single rule applied to each word from left dict
        /// </summary>
        public string RuleLeft
        {
            get
            {
                return ruleLeft;
            }
            set
            {
                ruleLeft = value;
            }
        }
        private string ruleLeft = "";

        /// <summary>
        /// Single rule applied to each word from right dict
        /// </summary>
        public string RuleRight
        {
            get
            {
                return ruleRight;
            }
            set
            {
                ruleRight = value;
            }
        }
        private string ruleRight = "";

        /// <summary>
        /// Rules-files
        /// </summary>
        public List<string> RulesFiles
        {
            get
            {
                return rulesFiles;
            }
            set
            {
                rulesFiles = value;
            }
        }
        private List<string> rulesFiles = new List<string>();

        /// <summary>
        /// Generate NUM random rules
        /// </summary>
        public int GenerateRules
        {
            get
            {
                return generateRules;
            }
            set
            {
               if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GenerateRules should be a positive integer value or -1 if not used.");
                }

                generateRules = value;
            }
        }
        private int generateRules = -1;

        /// <summary>
        /// Force NUM functions per random rule min
        /// </summary>
        public int GenerateRulesFuncMin
        {
            get
            {
                return generateRulesFuncMin;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GenerateRulesFuncMin should be a positive integer value or -1 if not used.");
                }

                generateRulesFuncMin = value;
            }
        }
        private int generateRulesFuncMin = -1;

        /// <summary>
        /// Force NUM functions per random rule max
        /// </summary>
        public int GenerateRulesFuncMax
        {
            get
            {
                return generateRulesFuncMax;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GenerateRulesFuncMax should be a positive integer value or -1 if not used.");
                }

                generateRulesFuncMax = value;
            }
        }
        private int generateRulesFuncMax = -1;

        /// <summary>
        /// Force RNG seed to NUM
        /// </summary>
        public int GenerateRulesSeed
        {
            get
            {
                return generateRulesSeed;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GenerateRulesSeed should be a positive integer value or -1 if not used.");
                }

                generateRulesSeed = value;
            }
        }
        private int generateRulesSeed = -1;

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>RulesSettings object</returns>
        public RulesSettings DeepCopy()
        {
            return (RulesSettings)MemberwiseClone();
        }
    }
    [Serializable()]
    public class CustomCharsetsSettings
    {
        /// <summary>
        /// User-defined charset 1
        /// </summary>
        public string Charset1
        {
            get
            {
                return charset1;
            }
            set
            {
                charset1 = value;
            }
        }
        private string charset1 = "";

        /// <summary>
        /// User-defined charset 2
        /// </summary>
        public string Charset2
        {
            get
            {
                return charset2;
            }
            set
            {
                charset2 = value;
            }
        }
        private string charset2 = "";

        /// <summary>
        /// User-defined charset 3
        /// </summary>
        public string Charset3
        {
            get
            {
                return charset3;
            }
            set
            {
                charset3 = value;
            }
        }
        private string charset3 = "";

        /// <summary>
        /// User-defined charset 4
        /// </summary>
        public string Charset4
        {
            get
            {
                return charset4;
            }
            set
            {
                charset4 = value;
            }
        }
        private string charset4 = "";

        /// <summary>
        /// Enables or disables usage of the user-defined charset 1
        /// </summary>
        public bool UseCharset1
        {
            get
            {
                return useCharset1;
            }
            set
            {
                useCharset1 = value;
            }
        }
        private bool useCharset1;

        /// <summary>
        /// Enables or disables usage of the user-defined charset 2
        /// </summary>
        public bool UseCharset2
        {
            get
            {
                return useCharset2;
            }
            set
            {
                useCharset2 = value;
            }
        }
        private bool useCharset2;

        /// <summary>
        /// Enables or disables usage of the user-defined charset 3
        /// </summary>
        public bool UseCharset3
        {
            get
            {
                return useCharset3;
            }
            set
            {
                useCharset3 = value;
            }
        }
        private bool useCharset3;

        /// <summary>
        /// Enables or disables usage of the user-defined charset 4
        /// </summary>
        public bool UseCharset4
        {
            get
            {
                return useCharset4;
            }
            set
            {
                useCharset4 = value;
            }
        }
        private bool useCharset4;

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>CustomCharsetsSettings object</returns>
        public CustomCharsetsSettings DeepCopy()
        {
            return (CustomCharsetsSettings)MemberwiseClone();
        }
    }
    [Serializable()]
    public class IncrementSettings
    {
        /// <summary>
        /// Enable increment mode
        /// </summary>
        public bool Increment
        {
            get
            {
                return increment;
            }
            set
            {
                increment = value;
            }
        }
        private bool increment;

        /// <summary>
        /// Start incrementing at NUM
        /// </summary>
        public int IncrementMin
        {
            get
            {
                return incrementMin;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("IncrementMin should be a positive integer value or -1 if not used.");
                }

                incrementMin = value;
            }
        }
        private int incrementMin = -1;

        /// <summary>
        /// Stop incrementing at NUM
        /// </summary>
        public int IncrementMax
        {
            get
            {
                return incrementMax;
            }
            set
            {
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("IncrementMax should be a positive integer value or -1 if not used.");
                }

                incrementMax = value;
            }
        }
        private int incrementMax = -1;

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>IncrementSettings object</returns>
        public IncrementSettings DeepCopy()
        {
            return (IncrementSettings)MemberwiseClone();
        }
    }

    [Serializable()]
    public class CrackTask
    {
        /// <summary>
        /// Indicates whether CrackTask is being cracked now.
        /// </summary>
        public bool IsRunning { get; set; }

        /* General */
        
        /// <summary>
        /// Target to crack
        /// </summary>
        public string CrackTarget
        {
            get
            {
                return crackTarget;
            }
            set
            {
                if(IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                crackTarget = value;
            }
        }
        private string crackTarget = "";

        /// <summary>
        /// Hash-type
        /// </summary>
        public HashType HashType
        {
            get
            {
                return hashType;
            }
            set
            {
                hashType = value;
            }
        }
        private HashType hashType = new HashType("", 0);

        /// <summary>
        /// Attack-mode
        /// </summary>
        public AttackModes AttackMode
        {
            get
            {
                return attackMode;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                attackMode = value;
            }
        }
        private AttackModes attackMode = AttackModes.Straight;

        /// <summary>
        /// Dictionary, mask or directory (left)
        /// </summary>
        public string CrackDataSourceLeft
        {
            get
            {
                return crackDataSourceLeft;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                crackDataSourceLeft = value;
            }
        }
        private string crackDataSourceLeft = "";

        /// <summary>
        /// Dictionary, mask or directory (right)
        /// </summary>
        public string CrackDataSourceRight
        {
            get
            {
                return crackDataSourceRight;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                crackDataSourceRight = value;
            }
        }
        private string crackDataSourceRight = "";

        /* Hashcat settings */

        /// <summary>
        /// Gets or sets Misc settings for oclHashcat
        /// </summary>
        public MiscSettings MiscSettings
        {
            get
            {
                return miscSettings;
            }
            set
            {
                miscSettings = value;
            }
        }
        private MiscSettings miscSettings = new MiscSettings();

        /// <summary>
        /// Gets or sets Markov settings for oclHashcat
        /// </summary>
        public MarkovSettings MarkovSettings
        {
            get
            {
                return markovSettings;
            }
            set
            {
                markovSettings = value;
            }
        }
        private MarkovSettings markovSettings = new MarkovSettings();

        /// <summary>
        /// Gets or sets Session settings for oclHashcat
        /// </summary>
        public SessionSettings SessionSettings
        {
            get
            {
                return sessionSettings;
            }
            set
            {
                sessionSettings = value;
            }
        }
        private SessionSettings sessionSettings = new SessionSettings();

        /// <summary>
        /// Gets or sets Files settings for oclHashcat
        /// </summary>
        public FilesSettings FilesSettings
        {
            get
            {
                return filesSettings;
            }
            set
            {
                filesSettings = value;
            }
        }
        private FilesSettings filesSettings = new FilesSettings();

        /// <summary>
        /// Gets or sets Resources settings for oclHashcat
        /// </summary>
        public ResourcesSettings ResourcesSettings
        {
            get
            {
                return resourcesSettings;
            }
            set
            {
                resourcesSettings = value;
            }
        }
        private ResourcesSettings resourcesSettings = new ResourcesSettings();

        /// <summary>
        /// Gets or sets Distributed settings for oclHashcat
        /// </summary>
        public DistributedSettings DistributedSettings
        {
            get
            {
                return distributedSettings;
            }
            set
            {
                distributedSettings = value;
            }
        }
        private DistributedSettings distributedSettings = new DistributedSettings();

        /// <summary>
        /// Gets or sets Rules settings for oclHashcat
        /// </summary>
        public RulesSettings RulesSettings
        {
            get
            {
                return rulesSettings;
            }
            set
            {
                rulesSettings = value;
            }
        }
        private RulesSettings rulesSettings = new RulesSettings();

        /// <summary>
        /// Gets or sets CustomCharsets settings for oclHashcat
        /// </summary>
        public CustomCharsetsSettings CustomCharsetsSettings
        {
            get
            {
                return customCharsetsSettings;
            }
            set
            {
                customCharsetsSettings = value;
            }
        }
        private CustomCharsetsSettings customCharsetsSettings = new CustomCharsetsSettings();

        /// <summary>
        /// Gets or sets Increment settings for oclHashcat
        /// </summary>
        public IncrementSettings IncrementSettings
        {
            get
            {
                return incrementSettings;
            }
            set
            {
                incrementSettings = value;
            }
        }
        private IncrementSettings incrementSettings = new IncrementSettings();

        /* Other */

        /// <summary>
        /// Recovered plain data
        /// </summary>
        public string Plain
        {
            get
            {
                return plain;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                plain = value;
            }
        }
        private string plain = "";

        /// <summary>
        /// Current crack status of the task
        /// </summary>
        public CrackStatuses CrackStatus
        {
            get
            {
                return crackStatus;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                crackStatus = value;
            }
        }
        private CrackStatuses crackStatus = CrackStatuses.Stopped;

        /// <summary>
        /// Current length of the mask
        /// </summary>
        public byte CurrentLength
        {
            get
            {
                return currentLength;
            }
            set
            {
                currentLength = value;
            }
        }
        private byte currentLength;

        /// <summary>
        /// Estimated time left to finish the task
        /// </summary>
        public string TimeEstimated
        {
            get
            {
                return timeEstimated;
            }
            set
            {
                timeEstimated = value;
            }
        }
        private string timeEstimated = "";

        /// <summary>
        /// Total number of digests
        /// </summary>
        public int Digests
        {
            get
            {
                return digests;
            }
            set
            {
                digests = value;
            }
        }
        private int digests;

        /// <summary>
        /// Number of recovered digests
        /// </summary>
        public int RecoveredDigests
        {
            get
            {
                return recoveredDigests;
            }
            set
            {
                recoveredDigests = value;
            }
        }
        private int recoveredDigests;

        /// <summary>
        /// Total number of salts
        /// </summary>
        public int Salts
        {
            get
            {
                return salts;
            }
            set
            {
                salts = value;
            }
        }
        private int salts;

        /// <summary>
        /// Number of recovered salts
        /// </summary>
        public int RecoveredSalts
        {
            get
            {
                return recoveredSalts;
            }
            set
            {
                recoveredSalts = value;
            }
        }
        private int recoveredSalts;

        /// <summary>
        /// Current cracking progress
        /// </summary>
        public float Progress
        {
            get
            {
                return progress;
            }
            set
            {
                progress = value;
            }
        }
        private float progress;

        /// <summary>
        /// Time the task cracking process started
        /// </summary>
        public DateTime Started
        {
            get
            {
                return started;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                started = value;
            }
        }
        private DateTime started;

        /// <summary>
        /// Time the task cracking process finished
        /// </summary>
        public DateTime Finished
        {
            get
            {
                return finished;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                finished = value;
            }
        }
        private DateTime finished;

        /// <summary>
        /// Generates string of arguments for oclHashcat
        /// </summary>
        /// <returns>String of arguments for oclHashcat</returns>
        public override string ToString()
        {
            if(SessionSettings.Restore)
            {
                return "--restore " + ((SessionSettings.Session != "") ? ("--session=" + SessionSettings.Session) : "");
            }

            return

            // General
            "-a "  + (int)attackMode +
            " -m " + hashType.Code   +

            // Misc
            (MiscSettings.HexCharset                            ? " --hex-charset"                                                  : "") +
            (MiscSettings.HexSalt                               ? " --hex-salt"                                                     : "") +
            (MiscSettings.HexWordlist                           ? " --hex-wordlist"                                                 : "") +
            (MiscSettings.Force                                 ? " --force"                                                        : "") +
            (MiscSettings.Loopback                              ? " --loopback"                                                     : "") +
            ((MiscSettings.WeakHashThreshold > -1)              ? " --weak-hash-threshold="     + MiscSettings.WeakHashThreshold    : "") +

            // Markov
            ((MarkovSettings.MarkovHcstat != "")                ? " --markov-hcstat="           + MarkovSettings.MarkovHcstat       : "") +
            (MarkovSettings.MarkovDisable                       ? " --markov-disable"                                               : "") +
            (MarkovSettings.MarkovClassic                       ? " --markov-classic"                                               : "") +
            ((MarkovSettings.MarkovThreshold > -1)              ? " --markov-threshold="        + MarkovSettings.MarkovThreshold    : "") +

            // Session
            ((SessionSettings.RunTime > -1)                     ? " --runtime="                 + SessionSettings.RunTime           : "") +
            ((SessionSettings.Session != "")                    ? " --session="                 + SessionSettings.Session                               : "") +
            (SessionSettings.RestoreDisable                     ? " --restore-disable"                                              : "") +

            // Files
            ((FilesSettings.OutFile != "")                      ? " --outfile="                 + FilesSettings.OutFile                               : "") +
            ((FilesSettings.OutFileFormat > -1)                 ? " --runtime="                 + FilesSettings.OutFileFormat                         : "") +
            (FilesSettings.OutFileAutoHexDisable                ? " --outfile-format="                                              : "") +
            ((FilesSettings.OutFileCheckTimer > -1)             ? " --outfile-check-timer="     + FilesSettings.OutFileCheckTimer                     : "") +
            ((FilesSettings.Separator != '\0')                  ? " --separator="               + FilesSettings.Separator                             : "") +
            (FilesSettings.ShowCrackedPasswordsOnly             ? " --show"                                                         : "") +
            (FilesSettings.ShowUncrackedPasswordsOnly           ? " --left"                                                         : "") +
            (FilesSettings.EnableIgnoringUsernames              ? " --username"                                                     : "") +
            (FilesSettings.RemoveCrackedHashes                  ? " --remove"                                                       : "") +
            ((FilesSettings.RemoveTimer > -1)                   ? " --remove-timer="            + FilesSettings.RemoveTimer                           : "") +
            (FilesSettings.PotfileDisable                       ? " --potfile-disable"                                              : "") +
            ((FilesSettings.DebugMode != DebugModes.NoDebug)    ? " --debug-mode="              + FilesSettings.DebugMode                             : "") +
            ((FilesSettings.DebugFile != "")                    ? " --debug-file="              + FilesSettings.DebugFile                             : "") +
            ((FilesSettings.InductionDir != "")                 ? " --induction-dir="           + FilesSettings.InductionDir                          : "") +
            ((FilesSettings.OutFileCheckDir != "")              ? " --outfile-check-dir="       + FilesSettings.OutFileCheckDir                       : "") +
            (FilesSettings.LogFileDisable                       ? " --logfile-disable"                                              : "") +
            ((FilesSettings.TrueCryptKeyFiles.Count > 0)        ? " --truecrypt-keyfiles="      + string.Join(",",
                                                                                                    FilesSettings.TrueCryptKeyFiles): "") +

            // Resources
            ((ResourcesSettings.SegmentSize > -1)               ? " --segment-size="            + ResourcesSettings.SegmentSize                           : "") +
            ((ResourcesSettings.BitmapMin > -1)                 ? " --bitmap-min="              + ResourcesSettings.BitmapMin                             : "") +
            ((ResourcesSettings.BitmapMax > -1)                 ? " --bitmap-max="              + ResourcesSettings.BitmapMax                             : "") +
            ((ResourcesSettings.CpuAffinity.Count > 0)          ? " --cpu-affinity="            + string.Join(",",
                                                                                                    ResourcesSettings.CpuAffinity)  : "") +
            (ResourcesSettings.GpuAsync                         ? " --gpu-async"                                                    : "") +
            ((ResourcesSettings.GpuDevices.Count > 0)           ? " --gpu-devices="             + string.Join(",",
                                                                                                    ResourcesSettings.GpuDevices)   : "") +
                                                                  " --workload-profile="        + (int)ResourcesSettings.WorkloadProfile  +
            ((ResourcesSettings.GpuAcceleration > -1)           ? " --gpu-accel="               + ResourcesSettings.GpuAcceleration : "") +
            ((ResourcesSettings.GpuLoops > -1)                  ? " --gpu-loops="               + ResourcesSettings.GpuLoops        : "") +
            (ResourcesSettings.GpuTempDisable                   ? " --gpu-temp-disable"                                             : "") +
            ((ResourcesSettings.GpuTempAbort > -1)              ? " --gpu-temp-abort="          + ResourcesSettings.GpuTempAbort    : "") +
            ((ResourcesSettings.GpuTempRetain > -1)             ? " --gpu-temp-retain="         + ResourcesSettings.GpuTempRetain   : "") +
            (ResourcesSettings.PowertuneEnable                  ? " --powertune-enable"                                             : "") +
            ((ResourcesSettings.ScriptTMTO > -1)                ? " --scrypt-tmto="             + ResourcesSettings.ScriptTMTO      : "") +

            // Distributed
            ((DistributedSettings.Skip > -1)                    ? " --skip="                    + DistributedSettings.Skip          : "") +
            ((DistributedSettings.Limit > -1)                   ? " --limit="                   + DistributedSettings.Limit         : "") +
            (DistributedSettings.Keyspace                       ? " --keyspace"                                                     : "") +

            // Rules
            ((RulesSettings.RuleLeft != "")                     ? " --rule-left="               + RulesSettings.RuleLeft                              : "") +
            ((RulesSettings.RuleRight != "")                    ? " --rule-right="              + RulesSettings.RuleRight                             : "") +
            ((RulesSettings.RulesFiles.Count > 0)               ? " -r "                        + string.Join("-r ",
                                                                                                    RulesSettings.RulesFiles)       : "") +
            ((RulesSettings.GenerateRules > -1)                 ? " --generate-rules="          + RulesSettings.GenerateRules       : "") +
            ((RulesSettings.GenerateRulesFuncMin > -1)          ? " --generate-rules-func-min=" + RulesSettings.GenerateRulesFuncMin: "") +
            ((RulesSettings.GenerateRulesFuncMax > -1)          ? " --generate-rules-func-max=" + RulesSettings.GenerateRulesFuncMax: "") +
            ((RulesSettings.GenerateRulesSeed > -1)             ? " --generate-rules-seed="     + RulesSettings.GenerateRulesSeed   : "") +

            // Custom charsets
            (CustomCharsetsSettings.UseCharset1                 ? " --custom-charset1="         + CustomCharsetsSettings.Charset1   : "") +
            (CustomCharsetsSettings.UseCharset2                 ? " --custom-charset2="         + CustomCharsetsSettings.Charset2   : "") +
            (CustomCharsetsSettings.UseCharset3                 ? " --custom-charset3="         + CustomCharsetsSettings.Charset3   : "") +
            (CustomCharsetsSettings.UseCharset4                 ? " --custom-charset4="         + CustomCharsetsSettings.Charset4   : "") +

            // Increment
            (IncrementSettings.Increment                        ? " --increment"                                                    : "") +
            ((IncrementSettings.IncrementMin > -1)              ? " --increment-min="           + IncrementSettings.IncrementMin    : "") +
            ((IncrementSettings.IncrementMax > -1)              ? " --increment-max="           + IncrementSettings.IncrementMax    : "") +

            // Target Part
                                                                  " "                           + crackTarget                             +
                                                                  " "                           + crackDataSourceLeft                     +
            ((AttackMode == AttackModes.Combination)
            || (AttackMode == AttackModes.DictPlusMask)
            || (AttackMode == AttackModes.MaskPlusDict)         ? " "                           + crackDataSourceRight              : "");
        }

        /// <summary>
        /// Returns deep copy of the object
        /// </summary>
        /// <returns>CrackTask object</returns>
        public CrackTask DeepCopy()
        {
            CrackTask crackTaskCopy = (CrackTask)MemberwiseClone();

            crackTaskCopy.MiscSettings = miscSettings.DeepCopy();
            crackTaskCopy.MarkovSettings = markovSettings.DeepCopy();
            crackTaskCopy.SessionSettings = sessionSettings.DeepCopy();
            crackTaskCopy.FilesSettings = filesSettings.DeepCopy();
            crackTaskCopy.ResourcesSettings = resourcesSettings.DeepCopy();
            crackTaskCopy.DistributedSettings = distributedSettings.DeepCopy();
            crackTaskCopy.RulesSettings = rulesSettings.DeepCopy();
            crackTaskCopy.CustomCharsetsSettings = customCharsetsSettings.DeepCopy();
            crackTaskCopy.IncrementSettings = incrementSettings.DeepCopy();

            return crackTaskCopy;
        }

        /// <summary>
        /// Clears all cracking results, returns CrackTask to initial state.
        /// </summary>
        public void ClearResults()
        {
            crackStatus = CrackStatuses.Stopped;
            plain = "";
            progress = 0;
            currentLength = 0;
            recoveredDigests = 0;
            recoveredSalts = 0;
            timeEstimated = "";
            started = DateTime.MinValue;
            finished = DateTime.MinValue;
            sessionSettings.Restore = false;
        }
    }
}
