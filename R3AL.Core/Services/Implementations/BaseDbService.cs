using R3AL.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace R3AL.Core.Services.Implementations
{
    public class BaseDbService
    {
        public IContext Context { get; }

        public BaseDbService(IContext context)
        {
            this.Context = context;
        }
    }
}
