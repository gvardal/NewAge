using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KyicTetkikPlani
{
    public int IcTetkikPlaniId { get; set; }

    public string? TetkikTuru { get; set; }

    public string? TetkikKodu { get; set; }

    public string? Konu { get; set; }

    public short? IlgiliSurecId { get; set; }

    public short? IlgiliBirimId { get; set; }

    public short? IsAkisSoruGrubuId { get; set; }

    public string? IcTetkikPlaniNo { get; set; }

    public string? OlcumTuruId { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public byte? Durum { get; set; }

    public bool? Tamamlandi { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public string? Degerlendirme { get; set; }

    public string? GelistirilmesiGerekenMadde { get; set; }

    public string? OrnekGosterilecekMadde { get; set; }

    public int? DenetlenenId { get; set; }

    public int? Sidenetci { get; set; }

    public bool? DenetimDegerlendir { get; set; }

    public byte? DenetimPuani { get; set; }

    public long? EnvanterId { get; set; }

    public int? IsEmriRotaId { get; set; }

    public int? UrunId { get; set; }

    public long? TeslimatHareketiId { get; set; }

    public long? SyteslimatPlaniId { get; set; }

    public long? BakimPlaniDetayiId { get; set; }

    public decimal? KontrolEdilenMiktar { get; set; }

    public decimal? KabulEdilenMiktar { get; set; }

    public decimal? RedEdilenMiktar { get; set; }

    public string? KademeliDenetimTuru { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual YmmusteriBakimPlaniUrun? BakimPlaniDetayi { get; set; }

    public virtual Ikcalisanlar? Denetlenen { get; set; }

    public virtual PGnldurumlar? DurumNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual YmmusteriEnvanter? Envanter { get; set; }

    public virtual Ikorganizasyonlar? IlgiliBirim { get; set; }

    public virtual Kysurecler? IlgiliSurec { get; set; }

    public virtual UyisAkisSoruGruplari? IsAkisSoruGrubu { get; set; }

    public virtual UyisEmriRotasi? IsEmriRota { get; set; }

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmets { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Ikcalisanlar? SidenetciNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual YmmusteriBakimPlaniLotNo? SyteslimatPlani { get; set; }

    public virtual SateklifSiparisTeslimatHareketi? TeslimatHareketi { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual ICollection<UyisAkisVerileri> UyisAkisVerileris { get; set; } = new List<UyisAkisVerileri>();
}
