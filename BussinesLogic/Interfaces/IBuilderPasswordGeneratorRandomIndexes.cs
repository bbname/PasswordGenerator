﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Interfaces
{
    interface IBuilderPasswordGeneratorRandomIndexes
    {
        int GenerateRandomIndex();
        IEnumerable<int> GetRandomIndexes();

    }
}
