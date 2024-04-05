namespace BlazorApp.Data
{
    public class Profile
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrgName { get; set; }

        public bool IsOrg { get; set; }

        public Profile() { }
    }
}