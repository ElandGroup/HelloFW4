using System;
using System.Text;
using System.Collections.Generic;


namespace HelloFW4.SampleMng.Domain {
    
    public class Fruit {
        public virtual string Code { get; set; }
        public virtual Store Store { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal? Price { get; set; }
        public virtual string Color { get; set; }
    }
}
