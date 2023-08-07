using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSyvadeler
{
    public byte Id { get; set; }

    public string? VadeKodu { get; set; }

    public string? Aciklama { get; set; }

    public int? VadeSuresi { get; set; }

    public double? VadeOrani { get; set; }

    public string VadeKoduOrani { get; set; } = null!;

    public double? VadeIskontoOrani { get; set; }

    public short? Taksit { get; set; }

    public bool? Ihracat { get; set; }

    public byte? OdemeTuruId { get; set; }

    public bool? Aktif { get; set; }

    public bool? B2b { get; set; }

    public bool? B2c { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual PFytahsilatOdemeTuru? OdemeTuru { get; set; }

    public virtual ICollection<PSysavadeDetayi> PSysavadeDetayis { get; set; } = new List<PSysavadeDetayi>();

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();
}
