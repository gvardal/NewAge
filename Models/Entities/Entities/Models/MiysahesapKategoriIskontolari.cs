using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiysahesapKategoriIskontolari
{
    public int HesapId { get; set; }

    public int KategoriId { get; set; }

    public double? IskontoOrani { get; set; }

    public byte? SyvadeKoduId { get; set; }

    public string? Aciklama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Miysahesaplar Hesap { get; set; } = null!;

    public virtual UyurunKategorisi Kategori { get; set; } = null!;

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
