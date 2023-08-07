using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkistenCikisKodu
{
    public string IstenCikisKoduId { get; set; } = null!;

    public string? Aciklama { get; set; }

    public string KoduAciklamasi { get; set; } = null!;

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikpdkssskgecmisi> Ikpdkssskgecmisis { get; set; } = new List<Ikpdkssskgecmisi>();
}
