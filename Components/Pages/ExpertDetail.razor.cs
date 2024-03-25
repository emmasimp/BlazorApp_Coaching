using Microsoft.AspNetCore.Components;

using BlazorApp_CoachingProject.Data;


namespace BlazorApp_CoachingProject.Components.Pages
{
    public partial class ExpertDetail
    {
        [Inject] private ProfileService profileService { get; set; }
        [Inject] public NavigationManager navigationManager { get; set; }

        [Parameter] public int id { get; set; }

        private PersonExpert personProfile { get; set; }
        private int passedId { get; set; }
        private string errMsg { get; set; }

        protected override void OnInitialized()
        {
            passedId = (int)id;

            personProfile = profileService.GetPersonById(passedId);

            errMsg = "";
        }

        private void Save()
        {
            string err = "";

            if (profileService.UpdateExpert(personProfile.Id, personProfile.FirstName, personProfile.LastName, ref err))
            {
                navigationManager.NavigateTo($"/listexperts", true);
            }
            else
            {
                errMsg = err;
            }
        }

        private void Cancel()
        {
            navigationManager.NavigateTo($"/listexperts", true);
        }
    }
}