using HelloFW4.SampleMng.Domain;
using Spring.Data.NHibernate.Generic.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloFW4.SampleMng.Dao
{
    public class SampleDao : HibernateDaoSupport, ISampleDao
    {
        public DateTime GetDate()
        {
            return Session.CreateSQLQuery("SELECT GETDATE()")
                .UniqueResult<DateTime>();
        }

        public IList<Fruit> GetFruit(string color)
        {
            return Session.QueryOver<Fruit>().Where(a => a.Color == color)
                .List();
        }
    }
}
