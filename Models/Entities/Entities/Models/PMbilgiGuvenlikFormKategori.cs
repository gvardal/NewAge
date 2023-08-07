using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PMbilgiGuvenlikFormKategori
{
    public short KategoriId { get; set; }

    public string? KategoriAdi { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<RymalzemeBilgiGuvenlikFormlari> RymalzemeBilgiGuvenlikFormlaris { get; set; } = new List<RymalzemeBilgiGuvenlikFormlari>();
}
