using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tripenticer.Models
{
    public class Package
    {
        public virtual int PackageId { get; set; }

        public virtual string Name { get; set; }

        public virtual int noDays { get; set; }

        public virtual decimal Price { get; set; }

        public virtual string Description { get; set; }

        public virtual string Itinerary { get; set; }

        public virtual string Location { get; set; }

        public virtual string ThumImg { get; set; }

        public virtual string img1 { get; set; }

        public virtual string img2 { get; set; }

        public virtual string img3 { get; set; }

        public virtual string img4 { get; set; }

        public virtual string img5 { get; set; }

        public virtual string Category { get; set; }

        public virtual string Destinations { get; set; }

    }
}