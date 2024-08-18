public class SharedStateService {
    public event Action? OnChange;
    private int _activeComponent = 1;

    public int ActiveComponent
    {
        get => _activeComponent;
        set
        {
            if (_activeComponent != value)
            {
                _activeComponent = value;
                NotifyStateChanged();
            }
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}