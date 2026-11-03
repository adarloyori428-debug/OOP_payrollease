namespace PayrollEase
{
    /// <summary>Holds the signed-in user for the lifetime of the main window.</summary>
    public static class Session
    {
        public static int UserId { get; set; }
        public static string Username { get; set; } = "";
        public static string FullName { get; set; } = "";
        public static string Role { get; set; } = "";

        public static bool IsAdmin { get { return Role == "Admin"; } }

        public static void Clear()
        {
            UserId = 0;
            Username = "";
            FullName = "";
            Role = "";
        }
    }
}
