using Microsoft.AspNetCore.Components;

namespace BlazorAppEmma.Data
{
    public class ProfileService
    {
        private static readonly List<PersonExpert> StaticPersonData = new List<PersonExpert>()
        {
            new PersonExpert() { Id = 1, IsOrg = false, FirstName = "Harry", LastName = "Potter", ResearchInterest = "HP inerest" },
            new PersonExpert() { Id = 2, IsOrg = false, FirstName = "Ginny", LastName = "Weasley", ResearchInterest = "GW inerest" },
            new PersonExpert() { Id = 3, IsOrg = false, FirstName = "Cho", LastName = "Chang", ResearchInterest = "CC inerest" },
            new PersonExpert() { Id = 4, IsOrg = false, FirstName = "Serius", LastName = "Snape", ResearchInterest = "SS inerest" }
        };

        private static readonly List<OrgExpert> StaticOrgData = new List<OrgExpert>()
        {
            new OrgExpert() { Id = 1, IsOrg = true, OrgName = "Gryffindor", SupportInfo = "G info"},
            new OrgExpert() { Id = 2, IsOrg = true, OrgName = "Slytherin", SupportInfo = "S info"}
        };

        private List<PersonExpert> _persons { get; set; }
        private List<OrgExpert> _orgs { get; set; }

        public ProfileService()
        {
            _persons = StaticPersonData;
            _orgs = StaticOrgData;
        }



        public Task<List<PersonExpert>> GetPersonsAsync()
        {
            return Task.FromResult(_persons);
        }

        public PersonExpert GetPersonById(int id)
        {
            //PersonExpert p = StaticPersonData.Where(x => x.Id == id).FirstOrDefault();
            PersonExpert p = _persons.Where(x => x.Id == id).FirstOrDefault();

            return p;
        }

        public bool UpdateExpert(int id, string firstName, string LastName, ref string err)
        {
            try
            {
                PersonExpert existingP = GetPersonById(id);
                int index = _persons.IndexOf(existingP);
                _persons[index].FirstName = firstName;
                _persons[index].LastName = LastName;

                return true;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}