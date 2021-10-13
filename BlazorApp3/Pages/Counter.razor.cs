using Microsoft.JSInterop;

namespace BlazorApp3.Pages;

public partial class Counter
{
    [Inject] private CounterState? CounterState { get; set; }

    private void IncrementCount() => CounterState?.IncrementCount();

    private async Task CounterAlert()
    {
        await (await JsRuntime.InvokeAsync<IJSObjectReference>("import", $"./{nameof(Pages)}/{nameof(Counter)}.razor.js")).InvokeVoidAsync("counterAlert", $"The current count is {CounterState?.CurrentCount}.");
    }
}
