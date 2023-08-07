using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VIkbugunYilDonumuDogumGunuOlanlar
{
    public int CalisanId { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public string BirimAdi { get; set; } = null!;

    public string UnvanAdi { get; set; } = null!;

    public string DogumGunuOrYilDonumu { get; set; } = null!;

    public DateTime? Tarih { get; set; }
}
