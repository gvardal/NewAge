using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunOzellikleri
{
    public long UrunOzellikleriId { get; set; }

    public int? UrunId { get; set; }

    public short? OzellikTuruId { get; set; }

    public byte? KodlamaTuruId { get; set; }

    public string? Aciklama { get; set; }

    public bool? DegerSecenek { get; set; }

    public string? Deger { get; set; }

    public string? Deger1 { get; set; }

    public short? OzellikSecenegiId { get; set; }

    public bool? SiparisOzelligi { get; set; }

    public bool? OpsiyonelOzellik { get; set; }

    public string? HesaplamaOzelligi { get; set; }

    public bool? AnaUrunOzellik { get; set; }

    public string? OzellikEtkiDuzeyi { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public virtual PUykodlamaTuru? KodlamaTuru { get; set; }

    public virtual PUyozellikTuru? OzellikTuru { get; set; }

    public virtual ICollection<SysiparisUrunOzellikOpsiyonlari> SysiparisUrunOzellikOpsiyonlaris { get; set; } = new List<SysiparisUrunOzellikOpsiyonlari>();

    public virtual Uyurunler? Urun { get; set; }
}
