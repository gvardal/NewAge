using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSavadeler
{
    public byte Id { get; set; }

    public string? VadeKodu { get; set; }

    public string? Aciklama { get; set; }

    public int? VadeSuresi { get; set; }

    public double? VadeOrani { get; set; }

    public string VadeKoduOrani { get; set; } = null!;

    public bool? Ithalat { get; set; }

    public byte? OdemeTuruId { get; set; }

    public bool? Aktif { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual PFytahsilatOdemeTuru? OdemeTuru { get; set; }

    public virtual ICollection<PSysavadeDetayi> PSysavadeDetayis { get; set; } = new List<PSysavadeDetayi>();

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();
}
