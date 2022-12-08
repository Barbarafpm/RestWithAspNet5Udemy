using System.Collections.Generic;

namespace RestWithASPNETUdemy.Hypermedia.Abstrct
{
    public interface ISupportHyperMedia
    {
        List<HyperMediLink> Links { get; set; }
    }
}
