namespace BlazorApp3.Pages
{
    [Route("/")]
    public partial class Index
    {
        private async Task JsAlert() => await JsInterop.Alert("Test");
    }
}
