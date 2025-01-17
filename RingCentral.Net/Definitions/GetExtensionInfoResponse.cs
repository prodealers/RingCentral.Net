namespace RingCentral
{
    public class GetExtensionInfoResponse
    {
        /// <summary>
        ///     Internal identifier of an extension
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of an extension
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public GetExtensionAccountInfo account { get; set; }

        /// <summary>
        /// </summary>
        public ContactInfo contact { get; set; }

        /// <summary>
        /// </summary>
        public CustomFieldInfo[] customFields { get; set; }

        /// <summary>
        ///     Information on department extension(s), to which the requested extension belongs. Returned only for user
        ///     extensions, members of department, requested by single extensionId. Please note that legacy 'Department' extension
        ///     type corresponds to 'Call Queue' extensions in modern RingCentral product terminology
        /// </summary>
        public DepartmentInfo[] departments { get; set; }

        /// <summary>
        ///     Number of extension
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public string[] extensionNumbers { get; set; }

        /// <summary>
        ///     Extension name. For user extension types the value is a combination of the specified first name and last name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the
        ///     mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client
        ///     application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters
        ///     using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all
        ///     request and response bodies these values are reflected via partnerId attributes of account and extension
        /// </summary>
        public string partnerId { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionPermissions permissions { get; set; }

        /// <summary>
        /// </summary>
        public ProfileImageInfo profileImage { get; set; }

        /// <summary>
        ///     List of non-RC internal identifiers assigned to an extension
        /// </summary>
        public ReferenceInfo[] references { get; set; }

        /// <summary>
        /// </summary>
        public Roles[] roles { get; set; }

        /// <summary>
        /// </summary>
        public RegionalSettings regionalSettings { get; set; }

        /// <summary>
        ///     Extension service features returned in response only when the logged-in user requests his/her own extension info,
        ///     see also Extension Service Features
        /// </summary>
        public ExtensionServiceFeatureInfo[] serviceFeatures { get; set; }

        /// <summary>
        ///     Specifies extension configuration wizard state (web service setup).
        ///     Default: NotStarted
        ///     Enum: NotStarted, Incomplete, Completed
        /// </summary>
        public string setupWizardState { get; set; }

        /// <summary>
        ///     Extension current state. If 'Unassigned' is specified, then extensions without ‘extensionNumber’ are returned. If
        ///     not specified, then all extensions are returned
        ///     Enum: Enabled, Disabled, Frozen, NotActivated, Unassigned
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionStatusInfo statusInfo { get; set; }

        /// <summary>
        ///     Extension type. Please note that legacy 'Department' extension type corresponds to 'Call Queue' extensions in
        ///     modern RingCentral product terminology
        ///     Enum: User, FaxUser, VirtualUser, DigitalUser, Department, Announcement, Voicemail, SharedLinesGroup, PagingOnly,
        ///     IvrMenu, ApplicationExtension, ParkLocation, Bot, Room, Limited, Site, ProxyAdmin, DelegatedLinesGroup,
        ///     GroupCallPickup
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CallQueueExtensionInfo callQueueInfo { get; set; }

        /// <summary>
        ///     Hides extension from showing in company directory. Supported for extensions of User type only
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site { get; set; }
    }
}