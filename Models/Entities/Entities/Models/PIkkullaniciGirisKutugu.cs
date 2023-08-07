using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkkullaniciGirisKutugu
{
    public long KullaniciGirisKutuguId { get; set; }

    public int? CalisanId { get; set; }

    public string? GirilenIp { get; set; }

    public DateTime? GirisTarihi { get; set; }

    public string? KullaniciId { get; set; }

    public string? Sifre { get; set; }

    public string? Sonuc { get; set; }

    public string? GirisAnahtari { get; set; }

    public string? Uygulama { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }
}
