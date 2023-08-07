using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkisBasvurulari
{
    public int Id { get; set; }

    public int? AdayAdi { get; set; }

    public long? PozisyonAdi { get; set; }

    public DateTime? BasvuruTarihi { get; set; }

    public string? BasvuruDegerlendirme { get; set; }

    public DateTime? DegerlendirmeTarihi { get; set; }

    public byte? DikkatTestiDogru { get; set; }

    public byte? DikkatTestiYanlis { get; set; }

    public byte? DikkatTestiBos { get; set; }

    public string? DikkatTestiSure { get; set; }

    public byte? Pm38ogrendikleriniKullanabilme { get; set; }

    public byte? Pm38yenilikleeAcikOlma { get; set; }

    public byte? Pm38egitimMeslekiAltYapi { get; set; }

    public byte? Pm38deneyiminIseAktarilmasi { get; set; }

    public byte? Pm38toplam { get; set; }

    public string? KisilikTestiItercih { get; set; }

    public string? KisilikTestiIitercih { get; set; }

    public string? KisilikTestiIiitercih { get; set; }

    public byte? IzkariyerGelisimi { get; set; }

    public byte? Izliderlik { get; set; }

    public byte? Izgirisimcilik { get; set; }

    public short? KisiselYeterlilikSkoru { get; set; }

    public short? MeslekiYeterlilikSkoru { get; set; }

    public short? ReferansSkoru { get; set; }

    public string? DegerlendirmeNotu { get; set; }

    public string? Durum { get; set; }

    public virtual Ikcalisanlar? AdayAdiNavigation { get; set; }

    public virtual IkacikPozisyonlar? PozisyonAdiNavigation { get; set; }
}
