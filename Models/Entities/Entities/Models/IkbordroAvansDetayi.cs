using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkbordroAvansDetayi
{
    public int AvansDetayiId { get; set; }

    public int? AvansId { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal? TahsilEdilen { get; set; }

    public string? Aciklama { get; set; }

    public byte? BankaHesabiId { get; set; }

    public decimal? BankaIslemUcreti { get; set; }

    public int? OdemeFisiId { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeTarihi { get; set; }

    public virtual IkbordroAvan? Avans { get; set; }

    public virtual FybankaHesabi? BankaHesabi { get; set; }

    public virtual FytahsilatOdeme? OdemeFisi { get; set; }
}
