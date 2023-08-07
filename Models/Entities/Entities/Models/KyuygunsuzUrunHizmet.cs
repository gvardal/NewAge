using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KyuygunsuzUrunHizmet
{
    public long UygunsuzUrunHizmetId { get; set; }

    public bool? Aktif { get; set; }

    public int? Dofid { get; set; }

    public byte? UygunsuzlukKaynagi { get; set; }

    public short? UygunsuzBirim { get; set; }

    public int? UygunsuzKonumId { get; set; }

    public int? SasiparisId { get; set; }

    public int? Firma { get; set; }

    public DateTime? TespitTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public int? TespitEdenId { get; set; }

    public int? UrunId { get; set; }

    public string? ParcaNumarasi { get; set; }

    public int? ProjeId { get; set; }

    public int? IsEmriRotaId { get; set; }

    public int? UretimPlaniId { get; set; }

    public long? EnvanterId { get; set; }

    public int? IcTetkikPlaniId { get; set; }

    public long? FaturaDetayiId { get; set; }

    public string? MusteriIrsaliyeNo { get; set; }

    public decimal? UygunsuzUrunHizmetMiktari { get; set; }

    public string? UygunsuzlukNedeni { get; set; }

    public int? FireTuruId { get; set; }

    public string? Durum { get; set; }

    public byte[]? DosyaYolu { get; set; }

    public string? DosyaAdi { get; set; }

    public string? DosyaUzantisi { get; set; }

    public string? YapilacakIslem { get; set; }

    public string? YapilanIslem { get; set; }

    public string? IslemSuresi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Kydof? Dof { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual YmmusteriEnvanter? Envanter { get; set; }

    public virtual UyfireTuru? FireTuru { get; set; }

    public virtual Miysahesaplar? FirmaNavigation { get; set; }

    public virtual KyicTetkikPlani? IcTetkikPlani { get; set; }

    public virtual UyisEmriRotasi? IsEmriRota { get; set; }

    public virtual ICollection<Kydof> Kydofs { get; set; } = new List<Kydof>();

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketis { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? TespitEden { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual Ikorganizasyonlar? UygunsuzBirimNavigation { get; set; }

    public virtual Uykonum? UygunsuzKonum { get; set; }

    public virtual PKyuygunsuzlukKaynagi? UygunsuzlukKaynagiNavigation { get; set; }
}
