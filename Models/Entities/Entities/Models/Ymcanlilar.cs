using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ymcanlilar
{
    public long CanliId { get; set; }

    public int? UrunId { get; set; }

    public long? AnneId { get; set; }

    public long? BabaId { get; set; }

    public int? HesapId { get; set; }

    public int? DurumId { get; set; }

    public string? KupeNo { get; set; }

    public string? ProjeNo { get; set; }

    public int? Irki { get; set; }

    public bool? Cinsi { get; set; }

    public bool? Cinsiyeti { get; set; }

    public bool? DogumSekli { get; set; }

    public int? DogumTipi { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public DateTime? OlumTarihi { get; set; }

    public bool? DamizlikDurumu { get; set; }

    public bool? Dybeden { get; set; }

    public bool? Dyderi { get; set; }

    public bool? Dykemik { get; set; }

    public bool? Dybas { get; set; }

    public bool? Dyboyun { get; set; }

    public bool? Dyboynuz { get; set; }

    public bool? Dykulaklar { get; set; }

    public bool? Dysirt { get; set; }

    public bool? Dybel { get; set; }

    public bool? Dysagri { get; set; }

    public bool? Dygogus { get; set; }

    public bool? Dykarin { get; set; }

    public bool? Dymeme { get; set; }

    public bool? Dybacak { get; set; }

    public bool? Dytirnak { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PYmcanliDogumTipi? DogumTipiNavigation { get; set; }

    public virtual YmcanliDurumu? Durum { get; set; }

    public virtual Miysahesaplar? Hesap { get; set; }

    public virtual PYmcanliIrki? IrkiNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<YmcanliEslesmeListesi> YmcanliEslesmeListesiDcanlis { get; set; } = new List<YmcanliEslesmeListesi>();

    public virtual ICollection<YmcanliEslesmeListesi> YmcanliEslesmeListesiEcanlis { get; set; } = new List<YmcanliEslesmeListesi>();

    public virtual ICollection<YmcanliOzellikleri> YmcanliOzellikleris { get; set; } = new List<YmcanliOzellikleri>();

    public virtual ICollection<YmmusteriBakimPlaniCanli> YmmusteriBakimPlaniCanlis { get; set; } = new List<YmmusteriBakimPlaniCanli>();
}
