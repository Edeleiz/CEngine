namespace CEngine.Interfaces.Stats
{
    public interface IModifier
    {
        ModifierType Type { get; }
        object Value { get; }
    }

    public interface IModifier<out T> : IModifier
    {
        new T Value { get; }
    }
}