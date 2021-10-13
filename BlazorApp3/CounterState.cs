namespace BlazorApp3
{
    public class CounterState
    {
        public int CurrentCount { get; private set; }

        public void IncrementCount() => CurrentCount++;
    }
}
