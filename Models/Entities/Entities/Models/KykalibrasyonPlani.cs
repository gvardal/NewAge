using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KykalibrasyonPlani
{
    public int KalibrasyonPlaniId { get; set; }

    public int? DemirbasId { get; set; }

    public string? KalibrasyonSekli { get; set; }

    public string? Durum { get; set; }

    public int? KalibrasyonFirmasiId { get; set; }

    public int? ReferansCihazId { get; set; }

    public string? ReferanDeger { get; set; }

    public bool? Yontem { get; set; }

    public DateTime? PlanlananKalibrasyonTarihi { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? GerceklesenKalibrasyonTarihi { get; set; }

    public string? OkunanDeger { get; set; }

    public string? UygunSapmaSiniri { get; set; }

    public string? Sapma { get; set; }

    public string? Sonuc { get; set; }

    public byte[]? SonucDosyası { get; set; }

    public string? SertifikaNumarasi { get; set; }

    public bool? GorunumFonksiyonKontrolu { get; set; }

    public DateTime? BirSonrakiKalibrasyonTarihi { get; set; }

    public int? GerceklestirenId { get; set; }

    public string? DosyaAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Fdemirba? Demirbas { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? Gerceklestiren { get; set; }

    public virtual Miysahesaplar? KalibrasyonFirmasi { get; set; }

    public virtual Fdemirba? ReferansCihaz { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
