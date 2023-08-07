using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkmeslekGruplari
{
    public short MeslekGrubuId { get; set; }

    public string? MeslekKodu { get; set; }

    public string? MeslekAdi { get; set; }

    public string MeslekKoduAdi { get; set; } = null!;

    public virtual ICollection<Ikpdkssskgecmisi> Ikpdkssskgecmisis { get; set; } = new List<Ikpdkssskgecmisi>();

    public virtual ICollection<Ikunvanlar> Ikunvanlars { get; set; } = new List<Ikunvanlar>();
}
