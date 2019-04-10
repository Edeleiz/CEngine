namespace CEngine.Interfaces.Stats
{
    public enum ModifierType
    {
        Relative,
        Absolute
    }

    public enum ModifierApplyType
    {
        Temporary,
        Constant
    }
    
    public interface IModifier
    {
        ModifierType Type { get; }
        ModifierApplyType ApplyType { get; }
        object Value { get; }
    }

    public interface IModifier<out T> : IModifier
    {
        new T Value { get; }
    }
}