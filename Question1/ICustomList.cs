﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal interface ICustomList
    {
        void Add(IItem item);
        void DisplayList();
    }
}
