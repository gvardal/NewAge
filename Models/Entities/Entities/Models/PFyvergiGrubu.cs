using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFyvergiGrubu
{
    public byte VergiGrubuId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<MiysahesapFiyatListesi> MiysahesapFiyatListesis { get; set; } = new List<MiysahesapFiyatListesi>();

    public virtual ICollection<PFyvergiGrubuDetayi> PFyvergiGrubuDetayis { get; set; } = new List<PFyvergiGrubuDetayi>();
}
