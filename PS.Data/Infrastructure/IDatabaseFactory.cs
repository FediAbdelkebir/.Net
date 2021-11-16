using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        PSContext DataContext { get; }
    }
}
