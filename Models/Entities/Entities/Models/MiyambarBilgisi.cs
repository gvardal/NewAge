using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiyambarBilgisi
{
    public int AmbarBilgisiId { get; set; }

    public int? MusteriKoduId { get; set; }

    public string? Aciklama { get; set; }

    public string? SorumluKisi { get; set; }

    public string? Adres1 { get; set; }

    public int? Ilce { get; set; }

    public int? Sehir { get; set; }

    public short? Ulke { get; set; }

    public string? PostaKodu { get; set; }

    public decimal? Gpsenlem { get; set; }

    public decimal? Gpsboylam { get; set; }

    public string? Uyari { get; set; }

    public string? Telefon { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual Pilceler? IlceNavigation { get; set; }

    public virtual Miysahesaplar? MusteriKodu { get; set; }

    public virtual Psehirler? SehirNavigation { get; set; }

    public virtual ICollection<Sysiparisler> SysiparislerAmbarSevkiyatAdresis { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<Sysiparisler> SysiparislerFaturaAdresis { get; set; } = new List<Sysiparisler>();

    public virtual Pulkeler? UlkeNavigation { get; set; }

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
