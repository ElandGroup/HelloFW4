using HelloFW4.SampleMng.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloFW4.SampleMng.Service
{
    public class MySqlSampleService : IMySqlSampleService
    {
        public IMySqlSampleDao MySqlSampleDao { private get; set; }
        public DateTime GetDate()
        {
            return MySqlSampleDao.GetDate();
        }
    }
}
