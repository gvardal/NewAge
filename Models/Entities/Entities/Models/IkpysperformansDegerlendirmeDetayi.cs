using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkpysperformansDegerlendirmeDetayi
{
    public int PerformansDegerlendirmeDetayiId { get; set; }

    public int? PerformansDegerlendirmeId { get; set; }

    public short? SoruId { get; set; }

    public byte? Puan { get; set; }

    public virtual IkpysperformansDegerlendirme? PerformansDegerlendirme { get; set; }

    public virtual Ikpyssorular? Soru { get; set; }
}
