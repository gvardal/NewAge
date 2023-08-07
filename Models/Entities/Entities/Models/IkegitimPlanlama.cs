using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkegitimPlanlama
{
    public long Id { get; set; }

    /// <summary>
    /// 1-İç Eğitim
    /// 2-Dış Eğitim
    /// 3-e-Öğrenme
    /// 4-Müşteri Eğitimi
    /// 5-Müşteri e-Öğrenme
    /// </summary>
    public byte? EgitimTuru { get; set; }

    public string? EgitimKodu { get; set; }

    public short? EgitimKategorisiId { get; set; }

    public int? KatalogEgitimiId { get; set; }

    public string? EgitimAdi { get; set; }

    public string? EgitimDurumu { get; set; }

    public DateTime? PlanlananEgitimBaslamaTarihi { get; set; }

    public DateTime? PlanlananEgitimBitisTarihi { get; set; }

    public int? PlanlananSure { get; set; }

    public string? EgitiminAmaci { get; set; }

    public string? PlanlananEgitimFirmasi { get; set; }

    public string? PlanlananEgitimiVeren { get; set; }

    public string? PlanlananYer { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public int? GerceklesenSure { get; set; }

    public string? GerceklesenEgitimFirmasi { get; set; }

    public string? GerceklesenEgitimiVeren { get; set; }

    public string? GerceklesenYer { get; set; }

    public decimal? BirimMaliyet { get; set; }

    public decimal? ToplamMaliyet { get; set; }

    public bool? Belge { get; set; }

    public short? KazanilanYetenek { get; set; }

    public int? KatilanKisi { get; set; }

    public int? Fark { get; set; }

    public string? GenelYorumlar { get; set; }

    public bool? Onay { get; set; }

    public int? Onaylayan { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual PIkegitimKategorileri? EgitimKategorisi { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesis { get; set; } = new List<IkegitimKatilimciListesi>();

    public virtual IkegitimKatalogu? KatalogEgitimi { get; set; }

    public virtual PIkozelYetenekler? KazanilanYetenekNavigation { get; set; }

    public virtual Ikcalisanlar? OnaylayanNavigation { get; set; }
}
