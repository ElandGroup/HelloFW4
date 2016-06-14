using System;
using System.Text;
using System.Collections.Generic;


namespace HelloFW4.SampleMng.Domain {
    
    public class Store {
        public Store() {
			Fruit = new List<Fruit>();
        }
        public virtual string Code { get; set; }
        public virtual string Storename { get; set; }
        public virtual IList<Fruit> Fruit { get; set; }
    }
}
