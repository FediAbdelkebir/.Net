using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Infrastructures
{
    public interface IDatabaseFactory : IDisposable
    {
        PSContexte DataContext { get; }
    }
}
