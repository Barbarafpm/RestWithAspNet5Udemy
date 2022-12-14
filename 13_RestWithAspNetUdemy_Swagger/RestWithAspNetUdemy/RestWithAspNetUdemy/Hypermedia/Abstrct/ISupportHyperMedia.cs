using System.Collections.Generic;

namespace RestWithASPNETUdemy.Hypermedia.Abstrct
{
    public interface ISupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
