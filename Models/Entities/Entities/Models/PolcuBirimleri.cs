using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PolcuBirimleri
{
    public int Id { get; set; }

    public string? OlcuKodu { get; set; }

    public string? OlcuBirimi { get; set; }

    public string? BirimTuru { get; set; }

    public short? BirimTuruId { get; set; }

    public string? EFaturaKoduId { get; set; }

    public string? Tr { get; set; }

    public string? En { get; set; }

    public virtual PUyolcuBirimiTurleri? BirimTuruNavigation { get; set; }

    public virtual PFyeFaturaOlcuBirimleri? EFaturaKodu { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<IkekipmanZimmet> IkekipmanZimmets { get; set; } = new List<IkekipmanZimmet>();

    public virtual ICollection<KycatikToplamaDetayi> KycatikToplamaDetayis { get; set; } = new List<KycatikToplamaDetayi>();

    public virtual ICollection<MiyfirsatAnalizi> MiyfirsatAnalizis { get; set; } = new List<MiyfirsatAnalizi>();

    public virtual ICollection<MiyfirsatDetayi> MiyfirsatDetayis { get; set; } = new List<MiyfirsatDetayi>();

    public virtual ICollection<PyprojeMaliyetAnalizi> PyprojeMaliyetAnalizis { get; set; } = new List<PyprojeMaliyetAnalizi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayiBirimNavigations { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayiIiolcuBirimis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<Sepet> Sepets { get; set; } = new List<Sepet>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayiIiolcuBirimis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayiOlcuBirimiNavigations { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<SyteslimatPlani> SyteslimatPlanis { get; set; } = new List<SyteslimatPlani>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayis { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UysambalajBilgisi> UysambalajBilgisis { get; set; } = new List<UysambalajBilgisi>();

    public virtual ICollection<Uyurunler> UyurunlerIisatinAlmaOlcuBirimis { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerIiuretimOlcuBirimis { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerSatinAlmaOlcuBirimis { get; set; } = new List<Uyurunler>();

    public virtual ICollection<Uyurunler> UyurunlerUretimOlcuBirimis { get; set; } = new List<Uyurunler>();
}
