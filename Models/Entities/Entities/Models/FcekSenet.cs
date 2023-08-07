using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FcekSenet
{
    public int CekSenetId { get; set; }

    public byte? FirmaId { get; set; }

    public int? TahsilatId { get; set; }

    public int? OdemeId { get; set; }

    public byte? BankaHesabiId { get; set; }

    public long? BankaHesapIslemiId { get; set; }

    public decimal? BankaIslemTutari { get; set; }

    public byte? KasaId { get; set; }

    public long? KasaIslemId { get; set; }

    public DateTime? Tarih { get; set; }

    public bool? CekSenet { get; set; }

    public string? TakipNo { get; set; }

    public int? AlinanHesapId { get; set; }

    public int? VerilenHesapId { get; set; }

    public string? AlinanVerilen { get; set; }

    public bool? KesideciMuhatap { get; set; }

    public byte? Banka { get; set; }

    public string? Sube { get; set; }

    public string? Ibanno { get; set; }

    public DateTime? Vadesi { get; set; }

    public string? OdemeYeri { get; set; }

    public string? CekNo { get; set; }

    public bool? DovizCekSenedi { get; set; }

    public decimal? DovizTutari { get; set; }

    public decimal? KurOrani { get; set; }

    public byte? ParaBirimiId { get; set; }

    public decimal? Tutari { get; set; }

    public byte? DurumId { get; set; }

    public byte? YerId { get; set; }

    public bool? KesideCiro { get; set; }

    public DateTime? KesideCiroTarihi { get; set; }

    public decimal? CiroKuru { get; set; }

    public string? Aciklama { get; set; }

    public int? IlgiliHesapPlaniId { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Miysahesaplar? AlinanHesap { get; set; }

    public virtual FybankaHesabi? BankaHesabi { get; set; }

    public virtual FybankaHesapHareketi? BankaHesapIslemi { get; set; }

    public virtual PFbankalar? BankaNavigation { get; set; }

    public virtual PFcekSenetDurum? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FcekSenetGecmisi> FcekSenetGecmisis { get; set; } = new List<FcekSenetGecmisi>();

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual FyhesapPlani? IlgiliHesapPlani { get; set; }

    public virtual Fykasalar? Kasa { get; set; }

    public virtual FykasaIslemleri? KasaIslem { get; set; }

    public virtual FytahsilatOdeme? Odeme { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FytahsilatOdeme? Tahsilat { get; set; }

    public virtual Miysahesaplar? VerilenHesap { get; set; }

    public virtual PFcekSenetYeri? Yer { get; set; }
}
