namespace Arma3BattlEye.Web.Core.Data.Contract
{
    public interface IEntity<out TKey> : IEntity
    {
        TKey Id { get; }
    }


    public interface IEntity
    {
    }
}