using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IitoplantiTutanagi
{
    public short ToplantiTutanagiId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public string? Konu { get; set; }

    public short? OncekiToplantiId { get; set; }

    public int? IlgiliHesapId { get; set; }

    public int? ProjeId { get; set; }

    public int? Yer { get; set; }

    public string? ToplantiyaDisaridanKatilanlar { get; set; }

    public int? HazirlayanCalisanId { get; set; }

    public DateTime? YapilacakToplantiTarihi { get; set; }

    public string? Notlar { get; set; }

    public byte? DurumId { get; set; }

    public byte? ToplantiTipi { get; set; }

    public string? PlanlananBaslamaSaati { get; set; }

    public string? PlanlananBitisSaati { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? GelecekToplantiTarihi { get; set; }

    public string? CevrimiciToplanti { get; set; }

    public string? CevrimiciToplantiSifresi { get; set; }

    public bool? Yineleme { get; set; }

    public string? YinelemeTuru { get; set; }

    public byte? YinelemeSuresi { get; set; }

    public virtual PIitoplantiDurumu? Durum { get; set; }

    public virtual Ikcalisanlar? HazirlayanCalisan { get; set; }

    public virtual ICollection<IigundemMaddesi> IigundemMaddesis { get; set; } = new List<IigundemMaddesi>();

    public virtual ICollection<IitoplantiDagitimListesi> IitoplantiDagitimListesis { get; set; } = new List<IitoplantiDagitimListesi>();

    public virtual ICollection<IitoplantiKatilimcisi> IitoplantiKatilimcisis { get; set; } = new List<IitoplantiKatilimcisi>();

    public virtual ICollection<IitoplantiTutanagi> InverseOncekiToplanti { get; set; } = new List<IitoplantiTutanagi>();

    public virtual IitoplantiTutanagi? OncekiToplanti { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual Uykonum? YerNavigation { get; set; }
}
