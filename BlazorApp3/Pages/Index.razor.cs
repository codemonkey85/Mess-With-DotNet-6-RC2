namespace BlazorApp3.Pages
{
    public partial class Index
    {
        private async Task JsAlert()
        {
            await JsInterop.Alert("Test");
        }
    }
}
