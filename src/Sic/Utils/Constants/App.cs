namespace Oire.Sic.Utils.Constants;

public static class App {
    public const string Name = "Sic";
    public const string ManufacturerNameShort = "Oire";
    public const string ManufacturerNameFull = "Oire Software";
    public const string ConfigFileExtension = "cfg";
    public static readonly bool IsPortable = Directory.Exists(Path.Combine(AppContext.BaseDirectory, "userdata"));
    public static readonly string DataFolder = IsPortable
        ? Path.Combine(AppContext.BaseDirectory, "userdata")
        : Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            ManufacturerNameShort,
            Name
        );
    private static readonly string DocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    public static readonly string DefaultOutputFolder = string.IsNullOrWhiteSpace(DocumentsFolder)
        ? Path.Combine(DataFolder, "Converted")
        : Path.Combine(DocumentsFolder, "SIC 输出");
    public const string RepoUrl = "https://github.com/Oire/sic";
    public const string AppcastUrl = "https://sic.oire.dev/appcast.xml";
    public const string UpdatePublicKey = "1Q9hfqwf3i6ZcncHvt08rqAO17iDrhHTvrjHAdCXw68=";
    public const string SystemLanguageName = "System";
    public static readonly string LocalesFolder = Path.Combine(AppContext.BaseDirectory, "locale");
    public static readonly string HelpFolder = Path.Combine(AppContext.BaseDirectory, "help");
}
