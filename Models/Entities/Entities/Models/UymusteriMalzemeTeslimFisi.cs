using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UymusteriMalzemeTeslimFisi
{
    public int MusteriMalzemeTeslimFisi { get; set; }

    public int? MusteriId { get; set; }

    public DateTime? TeslimAlmaTarihi { get; set; }

    public int? TeslimAlanCalisanId { get; set; }

    public string? Aciklama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public byte? DurumId { get; set; }

    public long? IrsaliyeId { get; set; }

    public int? SiparisId { get; set; }

    public virtual PUytaseronMalzemeTeslimDurumu? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual Fyfatura? Irsaliye { get; set; }

    public virtual Miysahesaplar? Musteri { get; set; }

    public virtual Sysiparisler? Siparis { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? TeslimAlanCalisan { get; set; }

    public virtual ICollection<UymusteriMalzemeTeslimFisiDetayi> UymusteriMalzemeTeslimFisiDetayis { get; set; } = new List<UymusteriMalzemeTeslimFisiDetayi>();
}
