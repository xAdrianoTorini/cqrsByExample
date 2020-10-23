using System;
using System.Collections.Generic;
using System.Text;

namespace Fleet.Domain.Dtos.Bus
{
    public class RemoveResult
    {
        public RemoveResult(bool removed)
        {
            Removed = removed;
        }

        public bool Removed { get; set; }
    }
}
