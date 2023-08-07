using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PsevkiyatYontemi
{
    public short SevkiyatYontemiId { get; set; }

    public string? YontemKodu { get; set; }

    public string? Yontem { get; set; }

    public string YontemAdiKodu { get; set; } = null!;

    public bool? TeslimatServisi { get; set; }

    public bool? MusteriyeTeslimat { get; set; }

    public bool? IthalatIhracat { get; set; }

    public byte? GonderilmeSekli { get; set; }

    public bool? B2b { get; set; }

    public bool? B2c { get; set; }

    public byte[]? Resim { get; set; }

    public int? TasiyiciFirmaId { get; set; }

    public bool? Aktif { get; set; }

    public string? KargoSirketi { get; set; }

    public string? KargoKullaniciAdi { get; set; }

    public string? KargoSifre { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<PsiparisTuru> PsiparisTurus { get; set; } = new List<PsiparisTuru>();

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();

    public virtual Miysahesaplar? TasiyiciFirma { get; set; }

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
