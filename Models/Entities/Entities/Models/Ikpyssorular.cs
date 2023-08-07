using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikpyssorular
{
    public short SoruId { get; set; }

    public byte? GrupId { get; set; }

    public byte? AnaPerformansKriteriId { get; set; }

    public string? Soru { get; set; }

    public virtual PIkpysanaPerformansKriteriId? AnaPerformansKriteri { get; set; }

    public virtual PIkpyssoruGrubu? Grup { get; set; }

    public virtual ICollection<IkpysperformansDegerlendirmeDetayi> IkpysperformansDegerlendirmeDetayis { get; set; } = new List<IkpysperformansDegerlendirmeDetayi>();
}
