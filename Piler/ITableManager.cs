using Piler.Controls;

namespace Piler
{
    public interface ITableManager
    {
        void Init();
        void MoveBlockOnTable(Block block);
        Crane Crane { get; set; }
    }
}