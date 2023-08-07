using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VIksgkebildirge
{
    public string? FirmaAdi { get; set; }

    public string? SgksicilNo { get; set; }

    public string? VergiDairesi { get; set; }

    public string? VergiNo { get; set; }

    public string? Adres { get; set; }

    public short? MaliYil { get; set; }

    public byte? MaliAy { get; set; }

    public string? BelgeTuruAciklama { get; set; }

    public string? KanunKoduAdi { get; set; }

    public string? Sskno { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? TckimlikNo { get; set; }

    public string? IlkSoyadi { get; set; }

    public decimal? AylikUcret { get; set; }

    public byte? EksikGunSayisi { get; set; }

    public decimal? FazlaMesaiUcreti { get; set; }

    public decimal? SosyalYardimUcretiNet { get; set; }

    public decimal? DigerKesintiUcreti { get; set; }

    public decimal? TemelUcret { get; set; }

    public decimal? Sgkmatrahi { get; set; }

    public byte? Sgkgun { get; set; }

    public string? EksikGunKoduAdi { get; set; }

    public string? KoduAciklamasi { get; set; }

    public decimal? EksikCalismaSaati { get; set; }

    public bool? CalismaDurumu { get; set; }
}
