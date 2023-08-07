using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkkursSeminerler
{
    public decimal Id { get; set; }

    public int? KullaniciAdi { get; set; }

    public string? KursSeminerAdi { get; set; }

    public string? KursSeminerKonusu { get; set; }

    public string? EgitimKurumu { get; set; }

    public string? Suresi { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public bool? KurumIci { get; set; }

    public long? EgitimKodu { get; set; }

    public virtual IkegitimKatilimciListesi? EgitimKoduNavigation { get; set; }

    public virtual Ikcalisanlar? KullaniciAdiNavigation { get; set; }
}
