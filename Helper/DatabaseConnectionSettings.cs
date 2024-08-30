namespace royaltjänstflytt.Helper
{
    public class DatabaseConnectionSettings
    {
        public const string SectionName = "ConnectionStrings";
        public string DefaultConnection { get; init; } = null!;
    }
}
