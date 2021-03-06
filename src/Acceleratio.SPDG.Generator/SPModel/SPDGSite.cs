﻿using System;

namespace Acceleratio.SPDG.Generator.SPModel
{
    public abstract class SPDGSite : IDisposable
    {
        public abstract SPDGWeb OpenWeb(Guid id);
        
        public abstract SPDGWeb RootWeb { get; }
        public abstract void Dispose();
    }
}
