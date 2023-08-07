using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkpysanaPerformansKriteriId
{
    public byte AnaPerformansKriteriId { get; set; }

    public byte? SoruGrubuId { get; set; }

    public string? Aciklama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Ikpyssorular> Ikpyssorulars { get; set; } = new List<Ikpyssorular>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual PIkpyssoruGrubu? SoruGrubu { get; set; }
}
