using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class LycihazAlanDurumu
{
    public short CihazAlanId { get; set; }

    public short AlanId { get; set; }

    public short Gpsid { get; set; }

    public string? Imei { get; set; }

    public bool? AlanIcindeAlarmVermeDurumu { get; set; }

    public bool? MevcutİhlalDurumu { get; set; }

    public short ToplamİhlalSayisi { get; set; }

    public DateTime? CihazAlanTanimlamaTarihi { get; set; }

    public virtual Lygpsalan Alan { get; set; } = null!;

    public virtual Lygpstanim Gps { get; set; } = null!;
}
