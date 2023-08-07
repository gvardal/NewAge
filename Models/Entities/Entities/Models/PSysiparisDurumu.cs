using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSysiparisDurumu
{
    public byte SiparisDurumId { get; set; }

    public string? Durum { get; set; }

    public string? Tur { get; set; }

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<Sysiparisler> Sysiparislers { get; set; } = new List<Sysiparisler>();

    public virtual ICollection<SyteslimatPlani> SyteslimatPlanis { get; set; } = new List<SyteslimatPlani>();
}
