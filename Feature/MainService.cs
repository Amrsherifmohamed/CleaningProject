using MapsterMapper;
using royaltjänstflytt.Context;
using royaltjänstflytt.Models;

namespace royaltjänstflytt.Feature
{
    public class MainService : IMainService
    {
        private readonly CleanContext _context;
        private readonly IMapper _mapper;
        public MainService(CleanContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Move> CreateMoveItem(Move Items)
        {
            try
            {
                var ItemCreate = _context.Moves.Add(Items);
                await _context.SaveChangesAsync();
                var ObjReturn = _mapper.Map<Move>(ItemCreate);
                return ObjReturn;
            }
            catch (Exception)
            {
                return null;
            }
          
        }
    }
}
