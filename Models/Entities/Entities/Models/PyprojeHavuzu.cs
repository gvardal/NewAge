using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyprojeHavuzu
{
    public int Id { get; set; }

    public string? ProjeAdi { get; set; }

    public int? ProjeTuru { get; set; }

    public string? ProjeSinifi { get; set; }

    public int? ProjeYoneticisi { get; set; }

    public string? IsModeli { get; set; }

    public string? BasariFaktorleri { get; set; }

    public string? ProjeHukumleri { get; set; }

    public string? KilometreTaslari { get; set; }

    public string? EkipmanListesi { get; set; }

    public string? TeknikPersonelListesi { get; set; }

    public short? PlanlananSure { get; set; }

    public decimal? HedeflenenKar { get; set; }

    public string? CalismaGunu { get; set; }

    public bool? CalismaHesaplamaTuru { get; set; }

    public decimal? HedeflenenGunlukProjeUcreti { get; set; }

    public decimal? HedeflenenGunlukProjeMaliyeti { get; set; }

    public bool? SubelerArasiSeyhat { get; set; }

    public bool? Varsayilan { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Uyurunler? ProjeTuruNavigation { get; set; }

    public virtual Ikcalisanlar? ProjeYoneticisiNavigation { get; set; }

    public virtual ICollection<PsiparisTuru> PsiparisTurus { get; set; } = new List<PsiparisTuru>();

    public virtual ICollection<PyprojeAdimlariHavuzu> PyprojeAdimlariHavuzus { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual ICollection<PyprojeHavuzuInsanKaynagi> PyprojeHavuzuInsanKaynagis { get; set; } = new List<PyprojeHavuzuInsanKaynagi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<UyurunKategorisi> UyurunKategorisis { get; set; } = new List<UyurunKategorisi>();
}
