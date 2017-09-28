﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugar
{
    public interface ISerializeManager
    {
        string SerializeObject(object value);
         T DeserializeObject<T>(string value);
    }
}
