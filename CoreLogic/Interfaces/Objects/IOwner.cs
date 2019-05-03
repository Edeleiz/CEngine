namespace CEngine.Interfaces.Objects
{
    public enum OwnerType
    {
        Player,
        Enemy,
        Neutral
    }
    
    public interface IOwner
    {
        OwnerType GetTypeForObject(IGameObject obj);
    }
}