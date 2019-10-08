using System;
using System.Collections.Generic;
using System.Text;

namespace dpz2.Orm {

    /// <summary>
    /// Orm表格信息集合
    /// </summary>
    public class Tables : dpz2.Object {

        // ActivityNew表对象缓存
        private Activity.ActivityNew _cacheActivityNew = null;

        /// <summary>
        /// 获取 ActivityNew 表定义
        /// </summary>
        public Activity.ActivityNew ActivityNew {
            get {
                if (_cacheActivityNew == null) _cacheActivityNew = new Activity.ActivityNew();
                return _cacheActivityNew;
            }
        }

        // AIWords表对象缓存
        private AI.AIWords _cacheAIWords = null;

        /// <summary>
        /// 获取 AIWords 表定义
        /// </summary>
        public AI.AIWords AIWords {
            get {
                if (_cacheAIWords == null) _cacheAIWords = new AI.AIWords();
                return _cacheAIWords;
            }
        }

        // AIMemory表对象缓存
        private AI.AIMemory _cacheAIMemory = null;

        /// <summary>
        /// 获取 AIMemory 表定义
        /// </summary>
        public AI.AIMemory AIMemory {
            get {
                if (_cacheAIMemory == null) _cacheAIMemory = new AI.AIMemory();
                return _cacheAIMemory;
            }
        }

        // AosObjects表对象缓存
        private Aos.AosObjects _cacheAosObjects = null;

        /// <summary>
        /// 获取 AosObjects 表定义
        /// </summary>
        public Aos.AosObjects AosObjects {
            get {
                if (_cacheAosObjects == null) _cacheAosObjects = new Aos.AosObjects();
                return _cacheAosObjects;
            }
        }

        // AosAuthorize表对象缓存
        private Aos.AosAuthorize _cacheAosAuthorize = null;

        /// <summary>
        /// 获取 AosAuthorize 表定义
        /// </summary>
        public Aos.AosAuthorize AosAuthorize {
            get {
                if (_cacheAosAuthorize == null) _cacheAosAuthorize = new Aos.AosAuthorize();
                return _cacheAosAuthorize;
            }
        }

        // AosAuthorizeCode表对象缓存
        private Aos.AosAuthorizeCode _cacheAosAuthorizeCode = null;

        /// <summary>
        /// 获取 AosAuthorizeCode 表定义
        /// </summary>
        public Aos.AosAuthorizeCode AosAuthorizeCode {
            get {
                if (_cacheAosAuthorizeCode == null) _cacheAosAuthorizeCode = new Aos.AosAuthorizeCode();
                return _cacheAosAuthorizeCode;
            }
        }

        // AosSessions表对象缓存
        private Aos.AosSessions _cacheAosSessions = null;

        /// <summary>
        /// 获取 AosSessions 表定义
        /// </summary>
        public Aos.AosSessions AosSessions {
            get {
                if (_cacheAosSessions == null) _cacheAosSessions = new Aos.AosSessions();
                return _cacheAosSessions;
            }
        }

        // AosSessionProcesses表对象缓存
        private Aos.AosSessionProcesses _cacheAosSessionProcesses = null;

        /// <summary>
        /// 获取 AosSessionProcesses 表定义
        /// </summary>
        public Aos.AosSessionProcesses AosSessionProcesses {
            get {
                if (_cacheAosSessionProcesses == null) _cacheAosSessionProcesses = new Aos.AosSessionProcesses();
                return _cacheAosSessionProcesses;
            }
        }

        // AosSessionValues表对象缓存
        private Aos.AosSessionValues _cacheAosSessionValues = null;

        /// <summary>
        /// 获取 AosSessionValues 表定义
        /// </summary>
        public Aos.AosSessionValues AosSessionValues {
            get {
                if (_cacheAosSessionValues == null) _cacheAosSessionValues = new Aos.AosSessionValues();
                return _cacheAosSessionValues;
            }
        }

        // AosLog表对象缓存
        private Aos.AosLog _cacheAosLog = null;

        /// <summary>
        /// 获取 AosLog 表定义
        /// </summary>
        public Aos.AosLog AosLog {
            get {
                if (_cacheAosLog == null) _cacheAosLog = new Aos.AosLog();
                return _cacheAosLog;
            }
        }

        // AosLogInterfaceData表对象缓存
        private Aos.AosLogInterfaceData _cacheAosLogInterfaceData = null;

        /// <summary>
        /// 获取 AosLogInterfaceData 表定义
        /// </summary>
        public Aos.AosLogInterfaceData AosLogInterfaceData {
            get {
                if (_cacheAosLogInterfaceData == null) _cacheAosLogInterfaceData = new Aos.AosLogInterfaceData();
                return _cacheAosLogInterfaceData;
            }
        }

        // AosApps表对象缓存
        private Aos.AosApps _cacheAosApps = null;

        /// <summary>
        /// 获取 AosApps 表定义
        /// </summary>
        public Aos.AosApps AosApps {
            get {
                if (_cacheAosApps == null) _cacheAosApps = new Aos.AosApps();
                return _cacheAosApps;
            }
        }

        // AosAppStores表对象缓存
        private Aos.AosAppStores _cacheAosAppStores = null;

        /// <summary>
        /// 获取 AosAppStores 表定义
        /// </summary>
        public Aos.AosAppStores AosAppStores {
            get {
                if (_cacheAosAppStores == null) _cacheAosAppStores = new Aos.AosAppStores();
                return _cacheAosAppStores;
            }
        }

        // AosPlugs表对象缓存
        private Aos.AosPlugs _cacheAosPlugs = null;

        /// <summary>
        /// 获取 AosPlugs 表定义
        /// </summary>
        public Aos.AosPlugs AosPlugs {
            get {
                if (_cacheAosPlugs == null) _cacheAosPlugs = new Aos.AosPlugs();
                return _cacheAosPlugs;
            }
        }

        // AosUsers表对象缓存
        private Aos.AosUsers _cacheAosUsers = null;

        /// <summary>
        /// 获取 AosUsers 表定义
        /// </summary>
        public Aos.AosUsers AosUsers {
            get {
                if (_cacheAosUsers == null) _cacheAosUsers = new Aos.AosUsers();
                return _cacheAosUsers;
            }
        }

        // AosLimits表对象缓存
        private Aos.AosLimits _cacheAosLimits = null;

        /// <summary>
        /// 获取 AosLimits 表定义
        /// </summary>
        public Aos.AosLimits AosLimits {
            get {
                if (_cacheAosLimits == null) _cacheAosLimits = new Aos.AosLimits();
                return _cacheAosLimits;
            }
        }

        // AosIPInfo表对象缓存
        private Aos.AosIPInfo _cacheAosIPInfo = null;

        /// <summary>
        /// 获取 AosIPInfo 表定义
        /// </summary>
        public Aos.AosIPInfo AosIPInfo {
            get {
                if (_cacheAosIPInfo == null) _cacheAosIPInfo = new Aos.AosIPInfo();
                return _cacheAosIPInfo;
            }
        }

        // AosUserApps表对象缓存
        private Aos.AosUserApps _cacheAosUserApps = null;

        /// <summary>
        /// 获取 AosUserApps 表定义
        /// </summary>
        public Aos.AosUserApps AosUserApps {
            get {
                if (_cacheAosUserApps == null) _cacheAosUserApps = new Aos.AosUserApps();
                return _cacheAosUserApps;
            }
        }

        // AosUserAuthorize表对象缓存
        private Aos.AosUserAuthorize _cacheAosUserAuthorize = null;

        /// <summary>
        /// 获取 AosUserAuthorize 表定义
        /// </summary>
        public Aos.AosUserAuthorize AosUserAuthorize {
            get {
                if (_cacheAosUserAuthorize == null) _cacheAosUserAuthorize = new Aos.AosUserAuthorize();
                return _cacheAosUserAuthorize;
            }
        }

        // AosUserSetting表对象缓存
        private Aos.AosUserSetting _cacheAosUserSetting = null;

        /// <summary>
        /// 获取 AosUserSetting 表定义
        /// </summary>
        public Aos.AosUserSetting AosUserSetting {
            get {
                if (_cacheAosUserSetting == null) _cacheAosUserSetting = new Aos.AosUserSetting();
                return _cacheAosUserSetting;
            }
        }

        // AosSetting表对象缓存
        private Aos.AosSetting _cacheAosSetting = null;

        /// <summary>
        /// 获取 AosSetting 表定义
        /// </summary>
        public Aos.AosSetting AosSetting {
            get {
                if (_cacheAosSetting == null) _cacheAosSetting = new Aos.AosSetting();
                return _cacheAosSetting;
            }
        }

        // AosAppLimits表对象缓存
        private Aos.AosAppLimits _cacheAosAppLimits = null;

        /// <summary>
        /// 获取 AosAppLimits 表定义
        /// </summary>
        public Aos.AosAppLimits AosAppLimits {
            get {
                if (_cacheAosAppLimits == null) _cacheAosAppLimits = new Aos.AosAppLimits();
                return _cacheAosAppLimits;
            }
        }

        // AosAppCatalogs表对象缓存
        private Aos.AosAppCatalogs _cacheAosAppCatalogs = null;

        /// <summary>
        /// 获取 AosAppCatalogs 表定义
        /// </summary>
        public Aos.AosAppCatalogs AosAppCatalogs {
            get {
                if (_cacheAosAppCatalogs == null) _cacheAosAppCatalogs = new Aos.AosAppCatalogs();
                return _cacheAosAppCatalogs;
            }
        }

        // AosCount表对象缓存
        private Aos.AosCount _cacheAosCount = null;

        /// <summary>
        /// 获取 AosCount 表定义
        /// </summary>
        public Aos.AosCount AosCount {
            get {
                if (_cacheAosCount == null) _cacheAosCount = new Aos.AosCount();
                return _cacheAosCount;
            }
        }

        // AosDesktopApps表对象缓存
        private Aos.AosDesktopApps _cacheAosDesktopApps = null;

        /// <summary>
        /// 获取 AosDesktopApps 表定义
        /// </summary>
        public Aos.AosDesktopApps AosDesktopApps {
            get {
                if (_cacheAosDesktopApps == null) _cacheAosDesktopApps = new Aos.AosDesktopApps();
                return _cacheAosDesktopApps;
            }
        }

        // AosDesktopAuthorizes表对象缓存
        private Aos.AosDesktopAuthorizes _cacheAosDesktopAuthorizes = null;

        /// <summary>
        /// 获取 AosDesktopAuthorizes 表定义
        /// </summary>
        public Aos.AosDesktopAuthorizes AosDesktopAuthorizes {
            get {
                if (_cacheAosDesktopAuthorizes == null) _cacheAosDesktopAuthorizes = new Aos.AosDesktopAuthorizes();
                return _cacheAosDesktopAuthorizes;
            }
        }

        // AosDesktops表对象缓存
        private Aos.AosDesktops _cacheAosDesktops = null;

        /// <summary>
        /// 获取 AosDesktops 表定义
        /// </summary>
        public Aos.AosDesktops AosDesktops {
            get {
                if (_cacheAosDesktops == null) _cacheAosDesktops = new Aos.AosDesktops();
                return _cacheAosDesktops;
            }
        }

        // AosThirdWeixin表对象缓存
        private Aos.AosThirdWeixin _cacheAosThirdWeixin = null;

        /// <summary>
        /// 获取 AosThirdWeixin 表定义
        /// </summary>
        public Aos.AosThirdWeixin AosThirdWeixin {
            get {
                if (_cacheAosThirdWeixin == null) _cacheAosThirdWeixin = new Aos.AosThirdWeixin();
                return _cacheAosThirdWeixin;
            }
        }

        // AosFiles表对象缓存
        private Aos.AosFiles _cacheAosFiles = null;

        /// <summary>
        /// 获取 AosFiles 表定义
        /// </summary>
        public Aos.AosFiles AosFiles {
            get {
                if (_cacheAosFiles == null) _cacheAosFiles = new Aos.AosFiles();
                return _cacheAosFiles;
            }
        }

        // AosMessages表对象缓存
        private Aos.AosMessages _cacheAosMessages = null;

        /// <summary>
        /// 获取 AosMessages 表定义
        /// </summary>
        public Aos.AosMessages AosMessages {
            get {
                if (_cacheAosMessages == null) _cacheAosMessages = new Aos.AosMessages();
                return _cacheAosMessages;
            }
        }

        // AosMessagesRead表对象缓存
        private Aos.AosMessagesRead _cacheAosMessagesRead = null;

        /// <summary>
        /// 获取 AosMessagesRead 表定义
        /// </summary>
        public Aos.AosMessagesRead AosMessagesRead {
            get {
                if (_cacheAosMessagesRead == null) _cacheAosMessagesRead = new Aos.AosMessagesRead();
                return _cacheAosMessagesRead;
            }
        }

        // AppInfos表对象缓存
        private App.AppInfos _cacheAppInfos = null;

        /// <summary>
        /// 获取 AppInfos 表定义
        /// </summary>
        public App.AppInfos AppInfos {
            get {
                if (_cacheAppInfos == null) _cacheAppInfos = new App.AppInfos();
                return _cacheAppInfos;
            }
        }

        // AppLimits表对象缓存
        private App.AppLimits _cacheAppLimits = null;

        /// <summary>
        /// 获取 AppLimits 表定义
        /// </summary>
        public App.AppLimits AppLimits {
            get {
                if (_cacheAppLimits == null) _cacheAppLimits = new App.AppLimits();
                return _cacheAppLimits;
            }
        }

        // AssessInfos表对象缓存
        private Assess.AssessInfos _cacheAssessInfos = null;

        /// <summary>
        /// 获取 AssessInfos 表定义
        /// </summary>
        public Assess.AssessInfos AssessInfos {
            get {
                if (_cacheAssessInfos == null) _cacheAssessInfos = new Assess.AssessInfos();
                return _cacheAssessInfos;
            }
        }

        // AssessItems表对象缓存
        private Assess.AssessItems _cacheAssessItems = null;

        /// <summary>
        /// 获取 AssessItems 表定义
        /// </summary>
        public Assess.AssessItems AssessItems {
            get {
                if (_cacheAssessItems == null) _cacheAssessItems = new Assess.AssessItems();
                return _cacheAssessItems;
            }
        }

        // AssessScore表对象缓存
        private Assess.AssessScore _cacheAssessScore = null;

        /// <summary>
        /// 获取 AssessScore 表定义
        /// </summary>
        public Assess.AssessScore AssessScore {
            get {
                if (_cacheAssessScore == null) _cacheAssessScore = new Assess.AssessScore();
                return _cacheAssessScore;
            }
        }

        // AssessItemScore表对象缓存
        private Assess.AssessItemScore _cacheAssessItemScore = null;

        /// <summary>
        /// 获取 AssessItemScore 表定义
        /// </summary>
        public Assess.AssessItemScore AssessItemScore {
            get {
                if (_cacheAssessItemScore == null) _cacheAssessItemScore = new Assess.AssessItemScore();
                return _cacheAssessItemScore;
            }
        }

        // AssessRoundScore表对象缓存
        private Assess.AssessRoundScore _cacheAssessRoundScore = null;

        /// <summary>
        /// 获取 AssessRoundScore 表定义
        /// </summary>
        public Assess.AssessRoundScore AssessRoundScore {
            get {
                if (_cacheAssessRoundScore == null) _cacheAssessRoundScore = new Assess.AssessRoundScore();
                return _cacheAssessRoundScore;
            }
        }

        // AssessUsers表对象缓存
        private Assess.AssessUsers _cacheAssessUsers = null;

        /// <summary>
        /// 获取 AssessUsers 表定义
        /// </summary>
        public Assess.AssessUsers AssessUsers {
            get {
                if (_cacheAssessUsers == null) _cacheAssessUsers = new Assess.AssessUsers();
                return _cacheAssessUsers;
            }
        }

        // SystemObjects表对象缓存
        private Base.SystemObjects _cacheSystemObjects = null;

        /// <summary>
        /// 获取 SystemObjects 表定义
        /// </summary>
        public Base.SystemObjects SystemObjects {
            get {
                if (_cacheSystemObjects == null) _cacheSystemObjects = new Base.SystemObjects();
                return _cacheSystemObjects;
            }
        }

        // SystemLimits表对象缓存
        private Base.SystemLimits _cacheSystemLimits = null;

        /// <summary>
        /// 获取 SystemLimits 表定义
        /// </summary>
        public Base.SystemLimits SystemLimits {
            get {
                if (_cacheSystemLimits == null) _cacheSystemLimits = new Base.SystemLimits();
                return _cacheSystemLimits;
            }
        }

        // SystemObjectLimits表对象缓存
        private Base.SystemObjectLimits _cacheSystemObjectLimits = null;

        /// <summary>
        /// 获取 SystemObjectLimits 表定义
        /// </summary>
        public Base.SystemObjectLimits SystemObjectLimits {
            get {
                if (_cacheSystemObjectLimits == null) _cacheSystemObjectLimits = new Base.SystemObjectLimits();
                return _cacheSystemObjectLimits;
            }
        }

        // SystemUsers表对象缓存
        private Base.SystemUsers _cacheSystemUsers = null;

        /// <summary>
        /// 获取 SystemUsers 表定义
        /// </summary>
        public Base.SystemUsers SystemUsers {
            get {
                if (_cacheSystemUsers == null) _cacheSystemUsers = new Base.SystemUsers();
                return _cacheSystemUsers;
            }
        }

        // SystemUserAppLimits表对象缓存
        private Base.SystemUserAppLimits _cacheSystemUserAppLimits = null;

        /// <summary>
        /// 获取 SystemUserAppLimits 表定义
        /// </summary>
        public Base.SystemUserAppLimits SystemUserAppLimits {
            get {
                if (_cacheSystemUserAppLimits == null) _cacheSystemUserAppLimits = new Base.SystemUserAppLimits();
                return _cacheSystemUserAppLimits;
            }
        }

        // SystemUserLimits表对象缓存
        private Base.SystemUserLimits _cacheSystemUserLimits = null;

        /// <summary>
        /// 获取 SystemUserLimits 表定义
        /// </summary>
        public Base.SystemUserLimits SystemUserLimits {
            get {
                if (_cacheSystemUserLimits == null) _cacheSystemUserLimits = new Base.SystemUserLimits();
                return _cacheSystemUserLimits;
            }
        }

        // SystemMessages表对象缓存
        private Base.SystemMessages _cacheSystemMessages = null;

        /// <summary>
        /// 获取 SystemMessages 表定义
        /// </summary>
        public Base.SystemMessages SystemMessages {
            get {
                if (_cacheSystemMessages == null) _cacheSystemMessages = new Base.SystemMessages();
                return _cacheSystemMessages;
            }
        }

        // SystemCatalog表对象缓存
        private Base.SystemCatalog _cacheSystemCatalog = null;

        /// <summary>
        /// 获取 SystemCatalog 表定义
        /// </summary>
        public Base.SystemCatalog SystemCatalog {
            get {
                if (_cacheSystemCatalog == null) _cacheSystemCatalog = new Base.SystemCatalog();
                return _cacheSystemCatalog;
            }
        }

        // SystemTableTypes表对象缓存
        private Base.SystemTableTypes _cacheSystemTableTypes = null;

        /// <summary>
        /// 获取 SystemTableTypes 表定义
        /// </summary>
        public Base.SystemTableTypes SystemTableTypes {
            get {
                if (_cacheSystemTableTypes == null) _cacheSystemTableTypes = new Base.SystemTableTypes();
                return _cacheSystemTableTypes;
            }
        }

        // SystemTables表对象缓存
        private Base.SystemTables _cacheSystemTables = null;

        /// <summary>
        /// 获取 SystemTables 表定义
        /// </summary>
        public Base.SystemTables SystemTables {
            get {
                if (_cacheSystemTables == null) _cacheSystemTables = new Base.SystemTables();
                return _cacheSystemTables;
            }
        }

        // SystemColumns表对象缓存
        private Base.SystemColumns _cacheSystemColumns = null;

        /// <summary>
        /// 获取 SystemColumns 表定义
        /// </summary>
        public Base.SystemColumns SystemColumns {
            get {
                if (_cacheSystemColumns == null) _cacheSystemColumns = new Base.SystemColumns();
                return _cacheSystemColumns;
            }
        }

        // SystemUserTableVisits表对象缓存
        private Base.SystemUserTableVisits _cacheSystemUserTableVisits = null;

        /// <summary>
        /// 获取 SystemUserTableVisits 表定义
        /// </summary>
        public Base.SystemUserTableVisits SystemUserTableVisits {
            get {
                if (_cacheSystemUserTableVisits == null) _cacheSystemUserTableVisits = new Base.SystemUserTableVisits();
                return _cacheSystemUserTableVisits;
            }
        }

        // ChatInfo表对象缓存
        private Chat.ChatInfo _cacheChatInfo = null;

        /// <summary>
        /// 获取 ChatInfo 表定义
        /// </summary>
        public Chat.ChatInfo ChatInfo {
            get {
                if (_cacheChatInfo == null) _cacheChatInfo = new Chat.ChatInfo();
                return _cacheChatInfo;
            }
        }

        // ChatToUser表对象缓存
        private Chat.ChatToUser _cacheChatToUser = null;

        /// <summary>
        /// 获取 ChatToUser 表定义
        /// </summary>
        public Chat.ChatToUser ChatToUser {
            get {
                if (_cacheChatToUser == null) _cacheChatToUser = new Chat.ChatToUser();
                return _cacheChatToUser;
            }
        }

        // ChatToGroup表对象缓存
        private Chat.ChatToGroup _cacheChatToGroup = null;

        /// <summary>
        /// 获取 ChatToGroup 表定义
        /// </summary>
        public Chat.ChatToGroup ChatToGroup {
            get {
                if (_cacheChatToGroup == null) _cacheChatToGroup = new Chat.ChatToGroup();
                return _cacheChatToGroup;
            }
        }

        // ChatMessage表对象缓存
        private Chat.ChatMessage _cacheChatMessage = null;

        /// <summary>
        /// 获取 ChatMessage 表定义
        /// </summary>
        public Chat.ChatMessage ChatMessage {
            get {
                if (_cacheChatMessage == null) _cacheChatMessage = new Chat.ChatMessage();
                return _cacheChatMessage;
            }
        }

        // ChatReceive表对象缓存
        private Chat.ChatReceive _cacheChatReceive = null;

        /// <summary>
        /// 获取 ChatReceive 表定义
        /// </summary>
        public Chat.ChatReceive ChatReceive {
            get {
                if (_cacheChatReceive == null) _cacheChatReceive = new Chat.ChatReceive();
                return _cacheChatReceive;
            }
        }

        // CloudList表对象缓存
        private Cloud.CloudList _cacheCloudList = null;

        /// <summary>
        /// 获取 CloudList 表定义
        /// </summary>
        public Cloud.CloudList CloudList {
            get {
                if (_cacheCloudList == null) _cacheCloudList = new Cloud.CloudList();
                return _cacheCloudList;
            }
        }

        // CloudHistory表对象缓存
        private Cloud.CloudHistory _cacheCloudHistory = null;

        /// <summary>
        /// 获取 CloudHistory 表定义
        /// </summary>
        public Cloud.CloudHistory CloudHistory {
            get {
                if (_cacheCloudHistory == null) _cacheCloudHistory = new Cloud.CloudHistory();
                return _cacheCloudHistory;
            }
        }

        // CloudFiles表对象缓存
        private Cloud.CloudFiles _cacheCloudFiles = null;

        /// <summary>
        /// 获取 CloudFiles 表定义
        /// </summary>
        public Cloud.CloudFiles CloudFiles {
            get {
                if (_cacheCloudFiles == null) _cacheCloudFiles = new Cloud.CloudFiles();
                return _cacheCloudFiles;
            }
        }

        // CloudFileHistory表对象缓存
        private Cloud.CloudFileHistory _cacheCloudFileHistory = null;

        /// <summary>
        /// 获取 CloudFileHistory 表定义
        /// </summary>
        public Cloud.CloudFileHistory CloudFileHistory {
            get {
                if (_cacheCloudFileHistory == null) _cacheCloudFileHistory = new Cloud.CloudFileHistory();
                return _cacheCloudFileHistory;
            }
        }

        // CloudUserStore表对象缓存
        private Cloud.CloudUserStore _cacheCloudUserStore = null;

        /// <summary>
        /// 获取 CloudUserStore 表定义
        /// </summary>
        public Cloud.CloudUserStore CloudUserStore {
            get {
                if (_cacheCloudUserStore == null) _cacheCloudUserStore = new Cloud.CloudUserStore();
                return _cacheCloudUserStore;
            }
        }

        // CloudOfficeFiles表对象缓存
        private Cloud.CloudOfficeFiles _cacheCloudOfficeFiles = null;

        /// <summary>
        /// 获取 CloudOfficeFiles 表定义
        /// </summary>
        public Cloud.CloudOfficeFiles CloudOfficeFiles {
            get {
                if (_cacheCloudOfficeFiles == null) _cacheCloudOfficeFiles = new Cloud.CloudOfficeFiles();
                return _cacheCloudOfficeFiles;
            }
        }

        // CloudExchangeFiles表对象缓存
        private Cloud.CloudExchangeFiles _cacheCloudExchangeFiles = null;

        /// <summary>
        /// 获取 CloudExchangeFiles 表定义
        /// </summary>
        public Cloud.CloudExchangeFiles CloudExchangeFiles {
            get {
                if (_cacheCloudExchangeFiles == null) _cacheCloudExchangeFiles = new Cloud.CloudExchangeFiles();
                return _cacheCloudExchangeFiles;
            }
        }

        // CloudStorageDisk表对象缓存
        private CloudStorage.CloudStorageDisk _cacheCloudStorageDisk = null;

        /// <summary>
        /// 获取 CloudStorageDisk 表定义
        /// </summary>
        public CloudStorage.CloudStorageDisk CloudStorageDisk {
            get {
                if (_cacheCloudStorageDisk == null) _cacheCloudStorageDisk = new CloudStorage.CloudStorageDisk();
                return _cacheCloudStorageDisk;
            }
        }

        // CloudStorageFolder表对象缓存
        private CloudStorage.CloudStorageFolder _cacheCloudStorageFolder = null;

        /// <summary>
        /// 获取 CloudStorageFolder 表定义
        /// </summary>
        public CloudStorage.CloudStorageFolder CloudStorageFolder {
            get {
                if (_cacheCloudStorageFolder == null) _cacheCloudStorageFolder = new CloudStorage.CloudStorageFolder();
                return _cacheCloudStorageFolder;
            }
        }

        // CloudStorageFile表对象缓存
        private CloudStorage.CloudStorageFile _cacheCloudStorageFile = null;

        /// <summary>
        /// 获取 CloudStorageFile 表定义
        /// </summary>
        public CloudStorage.CloudStorageFile CloudStorageFile {
            get {
                if (_cacheCloudStorageFile == null) _cacheCloudStorageFile = new CloudStorage.CloudStorageFile();
                return _cacheCloudStorageFile;
            }
        }

        // CloudStorageFileUpload表对象缓存
        private CloudStorage.CloudStorageFileUpload _cacheCloudStorageFileUpload = null;

        /// <summary>
        /// 获取 CloudStorageFileUpload 表定义
        /// </summary>
        public CloudStorage.CloudStorageFileUpload CloudStorageFileUpload {
            get {
                if (_cacheCloudStorageFileUpload == null) _cacheCloudStorageFileUpload = new CloudStorage.CloudStorageFileUpload();
                return _cacheCloudStorageFileUpload;
            }
        }

        // CloudStorageFileShare表对象缓存
        private CloudStorage.CloudStorageFileShare _cacheCloudStorageFileShare = null;

        /// <summary>
        /// 获取 CloudStorageFileShare 表定义
        /// </summary>
        public CloudStorage.CloudStorageFileShare CloudStorageFileShare {
            get {
                if (_cacheCloudStorageFileShare == null) _cacheCloudStorageFileShare = new CloudStorage.CloudStorageFileShare();
                return _cacheCloudStorageFileShare;
            }
        }

        // CPAClient表对象缓存
        private CPA.CPAClient _cacheCPAClient = null;

        /// <summary>
        /// 获取 CPAClient 表定义
        /// </summary>
        public CPA.CPAClient CPAClient {
            get {
                if (_cacheCPAClient == null) _cacheCPAClient = new CPA.CPAClient();
                return _cacheCPAClient;
            }
        }

        // CPAAccountClient表对象缓存
        private CPA.CPAAccountClient _cacheCPAAccountClient = null;

        /// <summary>
        /// 获取 CPAAccountClient 表定义
        /// </summary>
        public CPA.CPAAccountClient CPAAccountClient {
            get {
                if (_cacheCPAAccountClient == null) _cacheCPAAccountClient = new CPA.CPAAccountClient();
                return _cacheCPAAccountClient;
            }
        }

        // CPAAccountProcess表对象缓存
        private CPA.CPAAccountProcess _cacheCPAAccountProcess = null;

        /// <summary>
        /// 获取 CPAAccountProcess 表定义
        /// </summary>
        public CPA.CPAAccountProcess CPAAccountProcess {
            get {
                if (_cacheCPAAccountProcess == null) _cacheCPAAccountProcess = new CPA.CPAAccountProcess();
                return _cacheCPAAccountProcess;
            }
        }

        // CPAAccountProcessAssessCriteria表对象缓存
        private CPA.CPAAccountProcessAssessCriteria _cacheCPAAccountProcessAssessCriteria = null;

        /// <summary>
        /// 获取 CPAAccountProcessAssessCriteria 表定义
        /// </summary>
        public CPA.CPAAccountProcessAssessCriteria CPAAccountProcessAssessCriteria {
            get {
                if (_cacheCPAAccountProcessAssessCriteria == null) _cacheCPAAccountProcessAssessCriteria = new CPA.CPAAccountProcessAssessCriteria();
                return _cacheCPAAccountProcessAssessCriteria;
            }
        }

        // CPAAccountProcessAssessScore表对象缓存
        private CPA.CPAAccountProcessAssessScore _cacheCPAAccountProcessAssessScore = null;

        /// <summary>
        /// 获取 CPAAccountProcessAssessScore 表定义
        /// </summary>
        public CPA.CPAAccountProcessAssessScore CPAAccountProcessAssessScore {
            get {
                if (_cacheCPAAccountProcessAssessScore == null) _cacheCPAAccountProcessAssessScore = new CPA.CPAAccountProcessAssessScore();
                return _cacheCPAAccountProcessAssessScore;
            }
        }

        // CPAFinalSettlementClient表对象缓存
        private CPA.CPAFinalSettlementClient _cacheCPAFinalSettlementClient = null;

        /// <summary>
        /// 获取 CPAFinalSettlementClient 表定义
        /// </summary>
        public CPA.CPAFinalSettlementClient CPAFinalSettlementClient {
            get {
                if (_cacheCPAFinalSettlementClient == null) _cacheCPAFinalSettlementClient = new CPA.CPAFinalSettlementClient();
                return _cacheCPAFinalSettlementClient;
            }
        }

        // CPAFinalSettlementProcess表对象缓存
        private CPA.CPAFinalSettlementProcess _cacheCPAFinalSettlementProcess = null;

        /// <summary>
        /// 获取 CPAFinalSettlementProcess 表定义
        /// </summary>
        public CPA.CPAFinalSettlementProcess CPAFinalSettlementProcess {
            get {
                if (_cacheCPAFinalSettlementProcess == null) _cacheCPAFinalSettlementProcess = new CPA.CPAFinalSettlementProcess();
                return _cacheCPAFinalSettlementProcess;
            }
        }

        // CPAFinalSettlementYear表对象缓存
        private CPA.CPAFinalSettlementYear _cacheCPAFinalSettlementYear = null;

        /// <summary>
        /// 获取 CPAFinalSettlementYear 表定义
        /// </summary>
        public CPA.CPAFinalSettlementYear CPAFinalSettlementYear {
            get {
                if (_cacheCPAFinalSettlementYear == null) _cacheCPAFinalSettlementYear = new CPA.CPAFinalSettlementYear();
                return _cacheCPAFinalSettlementYear;
            }
        }

        // CPACheck01表对象缓存
        private CPA.CPACheck01 _cacheCPACheck01 = null;

        /// <summary>
        /// 获取 CPACheck01 表定义
        /// </summary>
        public CPA.CPACheck01 CPACheck01 {
            get {
                if (_cacheCPACheck01 == null) _cacheCPACheck01 = new CPA.CPACheck01();
                return _cacheCPACheck01;
            }
        }

        // CPACheck02表对象缓存
        private CPA.CPACheck02 _cacheCPACheck02 = null;

        /// <summary>
        /// 获取 CPACheck02 表定义
        /// </summary>
        public CPA.CPACheck02 CPACheck02 {
            get {
                if (_cacheCPACheck02 == null) _cacheCPACheck02 = new CPA.CPACheck02();
                return _cacheCPACheck02;
            }
        }

        // CPACheck03表对象缓存
        private CPA.CPACheck03 _cacheCPACheck03 = null;

        /// <summary>
        /// 获取 CPACheck03 表定义
        /// </summary>
        public CPA.CPACheck03 CPACheck03 {
            get {
                if (_cacheCPACheck03 == null) _cacheCPACheck03 = new CPA.CPACheck03();
                return _cacheCPACheck03;
            }
        }

        // CPAAccredClient表对象缓存
        private CPA.CPAAccredClient _cacheCPAAccredClient = null;

        /// <summary>
        /// 获取 CPAAccredClient 表定义
        /// </summary>
        public CPA.CPAAccredClient CPAAccredClient {
            get {
                if (_cacheCPAAccredClient == null) _cacheCPAAccredClient = new CPA.CPAAccredClient();
                return _cacheCPAAccredClient;
            }
        }

        // CPAAccredProcess表对象缓存
        private CPA.CPAAccredProcess _cacheCPAAccredProcess = null;

        /// <summary>
        /// 获取 CPAAccredProcess 表定义
        /// </summary>
        public CPA.CPAAccredProcess CPAAccredProcess {
            get {
                if (_cacheCPAAccredProcess == null) _cacheCPAAccredProcess = new CPA.CPAAccredProcess();
                return _cacheCPAAccredProcess;
            }
        }

        // CPAAccountCount表对象缓存
        private CPA.CPAAccountCount _cacheCPAAccountCount = null;

        /// <summary>
        /// 获取 CPAAccountCount 表定义
        /// </summary>
        public CPA.CPAAccountCount CPAAccountCount {
            get {
                if (_cacheCPAAccountCount == null) _cacheCPAAccountCount = new CPA.CPAAccountCount();
                return _cacheCPAAccountCount;
            }
        }

        // CustomIngredients表对象缓存
        private Custom_Fangde.CustomIngredients _cacheCustomIngredients = null;

        /// <summary>
        /// 获取 CustomIngredients 表定义
        /// </summary>
        public Custom_Fangde.CustomIngredients CustomIngredients {
            get {
                if (_cacheCustomIngredients == null) _cacheCustomIngredients = new Custom_Fangde.CustomIngredients();
                return _cacheCustomIngredients;
            }
        }

        // CustomIngredientsMaterial表对象缓存
        private Custom_Fangde.CustomIngredientsMaterial _cacheCustomIngredientsMaterial = null;

        /// <summary>
        /// 获取 CustomIngredientsMaterial 表定义
        /// </summary>
        public Custom_Fangde.CustomIngredientsMaterial CustomIngredientsMaterial {
            get {
                if (_cacheCustomIngredientsMaterial == null) _cacheCustomIngredientsMaterial = new Custom_Fangde.CustomIngredientsMaterial();
                return _cacheCustomIngredientsMaterial;
            }
        }

        // CustomMaterial表对象缓存
        private Custom_Fangde.CustomMaterial _cacheCustomMaterial = null;

        /// <summary>
        /// 获取 CustomMaterial 表定义
        /// </summary>
        public Custom_Fangde.CustomMaterial CustomMaterial {
            get {
                if (_cacheCustomMaterial == null) _cacheCustomMaterial = new Custom_Fangde.CustomMaterial();
                return _cacheCustomMaterial;
            }
        }

        // CustomMaterialStock表对象缓存
        private Custom_Fangde.CustomMaterialStock _cacheCustomMaterialStock = null;

        /// <summary>
        /// 获取 CustomMaterialStock 表定义
        /// </summary>
        public Custom_Fangde.CustomMaterialStock CustomMaterialStock {
            get {
                if (_cacheCustomMaterialStock == null) _cacheCustomMaterialStock = new Custom_Fangde.CustomMaterialStock();
                return _cacheCustomMaterialStock;
            }
        }

        // fmjc表对象缓存
        private Custom_Fangde.fmjc _cachefmjc = null;

        /// <summary>
        /// 获取 fmjc 表定义
        /// </summary>
        public Custom_Fangde.fmjc fmjc {
            get {
                if (_cachefmjc == null) _cachefmjc = new Custom_Fangde.fmjc();
                return _cachefmjc;
            }
        }

        // Drivers表对象缓存
        private Driving.Drivers _cacheDrivers = null;

        /// <summary>
        /// 获取 Drivers 表定义
        /// </summary>
        public Driving.Drivers Drivers {
            get {
                if (_cacheDrivers == null) _cacheDrivers = new Driving.Drivers();
                return _cacheDrivers;
            }
        }

        // DrivingOrders表对象缓存
        private Driving.DrivingOrders _cacheDrivingOrders = null;

        /// <summary>
        /// 获取 DrivingOrders 表定义
        /// </summary>
        public Driving.DrivingOrders DrivingOrders {
            get {
                if (_cacheDrivingOrders == null) _cacheDrivingOrders = new Driving.DrivingOrders();
                return _cacheDrivingOrders;
            }
        }

        // DrivingNodes表对象缓存
        private Driving.DrivingNodes _cacheDrivingNodes = null;

        /// <summary>
        /// 获取 DrivingNodes 表定义
        /// </summary>
        public Driving.DrivingNodes DrivingNodes {
            get {
                if (_cacheDrivingNodes == null) _cacheDrivingNodes = new Driving.DrivingNodes();
                return _cacheDrivingNodes;
            }
        }

        // DrivingEvaluations表对象缓存
        private Driving.DrivingEvaluations _cacheDrivingEvaluations = null;

        /// <summary>
        /// 获取 DrivingEvaluations 表定义
        /// </summary>
        public Driving.DrivingEvaluations DrivingEvaluations {
            get {
                if (_cacheDrivingEvaluations == null) _cacheDrivingEvaluations = new Driving.DrivingEvaluations();
                return _cacheDrivingEvaluations;
            }
        }

        // EMEmployee表对象缓存
        private EM.EMEmployee _cacheEMEmployee = null;

        /// <summary>
        /// 获取 EMEmployee 表定义
        /// </summary>
        public EM.EMEmployee EMEmployee {
            get {
                if (_cacheEMEmployee == null) _cacheEMEmployee = new EM.EMEmployee();
                return _cacheEMEmployee;
            }
        }

        // EMClient表对象缓存
        private EM.EMClient _cacheEMClient = null;

        /// <summary>
        /// 获取 EMClient 表定义
        /// </summary>
        public EM.EMClient EMClient {
            get {
                if (_cacheEMClient == null) _cacheEMClient = new EM.EMClient();
                return _cacheEMClient;
            }
        }

        // EMContact表对象缓存
        private EM.EMContact _cacheEMContact = null;

        /// <summary>
        /// 获取 EMContact 表定义
        /// </summary>
        public EM.EMContact EMContact {
            get {
                if (_cacheEMContact == null) _cacheEMContact = new EM.EMContact();
                return _cacheEMContact;
            }
        }

        // EMProjects表对象缓存
        private EM.EMProjects _cacheEMProjects = null;

        /// <summary>
        /// 获取 EMProjects 表定义
        /// </summary>
        public EM.EMProjects EMProjects {
            get {
                if (_cacheEMProjects == null) _cacheEMProjects = new EM.EMProjects();
                return _cacheEMProjects;
            }
        }

        // EMProcess表对象缓存
        private EM.EMProcess _cacheEMProcess = null;

        /// <summary>
        /// 获取 EMProcess 表定义
        /// </summary>
        public EM.EMProcess EMProcess {
            get {
                if (_cacheEMProcess == null) _cacheEMProcess = new EM.EMProcess();
                return _cacheEMProcess;
            }
        }

        // EMTask表对象缓存
        private EM.EMTask _cacheEMTask = null;

        /// <summary>
        /// 获取 EMTask 表定义
        /// </summary>
        public EM.EMTask EMTask {
            get {
                if (_cacheEMTask == null) _cacheEMTask = new EM.EMTask();
                return _cacheEMTask;
            }
        }

        // EMTaskUser表对象缓存
        private EM.EMTaskUser _cacheEMTaskUser = null;

        /// <summary>
        /// 获取 EMTaskUser 表定义
        /// </summary>
        public EM.EMTaskUser EMTaskUser {
            get {
                if (_cacheEMTaskUser == null) _cacheEMTaskUser = new EM.EMTaskUser();
                return _cacheEMTaskUser;
            }
        }

        // EMTaskFeedback表对象缓存
        private EM.EMTaskFeedback _cacheEMTaskFeedback = null;

        /// <summary>
        /// 获取 EMTaskFeedback 表定义
        /// </summary>
        public EM.EMTaskFeedback EMTaskFeedback {
            get {
                if (_cacheEMTaskFeedback == null) _cacheEMTaskFeedback = new EM.EMTaskFeedback();
                return _cacheEMTaskFeedback;
            }
        }

        // EMDaily表对象缓存
        private EM.EMDaily _cacheEMDaily = null;

        /// <summary>
        /// 获取 EMDaily 表定义
        /// </summary>
        public EM.EMDaily EMDaily {
            get {
                if (_cacheEMDaily == null) _cacheEMDaily = new EM.EMDaily();
                return _cacheEMDaily;
            }
        }

        // EMArticle表对象缓存
        private EM.EMArticle _cacheEMArticle = null;

        /// <summary>
        /// 获取 EMArticle 表定义
        /// </summary>
        public EM.EMArticle EMArticle {
            get {
                if (_cacheEMArticle == null) _cacheEMArticle = new EM.EMArticle();
                return _cacheEMArticle;
            }
        }

        // EMailAccount表对象缓存
        private EMail.EMailAccount _cacheEMailAccount = null;

        /// <summary>
        /// 获取 EMailAccount 表定义
        /// </summary>
        public EMail.EMailAccount EMailAccount {
            get {
                if (_cacheEMailAccount == null) _cacheEMailAccount = new EMail.EMailAccount();
                return _cacheEMailAccount;
            }
        }

        // EMailInfo表对象缓存
        private EMail.EMailInfo _cacheEMailInfo = null;

        /// <summary>
        /// 获取 EMailInfo 表定义
        /// </summary>
        public EMail.EMailInfo EMailInfo {
            get {
                if (_cacheEMailInfo == null) _cacheEMailInfo = new EMail.EMailInfo();
                return _cacheEMailInfo;
            }
        }

        // EMailAttachment表对象缓存
        private EMail.EMailAttachment _cacheEMailAttachment = null;

        /// <summary>
        /// 获取 EMailAttachment 表定义
        /// </summary>
        public EMail.EMailAttachment EMailAttachment {
            get {
                if (_cacheEMailAttachment == null) _cacheEMailAttachment = new EMail.EMailAttachment();
                return _cacheEMailAttachment;
            }
        }

        // FinanceAccounts表对象缓存
        private Finance.FinanceAccounts _cacheFinanceAccounts = null;

        /// <summary>
        /// 获取 FinanceAccounts 表定义
        /// </summary>
        public Finance.FinanceAccounts FinanceAccounts {
            get {
                if (_cacheFinanceAccounts == null) _cacheFinanceAccounts = new Finance.FinanceAccounts();
                return _cacheFinanceAccounts;
            }
        }

        // FinanceAccountTypes表对象缓存
        private Finance.FinanceAccountTypes _cacheFinanceAccountTypes = null;

        /// <summary>
        /// 获取 FinanceAccountTypes 表定义
        /// </summary>
        public Finance.FinanceAccountTypes FinanceAccountTypes {
            get {
                if (_cacheFinanceAccountTypes == null) _cacheFinanceAccountTypes = new Finance.FinanceAccountTypes();
                return _cacheFinanceAccountTypes;
            }
        }

        // FinanceAccounting表对象缓存
        private Finance.FinanceAccounting _cacheFinanceAccounting = null;

        /// <summary>
        /// 获取 FinanceAccounting 表定义
        /// </summary>
        public Finance.FinanceAccounting FinanceAccounting {
            get {
                if (_cacheFinanceAccounting == null) _cacheFinanceAccounting = new Finance.FinanceAccounting();
                return _cacheFinanceAccounting;
            }
        }

        // GameUsers表对象缓存
        private Game.GameUsers _cacheGameUsers = null;

        /// <summary>
        /// 获取 GameUsers 表定义
        /// </summary>
        public Game.GameUsers GameUsers {
            get {
                if (_cacheGameUsers == null) _cacheGameUsers = new Game.GameUsers();
                return _cacheGameUsers;
            }
        }

        // GameServers表对象缓存
        private Game.GameServers _cacheGameServers = null;

        /// <summary>
        /// 获取 GameServers 表定义
        /// </summary>
        public Game.GameServers GameServers {
            get {
                if (_cacheGameServers == null) _cacheGameServers = new Game.GameServers();
                return _cacheGameServers;
            }
        }

        // CardsInfo表对象缓存
        private Game_Card.CardsInfo _cacheCardsInfo = null;

        /// <summary>
        /// 获取 CardsInfo 表定义
        /// </summary>
        public Game_Card.CardsInfo CardsInfo {
            get {
                if (_cacheCardsInfo == null) _cacheCardsInfo = new Game_Card.CardsInfo();
                return _cacheCardsInfo;
            }
        }

        // CardsTypes表对象缓存
        private Game_Card.CardsTypes _cacheCardsTypes = null;

        /// <summary>
        /// 获取 CardsTypes 表定义
        /// </summary>
        public Game_Card.CardsTypes CardsTypes {
            get {
                if (_cacheCardsTypes == null) _cacheCardsTypes = new Game_Card.CardsTypes();
                return _cacheCardsTypes;
            }
        }

        // CardsLvs表对象缓存
        private Game_Card.CardsLvs _cacheCardsLvs = null;

        /// <summary>
        /// 获取 CardsLvs 表定义
        /// </summary>
        public Game_Card.CardsLvs CardsLvs {
            get {
                if (_cacheCardsLvs == null) _cacheCardsLvs = new Game_Card.CardsLvs();
                return _cacheCardsLvs;
            }
        }

        // CardsOffers表对象缓存
        private Game_Card.CardsOffers _cacheCardsOffers = null;

        /// <summary>
        /// 获取 CardsOffers 表定义
        /// </summary>
        public Game_Card.CardsOffers CardsOffers {
            get {
                if (_cacheCardsOffers == null) _cacheCardsOffers = new Game_Card.CardsOffers();
                return _cacheCardsOffers;
            }
        }

        // MonasticismUsers表对象缓存
        private Game_Monasticism.MonasticismUsers _cacheMonasticismUsers = null;

        /// <summary>
        /// 获取 MonasticismUsers 表定义
        /// </summary>
        public Game_Monasticism.MonasticismUsers MonasticismUsers {
            get {
                if (_cacheMonasticismUsers == null) _cacheMonasticismUsers = new Game_Monasticism.MonasticismUsers();
                return _cacheMonasticismUsers;
            }
        }

        // MonasticismLvs表对象缓存
        private Game_Monasticism.MonasticismLvs _cacheMonasticismLvs = null;

        /// <summary>
        /// 获取 MonasticismLvs 表定义
        /// </summary>
        public Game_Monasticism.MonasticismLvs MonasticismLvs {
            get {
                if (_cacheMonasticismLvs == null) _cacheMonasticismLvs = new Game_Monasticism.MonasticismLvs();
                return _cacheMonasticismLvs;
            }
        }

        // GeographyCountry表对象缓存
        private Geography.GeographyCountry _cacheGeographyCountry = null;

        /// <summary>
        /// 获取 GeographyCountry 表定义
        /// </summary>
        public Geography.GeographyCountry GeographyCountry {
            get {
                if (_cacheGeographyCountry == null) _cacheGeographyCountry = new Geography.GeographyCountry();
                return _cacheGeographyCountry;
            }
        }

        // GeographyProvince表对象缓存
        private Geography.GeographyProvince _cacheGeographyProvince = null;

        /// <summary>
        /// 获取 GeographyProvince 表定义
        /// </summary>
        public Geography.GeographyProvince GeographyProvince {
            get {
                if (_cacheGeographyProvince == null) _cacheGeographyProvince = new Geography.GeographyProvince();
                return _cacheGeographyProvince;
            }
        }

        // GeographyCity表对象缓存
        private Geography.GeographyCity _cacheGeographyCity = null;

        /// <summary>
        /// 获取 GeographyCity 表定义
        /// </summary>
        public Geography.GeographyCity GeographyCity {
            get {
                if (_cacheGeographyCity == null) _cacheGeographyCity = new Geography.GeographyCity();
                return _cacheGeographyCity;
            }
        }

        // GeographyArea表对象缓存
        private Geography.GeographyArea _cacheGeographyArea = null;

        /// <summary>
        /// 获取 GeographyArea 表定义
        /// </summary>
        public Geography.GeographyArea GeographyArea {
            get {
                if (_cacheGeographyArea == null) _cacheGeographyArea = new Geography.GeographyArea();
                return _cacheGeographyArea;
            }
        }

        // GeographyTown表对象缓存
        private Geography.GeographyTown _cacheGeographyTown = null;

        /// <summary>
        /// 获取 GeographyTown 表定义
        /// </summary>
        public Geography.GeographyTown GeographyTown {
            get {
                if (_cacheGeographyTown == null) _cacheGeographyTown = new Geography.GeographyTown();
                return _cacheGeographyTown;
            }
        }

        // GeographyVillage表对象缓存
        private Geography.GeographyVillage _cacheGeographyVillage = null;

        /// <summary>
        /// 获取 GeographyVillage 表定义
        /// </summary>
        public Geography.GeographyVillage GeographyVillage {
            get {
                if (_cacheGeographyVillage == null) _cacheGeographyVillage = new Geography.GeographyVillage();
                return _cacheGeographyVillage;
            }
        }

        // JxcBook表对象缓存
        private Jxc.JxcBook _cacheJxcBook = null;

        /// <summary>
        /// 获取 JxcBook 表定义
        /// </summary>
        public Jxc.JxcBook JxcBook {
            get {
                if (_cacheJxcBook == null) _cacheJxcBook = new Jxc.JxcBook();
                return _cacheJxcBook;
            }
        }

        // JxcBookMember表对象缓存
        private Jxc.JxcBookMember _cacheJxcBookMember = null;

        /// <summary>
        /// 获取 JxcBookMember 表定义
        /// </summary>
        public Jxc.JxcBookMember JxcBookMember {
            get {
                if (_cacheJxcBookMember == null) _cacheJxcBookMember = new Jxc.JxcBookMember();
                return _cacheJxcBookMember;
            }
        }

        // JxcSuppliers表对象缓存
        private Jxc.JxcSuppliers _cacheJxcSuppliers = null;

        /// <summary>
        /// 获取 JxcSuppliers 表定义
        /// </summary>
        public Jxc.JxcSuppliers JxcSuppliers {
            get {
                if (_cacheJxcSuppliers == null) _cacheJxcSuppliers = new Jxc.JxcSuppliers();
                return _cacheJxcSuppliers;
            }
        }

        // JxcClients表对象缓存
        private Jxc.JxcClients _cacheJxcClients = null;

        /// <summary>
        /// 获取 JxcClients 表定义
        /// </summary>
        public Jxc.JxcClients JxcClients {
            get {
                if (_cacheJxcClients == null) _cacheJxcClients = new Jxc.JxcClients();
                return _cacheJxcClients;
            }
        }

        // JxcCatalogs表对象缓存
        private Jxc.JxcCatalogs _cacheJxcCatalogs = null;

        /// <summary>
        /// 获取 JxcCatalogs 表定义
        /// </summary>
        public Jxc.JxcCatalogs JxcCatalogs {
            get {
                if (_cacheJxcCatalogs == null) _cacheJxcCatalogs = new Jxc.JxcCatalogs();
                return _cacheJxcCatalogs;
            }
        }

        // JxcProducts表对象缓存
        private Jxc.JxcProducts _cacheJxcProducts = null;

        /// <summary>
        /// 获取 JxcProducts 表定义
        /// </summary>
        public Jxc.JxcProducts JxcProducts {
            get {
                if (_cacheJxcProducts == null) _cacheJxcProducts = new Jxc.JxcProducts();
                return _cacheJxcProducts;
            }
        }

        // JxcProductPrices表对象缓存
        private Jxc.JxcProductPrices _cacheJxcProductPrices = null;

        /// <summary>
        /// 获取 JxcProductPrices 表定义
        /// </summary>
        public Jxc.JxcProductPrices JxcProductPrices {
            get {
                if (_cacheJxcProductPrices == null) _cacheJxcProductPrices = new Jxc.JxcProductPrices();
                return _cacheJxcProductPrices;
            }
        }

        // JxcWarehouses表对象缓存
        private Jxc.JxcWarehouses _cacheJxcWarehouses = null;

        /// <summary>
        /// 获取 JxcWarehouses 表定义
        /// </summary>
        public Jxc.JxcWarehouses JxcWarehouses {
            get {
                if (_cacheJxcWarehouses == null) _cacheJxcWarehouses = new Jxc.JxcWarehouses();
                return _cacheJxcWarehouses;
            }
        }

        // JxcPurchaseList表对象缓存
        private Jxc.JxcPurchaseList _cacheJxcPurchaseList = null;

        /// <summary>
        /// 获取 JxcPurchaseList 表定义
        /// </summary>
        public Jxc.JxcPurchaseList JxcPurchaseList {
            get {
                if (_cacheJxcPurchaseList == null) _cacheJxcPurchaseList = new Jxc.JxcPurchaseList();
                return _cacheJxcPurchaseList;
            }
        }

        // JxcPurchaseProducts表对象缓存
        private Jxc.JxcPurchaseProducts _cacheJxcPurchaseProducts = null;

        /// <summary>
        /// 获取 JxcPurchaseProducts 表定义
        /// </summary>
        public Jxc.JxcPurchaseProducts JxcPurchaseProducts {
            get {
                if (_cacheJxcPurchaseProducts == null) _cacheJxcPurchaseProducts = new Jxc.JxcPurchaseProducts();
                return _cacheJxcPurchaseProducts;
            }
        }

        // JxcSellList表对象缓存
        private Jxc.JxcSellList _cacheJxcSellList = null;

        /// <summary>
        /// 获取 JxcSellList 表定义
        /// </summary>
        public Jxc.JxcSellList JxcSellList {
            get {
                if (_cacheJxcSellList == null) _cacheJxcSellList = new Jxc.JxcSellList();
                return _cacheJxcSellList;
            }
        }

        // JxcSellProducts表对象缓存
        private Jxc.JxcSellProducts _cacheJxcSellProducts = null;

        /// <summary>
        /// 获取 JxcSellProducts 表定义
        /// </summary>
        public Jxc.JxcSellProducts JxcSellProducts {
            get {
                if (_cacheJxcSellProducts == null) _cacheJxcSellProducts = new Jxc.JxcSellProducts();
                return _cacheJxcSellProducts;
            }
        }

        // JxcStocks表对象缓存
        private Jxc.JxcStocks _cacheJxcStocks = null;

        /// <summary>
        /// 获取 JxcStocks 表定义
        /// </summary>
        public Jxc.JxcStocks JxcStocks {
            get {
                if (_cacheJxcStocks == null) _cacheJxcStocks = new Jxc.JxcStocks();
                return _cacheJxcStocks;
            }
        }

        // JxcPayables表对象缓存
        private Jxc.JxcPayables _cacheJxcPayables = null;

        /// <summary>
        /// 获取 JxcPayables 表定义
        /// </summary>
        public Jxc.JxcPayables JxcPayables {
            get {
                if (_cacheJxcPayables == null) _cacheJxcPayables = new Jxc.JxcPayables();
                return _cacheJxcPayables;
            }
        }

        // JxcReceivables表对象缓存
        private Jxc.JxcReceivables _cacheJxcReceivables = null;

        /// <summary>
        /// 获取 JxcReceivables 表定义
        /// </summary>
        public Jxc.JxcReceivables JxcReceivables {
            get {
                if (_cacheJxcReceivables == null) _cacheJxcReceivables = new Jxc.JxcReceivables();
                return _cacheJxcReceivables;
            }
        }

        // SystemAutomatic表对象缓存
        private Kernel.SystemAutomatic _cacheSystemAutomatic = null;

        /// <summary>
        /// 获取 SystemAutomatic 表定义
        /// </summary>
        public Kernel.SystemAutomatic SystemAutomatic {
            get {
                if (_cacheSystemAutomatic == null) _cacheSystemAutomatic = new Kernel.SystemAutomatic();
                return _cacheSystemAutomatic;
            }
        }

        // SystemDepartments表对象缓存
        private Kernel.SystemDepartments _cacheSystemDepartments = null;

        /// <summary>
        /// 获取 SystemDepartments 表定义
        /// </summary>
        public Kernel.SystemDepartments SystemDepartments {
            get {
                if (_cacheSystemDepartments == null) _cacheSystemDepartments = new Kernel.SystemDepartments();
                return _cacheSystemDepartments;
            }
        }

        // SystemDepartmentLimits表对象缓存
        private Kernel.SystemDepartmentLimits _cacheSystemDepartmentLimits = null;

        /// <summary>
        /// 获取 SystemDepartmentLimits 表定义
        /// </summary>
        public Kernel.SystemDepartmentLimits SystemDepartmentLimits {
            get {
                if (_cacheSystemDepartmentLimits == null) _cacheSystemDepartmentLimits = new Kernel.SystemDepartmentLimits();
                return _cacheSystemDepartmentLimits;
            }
        }

        // SystemGroups表对象缓存
        private Kernel.SystemGroups _cacheSystemGroups = null;

        /// <summary>
        /// 获取 SystemGroups 表定义
        /// </summary>
        public Kernel.SystemGroups SystemGroups {
            get {
                if (_cacheSystemGroups == null) _cacheSystemGroups = new Kernel.SystemGroups();
                return _cacheSystemGroups;
            }
        }

        // SystemGroupLimits表对象缓存
        private Kernel.SystemGroupLimits _cacheSystemGroupLimits = null;

        /// <summary>
        /// 获取 SystemGroupLimits 表定义
        /// </summary>
        public Kernel.SystemGroupLimits SystemGroupLimits {
            get {
                if (_cacheSystemGroupLimits == null) _cacheSystemGroupLimits = new Kernel.SystemGroupLimits();
                return _cacheSystemGroupLimits;
            }
        }

        // SystemUserGroups表对象缓存
        private Kernel.SystemUserGroups _cacheSystemUserGroups = null;

        /// <summary>
        /// 获取 SystemUserGroups 表定义
        /// </summary>
        public Kernel.SystemUserGroups SystemUserGroups {
            get {
                if (_cacheSystemUserGroups == null) _cacheSystemUserGroups = new Kernel.SystemUserGroups();
                return _cacheSystemUserGroups;
            }
        }

        // SystemImages表对象缓存
        private Kernel.SystemImages _cacheSystemImages = null;

        /// <summary>
        /// 获取 SystemImages 表定义
        /// </summary>
        public Kernel.SystemImages SystemImages {
            get {
                if (_cacheSystemImages == null) _cacheSystemImages = new Kernel.SystemImages();
                return _cacheSystemImages;
            }
        }

        // SystemGeneralDatas表对象缓存
        private Kernel.SystemGeneralDatas _cacheSystemGeneralDatas = null;

        /// <summary>
        /// 获取 SystemGeneralDatas 表定义
        /// </summary>
        public Kernel.SystemGeneralDatas SystemGeneralDatas {
            get {
                if (_cacheSystemGeneralDatas == null) _cacheSystemGeneralDatas = new Kernel.SystemGeneralDatas();
                return _cacheSystemGeneralDatas;
            }
        }

        // KernelConfig表对象缓存
        private Kernel.KernelConfig _cacheKernelConfig = null;

        /// <summary>
        /// 获取 KernelConfig 表定义
        /// </summary>
        public Kernel.KernelConfig KernelConfig {
            get {
                if (_cacheKernelConfig == null) _cacheKernelConfig = new Kernel.KernelConfig();
                return _cacheKernelConfig;
            }
        }

        // MemberInfos表对象缓存
        private Member.MemberInfos _cacheMemberInfos = null;

        /// <summary>
        /// 获取 MemberInfos 表定义
        /// </summary>
        public Member.MemberInfos MemberInfos {
            get {
                if (_cacheMemberInfos == null) _cacheMemberInfos = new Member.MemberInfos();
                return _cacheMemberInfos;
            }
        }

        // MemberMoney表对象缓存
        private Member.MemberMoney _cacheMemberMoney = null;

        /// <summary>
        /// 获取 MemberMoney 表定义
        /// </summary>
        public Member.MemberMoney MemberMoney {
            get {
                if (_cacheMemberMoney == null) _cacheMemberMoney = new Member.MemberMoney();
                return _cacheMemberMoney;
            }
        }

        // MemberIntegral表对象缓存
        private Member.MemberIntegral _cacheMemberIntegral = null;

        /// <summary>
        /// 获取 MemberIntegral 表定义
        /// </summary>
        public Member.MemberIntegral MemberIntegral {
            get {
                if (_cacheMemberIntegral == null) _cacheMemberIntegral = new Member.MemberIntegral();
                return _cacheMemberIntegral;
            }
        }

        // MemberCard表对象缓存
        private Member.MemberCard _cacheMemberCard = null;

        /// <summary>
        /// 获取 MemberCard 表定义
        /// </summary>
        public Member.MemberCard MemberCard {
            get {
                if (_cacheMemberCard == null) _cacheMemberCard = new Member.MemberCard();
                return _cacheMemberCard;
            }
        }

        // MomentsList表对象缓存
        private Moments.MomentsList _cacheMomentsList = null;

        /// <summary>
        /// 获取 MomentsList 表定义
        /// </summary>
        public Moments.MomentsList MomentsList {
            get {
                if (_cacheMomentsList == null) _cacheMomentsList = new Moments.MomentsList();
                return _cacheMomentsList;
            }
        }

        // MomentsImage表对象缓存
        private Moments.MomentsImage _cacheMomentsImage = null;

        /// <summary>
        /// 获取 MomentsImage 表定义
        /// </summary>
        public Moments.MomentsImage MomentsImage {
            get {
                if (_cacheMomentsImage == null) _cacheMomentsImage = new Moments.MomentsImage();
                return _cacheMomentsImage;
            }
        }

        // MoneyPay表对象缓存
        private Money.MoneyPay _cacheMoneyPay = null;

        /// <summary>
        /// 获取 MoneyPay 表定义
        /// </summary>
        public Money.MoneyPay MoneyPay {
            get {
                if (_cacheMoneyPay == null) _cacheMoneyPay = new Money.MoneyPay();
                return _cacheMoneyPay;
            }
        }

        // MoneyTake表对象缓存
        private Money.MoneyTake _cacheMoneyTake = null;

        /// <summary>
        /// 获取 MoneyTake 表定义
        /// </summary>
        public Money.MoneyTake MoneyTake {
            get {
                if (_cacheMoneyTake == null) _cacheMoneyTake = new Money.MoneyTake();
                return _cacheMoneyTake;
            }
        }

        // MoneyPayTypes表对象缓存
        private Money.MoneyPayTypes _cacheMoneyPayTypes = null;

        /// <summary>
        /// 获取 MoneyPayTypes 表定义
        /// </summary>
        public Money.MoneyPayTypes MoneyPayTypes {
            get {
                if (_cacheMoneyPayTypes == null) _cacheMoneyPayTypes = new Money.MoneyPayTypes();
                return _cacheMoneyPayTypes;
            }
        }

        // OAPosition表对象缓存
        private OA.OAPosition _cacheOAPosition = null;

        /// <summary>
        /// 获取 OAPosition 表定义
        /// </summary>
        public OA.OAPosition OAPosition {
            get {
                if (_cacheOAPosition == null) _cacheOAPosition = new OA.OAPosition();
                return _cacheOAPosition;
            }
        }

        // OAUserPosition表对象缓存
        private OA.OAUserPosition _cacheOAUserPosition = null;

        /// <summary>
        /// 获取 OAUserPosition 表定义
        /// </summary>
        public OA.OAUserPosition OAUserPosition {
            get {
                if (_cacheOAUserPosition == null) _cacheOAUserPosition = new OA.OAUserPosition();
                return _cacheOAUserPosition;
            }
        }

        // OARole表对象缓存
        private OA.OARole _cacheOARole = null;

        /// <summary>
        /// 获取 OARole 表定义
        /// </summary>
        public OA.OARole OARole {
            get {
                if (_cacheOARole == null) _cacheOARole = new OA.OARole();
                return _cacheOARole;
            }
        }

        // OAUserRole表对象缓存
        private OA.OAUserRole _cacheOAUserRole = null;

        /// <summary>
        /// 获取 OAUserRole 表定义
        /// </summary>
        public OA.OAUserRole OAUserRole {
            get {
                if (_cacheOAUserRole == null) _cacheOAUserRole = new OA.OAUserRole();
                return _cacheOAUserRole;
            }
        }

        // Material表对象缓存
        private Produce.Material _cacheMaterial = null;

        /// <summary>
        /// 获取 Material 表定义
        /// </summary>
        public Produce.Material Material {
            get {
                if (_cacheMaterial == null) _cacheMaterial = new Produce.Material();
                return _cacheMaterial;
            }
        }

        // ReleaseCDKey表对象缓存
        private Release.ReleaseCDKey _cacheReleaseCDKey = null;

        /// <summary>
        /// 获取 ReleaseCDKey 表定义
        /// </summary>
        public Release.ReleaseCDKey ReleaseCDKey {
            get {
                if (_cacheReleaseCDKey == null) _cacheReleaseCDKey = new Release.ReleaseCDKey();
                return _cacheReleaseCDKey;
            }
        }

        // ReleaseVersion表对象缓存
        private Release.ReleaseVersion _cacheReleaseVersion = null;

        /// <summary>
        /// 获取 ReleaseVersion 表定义
        /// </summary>
        public Release.ReleaseVersion ReleaseVersion {
            get {
                if (_cacheReleaseVersion == null) _cacheReleaseVersion = new Release.ReleaseVersion();
                return _cacheReleaseVersion;
            }
        }

        // SessionInfo表对象缓存
        private Session.SessionInfo _cacheSessionInfo = null;

        /// <summary>
        /// 获取 SessionInfo 表定义
        /// </summary>
        public Session.SessionInfo SessionInfo {
            get {
                if (_cacheSessionInfo == null) _cacheSessionInfo = new Session.SessionInfo();
                return _cacheSessionInfo;
            }
        }

        // SessionValue表对象缓存
        private Session.SessionValue _cacheSessionValue = null;

        /// <summary>
        /// 获取 SessionValue 表定义
        /// </summary>
        public Session.SessionValue SessionValue {
            get {
                if (_cacheSessionValue == null) _cacheSessionValue = new Session.SessionValue();
                return _cacheSessionValue;
            }
        }

        // Sales3Users表对象缓存
        private Sales3.Sales3Users _cacheSales3Users = null;

        /// <summary>
        /// 获取 Sales3Users 表定义
        /// </summary>
        public Sales3.Sales3Users Sales3Users {
            get {
                if (_cacheSales3Users == null) _cacheSales3Users = new Sales3.Sales3Users();
                return _cacheSales3Users;
            }
        }

        // Sales3Settlement表对象缓存
        private Sales3.Sales3Settlement _cacheSales3Settlement = null;

        /// <summary>
        /// 获取 Sales3Settlement 表定义
        /// </summary>
        public Sales3.Sales3Settlement Sales3Settlement {
            get {
                if (_cacheSales3Settlement == null) _cacheSales3Settlement = new Sales3.Sales3Settlement();
                return _cacheSales3Settlement;
            }
        }

        // Sales3Cash表对象缓存
        private Sales3.Sales3Cash _cacheSales3Cash = null;

        /// <summary>
        /// 获取 Sales3Cash 表定义
        /// </summary>
        public Sales3.Sales3Cash Sales3Cash {
            get {
                if (_cacheSales3Cash == null) _cacheSales3Cash = new Sales3.Sales3Cash();
                return _cacheSales3Cash;
            }
        }

        // TravelScenicArea表对象缓存
        private Travel.TravelScenicArea _cacheTravelScenicArea = null;

        /// <summary>
        /// 获取 TravelScenicArea 表定义
        /// </summary>
        public Travel.TravelScenicArea TravelScenicArea {
            get {
                if (_cacheTravelScenicArea == null) _cacheTravelScenicArea = new Travel.TravelScenicArea();
                return _cacheTravelScenicArea;
            }
        }

        // TravelPicture表对象缓存
        private Travel.TravelPicture _cacheTravelPicture = null;

        /// <summary>
        /// 获取 TravelPicture 表定义
        /// </summary>
        public Travel.TravelPicture TravelPicture {
            get {
                if (_cacheTravelPicture == null) _cacheTravelPicture = new Travel.TravelPicture();
                return _cacheTravelPicture;
            }
        }

        // SystemColumnTypes表对象缓存
        private Table.SystemColumnTypes _cacheSystemColumnTypes = null;

        /// <summary>
        /// 获取 SystemColumnTypes 表定义
        /// </summary>
        public Table.SystemColumnTypes SystemColumnTypes {
            get {
                if (_cacheSystemColumnTypes == null) _cacheSystemColumnTypes = new Table.SystemColumnTypes();
                return _cacheSystemColumnTypes;
            }
        }

        // SystemEventNames表对象缓存
        private Table.SystemEventNames _cacheSystemEventNames = null;

        /// <summary>
        /// 获取 SystemEventNames 表定义
        /// </summary>
        public Table.SystemEventNames SystemEventNames {
            get {
                if (_cacheSystemEventNames == null) _cacheSystemEventNames = new Table.SystemEventNames();
                return _cacheSystemEventNames;
            }
        }

        // SystemEvents表对象缓存
        private Table.SystemEvents _cacheSystemEvents = null;

        /// <summary>
        /// 获取 SystemEvents 表定义
        /// </summary>
        public Table.SystemEvents SystemEvents {
            get {
                if (_cacheSystemEvents == null) _cacheSystemEvents = new Table.SystemEvents();
                return _cacheSystemEvents;
            }
        }

        // SystemHistory表对象缓存
        private Table.SystemHistory _cacheSystemHistory = null;

        /// <summary>
        /// 获取 SystemHistory 表定义
        /// </summary>
        public Table.SystemHistory SystemHistory {
            get {
                if (_cacheSystemHistory == null) _cacheSystemHistory = new Table.SystemHistory();
                return _cacheSystemHistory;
            }
        }

        // SystemPremises表对象缓存
        private Table.SystemPremises _cacheSystemPremises = null;

        /// <summary>
        /// 获取 SystemPremises 表定义
        /// </summary>
        public Table.SystemPremises SystemPremises {
            get {
                if (_cacheSystemPremises == null) _cacheSystemPremises = new Table.SystemPremises();
                return _cacheSystemPremises;
            }
        }

        // SystemPremiseTypes表对象缓存
        private Table.SystemPremiseTypes _cacheSystemPremiseTypes = null;

        /// <summary>
        /// 获取 SystemPremiseTypes 表定义
        /// </summary>
        public Table.SystemPremiseTypes SystemPremiseTypes {
            get {
                if (_cacheSystemPremiseTypes == null) _cacheSystemPremiseTypes = new Table.SystemPremiseTypes();
                return _cacheSystemPremiseTypes;
            }
        }

        // SystemRelation表对象缓存
        private Table.SystemRelation _cacheSystemRelation = null;

        /// <summary>
        /// 获取 SystemRelation 表定义
        /// </summary>
        public Table.SystemRelation SystemRelation {
            get {
                if (_cacheSystemRelation == null) _cacheSystemRelation = new Table.SystemRelation();
                return _cacheSystemRelation;
            }
        }

        // TabFilterPremises表对象缓存
        private Table.TabFilterPremises _cacheTabFilterPremises = null;

        /// <summary>
        /// 获取 TabFilterPremises 表定义
        /// </summary>
        public Table.TabFilterPremises TabFilterPremises {
            get {
                if (_cacheTabFilterPremises == null) _cacheTabFilterPremises = new Table.TabFilterPremises();
                return _cacheTabFilterPremises;
            }
        }

        // TabFilterTrigger表对象缓存
        private Table.TabFilterTrigger _cacheTabFilterTrigger = null;

        /// <summary>
        /// 获取 TabFilterTrigger 表定义
        /// </summary>
        public Table.TabFilterTrigger TabFilterTrigger {
            get {
                if (_cacheTabFilterTrigger == null) _cacheTabFilterTrigger = new Table.TabFilterTrigger();
                return _cacheTabFilterTrigger;
            }
        }

        // TabFilter表对象缓存
        private Table.TabFilter _cacheTabFilter = null;

        /// <summary>
        /// 获取 TabFilter 表定义
        /// </summary>
        public Table.TabFilter TabFilter {
            get {
                if (_cacheTabFilter == null) _cacheTabFilter = new Table.TabFilter();
                return _cacheTabFilter;
            }
        }

        // TabBindingPremises表对象缓存
        private Table.TabBindingPremises _cacheTabBindingPremises = null;

        /// <summary>
        /// 获取 TabBindingPremises 表定义
        /// </summary>
        public Table.TabBindingPremises TabBindingPremises {
            get {
                if (_cacheTabBindingPremises == null) _cacheTabBindingPremises = new Table.TabBindingPremises();
                return _cacheTabBindingPremises;
            }
        }

        // TabBindingColumns表对象缓存
        private Table.TabBindingColumns _cacheTabBindingColumns = null;

        /// <summary>
        /// 获取 TabBindingColumns 表定义
        /// </summary>
        public Table.TabBindingColumns TabBindingColumns {
            get {
                if (_cacheTabBindingColumns == null) _cacheTabBindingColumns = new Table.TabBindingColumns();
                return _cacheTabBindingColumns;
            }
        }

        // TabBindingTables表对象缓存
        private Table.TabBindingTables _cacheTabBindingTables = null;

        /// <summary>
        /// 获取 TabBindingTables 表定义
        /// </summary>
        public Table.TabBindingTables TabBindingTables {
            get {
                if (_cacheTabBindingTables == null) _cacheTabBindingTables = new Table.TabBindingTables();
                return _cacheTabBindingTables;
            }
        }

        // TabBinding表对象缓存
        private Table.TabBinding _cacheTabBinding = null;

        /// <summary>
        /// 获取 TabBinding 表定义
        /// </summary>
        public Table.TabBinding TabBinding {
            get {
                if (_cacheTabBinding == null) _cacheTabBinding = new Table.TabBinding();
                return _cacheTabBinding;
            }
        }

        // Table2D表对象缓存
        private Table.Table2D _cacheTable2D = null;

        /// <summary>
        /// 获取 Table2D 表定义
        /// </summary>
        public Table.Table2D Table2D {
            get {
                if (_cacheTable2D == null) _cacheTable2D = new Table.Table2D();
                return _cacheTable2D;
            }
        }

        // UserInfos表对象缓存
        private User.UserInfos _cacheUserInfos = null;

        /// <summary>
        /// 获取 UserInfos 表定义
        /// </summary>
        public User.UserInfos UserInfos {
            get {
                if (_cacheUserInfos == null) _cacheUserInfos = new User.UserInfos();
                return _cacheUserInfos;
            }
        }

        // UserTypes表对象缓存
        private User.UserTypes _cacheUserTypes = null;

        /// <summary>
        /// 获取 UserTypes 表定义
        /// </summary>
        public User.UserTypes UserTypes {
            get {
                if (_cacheUserTypes == null) _cacheUserTypes = new User.UserTypes();
                return _cacheUserTypes;
            }
        }

        // UserConfigs表对象缓存
        private User.UserConfigs _cacheUserConfigs = null;

        /// <summary>
        /// 获取 UserConfigs 表定义
        /// </summary>
        public User.UserConfigs UserConfigs {
            get {
                if (_cacheUserConfigs == null) _cacheUserConfigs = new User.UserConfigs();
                return _cacheUserConfigs;
            }
        }

        // VideoSeries表对象缓存
        private Video.VideoSeries _cacheVideoSeries = null;

        /// <summary>
        /// 获取 VideoSeries 表定义
        /// </summary>
        public Video.VideoSeries VideoSeries {
            get {
                if (_cacheVideoSeries == null) _cacheVideoSeries = new Video.VideoSeries();
                return _cacheVideoSeries;
            }
        }

        // VideoGroup表对象缓存
        private Video.VideoGroup _cacheVideoGroup = null;

        /// <summary>
        /// 获取 VideoGroup 表定义
        /// </summary>
        public Video.VideoGroup VideoGroup {
            get {
                if (_cacheVideoGroup == null) _cacheVideoGroup = new Video.VideoGroup();
                return _cacheVideoGroup;
            }
        }

        // VideoInfo表对象缓存
        private Video.VideoInfo _cacheVideoInfo = null;

        /// <summary>
        /// 获取 VideoInfo 表定义
        /// </summary>
        public Video.VideoInfo VideoInfo {
            get {
                if (_cacheVideoInfo == null) _cacheVideoInfo = new Video.VideoInfo();
                return _cacheVideoInfo;
            }
        }

        // WebSites表对象缓存
        private Web.WebSites _cacheWebSites = null;

        /// <summary>
        /// 获取 WebSites 表定义
        /// </summary>
        public Web.WebSites WebSites {
            get {
                if (_cacheWebSites == null) _cacheWebSites = new Web.WebSites();
                return _cacheWebSites;
            }
        }

        // WebMuds表对象缓存
        private Web.WebMuds _cacheWebMuds = null;

        /// <summary>
        /// 获取 WebMuds 表定义
        /// </summary>
        public Web.WebMuds WebMuds {
            get {
                if (_cacheWebMuds == null) _cacheWebMuds = new Web.WebMuds();
                return _cacheWebMuds;
            }
        }

        // WebSections表对象缓存
        private Web.WebSections _cacheWebSections = null;

        /// <summary>
        /// 获取 WebSections 表定义
        /// </summary>
        public Web.WebSections WebSections {
            get {
                if (_cacheWebSections == null) _cacheWebSections = new Web.WebSections();
                return _cacheWebSections;
            }
        }

        // WebHtmls表对象缓存
        private Web.WebHtmls _cacheWebHtmls = null;

        /// <summary>
        /// 获取 WebHtmls 表定义
        /// </summary>
        public Web.WebHtmls WebHtmls {
            get {
                if (_cacheWebHtmls == null) _cacheWebHtmls = new Web.WebHtmls();
                return _cacheWebHtmls;
            }
        }

        // WebArticleCatalog表对象缓存
        private Web.WebArticleCatalog _cacheWebArticleCatalog = null;

        /// <summary>
        /// 获取 WebArticleCatalog 表定义
        /// </summary>
        public Web.WebArticleCatalog WebArticleCatalog {
            get {
                if (_cacheWebArticleCatalog == null) _cacheWebArticleCatalog = new Web.WebArticleCatalog();
                return _cacheWebArticleCatalog;
            }
        }

        // WebArticleList表对象缓存
        private Web.WebArticleList _cacheWebArticleList = null;

        /// <summary>
        /// 获取 WebArticleList 表定义
        /// </summary>
        public Web.WebArticleList WebArticleList {
            get {
                if (_cacheWebArticleList == null) _cacheWebArticleList = new Web.WebArticleList();
                return _cacheWebArticleList;
            }
        }

        // WebAds表对象缓存
        private Web.WebAds _cacheWebAds = null;

        /// <summary>
        /// 获取 WebAds 表定义
        /// </summary>
        public Web.WebAds WebAds {
            get {
                if (_cacheWebAds == null) _cacheWebAds = new Web.WebAds();
                return _cacheWebAds;
            }
        }

        // WebComments表对象缓存
        private Web.WebComments _cacheWebComments = null;

        /// <summary>
        /// 获取 WebComments 表定义
        /// </summary>
        public Web.WebComments WebComments {
            get {
                if (_cacheWebComments == null) _cacheWebComments = new Web.WebComments();
                return _cacheWebComments;
            }
        }

        // WebHomeModule表对象缓存
        private Web.WebHomeModule _cacheWebHomeModule = null;

        /// <summary>
        /// 获取 WebHomeModule 表定义
        /// </summary>
        public Web.WebHomeModule WebHomeModule {
            get {
                if (_cacheWebHomeModule == null) _cacheWebHomeModule = new Web.WebHomeModule();
                return _cacheWebHomeModule;
            }
        }

        // WebImgList表对象缓存
        private Web.WebImgList _cacheWebImgList = null;

        /// <summary>
        /// 获取 WebImgList 表定义
        /// </summary>
        public Web.WebImgList WebImgList {
            get {
                if (_cacheWebImgList == null) _cacheWebImgList = new Web.WebImgList();
                return _cacheWebImgList;
            }
        }

        // WebSpread表对象缓存
        private Web.WebSpread _cacheWebSpread = null;

        /// <summary>
        /// 获取 WebSpread 表定义
        /// </summary>
        public Web.WebSpread WebSpread {
            get {
                if (_cacheWebSpread == null) _cacheWebSpread = new Web.WebSpread();
                return _cacheWebSpread;
            }
        }

        // LoanApply表对象缓存
        private Web_Loan.LoanApply _cacheLoanApply = null;

        /// <summary>
        /// 获取 LoanApply 表定义
        /// </summary>
        public Web_Loan.LoanApply LoanApply {
            get {
                if (_cacheLoanApply == null) _cacheLoanApply = new Web_Loan.LoanApply();
                return _cacheLoanApply;
            }
        }

        // LoanSpread表对象缓存
        private Web_Loan.LoanSpread _cacheLoanSpread = null;

        /// <summary>
        /// 获取 LoanSpread 表定义
        /// </summary>
        public Web_Loan.LoanSpread LoanSpread {
            get {
                if (_cacheLoanSpread == null) _cacheLoanSpread = new Web_Loan.LoanSpread();
                return _cacheLoanSpread;
            }
        }

        // LoanBusinessEvaluation表对象缓存
        private Web_Loan.LoanBusinessEvaluation _cacheLoanBusinessEvaluation = null;

        /// <summary>
        /// 获取 LoanBusinessEvaluation 表定义
        /// </summary>
        public Web_Loan.LoanBusinessEvaluation LoanBusinessEvaluation {
            get {
                if (_cacheLoanBusinessEvaluation == null) _cacheLoanBusinessEvaluation = new Web_Loan.LoanBusinessEvaluation();
                return _cacheLoanBusinessEvaluation;
            }
        }

        // LoanClient表对象缓存
        private Web_Loan.LoanClient _cacheLoanClient = null;

        /// <summary>
        /// 获取 LoanClient 表定义
        /// </summary>
        public Web_Loan.LoanClient LoanClient {
            get {
                if (_cacheLoanClient == null) _cacheLoanClient = new Web_Loan.LoanClient();
                return _cacheLoanClient;
            }
        }

        // LoanBusiness表对象缓存
        private Web_Loan.LoanBusiness _cacheLoanBusiness = null;

        /// <summary>
        /// 获取 LoanBusiness 表定义
        /// </summary>
        public Web_Loan.LoanBusiness LoanBusiness {
            get {
                if (_cacheLoanBusiness == null) _cacheLoanBusiness = new Web_Loan.LoanBusiness();
                return _cacheLoanBusiness;
            }
        }

        // MallUsers表对象缓存
        private Web_Mall.MallUsers _cacheMallUsers = null;

        /// <summary>
        /// 获取 MallUsers 表定义
        /// </summary>
        public Web_Mall.MallUsers MallUsers {
            get {
                if (_cacheMallUsers == null) _cacheMallUsers = new Web_Mall.MallUsers();
                return _cacheMallUsers;
            }
        }

        // MallUserLvs表对象缓存
        private Web_Mall.MallUserLvs _cacheMallUserLvs = null;

        /// <summary>
        /// 获取 MallUserLvs 表定义
        /// </summary>
        public Web_Mall.MallUserLvs MallUserLvs {
            get {
                if (_cacheMallUserLvs == null) _cacheMallUserLvs = new Web_Mall.MallUserLvs();
                return _cacheMallUserLvs;
            }
        }

        // MallCatalogs表对象缓存
        private Web_Mall.MallCatalogs _cacheMallCatalogs = null;

        /// <summary>
        /// 获取 MallCatalogs 表定义
        /// </summary>
        public Web_Mall.MallCatalogs MallCatalogs {
            get {
                if (_cacheMallCatalogs == null) _cacheMallCatalogs = new Web_Mall.MallCatalogs();
                return _cacheMallCatalogs;
            }
        }

        // MallProduct表对象缓存
        private Web_Mall.MallProduct _cacheMallProduct = null;

        /// <summary>
        /// 获取 MallProduct 表定义
        /// </summary>
        public Web_Mall.MallProduct MallProduct {
            get {
                if (_cacheMallProduct == null) _cacheMallProduct = new Web_Mall.MallProduct();
                return _cacheMallProduct;
            }
        }

        // MallGoodImages表对象缓存
        private Web_Mall.MallGoodImages _cacheMallGoodImages = null;

        /// <summary>
        /// 获取 MallGoodImages 表定义
        /// </summary>
        public Web_Mall.MallGoodImages MallGoodImages {
            get {
                if (_cacheMallGoodImages == null) _cacheMallGoodImages = new Web_Mall.MallGoodImages();
                return _cacheMallGoodImages;
            }
        }

        // MallGoodDetail表对象缓存
        private Web_Mall.MallGoodDetail _cacheMallGoodDetail = null;

        /// <summary>
        /// 获取 MallGoodDetail 表定义
        /// </summary>
        public Web_Mall.MallGoodDetail MallGoodDetail {
            get {
                if (_cacheMallGoodDetail == null) _cacheMallGoodDetail = new Web_Mall.MallGoodDetail();
                return _cacheMallGoodDetail;
            }
        }

        // MallOrder表对象缓存
        private Web_Mall.MallOrder _cacheMallOrder = null;

        /// <summary>
        /// 获取 MallOrder 表定义
        /// </summary>
        public Web_Mall.MallOrder MallOrder {
            get {
                if (_cacheMallOrder == null) _cacheMallOrder = new Web_Mall.MallOrder();
                return _cacheMallOrder;
            }
        }

        // MallOrderProduct表对象缓存
        private Web_Mall.MallOrderProduct _cacheMallOrderProduct = null;

        /// <summary>
        /// 获取 MallOrderProduct 表定义
        /// </summary>
        public Web_Mall.MallOrderProduct MallOrderProduct {
            get {
                if (_cacheMallOrderProduct == null) _cacheMallOrderProduct = new Web_Mall.MallOrderProduct();
                return _cacheMallOrderProduct;
            }
        }

        // MallRecharges表对象缓存
        private Web_Mall.MallRecharges _cacheMallRecharges = null;

        /// <summary>
        /// 获取 MallRecharges 表定义
        /// </summary>
        public Web_Mall.MallRecharges MallRecharges {
            get {
                if (_cacheMallRecharges == null) _cacheMallRecharges = new Web_Mall.MallRecharges();
                return _cacheMallRecharges;
            }
        }

        // MallContacts表对象缓存
        private Web_Mall.MallContacts _cacheMallContacts = null;

        /// <summary>
        /// 获取 MallContacts 表定义
        /// </summary>
        public Web_Mall.MallContacts MallContacts {
            get {
                if (_cacheMallContacts == null) _cacheMallContacts = new Web_Mall.MallContacts();
                return _cacheMallContacts;
            }
        }

        // MallAddress表对象缓存
        private Web_Mall.MallAddress _cacheMallAddress = null;

        /// <summary>
        /// 获取 MallAddress 表定义
        /// </summary>
        public Web_Mall.MallAddress MallAddress {
            get {
                if (_cacheMallAddress == null) _cacheMallAddress = new Web_Mall.MallAddress();
                return _cacheMallAddress;
            }
        }

        // MallPay表对象缓存
        private Web_Mall.MallPay _cacheMallPay = null;

        /// <summary>
        /// 获取 MallPay 表定义
        /// </summary>
        public Web_Mall.MallPay MallPay {
            get {
                if (_cacheMallPay == null) _cacheMallPay = new Web_Mall.MallPay();
                return _cacheMallPay;
            }
        }

        // MallGoodVisited表对象缓存
        private Web_Mall.MallGoodVisited _cacheMallGoodVisited = null;

        /// <summary>
        /// 获取 MallGoodVisited 表定义
        /// </summary>
        public Web_Mall.MallGoodVisited MallGoodVisited {
            get {
                if (_cacheMallGoodVisited == null) _cacheMallGoodVisited = new Web_Mall.MallGoodVisited();
                return _cacheMallGoodVisited;
            }
        }

        // MallVisitedKey表对象缓存
        private Web_Mall.MallVisitedKey _cacheMallVisitedKey = null;

        /// <summary>
        /// 获取 MallVisitedKey 表定义
        /// </summary>
        public Web_Mall.MallVisitedKey MallVisitedKey {
            get {
                if (_cacheMallVisitedKey == null) _cacheMallVisitedKey = new Web_Mall.MallVisitedKey();
                return _cacheMallVisitedKey;
            }
        }

        // MallIntegral表对象缓存
        private Web_Mall.MallIntegral _cacheMallIntegral = null;

        /// <summary>
        /// 获取 MallIntegral 表定义
        /// </summary>
        public Web_Mall.MallIntegral MallIntegral {
            get {
                if (_cacheMallIntegral == null) _cacheMallIntegral = new Web_Mall.MallIntegral();
                return _cacheMallIntegral;
            }
        }

        // MallStock表对象缓存
        private Web_Mall.MallStock _cacheMallStock = null;

        /// <summary>
        /// 获取 MallStock 表定义
        /// </summary>
        public Web_Mall.MallStock MallStock {
            get {
                if (_cacheMallStock == null) _cacheMallStock = new Web_Mall.MallStock();
                return _cacheMallStock;
            }
        }

        // MallFreightes表对象缓存
        private Web_Mall.MallFreightes _cacheMallFreightes = null;

        /// <summary>
        /// 获取 MallFreightes 表定义
        /// </summary>
        public Web_Mall.MallFreightes MallFreightes {
            get {
                if (_cacheMallFreightes == null) _cacheMallFreightes = new Web_Mall.MallFreightes();
                return _cacheMallFreightes;
            }
        }

        // PlatformFloors表对象缓存
        private Web_Platform.PlatformFloors _cachePlatformFloors = null;

        /// <summary>
        /// 获取 PlatformFloors 表定义
        /// </summary>
        public Web_Platform.PlatformFloors PlatformFloors {
            get {
                if (_cachePlatformFloors == null) _cachePlatformFloors = new Web_Platform.PlatformFloors();
                return _cachePlatformFloors;
            }
        }

        // PlatformShop表对象缓存
        private Web_Platform.PlatformShop _cachePlatformShop = null;

        /// <summary>
        /// 获取 PlatformShop 表定义
        /// </summary>
        public Web_Platform.PlatformShop PlatformShop {
            get {
                if (_cachePlatformShop == null) _cachePlatformShop = new Web_Platform.PlatformShop();
                return _cachePlatformShop;
            }
        }

        // PlatformStar表对象缓存
        private Web_Platform.PlatformStar _cachePlatformStar = null;

        /// <summary>
        /// 获取 PlatformStar 表定义
        /// </summary>
        public Web_Platform.PlatformStar PlatformStar {
            get {
                if (_cachePlatformStar == null) _cachePlatformStar = new Web_Platform.PlatformStar();
                return _cachePlatformStar;
            }
        }

        // PlatformPraise表对象缓存
        private Web_Platform.PlatformPraise _cachePlatformPraise = null;

        /// <summary>
        /// 获取 PlatformPraise 表定义
        /// </summary>
        public Web_Platform.PlatformPraise PlatformPraise {
            get {
                if (_cachePlatformPraise == null) _cachePlatformPraise = new Web_Platform.PlatformPraise();
                return _cachePlatformPraise;
            }
        }

        // PlatformVotes表对象缓存
        private Web_Platform.PlatformVotes _cachePlatformVotes = null;

        /// <summary>
        /// 获取 PlatformVotes 表定义
        /// </summary>
        public Web_Platform.PlatformVotes PlatformVotes {
            get {
                if (_cachePlatformVotes == null) _cachePlatformVotes = new Web_Platform.PlatformVotes();
                return _cachePlatformVotes;
            }
        }

        // PlatformVoteItems表对象缓存
        private Web_Platform.PlatformVoteItems _cachePlatformVoteItems = null;

        /// <summary>
        /// 获取 PlatformVoteItems 表定义
        /// </summary>
        public Web_Platform.PlatformVoteItems PlatformVoteItems {
            get {
                if (_cachePlatformVoteItems == null) _cachePlatformVoteItems = new Web_Platform.PlatformVoteItems();
                return _cachePlatformVoteItems;
            }
        }

        // PlatformVoteCast表对象缓存
        private Web_Platform.PlatformVoteCast _cachePlatformVoteCast = null;

        /// <summary>
        /// 获取 PlatformVoteCast 表定义
        /// </summary>
        public Web_Platform.PlatformVoteCast PlatformVoteCast {
            get {
                if (_cachePlatformVoteCast == null) _cachePlatformVoteCast = new Web_Platform.PlatformVoteCast();
                return _cachePlatformVoteCast;
            }
        }

        // PlatformBrands表对象缓存
        private Web_Platform.PlatformBrands _cachePlatformBrands = null;

        /// <summary>
        /// 获取 PlatformBrands 表定义
        /// </summary>
        public Web_Platform.PlatformBrands PlatformBrands {
            get {
                if (_cachePlatformBrands == null) _cachePlatformBrands = new Web_Platform.PlatformBrands();
                return _cachePlatformBrands;
            }
        }

        // PlatformProducts表对象缓存
        private Web_Platform.PlatformProducts _cachePlatformProducts = null;

        /// <summary>
        /// 获取 PlatformProducts 表定义
        /// </summary>
        public Web_Platform.PlatformProducts PlatformProducts {
            get {
                if (_cachePlatformProducts == null) _cachePlatformProducts = new Web_Platform.PlatformProducts();
                return _cachePlatformProducts;
            }
        }

        // PlatformSearch表对象缓存
        private Web_Platform.PlatformSearch _cachePlatformSearch = null;

        /// <summary>
        /// 获取 PlatformSearch 表定义
        /// </summary>
        public Web_Platform.PlatformSearch PlatformSearch {
            get {
                if (_cachePlatformSearch == null) _cachePlatformSearch = new Web_Platform.PlatformSearch();
                return _cachePlatformSearch;
            }
        }

        // PlatformSearchHistory表对象缓存
        private Web_Platform.PlatformSearchHistory _cachePlatformSearchHistory = null;

        /// <summary>
        /// 获取 PlatformSearchHistory 表定义
        /// </summary>
        public Web_Platform.PlatformSearchHistory PlatformSearchHistory {
            get {
                if (_cachePlatformSearchHistory == null) _cachePlatformSearchHistory = new Web_Platform.PlatformSearchHistory();
                return _cachePlatformSearchHistory;
            }
        }

        // PlatformReg表对象缓存
        private Web_Platform.PlatformReg _cachePlatformReg = null;

        /// <summary>
        /// 获取 PlatformReg 表定义
        /// </summary>
        public Web_Platform.PlatformReg PlatformReg {
            get {
                if (_cachePlatformReg == null) _cachePlatformReg = new Web_Platform.PlatformReg();
                return _cachePlatformReg;
            }
        }

        // PlatformArchitectures表对象缓存
        private Web_Platform.PlatformArchitectures _cachePlatformArchitectures = null;

        /// <summary>
        /// 获取 PlatformArchitectures 表定义
        /// </summary>
        public Web_Platform.PlatformArchitectures PlatformArchitectures {
            get {
                if (_cachePlatformArchitectures == null) _cachePlatformArchitectures = new Web_Platform.PlatformArchitectures();
                return _cachePlatformArchitectures;
            }
        }

        // PlatformShopArchitectures表对象缓存
        private Web_Platform.PlatformShopArchitectures _cachePlatformShopArchitectures = null;

        /// <summary>
        /// 获取 PlatformShopArchitectures 表定义
        /// </summary>
        public Web_Platform.PlatformShopArchitectures PlatformShopArchitectures {
            get {
                if (_cachePlatformShopArchitectures == null) _cachePlatformShopArchitectures = new Web_Platform.PlatformShopArchitectures();
                return _cachePlatformShopArchitectures;
            }
        }

        // WeixinUsers表对象缓存
        private Web_Weixin.WeixinUsers _cacheWeixinUsers = null;

        /// <summary>
        /// 获取 WeixinUsers 表定义
        /// </summary>
        public Web_Weixin.WeixinUsers WeixinUsers {
            get {
                if (_cacheWeixinUsers == null) _cacheWeixinUsers = new Web_Weixin.WeixinUsers();
                return _cacheWeixinUsers;
            }
        }

        // WeixinActivity表对象缓存
        private Web_Weixin.WeixinActivity _cacheWeixinActivity = null;

        /// <summary>
        /// 获取 WeixinActivity 表定义
        /// </summary>
        public Web_Weixin.WeixinActivity WeixinActivity {
            get {
                if (_cacheWeixinActivity == null) _cacheWeixinActivity = new Web_Weixin.WeixinActivity();
                return _cacheWeixinActivity;
            }
        }

        // WeixinActivityJoin表对象缓存
        private Web_Weixin.WeixinActivityJoin _cacheWeixinActivityJoin = null;

        /// <summary>
        /// 获取 WeixinActivityJoin 表定义
        /// </summary>
        public Web_Weixin.WeixinActivityJoin WeixinActivityJoin {
            get {
                if (_cacheWeixinActivityJoin == null) _cacheWeixinActivityJoin = new Web_Weixin.WeixinActivityJoin();
                return _cacheWeixinActivityJoin;
            }
        }

        // WeixinRedEnvelopes表对象缓存
        private Web_Weixin.WeixinRedEnvelopes _cacheWeixinRedEnvelopes = null;

        /// <summary>
        /// 获取 WeixinRedEnvelopes 表定义
        /// </summary>
        public Web_Weixin.WeixinRedEnvelopes WeixinRedEnvelopes {
            get {
                if (_cacheWeixinRedEnvelopes == null) _cacheWeixinRedEnvelopes = new Web_Weixin.WeixinRedEnvelopes();
                return _cacheWeixinRedEnvelopes;
            }
        }

        // YYGoods表对象缓存
        private Web_YYMall.YYGoods _cacheYYGoods = null;

        /// <summary>
        /// 获取 YYGoods 表定义
        /// </summary>
        public Web_YYMall.YYGoods YYGoods {
            get {
                if (_cacheYYGoods == null) _cacheYYGoods = new Web_YYMall.YYGoods();
                return _cacheYYGoods;
            }
        }

        // YYOrders表对象缓存
        private Web_YYMall.YYOrders _cacheYYOrders = null;

        /// <summary>
        /// 获取 YYOrders 表定义
        /// </summary>
        public Web_YYMall.YYOrders YYOrders {
            get {
                if (_cacheYYOrders == null) _cacheYYOrders = new Web_YYMall.YYOrders();
                return _cacheYYOrders;
            }
        }

        // YYLottery表对象缓存
        private Web_YYMall.YYLottery _cacheYYLottery = null;

        /// <summary>
        /// 获取 YYLottery 表定义
        /// </summary>
        public Web_YYMall.YYLottery YYLottery {
            get {
                if (_cacheYYLottery == null) _cacheYYLottery = new Web_YYMall.YYLottery();
                return _cacheYYLottery;
            }
        }

        // YYGoodShow表对象缓存
        private Web_YYMall.YYGoodShow _cacheYYGoodShow = null;

        /// <summary>
        /// 获取 YYGoodShow 表定义
        /// </summary>
        public Web_YYMall.YYGoodShow YYGoodShow {
            get {
                if (_cacheYYGoodShow == null) _cacheYYGoodShow = new Web_YYMall.YYGoodShow();
                return _cacheYYGoodShow;
            }
        }

        // YYGoodShowImage表对象缓存
        private Web_YYMall.YYGoodShowImage _cacheYYGoodShowImage = null;

        /// <summary>
        /// 获取 YYGoodShowImage 表定义
        /// </summary>
        public Web_YYMall.YYGoodShowImage YYGoodShowImage {
            get {
                if (_cacheYYGoodShowImage == null) _cacheYYGoodShowImage = new Web_YYMall.YYGoodShowImage();
                return _cacheYYGoodShowImage;
            }
        }

        // YYGoodLottery表对象缓存
        private Web_YYMall.YYGoodLottery _cacheYYGoodLottery = null;

        /// <summary>
        /// 获取 YYGoodLottery 表定义
        /// </summary>
        public Web_YYMall.YYGoodLottery YYGoodLottery {
            get {
                if (_cacheYYGoodLottery == null) _cacheYYGoodLottery = new Web_YYMall.YYGoodLottery();
                return _cacheYYGoodLottery;
            }
        }

        // YYGoodShowVerify表对象缓存
        private Web_YYMall.YYGoodShowVerify _cacheYYGoodShowVerify = null;

        /// <summary>
        /// 获取 YYGoodShowVerify 表定义
        /// </summary>
        public Web_YYMall.YYGoodShowVerify YYGoodShowVerify {
            get {
                if (_cacheYYGoodShowVerify == null) _cacheYYGoodShowVerify = new Web_YYMall.YYGoodShowVerify();
                return _cacheYYGoodShowVerify;
            }
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        protected override void OnDispose() {
            base.OnDispose();

            if (_cacheActivityNew != null) {
                _cacheActivityNew.Dispose();
                _cacheActivityNew = null;
            }

            if (_cacheAIWords != null) {
                _cacheAIWords.Dispose();
                _cacheAIWords = null;
            }

            if (_cacheAIMemory != null) {
                _cacheAIMemory.Dispose();
                _cacheAIMemory = null;
            }

            if (_cacheAosObjects != null) {
                _cacheAosObjects.Dispose();
                _cacheAosObjects = null;
            }

            if (_cacheAosAuthorize != null) {
                _cacheAosAuthorize.Dispose();
                _cacheAosAuthorize = null;
            }

            if (_cacheAosAuthorizeCode != null) {
                _cacheAosAuthorizeCode.Dispose();
                _cacheAosAuthorizeCode = null;
            }

            if (_cacheAosSessions != null) {
                _cacheAosSessions.Dispose();
                _cacheAosSessions = null;
            }

            if (_cacheAosSessionProcesses != null) {
                _cacheAosSessionProcesses.Dispose();
                _cacheAosSessionProcesses = null;
            }

            if (_cacheAosSessionValues != null) {
                _cacheAosSessionValues.Dispose();
                _cacheAosSessionValues = null;
            }

            if (_cacheAosLog != null) {
                _cacheAosLog.Dispose();
                _cacheAosLog = null;
            }

            if (_cacheAosLogInterfaceData != null) {
                _cacheAosLogInterfaceData.Dispose();
                _cacheAosLogInterfaceData = null;
            }

            if (_cacheAosApps != null) {
                _cacheAosApps.Dispose();
                _cacheAosApps = null;
            }

            if (_cacheAosAppStores != null) {
                _cacheAosAppStores.Dispose();
                _cacheAosAppStores = null;
            }

            if (_cacheAosPlugs != null) {
                _cacheAosPlugs.Dispose();
                _cacheAosPlugs = null;
            }

            if (_cacheAosUsers != null) {
                _cacheAosUsers.Dispose();
                _cacheAosUsers = null;
            }

            if (_cacheAosLimits != null) {
                _cacheAosLimits.Dispose();
                _cacheAosLimits = null;
            }

            if (_cacheAosIPInfo != null) {
                _cacheAosIPInfo.Dispose();
                _cacheAosIPInfo = null;
            }

            if (_cacheAosUserApps != null) {
                _cacheAosUserApps.Dispose();
                _cacheAosUserApps = null;
            }

            if (_cacheAosUserAuthorize != null) {
                _cacheAosUserAuthorize.Dispose();
                _cacheAosUserAuthorize = null;
            }

            if (_cacheAosUserSetting != null) {
                _cacheAosUserSetting.Dispose();
                _cacheAosUserSetting = null;
            }

            if (_cacheAosSetting != null) {
                _cacheAosSetting.Dispose();
                _cacheAosSetting = null;
            }

            if (_cacheAosAppLimits != null) {
                _cacheAosAppLimits.Dispose();
                _cacheAosAppLimits = null;
            }

            if (_cacheAosAppCatalogs != null) {
                _cacheAosAppCatalogs.Dispose();
                _cacheAosAppCatalogs = null;
            }

            if (_cacheAosCount != null) {
                _cacheAosCount.Dispose();
                _cacheAosCount = null;
            }

            if (_cacheAosDesktopApps != null) {
                _cacheAosDesktopApps.Dispose();
                _cacheAosDesktopApps = null;
            }

            if (_cacheAosDesktopAuthorizes != null) {
                _cacheAosDesktopAuthorizes.Dispose();
                _cacheAosDesktopAuthorizes = null;
            }

            if (_cacheAosDesktops != null) {
                _cacheAosDesktops.Dispose();
                _cacheAosDesktops = null;
            }

            if (_cacheAosThirdWeixin != null) {
                _cacheAosThirdWeixin.Dispose();
                _cacheAosThirdWeixin = null;
            }

            if (_cacheAosFiles != null) {
                _cacheAosFiles.Dispose();
                _cacheAosFiles = null;
            }

            if (_cacheAosMessages != null) {
                _cacheAosMessages.Dispose();
                _cacheAosMessages = null;
            }

            if (_cacheAosMessagesRead != null) {
                _cacheAosMessagesRead.Dispose();
                _cacheAosMessagesRead = null;
            }

            if (_cacheAppInfos != null) {
                _cacheAppInfos.Dispose();
                _cacheAppInfos = null;
            }

            if (_cacheAppLimits != null) {
                _cacheAppLimits.Dispose();
                _cacheAppLimits = null;
            }

            if (_cacheAssessInfos != null) {
                _cacheAssessInfos.Dispose();
                _cacheAssessInfos = null;
            }

            if (_cacheAssessItems != null) {
                _cacheAssessItems.Dispose();
                _cacheAssessItems = null;
            }

            if (_cacheAssessScore != null) {
                _cacheAssessScore.Dispose();
                _cacheAssessScore = null;
            }

            if (_cacheAssessItemScore != null) {
                _cacheAssessItemScore.Dispose();
                _cacheAssessItemScore = null;
            }

            if (_cacheAssessRoundScore != null) {
                _cacheAssessRoundScore.Dispose();
                _cacheAssessRoundScore = null;
            }

            if (_cacheAssessUsers != null) {
                _cacheAssessUsers.Dispose();
                _cacheAssessUsers = null;
            }

            if (_cacheSystemObjects != null) {
                _cacheSystemObjects.Dispose();
                _cacheSystemObjects = null;
            }

            if (_cacheSystemLimits != null) {
                _cacheSystemLimits.Dispose();
                _cacheSystemLimits = null;
            }

            if (_cacheSystemObjectLimits != null) {
                _cacheSystemObjectLimits.Dispose();
                _cacheSystemObjectLimits = null;
            }

            if (_cacheSystemUsers != null) {
                _cacheSystemUsers.Dispose();
                _cacheSystemUsers = null;
            }

            if (_cacheSystemUserAppLimits != null) {
                _cacheSystemUserAppLimits.Dispose();
                _cacheSystemUserAppLimits = null;
            }

            if (_cacheSystemUserLimits != null) {
                _cacheSystemUserLimits.Dispose();
                _cacheSystemUserLimits = null;
            }

            if (_cacheSystemMessages != null) {
                _cacheSystemMessages.Dispose();
                _cacheSystemMessages = null;
            }

            if (_cacheSystemCatalog != null) {
                _cacheSystemCatalog.Dispose();
                _cacheSystemCatalog = null;
            }

            if (_cacheSystemTableTypes != null) {
                _cacheSystemTableTypes.Dispose();
                _cacheSystemTableTypes = null;
            }

            if (_cacheSystemTables != null) {
                _cacheSystemTables.Dispose();
                _cacheSystemTables = null;
            }

            if (_cacheSystemColumns != null) {
                _cacheSystemColumns.Dispose();
                _cacheSystemColumns = null;
            }

            if (_cacheSystemUserTableVisits != null) {
                _cacheSystemUserTableVisits.Dispose();
                _cacheSystemUserTableVisits = null;
            }

            if (_cacheChatInfo != null) {
                _cacheChatInfo.Dispose();
                _cacheChatInfo = null;
            }

            if (_cacheChatToUser != null) {
                _cacheChatToUser.Dispose();
                _cacheChatToUser = null;
            }

            if (_cacheChatToGroup != null) {
                _cacheChatToGroup.Dispose();
                _cacheChatToGroup = null;
            }

            if (_cacheChatMessage != null) {
                _cacheChatMessage.Dispose();
                _cacheChatMessage = null;
            }

            if (_cacheChatReceive != null) {
                _cacheChatReceive.Dispose();
                _cacheChatReceive = null;
            }

            if (_cacheCloudList != null) {
                _cacheCloudList.Dispose();
                _cacheCloudList = null;
            }

            if (_cacheCloudHistory != null) {
                _cacheCloudHistory.Dispose();
                _cacheCloudHistory = null;
            }

            if (_cacheCloudFiles != null) {
                _cacheCloudFiles.Dispose();
                _cacheCloudFiles = null;
            }

            if (_cacheCloudFileHistory != null) {
                _cacheCloudFileHistory.Dispose();
                _cacheCloudFileHistory = null;
            }

            if (_cacheCloudUserStore != null) {
                _cacheCloudUserStore.Dispose();
                _cacheCloudUserStore = null;
            }

            if (_cacheCloudOfficeFiles != null) {
                _cacheCloudOfficeFiles.Dispose();
                _cacheCloudOfficeFiles = null;
            }

            if (_cacheCloudExchangeFiles != null) {
                _cacheCloudExchangeFiles.Dispose();
                _cacheCloudExchangeFiles = null;
            }

            if (_cacheCloudStorageDisk != null) {
                _cacheCloudStorageDisk.Dispose();
                _cacheCloudStorageDisk = null;
            }

            if (_cacheCloudStorageFolder != null) {
                _cacheCloudStorageFolder.Dispose();
                _cacheCloudStorageFolder = null;
            }

            if (_cacheCloudStorageFile != null) {
                _cacheCloudStorageFile.Dispose();
                _cacheCloudStorageFile = null;
            }

            if (_cacheCloudStorageFileUpload != null) {
                _cacheCloudStorageFileUpload.Dispose();
                _cacheCloudStorageFileUpload = null;
            }

            if (_cacheCloudStorageFileShare != null) {
                _cacheCloudStorageFileShare.Dispose();
                _cacheCloudStorageFileShare = null;
            }

            if (_cacheCPAClient != null) {
                _cacheCPAClient.Dispose();
                _cacheCPAClient = null;
            }

            if (_cacheCPAAccountClient != null) {
                _cacheCPAAccountClient.Dispose();
                _cacheCPAAccountClient = null;
            }

            if (_cacheCPAAccountProcess != null) {
                _cacheCPAAccountProcess.Dispose();
                _cacheCPAAccountProcess = null;
            }

            if (_cacheCPAAccountProcessAssessCriteria != null) {
                _cacheCPAAccountProcessAssessCriteria.Dispose();
                _cacheCPAAccountProcessAssessCriteria = null;
            }

            if (_cacheCPAAccountProcessAssessScore != null) {
                _cacheCPAAccountProcessAssessScore.Dispose();
                _cacheCPAAccountProcessAssessScore = null;
            }

            if (_cacheCPAFinalSettlementClient != null) {
                _cacheCPAFinalSettlementClient.Dispose();
                _cacheCPAFinalSettlementClient = null;
            }

            if (_cacheCPAFinalSettlementProcess != null) {
                _cacheCPAFinalSettlementProcess.Dispose();
                _cacheCPAFinalSettlementProcess = null;
            }

            if (_cacheCPAFinalSettlementYear != null) {
                _cacheCPAFinalSettlementYear.Dispose();
                _cacheCPAFinalSettlementYear = null;
            }

            if (_cacheCPACheck01 != null) {
                _cacheCPACheck01.Dispose();
                _cacheCPACheck01 = null;
            }

            if (_cacheCPACheck02 != null) {
                _cacheCPACheck02.Dispose();
                _cacheCPACheck02 = null;
            }

            if (_cacheCPACheck03 != null) {
                _cacheCPACheck03.Dispose();
                _cacheCPACheck03 = null;
            }

            if (_cacheCPAAccredClient != null) {
                _cacheCPAAccredClient.Dispose();
                _cacheCPAAccredClient = null;
            }

            if (_cacheCPAAccredProcess != null) {
                _cacheCPAAccredProcess.Dispose();
                _cacheCPAAccredProcess = null;
            }

            if (_cacheCPAAccountCount != null) {
                _cacheCPAAccountCount.Dispose();
                _cacheCPAAccountCount = null;
            }

            if (_cacheCustomIngredients != null) {
                _cacheCustomIngredients.Dispose();
                _cacheCustomIngredients = null;
            }

            if (_cacheCustomIngredientsMaterial != null) {
                _cacheCustomIngredientsMaterial.Dispose();
                _cacheCustomIngredientsMaterial = null;
            }

            if (_cacheCustomMaterial != null) {
                _cacheCustomMaterial.Dispose();
                _cacheCustomMaterial = null;
            }

            if (_cacheCustomMaterialStock != null) {
                _cacheCustomMaterialStock.Dispose();
                _cacheCustomMaterialStock = null;
            }

            if (_cachefmjc != null) {
                _cachefmjc.Dispose();
                _cachefmjc = null;
            }

            if (_cacheDrivers != null) {
                _cacheDrivers.Dispose();
                _cacheDrivers = null;
            }

            if (_cacheDrivingOrders != null) {
                _cacheDrivingOrders.Dispose();
                _cacheDrivingOrders = null;
            }

            if (_cacheDrivingNodes != null) {
                _cacheDrivingNodes.Dispose();
                _cacheDrivingNodes = null;
            }

            if (_cacheDrivingEvaluations != null) {
                _cacheDrivingEvaluations.Dispose();
                _cacheDrivingEvaluations = null;
            }

            if (_cacheEMEmployee != null) {
                _cacheEMEmployee.Dispose();
                _cacheEMEmployee = null;
            }

            if (_cacheEMClient != null) {
                _cacheEMClient.Dispose();
                _cacheEMClient = null;
            }

            if (_cacheEMContact != null) {
                _cacheEMContact.Dispose();
                _cacheEMContact = null;
            }

            if (_cacheEMProjects != null) {
                _cacheEMProjects.Dispose();
                _cacheEMProjects = null;
            }

            if (_cacheEMProcess != null) {
                _cacheEMProcess.Dispose();
                _cacheEMProcess = null;
            }

            if (_cacheEMTask != null) {
                _cacheEMTask.Dispose();
                _cacheEMTask = null;
            }

            if (_cacheEMTaskUser != null) {
                _cacheEMTaskUser.Dispose();
                _cacheEMTaskUser = null;
            }

            if (_cacheEMTaskFeedback != null) {
                _cacheEMTaskFeedback.Dispose();
                _cacheEMTaskFeedback = null;
            }

            if (_cacheEMDaily != null) {
                _cacheEMDaily.Dispose();
                _cacheEMDaily = null;
            }

            if (_cacheEMArticle != null) {
                _cacheEMArticle.Dispose();
                _cacheEMArticle = null;
            }

            if (_cacheEMailAccount != null) {
                _cacheEMailAccount.Dispose();
                _cacheEMailAccount = null;
            }

            if (_cacheEMailInfo != null) {
                _cacheEMailInfo.Dispose();
                _cacheEMailInfo = null;
            }

            if (_cacheEMailAttachment != null) {
                _cacheEMailAttachment.Dispose();
                _cacheEMailAttachment = null;
            }

            if (_cacheFinanceAccounts != null) {
                _cacheFinanceAccounts.Dispose();
                _cacheFinanceAccounts = null;
            }

            if (_cacheFinanceAccountTypes != null) {
                _cacheFinanceAccountTypes.Dispose();
                _cacheFinanceAccountTypes = null;
            }

            if (_cacheFinanceAccounting != null) {
                _cacheFinanceAccounting.Dispose();
                _cacheFinanceAccounting = null;
            }

            if (_cacheGameUsers != null) {
                _cacheGameUsers.Dispose();
                _cacheGameUsers = null;
            }

            if (_cacheGameServers != null) {
                _cacheGameServers.Dispose();
                _cacheGameServers = null;
            }

            if (_cacheCardsInfo != null) {
                _cacheCardsInfo.Dispose();
                _cacheCardsInfo = null;
            }

            if (_cacheCardsTypes != null) {
                _cacheCardsTypes.Dispose();
                _cacheCardsTypes = null;
            }

            if (_cacheCardsLvs != null) {
                _cacheCardsLvs.Dispose();
                _cacheCardsLvs = null;
            }

            if (_cacheCardsOffers != null) {
                _cacheCardsOffers.Dispose();
                _cacheCardsOffers = null;
            }

            if (_cacheMonasticismUsers != null) {
                _cacheMonasticismUsers.Dispose();
                _cacheMonasticismUsers = null;
            }

            if (_cacheMonasticismLvs != null) {
                _cacheMonasticismLvs.Dispose();
                _cacheMonasticismLvs = null;
            }

            if (_cacheGeographyCountry != null) {
                _cacheGeographyCountry.Dispose();
                _cacheGeographyCountry = null;
            }

            if (_cacheGeographyProvince != null) {
                _cacheGeographyProvince.Dispose();
                _cacheGeographyProvince = null;
            }

            if (_cacheGeographyCity != null) {
                _cacheGeographyCity.Dispose();
                _cacheGeographyCity = null;
            }

            if (_cacheGeographyArea != null) {
                _cacheGeographyArea.Dispose();
                _cacheGeographyArea = null;
            }

            if (_cacheGeographyTown != null) {
                _cacheGeographyTown.Dispose();
                _cacheGeographyTown = null;
            }

            if (_cacheGeographyVillage != null) {
                _cacheGeographyVillage.Dispose();
                _cacheGeographyVillage = null;
            }

            if (_cacheJxcBook != null) {
                _cacheJxcBook.Dispose();
                _cacheJxcBook = null;
            }

            if (_cacheJxcBookMember != null) {
                _cacheJxcBookMember.Dispose();
                _cacheJxcBookMember = null;
            }

            if (_cacheJxcSuppliers != null) {
                _cacheJxcSuppliers.Dispose();
                _cacheJxcSuppliers = null;
            }

            if (_cacheJxcClients != null) {
                _cacheJxcClients.Dispose();
                _cacheJxcClients = null;
            }

            if (_cacheJxcCatalogs != null) {
                _cacheJxcCatalogs.Dispose();
                _cacheJxcCatalogs = null;
            }

            if (_cacheJxcProducts != null) {
                _cacheJxcProducts.Dispose();
                _cacheJxcProducts = null;
            }

            if (_cacheJxcProductPrices != null) {
                _cacheJxcProductPrices.Dispose();
                _cacheJxcProductPrices = null;
            }

            if (_cacheJxcWarehouses != null) {
                _cacheJxcWarehouses.Dispose();
                _cacheJxcWarehouses = null;
            }

            if (_cacheJxcPurchaseList != null) {
                _cacheJxcPurchaseList.Dispose();
                _cacheJxcPurchaseList = null;
            }

            if (_cacheJxcPurchaseProducts != null) {
                _cacheJxcPurchaseProducts.Dispose();
                _cacheJxcPurchaseProducts = null;
            }

            if (_cacheJxcSellList != null) {
                _cacheJxcSellList.Dispose();
                _cacheJxcSellList = null;
            }

            if (_cacheJxcSellProducts != null) {
                _cacheJxcSellProducts.Dispose();
                _cacheJxcSellProducts = null;
            }

            if (_cacheJxcStocks != null) {
                _cacheJxcStocks.Dispose();
                _cacheJxcStocks = null;
            }

            if (_cacheJxcPayables != null) {
                _cacheJxcPayables.Dispose();
                _cacheJxcPayables = null;
            }

            if (_cacheJxcReceivables != null) {
                _cacheJxcReceivables.Dispose();
                _cacheJxcReceivables = null;
            }

            if (_cacheSystemAutomatic != null) {
                _cacheSystemAutomatic.Dispose();
                _cacheSystemAutomatic = null;
            }

            if (_cacheSystemDepartments != null) {
                _cacheSystemDepartments.Dispose();
                _cacheSystemDepartments = null;
            }

            if (_cacheSystemDepartmentLimits != null) {
                _cacheSystemDepartmentLimits.Dispose();
                _cacheSystemDepartmentLimits = null;
            }

            if (_cacheSystemGroups != null) {
                _cacheSystemGroups.Dispose();
                _cacheSystemGroups = null;
            }

            if (_cacheSystemGroupLimits != null) {
                _cacheSystemGroupLimits.Dispose();
                _cacheSystemGroupLimits = null;
            }

            if (_cacheSystemUserGroups != null) {
                _cacheSystemUserGroups.Dispose();
                _cacheSystemUserGroups = null;
            }

            if (_cacheSystemImages != null) {
                _cacheSystemImages.Dispose();
                _cacheSystemImages = null;
            }

            if (_cacheSystemGeneralDatas != null) {
                _cacheSystemGeneralDatas.Dispose();
                _cacheSystemGeneralDatas = null;
            }

            if (_cacheKernelConfig != null) {
                _cacheKernelConfig.Dispose();
                _cacheKernelConfig = null;
            }

            if (_cacheMemberInfos != null) {
                _cacheMemberInfos.Dispose();
                _cacheMemberInfos = null;
            }

            if (_cacheMemberMoney != null) {
                _cacheMemberMoney.Dispose();
                _cacheMemberMoney = null;
            }

            if (_cacheMemberIntegral != null) {
                _cacheMemberIntegral.Dispose();
                _cacheMemberIntegral = null;
            }

            if (_cacheMemberCard != null) {
                _cacheMemberCard.Dispose();
                _cacheMemberCard = null;
            }

            if (_cacheMomentsList != null) {
                _cacheMomentsList.Dispose();
                _cacheMomentsList = null;
            }

            if (_cacheMomentsImage != null) {
                _cacheMomentsImage.Dispose();
                _cacheMomentsImage = null;
            }

            if (_cacheMoneyPay != null) {
                _cacheMoneyPay.Dispose();
                _cacheMoneyPay = null;
            }

            if (_cacheMoneyTake != null) {
                _cacheMoneyTake.Dispose();
                _cacheMoneyTake = null;
            }

            if (_cacheMoneyPayTypes != null) {
                _cacheMoneyPayTypes.Dispose();
                _cacheMoneyPayTypes = null;
            }

            if (_cacheOAPosition != null) {
                _cacheOAPosition.Dispose();
                _cacheOAPosition = null;
            }

            if (_cacheOAUserPosition != null) {
                _cacheOAUserPosition.Dispose();
                _cacheOAUserPosition = null;
            }

            if (_cacheOARole != null) {
                _cacheOARole.Dispose();
                _cacheOARole = null;
            }

            if (_cacheOAUserRole != null) {
                _cacheOAUserRole.Dispose();
                _cacheOAUserRole = null;
            }

            if (_cacheMaterial != null) {
                _cacheMaterial.Dispose();
                _cacheMaterial = null;
            }

            if (_cacheReleaseCDKey != null) {
                _cacheReleaseCDKey.Dispose();
                _cacheReleaseCDKey = null;
            }

            if (_cacheReleaseVersion != null) {
                _cacheReleaseVersion.Dispose();
                _cacheReleaseVersion = null;
            }

            if (_cacheSessionInfo != null) {
                _cacheSessionInfo.Dispose();
                _cacheSessionInfo = null;
            }

            if (_cacheSessionValue != null) {
                _cacheSessionValue.Dispose();
                _cacheSessionValue = null;
            }

            if (_cacheSales3Users != null) {
                _cacheSales3Users.Dispose();
                _cacheSales3Users = null;
            }

            if (_cacheSales3Settlement != null) {
                _cacheSales3Settlement.Dispose();
                _cacheSales3Settlement = null;
            }

            if (_cacheSales3Cash != null) {
                _cacheSales3Cash.Dispose();
                _cacheSales3Cash = null;
            }

            if (_cacheTravelScenicArea != null) {
                _cacheTravelScenicArea.Dispose();
                _cacheTravelScenicArea = null;
            }

            if (_cacheTravelPicture != null) {
                _cacheTravelPicture.Dispose();
                _cacheTravelPicture = null;
            }

            if (_cacheSystemColumnTypes != null) {
                _cacheSystemColumnTypes.Dispose();
                _cacheSystemColumnTypes = null;
            }

            if (_cacheSystemEventNames != null) {
                _cacheSystemEventNames.Dispose();
                _cacheSystemEventNames = null;
            }

            if (_cacheSystemEvents != null) {
                _cacheSystemEvents.Dispose();
                _cacheSystemEvents = null;
            }

            if (_cacheSystemHistory != null) {
                _cacheSystemHistory.Dispose();
                _cacheSystemHistory = null;
            }

            if (_cacheSystemPremises != null) {
                _cacheSystemPremises.Dispose();
                _cacheSystemPremises = null;
            }

            if (_cacheSystemPremiseTypes != null) {
                _cacheSystemPremiseTypes.Dispose();
                _cacheSystemPremiseTypes = null;
            }

            if (_cacheSystemRelation != null) {
                _cacheSystemRelation.Dispose();
                _cacheSystemRelation = null;
            }

            if (_cacheTabFilterPremises != null) {
                _cacheTabFilterPremises.Dispose();
                _cacheTabFilterPremises = null;
            }

            if (_cacheTabFilterTrigger != null) {
                _cacheTabFilterTrigger.Dispose();
                _cacheTabFilterTrigger = null;
            }

            if (_cacheTabFilter != null) {
                _cacheTabFilter.Dispose();
                _cacheTabFilter = null;
            }

            if (_cacheTabBindingPremises != null) {
                _cacheTabBindingPremises.Dispose();
                _cacheTabBindingPremises = null;
            }

            if (_cacheTabBindingColumns != null) {
                _cacheTabBindingColumns.Dispose();
                _cacheTabBindingColumns = null;
            }

            if (_cacheTabBindingTables != null) {
                _cacheTabBindingTables.Dispose();
                _cacheTabBindingTables = null;
            }

            if (_cacheTabBinding != null) {
                _cacheTabBinding.Dispose();
                _cacheTabBinding = null;
            }

            if (_cacheTable2D != null) {
                _cacheTable2D.Dispose();
                _cacheTable2D = null;
            }

            if (_cacheUserInfos != null) {
                _cacheUserInfos.Dispose();
                _cacheUserInfos = null;
            }

            if (_cacheUserTypes != null) {
                _cacheUserTypes.Dispose();
                _cacheUserTypes = null;
            }

            if (_cacheUserConfigs != null) {
                _cacheUserConfigs.Dispose();
                _cacheUserConfigs = null;
            }

            if (_cacheVideoSeries != null) {
                _cacheVideoSeries.Dispose();
                _cacheVideoSeries = null;
            }

            if (_cacheVideoGroup != null) {
                _cacheVideoGroup.Dispose();
                _cacheVideoGroup = null;
            }

            if (_cacheVideoInfo != null) {
                _cacheVideoInfo.Dispose();
                _cacheVideoInfo = null;
            }

            if (_cacheWebSites != null) {
                _cacheWebSites.Dispose();
                _cacheWebSites = null;
            }

            if (_cacheWebMuds != null) {
                _cacheWebMuds.Dispose();
                _cacheWebMuds = null;
            }

            if (_cacheWebSections != null) {
                _cacheWebSections.Dispose();
                _cacheWebSections = null;
            }

            if (_cacheWebHtmls != null) {
                _cacheWebHtmls.Dispose();
                _cacheWebHtmls = null;
            }

            if (_cacheWebArticleCatalog != null) {
                _cacheWebArticleCatalog.Dispose();
                _cacheWebArticleCatalog = null;
            }

            if (_cacheWebArticleList != null) {
                _cacheWebArticleList.Dispose();
                _cacheWebArticleList = null;
            }

            if (_cacheWebAds != null) {
                _cacheWebAds.Dispose();
                _cacheWebAds = null;
            }

            if (_cacheWebComments != null) {
                _cacheWebComments.Dispose();
                _cacheWebComments = null;
            }

            if (_cacheWebHomeModule != null) {
                _cacheWebHomeModule.Dispose();
                _cacheWebHomeModule = null;
            }

            if (_cacheWebImgList != null) {
                _cacheWebImgList.Dispose();
                _cacheWebImgList = null;
            }

            if (_cacheWebSpread != null) {
                _cacheWebSpread.Dispose();
                _cacheWebSpread = null;
            }

            if (_cacheLoanApply != null) {
                _cacheLoanApply.Dispose();
                _cacheLoanApply = null;
            }

            if (_cacheLoanSpread != null) {
                _cacheLoanSpread.Dispose();
                _cacheLoanSpread = null;
            }

            if (_cacheLoanBusinessEvaluation != null) {
                _cacheLoanBusinessEvaluation.Dispose();
                _cacheLoanBusinessEvaluation = null;
            }

            if (_cacheLoanClient != null) {
                _cacheLoanClient.Dispose();
                _cacheLoanClient = null;
            }

            if (_cacheLoanBusiness != null) {
                _cacheLoanBusiness.Dispose();
                _cacheLoanBusiness = null;
            }

            if (_cacheMallUsers != null) {
                _cacheMallUsers.Dispose();
                _cacheMallUsers = null;
            }

            if (_cacheMallUserLvs != null) {
                _cacheMallUserLvs.Dispose();
                _cacheMallUserLvs = null;
            }

            if (_cacheMallCatalogs != null) {
                _cacheMallCatalogs.Dispose();
                _cacheMallCatalogs = null;
            }

            if (_cacheMallProduct != null) {
                _cacheMallProduct.Dispose();
                _cacheMallProduct = null;
            }

            if (_cacheMallGoodImages != null) {
                _cacheMallGoodImages.Dispose();
                _cacheMallGoodImages = null;
            }

            if (_cacheMallGoodDetail != null) {
                _cacheMallGoodDetail.Dispose();
                _cacheMallGoodDetail = null;
            }

            if (_cacheMallOrder != null) {
                _cacheMallOrder.Dispose();
                _cacheMallOrder = null;
            }

            if (_cacheMallOrderProduct != null) {
                _cacheMallOrderProduct.Dispose();
                _cacheMallOrderProduct = null;
            }

            if (_cacheMallRecharges != null) {
                _cacheMallRecharges.Dispose();
                _cacheMallRecharges = null;
            }

            if (_cacheMallContacts != null) {
                _cacheMallContacts.Dispose();
                _cacheMallContacts = null;
            }

            if (_cacheMallAddress != null) {
                _cacheMallAddress.Dispose();
                _cacheMallAddress = null;
            }

            if (_cacheMallPay != null) {
                _cacheMallPay.Dispose();
                _cacheMallPay = null;
            }

            if (_cacheMallGoodVisited != null) {
                _cacheMallGoodVisited.Dispose();
                _cacheMallGoodVisited = null;
            }

            if (_cacheMallVisitedKey != null) {
                _cacheMallVisitedKey.Dispose();
                _cacheMallVisitedKey = null;
            }

            if (_cacheMallIntegral != null) {
                _cacheMallIntegral.Dispose();
                _cacheMallIntegral = null;
            }

            if (_cacheMallStock != null) {
                _cacheMallStock.Dispose();
                _cacheMallStock = null;
            }

            if (_cacheMallFreightes != null) {
                _cacheMallFreightes.Dispose();
                _cacheMallFreightes = null;
            }

            if (_cachePlatformFloors != null) {
                _cachePlatformFloors.Dispose();
                _cachePlatformFloors = null;
            }

            if (_cachePlatformShop != null) {
                _cachePlatformShop.Dispose();
                _cachePlatformShop = null;
            }

            if (_cachePlatformStar != null) {
                _cachePlatformStar.Dispose();
                _cachePlatformStar = null;
            }

            if (_cachePlatformPraise != null) {
                _cachePlatformPraise.Dispose();
                _cachePlatformPraise = null;
            }

            if (_cachePlatformVotes != null) {
                _cachePlatformVotes.Dispose();
                _cachePlatformVotes = null;
            }

            if (_cachePlatformVoteItems != null) {
                _cachePlatformVoteItems.Dispose();
                _cachePlatformVoteItems = null;
            }

            if (_cachePlatformVoteCast != null) {
                _cachePlatformVoteCast.Dispose();
                _cachePlatformVoteCast = null;
            }

            if (_cachePlatformBrands != null) {
                _cachePlatformBrands.Dispose();
                _cachePlatformBrands = null;
            }

            if (_cachePlatformProducts != null) {
                _cachePlatformProducts.Dispose();
                _cachePlatformProducts = null;
            }

            if (_cachePlatformSearch != null) {
                _cachePlatformSearch.Dispose();
                _cachePlatformSearch = null;
            }

            if (_cachePlatformSearchHistory != null) {
                _cachePlatformSearchHistory.Dispose();
                _cachePlatformSearchHistory = null;
            }

            if (_cachePlatformReg != null) {
                _cachePlatformReg.Dispose();
                _cachePlatformReg = null;
            }

            if (_cachePlatformArchitectures != null) {
                _cachePlatformArchitectures.Dispose();
                _cachePlatformArchitectures = null;
            }

            if (_cachePlatformShopArchitectures != null) {
                _cachePlatformShopArchitectures.Dispose();
                _cachePlatformShopArchitectures = null;
            }

            if (_cacheWeixinUsers != null) {
                _cacheWeixinUsers.Dispose();
                _cacheWeixinUsers = null;
            }

            if (_cacheWeixinActivity != null) {
                _cacheWeixinActivity.Dispose();
                _cacheWeixinActivity = null;
            }

            if (_cacheWeixinActivityJoin != null) {
                _cacheWeixinActivityJoin.Dispose();
                _cacheWeixinActivityJoin = null;
            }

            if (_cacheWeixinRedEnvelopes != null) {
                _cacheWeixinRedEnvelopes.Dispose();
                _cacheWeixinRedEnvelopes = null;
            }

            if (_cacheYYGoods != null) {
                _cacheYYGoods.Dispose();
                _cacheYYGoods = null;
            }

            if (_cacheYYOrders != null) {
                _cacheYYOrders.Dispose();
                _cacheYYOrders = null;
            }

            if (_cacheYYLottery != null) {
                _cacheYYLottery.Dispose();
                _cacheYYLottery = null;
            }

            if (_cacheYYGoodShow != null) {
                _cacheYYGoodShow.Dispose();
                _cacheYYGoodShow = null;
            }

            if (_cacheYYGoodShowImage != null) {
                _cacheYYGoodShowImage.Dispose();
                _cacheYYGoodShowImage = null;
            }

            if (_cacheYYGoodLottery != null) {
                _cacheYYGoodLottery.Dispose();
                _cacheYYGoodLottery = null;
            }

            if (_cacheYYGoodShowVerify != null) {
                _cacheYYGoodShowVerify.Dispose();
                _cacheYYGoodShowVerify = null;
            }

        }


    }

}
