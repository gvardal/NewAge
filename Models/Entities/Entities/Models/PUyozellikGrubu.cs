using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyozellikGrubu
{
    public short OzellikGrubuId { get; set; }

    public string? OzellikSinifi { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<UykategoriOzellikleri> UykategoriOzellikleris { get; set; } = new List<UykategoriOzellikleri>();
}
