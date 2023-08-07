using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyprojeCalismaKaydi
{
    public long ProjeCalismaKaydiId { get; set; }

    public int? ProjeId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public int? GorevId { get; set; }

    public int CalisanId { get; set; }

    public DateTime? BaslamaSaati { get; set; }

    public DateTime? BitisSaati { get; set; }

    public decimal? CalisilanZaman { get; set; }

    public byte? ProjeDurumId { get; set; }

    public bool? Tamamlandi { get; set; }

    public decimal? SaatlikUcreti { get; set; }

    public decimal? ToplamUcret { get; set; }

    public string? Aciklama { get; set; }

    public string? BelgeAciklama { get; set; }

    public int? EvrakId { get; set; }

    public int? Miktar { get; set; }

    public bool? Faturalanacak { get; set; }

    public byte? FaturalanmamaNedeniId { get; set; }

    public string? FaturaAciklama { get; set; }

    public long? FaturaDetayiId { get; set; }

    public bool? SehirDisi { get; set; }

    public bool? Yemek { get; set; }

    public decimal? OtelMasrafi { get; set; }

    public decimal? YolMasrafi { get; set; }

    public decimal? SeyahatSuresi { get; set; }

    public decimal? Harcirah { get; set; }

    public string? MusteriDegerlendirme { get; set; }

    public string? MusteriAciklama { get; set; }

    public int? MusteriDegerlendirenId { get; set; }

    public double? BaslamaEnlem { get; set; }

    public double? BaslamaBoylam { get; set; }

    public double? BitisEnlem { get; set; }

    public double? BitisBoylam { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Dybyevraklar? Evrak { get; set; }

    public virtual FyfaturaDetayi? FaturaDetayi { get; set; }

    public virtual PPyfaturalanmamaNedeni? FaturalanmamaNedeni { get; set; }

    public virtual Ggorevler? Gorev { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }

    public virtual PPyprojeAdimiDurumu? ProjeDurum { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
