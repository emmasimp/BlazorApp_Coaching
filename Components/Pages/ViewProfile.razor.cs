using Microsoft.AspNetCore.Components;

using BlazorApp_CoachingProject.Data;

namespace BlazorApp_CoachingProject.Pages
{


    public partial class ViewProfile
    {
        [Inject] private ProfileService profileService { get; set; }

        private Profile currentprofile { get; set; }

        [Parameter]
        public int Id { get; set; }

        // protected override void OnParametersSet()
        // {
        //     Value = Value ?? "fantastic";
        // }

        protected async override Task OnInitializedAsync()
        {
            int given_id = 1;
            currentprofile = profileService.GetProfileById(given_id);

        }
    }
}


