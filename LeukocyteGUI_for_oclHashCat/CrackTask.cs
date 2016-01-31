using System;
using System.Collections.Generic;

namespace LeukocyteGUI_for_oclHashCat
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
        private string crackTarget;

        /// <summary>
        /// Hash-type
        /// </summary>
        public int HashType
        {
            get
            {
                return hashType;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HashType should be a non-negative value.");
                }

                hashType = value;
            }
        }
        private int hashType = 0;

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
        /// Dictionary, mask or directory
        /// </summary>
        public string CrackDataSource
        {
            get
            {
                return crackDataSource;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                crackDataSource = value;
            }
        }
        private string crackDataSource;

        /* Misc */

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("WeakHashThreshold should be a positive integer value or -1 if not used.");
                }

                weakHashThreshold = value;
            }
        }
        private int weakHashThreshold = -1;

        /* Markov */

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                markovHcstat = value;
            }
        }
        private string markovHcstat;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("MarkovThreshold should be a positive integer value or -1 if not used.");
                }

                markovThreshold = value;
            }
        }
        private int markovThreshold = -1;

        /* Session */

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                session = value;
            }
        }
        private string session;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                restoreDisable = value;
            }
        }
        private bool restoreDisable;

        /* Files */

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                outFile = value;
            }
        }
        private string outFile;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                debugFile = value;
            }
        }
        private string debugFile;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                inductionDir = value;
            }
        }
        private string inductionDir;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                outFileCheckDir = value;
            }
        }
        private string outFileCheckDir;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                trueCryptKeyFiles = value;
            }
        }
        private List<string> trueCryptKeyFiles;

        /* Resources */

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                cpuAffinity = value;
            }
        }
        private List<string> cpuAffinity;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                gpuDevices = value;
            }
        }
        private List<string> gpuDevices;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                scriptTMTO = value;
            }
        }
        private int scriptTMTO = -1;

        /* Distributed */

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                return segmentSize;
            }
            set
            {
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("Limit should be a positive integer value or -1 if not used.");
                }

                segmentSize = value;
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                keyspace = value;
            }
        }
        private bool keyspace;

        /* Rules */

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                ruleLeft = value;
            }
        }
        private string ruleLeft;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                ruleRight = value;
            }
        }
        private string ruleRight;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                rulesFiles = value;
            }
        }
        private List<string> rulesFiles;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GenerateRulesFuncMin should be a positive integer value or -1 if not used.");
                }

                generateRulesFuncMin = value;
            }
        }
        private int generateRulesFuncMin;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GenerateRulesFuncMax should be a positive integer value or -1 if not used.");
                }

                generateRulesFuncMax = value;
            }
        }
        private int generateRulesFuncMax;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("GenerateRulesSeed should be a positive integer value or -1 if not used.");
                }

                generateRulesSeed = value;
            }
        }
        private int generateRulesSeed;

        /* Custom Charsets */

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                charset1 = value;
            }
        }
        private string charset1;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                charset2 = value;
            }
        }
        private string charset2;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                charset3 = value;
            }
        }
        private string charset3;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                charset4 = value;
            }
        }
        private string charset4;

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

                useCharset4 = value;
            }
        }
        private bool useCharset4;

        /* Increment */

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }

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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
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
                if (IsRunning)
                {
                    throw new InvalidOperationException("Cannot change CrackTask's property while it's being cracked.");
                }
                if ((value == 0) || (value < -1))
                {
                    throw new ArgumentOutOfRangeException("IncrementMax should be a positive integer value or -1 if not used.");
                }

                incrementMax = value;
            }
        }
        private int incrementMax = -1;

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
        private string plain;

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
        private string timeEstimated;

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
            return

                // General
                "-a "  + attackMode +
                " -m " + hashType   +

                // Misc
                (hexCharset                         ? " --hex-charset"                                                      : "") +
                (hexSalt                            ? " --hex-salt"                                                         : "") +
                (hexWordlist                        ? " --hex-wordlist"                                                     : "") +
                (force                              ? " --force"                                                            : "") +
                (loopback                           ? " --loopback"                                                         : "") +
                ((weakHashThreshold > -1)           ? " --weak-hash-threshold="     + weakHashThreshold                     : "") +

                // Markov
                ((markovHcstat != "")               ? " --markov-hcstat="           + markovHcstat                          : "") +
                (markovDisable                      ? " --markov-disable"                                                   : "") +
                (markovClassic                      ? " --markov-classic"                                                   : "") +
                ((markovThreshold > -1)             ? " --markov-threshold="        + markovThreshold                       : "") +

                // Session
                ((runTime > -1)                     ? " --runtime="                 + runTime                               : "") +
                ((session != "")                    ? " --session="                 + session                               : "") +
                (restore                            ? " --restore"                                                          : "") +
                (restoreDisable                     ? " --restore-disable"                                                  : "") +

                // Files
                ((outFile != "")                    ? " --outfile="                 + outFile                               : "") +
                ((outFileFormat > -1)               ? " --runtime="                 + outFileFormat                         : "") +
                (outFileAutoHexDisable              ? " --outfile-format="                                                  : "") +
                ((outFileCheckTimer > -1)           ? " --outfile-check-timer="     + outFileCheckTimer                     : "") +
                ((separator != '\0')                ? " --separator="               + separator                             : "") +
                (showCrackedPasswordsOnly           ? " --show"                                                             : "") +
                (showUncrackedPasswordsOnly         ? " --left"                                                             : "") +
                (enableIgnoringUsernames            ? " --username"                                                         : "") +
                (removeCrackedHashes                ? " --remove"                                                           : "") +
                ((removeTimer > -1)                 ? " --remove-timer="            + removeTimer                           : "") +
                (potfileDisable                     ? " --potfile-disable"                                                  : "") +
                ((debugMode != DebugModes.NoDebug)  ? " --debug-mode="              + debugMode                             : "") +
                ((debugFile != "")                  ? " --debug-file="              + debugFile                             : "") +
                ((inductionDir != "")               ? " --induction-dir="           + inductionDir                          : "") +
                ((outFileCheckDir != "")            ? " --outfile-check-dir="       + outFileCheckDir                       : "") +
                (logFileDisable                     ? " --logfile-disable"                                                  : "") +
                ((trueCryptKeyFiles.Count > 0)      ? " --truecrypt-keyfiles="      + string.Join(",", trueCryptKeyFiles)   : "") +

                // Resources
                ((segmentSize > -1)                 ? " --segment-size="            + segmentSize                           : "") +
                ((bitmapMin > -1)                   ? " --bitmap-min="              + bitmapMin                             : "") +
                ((bitmapMax > -1)                   ? " --bitmap-max="              + bitmapMax                             : "") +
                ((cpuAffinity.Count > 0)            ? " --cpu-affinity="            + string.Join(",", cpuAffinity)         : "") +
                (gpuAsync                           ? " --gpu-async"                                                        : "") +
                ((gpuDevices.Count > 0)             ? " --gpu-devices="             + string.Join(",", gpuDevices)          : "") +
                                                      " --workload-profile="        + workloadProfile                             +
                ((gpuAcceleration > -1)             ? " --gpu-accel="               + gpuAcceleration                       : "") +
                ((gpuLoops > -1)                    ? " --gpu-loops="               + gpuLoops                              : "") +
                (gpuTempDisable                     ? " --gpu-temp-disable"                                                 : "") +
                ((gpuTempAbort > -1)                ? " --gpu-temp-abort="          + gpuTempAbort                          : "") +
                ((gpuTempRetain > -1)               ? " --gpu-temp-retain="         + gpuTempRetain                         : "") +
                (powertuneEnable                    ? " --powertune-enable"                                                 : "") +
                ((scriptTMTO > -1)                  ? " --scrypt-tmto="             + scriptTMTO                            : "") +

                // Distributed
                ((skip > -1)                        ? " --skip="                    + skip                                  : "") +
                ((limit > -1)                       ? " --limit="                   + limit                                 : "") +
                (keyspace                           ? " --keyspace"                                                         : "") +

                // Rules
                ((ruleLeft != "")                   ? " --rule-left="               + ruleLeft                              : "") +
                ((ruleRight != "")                  ? " --rule-right="              + ruleRight                             : "") +
                ((rulesFiles.Count > 0)             ? " -r "                        + string.Join("-r ", rulesFiles)        : "") +
                ((generateRules > -1)               ? " --generate-rules="          + generateRules                         : "") +
                ((generateRulesFuncMin > -1)        ? " --generate-rules-func-min=" + generateRulesFuncMin                  : "") +
                ((generateRulesFuncMax > -1)        ? " --generate-rules-func-max=" + generateRulesFuncMax                  : "") +
                ((generateRulesSeed > -1)           ? " --generate-rules-seed="     + generateRulesSeed                     : "") +

                // Custom charsets
                (useCharset1                        ? " --custom-charset1="         + charset1                              : "") +
                (useCharset2                        ? " --custom-charset2="         + charset2                              : "") +
                (useCharset3                        ? " --custom-charset3="         + charset3                              : "") +
                (useCharset4                        ? " --custom-charset4="         + charset4                              : "") +

                // Increment
                (increment                          ? " --increment"                                                        : "") +
                ((incrementMin > -1)                ? " --increment-min="           + incrementMin                          : "") +
                ((incrementMax > -1)                ? " --increment-max="           + incrementMax                          : "") +

                // Target Part
                " " + crackTarget +
                " " + crackDataSource;
        }
    }
}
