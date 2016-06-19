﻿using System;
using LeukocyteCore_for_oclHashcat.Classes;

namespace LeukocyteCore_for_oclHashcat.Interfaces
{
    public interface ICrackDataSource : ICloneable
    {
        string Name { get; set; }
        string Description { get; set; }
        string Source { get; set; }
        AttackModes AttackMode { get; }
    }
}
