﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngishTime.Infrastructure
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
