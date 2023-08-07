using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIksgkkanunlari
{
    public short SgkkanunId { get; set; }

    public string? KanunKodu { get; set; }

    public string? Aciklama { get; set; }

    public string KanunKoduAdi { get; set; } = null!;

    public virtual ICollection<Ikpdkssskgecmisi> Ikpdkssskgecmisis { get; set; } = new List<Ikpdkssskgecmisi>();
}
