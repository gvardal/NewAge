using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkpysperformansDegerlendirme
{
    public int PerformansDegerlendirmeId { get; set; }

    public int? PerformansId { get; set; }

    public byte? DurumId { get; set; }

    public int? DegerlendirenId { get; set; }

    public DateTime? DegerlendirmeTarihi { get; set; }

    public string? Aciklama { get; set; }

    public byte? ToplamPuan { get; set; }

    public virtual Ikcalisanlar? Degerlendiren { get; set; }

    public virtual PIkpysperformansDurum? Durum { get; set; }

    public virtual ICollection<IkpysperformansDegerlendirmeDetayi> IkpysperformansDegerlendirmeDetayis { get; set; } = new List<IkpysperformansDegerlendirmeDetayi>();

    public virtual ICollection<Kshedefler> Kshedeflers { get; set; } = new List<Kshedefler>();

    public virtual Ikpysperforman? Performans { get; set; }
}
