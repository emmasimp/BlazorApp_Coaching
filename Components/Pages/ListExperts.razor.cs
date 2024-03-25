using Microsoft.AspNetCore.Components;

using BlazorApp_CoachingProject.Data;


namespace BlazorApp_CoachingProject.Pages
{
    public partial class ListExperts
    {
        [Inject] private ProfileService profileService { get; set; }
        [Inject] public NavigationManager navigationManager { get; set; }

        private List<PersonExpert> persons { get; set; }
        private List<OrgExpert> orgs { get; set; }

        protected async override Task OnInitializedAsync()
        {
            persons = await profileService.GetPersonsAsync();
        }

        private void EditPerson(int id)
        {
            navigationManager.NavigateTo($"/expertdetail/{id}", true);
        }
    }
}