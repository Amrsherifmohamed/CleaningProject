using royaltjänstflytt.Models;

namespace royaltjänstflytt.Feature
{
    public interface IMainService
    {
        Task<Move> CreateMoveItem(Move Items);

    }
}
