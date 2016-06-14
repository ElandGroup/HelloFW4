﻿using HelloFW4.SampleMng.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloFW4.SampleMng.Dao
{
    public interface ISampleDao
    {
        DateTime GetDate();
        IList<Fruit> GetFruit(string color);

    }
}
