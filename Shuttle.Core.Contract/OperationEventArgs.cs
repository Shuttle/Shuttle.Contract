namespace Shuttle.Core.Contract;

public class OperationEventArgs(string name, object? data = null) : EventArgs
{
    public string Name { get; } = Guard.AgainstEmpty(name, nameof(name));
    public object? Data { get; } = data;
}

public class OperationEventArgs<T>(string name, T? data) : EventArgs
{
    public string Name { get; } = Guard.AgainstEmpty(name, nameof(name));
    public T? Data { get; } = data;
}