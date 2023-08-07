using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PLyteslimSarti
{
    public byte TeslimSartiId { get; set; }

    public string? TeslimSartiKodu { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();
}
