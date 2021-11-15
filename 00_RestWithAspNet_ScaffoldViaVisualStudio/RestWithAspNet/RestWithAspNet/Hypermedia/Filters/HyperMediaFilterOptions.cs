using RestWithAspNet.HyperMedia.Abstract;
using System.Collections.Generic;

namespace RestWithAspNet.HyperMedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
