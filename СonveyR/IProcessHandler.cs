﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace СonveyoR
{
    /// <summary>
    /// Common process handler interface
    /// </summary>
    /// <typeparam name="TProcessContext"></typeparam>
    public interface IProcessHandler<in TProcessContext> where TProcessContext : class
    {
        Task Process(TProcessContext context, params object[] args);
    }
}
