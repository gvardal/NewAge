using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkpdkssgkbelgeTurleri
{
    public string BelgeTuruId { get; set; } = null!;

    public string? BelgeTuruAciklama { get; set; }

    public bool? Kvsk { get; set; }

    public decimal? IksgkisciPrimi { get; set; }

    public decimal? IksgkisVerenPrimi { get; set; }

    public decimal? IkissizlikIsciPrimi { get; set; }

    public decimal? IkissizlikIsverenPrimi { get; set; }

    public decimal? HazineYardimi { get; set; }

    public virtual ICollection<Ikpdkssskgecmisi> Ikpdkssskgecmisis { get; set; } = new List<Ikpdkssskgecmisi>();
}
