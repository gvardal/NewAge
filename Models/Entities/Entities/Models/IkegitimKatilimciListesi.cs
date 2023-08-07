using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkegitimKatilimciListesi
{
    public long Id { get; set; }

    public long? EgitimKodu { get; set; }

    public int? EgitimKataloguId { get; set; }

    public int? Katilimci { get; set; }

    public bool? KatilimDurumu { get; set; }

    public DateTime? KatilimTarihi { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public DateTime? OkumaTarihi { get; set; }

    public string? KatilmamaGerekcesi { get; set; }

    public byte? EgitmeninKalitesi { get; set; }

    public byte? EgitiminKonusu { get; set; }

    public byte? EgitimSuresi { get; set; }

    public byte? EgitimZamani { get; set; }

    public byte? EgitimOrtami { get; set; }

    public byte? EgitiminIseOlanKatkisi { get; set; }

    public byte? EgitiminKisiyeOlanKatkisi { get; set; }

    public string? Aciklama { get; set; }

    public byte? DogruSayisi { get; set; }

    public byte? YanlisSayisi { get; set; }

    public byte? BosSayisi { get; set; }

    public bool? Sonuc { get; set; }

    public bool? GorevlerimdenKaldir { get; set; }

    public bool? Degerlendirme { get; set; }

    public int? MuhasebeHesapKoduId { get; set; }

    public virtual IkegitimKatalogu? EgitimKatalo { get; set; }

    public virtual IkegitimPlanlama? EgitimKoduNavigation { get; set; }

    public virtual PIkegitimDegerlendirme? EgitimOrtamiNavigation { get; set; }

    public virtual PIkegitimDegerlendirme? EgitimSuresiNavigation { get; set; }

    public virtual PIkegitimDegerlendirme? EgitimZamaniNavigation { get; set; }

    public virtual PIkegitimDegerlendirme? EgitiminIseOlanKatkisiNavigation { get; set; }

    public virtual PIkegitimDegerlendirme? EgitiminKisiyeOlanKatkisiNavigation { get; set; }

    public virtual PIkegitimDegerlendirme? EgitiminKonusuNavigation { get; set; }

    public virtual PIkegitimDegerlendirme? EgitmeninKalitesiNavigation { get; set; }

    public virtual ICollection<IkkursSeminerler> IkkursSeminerlers { get; set; } = new List<IkkursSeminerler>();

    public virtual Ikcalisanlar? KatilimciNavigation { get; set; }

    public virtual ICollection<UyisAkisVerileri> UyisAkisVerileris { get; set; } = new List<UyisAkisVerileri>();
}
