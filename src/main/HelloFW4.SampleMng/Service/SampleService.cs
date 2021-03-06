﻿using HelloFW4.SampleMng.Dao;
using HelloFW4.SampleMng.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloFW4.SampleMng.Service
{
    public class SampleService : ISampleService
    {
        #region member(s)

        public ISampleDao SampleDao { private get; set; }

        #endregion

        public DateTime GetDate()
        {
            return SampleDao.GetDate();
        }


        public IList<Fruit> GetFruit(string color)
        {
            return SampleDao.GetFruit(color);
        }
    }
}
