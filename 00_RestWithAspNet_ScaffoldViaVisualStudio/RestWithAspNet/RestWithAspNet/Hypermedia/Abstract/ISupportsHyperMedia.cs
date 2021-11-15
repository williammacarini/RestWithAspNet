using System.Collections.Generic;

namespace RestWithAspNet.HyperMedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
