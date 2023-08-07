using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VPyprojeAdimlari
{
    public int ProjeAdimiId { get; set; }

    public int? ProjeKodu { get; set; }

    public int? OncekiProjeAdimi { get; set; }

    public string? IsinAdi { get; set; }

    public byte? ProjeAdimiDurumuId { get; set; }

    public byte? ProjeAdimiTuruId { get; set; }

    public string? Onem { get; set; }

    public string? Url { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public int? PlanlananSure { get; set; }

    public int? StandartSure { get; set; }

    public int? Sorumlu { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public int? GerceklesenSure { get; set; }

    public string? VarsaSapmaAciklamasi { get; set; }

    public decimal? ButceKaydi { get; set; }

    public decimal? TahiminiMaliyeti { get; set; }

    public short? KrediPuani { get; set; }

    public string? Onculler { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public string? Konu { get; set; }

    public decimal? GerceklesmeMaliyeti { get; set; }

    public string? FaturaDurumu { get; set; }

    public long? FaturaNo { get; set; }

    public string? KısaAcıklama { get; set; }

    public string? TeslimHukumleri { get; set; }

    public string? Yorumlar { get; set; }

    public string? RedNedeni { get; set; }

    public short? ProjeTakimi { get; set; }

    public short? ProjeUnvani { get; set; }

    public string? KilometreTasiKonusu { get; set; }

    public int? KilometreTasiSorumlusu { get; set; }

    public int? KilometreTasiEkleyen { get; set; }

    public int? ReddedilenAksiyonSayisi { get; set; }

    public int? KontrolBekleyenAksiyonSayisi { get; set; }

    public int? OkunacakAksiyonSayisi { get; set; }

    public int? BaslayanAksiyonSayisi { get; set; }

    public int? DuranAksiyonSayisi { get; set; }
}
