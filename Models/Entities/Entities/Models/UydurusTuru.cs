using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UydurusTuru
{
    public byte DurusTuruId { get; set; }

    public byte? OnceliDurusTuruId { get; set; }

    public string? DurusKodu { get; set; }

    public string? DurusTuruAdi { get; set; }

    public string? DurusTuruKoduAdi { get; set; }

    public string? KayipTuru { get; set; }

    public bool? IstisnaDurus { get; set; }

    public int? FymaliyetMuhasebeHesapId { get; set; }

    public int? FyamortismanGiderHesapId { get; set; }

    public virtual FyhesapPlani? FyamortismanGiderHesap { get; set; }

    public virtual FyhesapPlani? FymaliyetMuhasebeHesap { get; set; }

    public virtual ICollection<UydurusTuru> InverseOnceliDurusTuru { get; set; } = new List<UydurusTuru>();

    public virtual UydurusTuru? OnceliDurusTuru { get; set; }

    public virtual ICollection<UyisciZamanKartiArsivi> UyisciZamanKartiArsivis { get; set; } = new List<UyisciZamanKartiArsivi>();

    public virtual ICollection<UyisciZamanKarti> UyisciZamanKartis { get; set; } = new List<UyisciZamanKarti>();

    public virtual ICollection<UyuretimVerileriArsivi> UyuretimVerileriArsivis { get; set; } = new List<UyuretimVerileriArsivi>();

    public virtual ICollection<UyuretimVerileri> UyuretimVerileris { get; set; } = new List<UyuretimVerileri>();
}
