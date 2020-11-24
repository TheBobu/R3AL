using R3AL.Core.Services.Interfaces;
using R3AL.Data;

namespace R3AL.Core.Services.Implementations
{
    public class ProjectService : BaseDbService, IProjectService
    {
        public ProjectService(IContext context) : base(context)
        {
        }
    }
}