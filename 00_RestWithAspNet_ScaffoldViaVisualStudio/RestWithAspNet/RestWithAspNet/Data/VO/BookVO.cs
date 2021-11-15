using RestWithAspNet.HyperMedia;
using RestWithAspNet.HyperMedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestWithAspNet.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime LaunchDate { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
