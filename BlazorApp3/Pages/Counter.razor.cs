using Microsoft.JSInterop;

namespace BlazorApp3.Pages;

public partial class Counter
{
    [Inject] private CounterState? CounterState { get; set; }

    private void IncrementCount() => CounterState?.IncrementCount();

    private async Task CounterAlert()
    {
        //IJSObjectReference? module = await JsRuntime.InvokeAsync<IJSObjectReference>("import", $"./_content/{nameof(BlazorApp3)}/{nameof(Pages)}/{nameof(Counter)}.razor.js");
        IJSObjectReference? module = await JsRuntime.InvokeAsync<IJSObjectReference>("import", $"./{nameof(Pages)}/{nameof(Counter)}.razor.js");
        await module.InvokeVoidAsync("counterAlert", "This is a collocated JS file saying hello!");
    }
}
