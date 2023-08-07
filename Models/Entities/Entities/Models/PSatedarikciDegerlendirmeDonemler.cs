using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSatedarikciDegerlendirmeDonemler
{
    public short DonemId { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public byte? Durum { get; set; }

    public int? KontrolEdenId { get; set; }

    public DateTime? KontroleGonderimTarihi { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayaGonderimTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual PIkpysperformansDurum? DurumNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? KontrolEden { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual ICollection<SatedarikciDegerlendirme> SatedarikciDegerlendirmes { get; set; } = new List<SatedarikciDegerlendirme>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
