using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkpyssoruGrubu
{
    public byte GrupId { get; set; }

    public string? Aciklama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Ikpysperforman> Ikpysperformen { get; set; } = new List<Ikpysperforman>();

    public virtual ICollection<Ikpyssorular> Ikpyssorulars { get; set; } = new List<Ikpyssorular>();

    public virtual ICollection<PIkpysanaPerformansKriteriId> PIkpysanaPerformansKriteriIds { get; set; } = new List<PIkpysanaPerformansKriteriId>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
