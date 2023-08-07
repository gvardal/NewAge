using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FmiysacariHesapHareketleri
{
    public int CariHareketId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public byte? CariHesapHareketTuruId { get; set; }

    public long? FaturaId { get; set; }

    public int? TahsilatOdemeId { get; set; }

    public int? HesapKodu { get; set; }

    public DateTime? Tarih { get; set; }

    public string? BelgeNo { get; set; }

    public string? Aciklama { get; set; }

    public decimal? DovizTutar { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? Kur { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public decimal? BorcBakiye { get; set; }

    public decimal? AlacakBakiye { get; set; }

    public decimal? Dborc { get; set; }

    public decimal? Dalacak { get; set; }

    public decimal? DborcBakiye { get; set; }

    public decimal? DalacakBakiye { get; set; }

    public byte? VirmanYapilanParaBirimiId { get; set; }

    public decimal? VirmanYapilanKur { get; set; }

    public int? VirmanYapilanHesapId { get; set; }

    public int? VirmanYapilanCariHareketId { get; set; }

    public short? VadeGunu { get; set; }

    public long? YevmiyeDefteriId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Fyfatura? Fatura { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual Miysahesaplar? HesapKoduNavigation { get; set; }

    public virtual PFyisAlani? IsAlani { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FytahsilatOdeme? TahsilatOdeme { get; set; }

    public virtual Miysahesaplar? VirmanYapilanHesap { get; set; }

    public virtual PparaBirimi? VirmanYapilanParaBirimi { get; set; }
}
