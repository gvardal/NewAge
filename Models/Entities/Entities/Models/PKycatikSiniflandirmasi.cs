using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKycatikSiniflandirmasi
{
    public int SinifId { get; set; }

    public string? SinifKodu { get; set; }

    public string? SinifAciklama { get; set; }

    public virtual ICollection<KycatikTanimlari> KycatikTanimlaris { get; set; } = new List<KycatikTanimlari>();
}
