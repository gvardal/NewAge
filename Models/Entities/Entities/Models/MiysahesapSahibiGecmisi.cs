using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiysahesapSahibiGecmisi
{
    public int HesapSahibiGecmisiId { get; set; }

    public int? HesapId { get; set; }

    public int? HesapSahibiId { get; set; }

    public short? UrunGrubuId { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Miysahesaplar? Hesap { get; set; }

    public virtual Ikcalisanlar? HesapSahibi { get; set; }

    public virtual PUyurunGruplari? UrunGrubu { get; set; }
}
