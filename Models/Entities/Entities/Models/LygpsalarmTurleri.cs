using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class LygpsalarmTurleri
{
    public short AlarmTuruId { get; set; }

    public string AlarmTuru { get; set; } = null!;

    public virtual ICollection<Lygpsalarm> Lygpsalarms { get; set; } = new List<Lygpsalarm>();
}
