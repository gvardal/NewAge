using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSatalepDurumu
{
    public byte SatinAlmaTalepDurumuId { get; set; }

    public string? TalepDurumu { get; set; }

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayis { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SateklifSipari> SateklifSiparis { get; set; } = new List<SateklifSipari>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();
}
