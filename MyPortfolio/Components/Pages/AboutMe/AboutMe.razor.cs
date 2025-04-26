using Microsoft.JSInterop;

namespace MyPortfolio.Components.Pages.AboutMe
{
    public partial class AboutMe
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JS.InvokeVoidAsync("startAutoScroll");
            }
        }
    }
}
