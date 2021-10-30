using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public abstract class Concept
    {
        internal bool isApproved;

        public abstract void GetDetails();
    }
}
