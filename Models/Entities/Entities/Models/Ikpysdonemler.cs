using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikpysdonemler
{
    public short DonemId { get; set; }

    public string? PerformansDonemiAdi { get; set; }

    public string? DegerlendirmeTuru { get; set; }

    public string? DonemAraligi { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public byte? Durum { get; set; }

    public bool? Kendisi { get; set; }

    public bool? Ustleri { get; set; }

    public bool? Astlari { get; set; }

    public bool? EsDegerleri { get; set; }

    public decimal? YetkinlikAgirlik { get; set; }

    public DateTime? YetkinlikBaslangic { get; set; }

    public DateTime? YetkinlikBitis { get; set; }

    public decimal? HedefAgirlik { get; set; }

    public DateTime? HedefGirisBaslangic { get; set; }

    public DateTime? HedefGirisBitis { get; set; }

    public DateTime? HedefSonucBaslangic { get; set; }

    public DateTime? HedefSonucBitis { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PIkpysperformansDurum? DurumNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Ikpysperforman> Ikpysperformen { get; set; } = new List<Ikpysperforman>();

    public virtual ICollection<Kshedefler> Kshedeflers { get; set; } = new List<Kshedefler>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
