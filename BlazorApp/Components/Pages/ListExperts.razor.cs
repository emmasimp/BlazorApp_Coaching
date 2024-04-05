using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Data;
namespace BlazorApp.Components.Pages
{
    public partial class ListExperts
    {
        private List<Profile> profiles;
        private Profile profile;

        protected override async Task OnInitializedAsync()
        {
            profiles = new List<Profile>();
            profile = new Profile() { Id = 1, FirstName = "Emma", LastName = "Simpson", OrgName = "UoM" };
            profiles.Add(profile);
            profile = new Profile() { Id = 2, FirstName = "April", LastName = "Simpson", OrgName = "UoM" };
            profiles.Add(profile);
            profile = new Profile() { Id = 3, FirstName = "Karen", LastName = "Simpson", OrgName = "UoM" };
            profiles.Add(profile);
            // Simulate asynchronous loading to demonstrate streaming rendering
            await Task.Delay(500);
        }

    }


}