﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KeyCloakIntegrate.Test
{
    public interface ITestAppService
    {
        Task<string> GetNameAsync();
    }
}
