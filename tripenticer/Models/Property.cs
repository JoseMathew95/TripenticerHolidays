using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tripenticer.Models
{
    public class Property
    {
        public virtual int PropertyId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual string Location { get; set; }

        public virtual string Category { get; set; }

        public virtual string ThumImg { get; set; }

        public virtual string img1 { get; set; }

        public virtual string img2 { get; set; }

        public virtual string img3 { get; set; }
    }
}