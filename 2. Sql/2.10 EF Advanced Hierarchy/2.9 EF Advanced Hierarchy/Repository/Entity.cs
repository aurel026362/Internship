﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    public abstract class Entity<T>
    {
        public T Id { get; set; }
    }
}