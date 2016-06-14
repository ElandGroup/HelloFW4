using Spring.Data.NHibernate.Generic.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloFW4.SampleMng.Dao
{
    public class MySqlSampleDao:HibernateDaoSupport,IMySqlSampleDao
    {
        public DateTime GetDate()
        {
            return Session.CreateSQLQuery("SELECT UTC_DATE()").UniqueResult<DateTime>();
        }
    }
}
