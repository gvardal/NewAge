using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkbordroAvan
{
    public int AvansId { get; set; }

    public int AvansAlanCalisanId { get; set; }

    public DateTime Tarih { get; set; }

    public string? AvansTuru { get; set; }

    public byte? TaksitSayisi { get; set; }

    public decimal? AlinanMiktar { get; set; }

    public decimal? IoncekiTahsilEdilen { get; set; }

    public decimal? TahsilEdilen { get; set; }

    public decimal? Bakiye { get; set; }

    public string? Aciklama { get; set; }

    public byte? KasaId { get; set; }

    public byte? BankaHesabiId { get; set; }

    public decimal? BankaIslemUcreti { get; set; }

    public int? OdemeFisId { get; set; }

    public int? MuhasebeHesapKoduId { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeTarihi { get; set; }

    public DateTime? IdosyaTarihi { get; set; }

    public string? IdosyaNumarasi { get; set; }

    public string? ImahkemeAdi { get; set; }

    public string? IicraDairesi { get; set; }

    public string? Ialacakli { get; set; }

    public string? IodemeYapilacakBankaAdi { get; set; }

    public string? IodemeYapilacakHesapNo { get; set; }

    public string? IodemeYapilacakIbanNo { get; set; }

    public byte? IaylikKesintiOraniI { get; set; }

    public byte? IaylikKesintiOraniIi { get; set; }

    public decimal? IaylikKesintiTutari { get; set; }

    public bool? IagidahilEdilsin { get; set; }

    public string? Iagikesintisi { get; set; }

    public string? IicraKesintiBaslangicYili { get; set; }

    public string? IicraKesintiBaslangicAyi { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public short? Ioncelik { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar AvansAlanCalisan { get; set; } = null!;

    public virtual FybankaHesabi? BankaHesabi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<IkbordroAvansDetayi> IkbordroAvansDetayis { get; set; } = new List<IkbordroAvansDetayi>();

    public virtual Fykasalar? Kasa { get; set; }

    public virtual FyhesapPlani? MuhasebeHesapKodu { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
