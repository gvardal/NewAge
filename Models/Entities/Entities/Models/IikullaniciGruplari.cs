using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IikullaniciGruplari
{
    public int KullaniciGrubuId { get; set; }

    public string? Aciklama { get; set; }

    public byte[]? GrupFoto { get; set; }

    public virtual ICollection<Iiiletisim> Iiiletisims { get; set; } = new List<Iiiletisim>();

    public virtual ICollection<IikullaniciGrupKatilimcilari> IikullaniciGrupKatilimcilaris { get; set; } = new List<IikullaniciGrupKatilimcilari>();
}
