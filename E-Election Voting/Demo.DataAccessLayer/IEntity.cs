﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccessLayer
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
