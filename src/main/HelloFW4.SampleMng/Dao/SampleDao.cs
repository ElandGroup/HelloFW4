using Spring.Data.NHibernate.Generic.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloFW4.SampleMng.Dao
{
    public class SampleDao:HibernateDaoSupport,ISampleDao
    {
        public DateTime GetDate()
        {
            return Session.CreateSQLQuery("SELECT GETDATE()")
                .UniqueResult<DateTime>();
        }
    }
}
