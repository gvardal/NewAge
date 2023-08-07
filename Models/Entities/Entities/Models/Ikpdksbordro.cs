using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikpdksbordro
{
    public int BordroId { get; set; }

    public int CalisanId { get; set; }

    public DateTime Tarih { get; set; }

    public DateTime? Giris { get; set; }

    public DateTime? Cikis { get; set; }

    public DateTime? ToplamCalismaSuresi { get; set; }

    public DateTime? Ncsaat { get; set; }

    public decimal? NctoplamUcret { get; set; }

    public DateTime? Fmsaat { get; set; }

    public decimal? FmtoplamUcret { get; set; }

    public DateTime? Fm100saat { get; set; }

    public decimal? Fm100toplamUcret { get; set; }

    public DateTime? Tgsaat { get; set; }

    public decimal? TgtoplamUcret { get; set; }

    public DateTime? UcretliIzinSaat { get; set; }

    public decimal? UcretliIzinToplamUcret { get; set; }

    public DateTime? UcretsizIzinSaat { get; set; }

    /// <summary>
    /// Çalışan Resmi Tatil Günü Çalışırsa FM100Saat kısmına x2 kaydedlir çalışmaz ise Genel Tatil Kısmına x1 olarak Kaydedilir
    /// </summary>
    public DateTime? GenelTatilSaat { get; set; }

    public decimal? GenelTatilToplamUcret { get; set; }

    /// <summary>
    /// 7 günde 24 saatten az olmamak koşulu ile 45 saatte 1 haftasonu 1 günlük hafta sonu izin koşulu
    /// </summary>
    public DateTime? HaftaSonuSaat { get; set; }

    public decimal? HaftaSonuToplamUcret { get; set; }

    public DateTime? YillikIzinSaat { get; set; }

    public decimal? YillikIzinToplamUcret { get; set; }

    public DateTime? DevamsizSaat { get; set; }

    public decimal? AvansUcreti { get; set; }

    public decimal? EkKazanc { get; set; }

    public long? BordroIzinId { get; set; }

    public byte? VardiyaId { get; set; }

    public double? GirisEnlem { get; set; }

    public double? GirisBoylam { get; set; }

    public double? CikisEnlem { get; set; }

    public double? CikisBoylam { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;

    public virtual ICollection<IkpdksgirisCiki> IkpdksgirisCikis { get; set; } = new List<IkpdksgirisCiki>();
}
