using System;
using System.Collections.Generic;

namespace Entities.Models;

/// <summary>
/// Kullanıcılar Arası İletişim Kayıtları burada Tutulur.
/// </summary>
public partial class Iiiletisim
{
    public long IletisimId { get; set; }

    public int? KullaniciGrupId { get; set; }

    public int? KullaniciId { get; set; }

    public int? GorevId { get; set; }

    public string? Mesaj { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ggorevler? Gorev { get; set; }

    public virtual Ikcalisanlar? Kullanici { get; set; }

    public virtual IikullaniciGruplari? KullaniciGrup { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
