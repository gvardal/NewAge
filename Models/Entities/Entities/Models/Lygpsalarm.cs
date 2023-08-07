using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Lygpsalarm
{
    public short AlarmId { get; set; }

    public decimal Enlem { get; set; }

    public decimal Boylam { get; set; }

    public short AlarmTuruId { get; set; }

    public string? Deger { get; set; }

    public bool? Durum { get; set; }

    public string? Imei { get; set; }

    public short? Gpsid { get; set; }

    public DateTime? AlarmZamani { get; set; }

    public DateTime? AlarmMudahaleZamani { get; set; }

    public virtual LygpsalarmTurleri AlarmTuru { get; set; } = null!;

    public virtual ICollection<Lygpshareket> Lygpsharekets { get; set; } = new List<Lygpshareket>();
}
