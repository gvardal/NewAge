using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmproblemTuru
{
    public short Id { get; set; }

    public string? ProblemTuru { get; set; }

    public string? ProblemTuruAciklamasi { get; set; }

    public virtual ICollection<YmproblemCozumuTakibi> YmproblemCozumuTakibis { get; set; } = new List<YmproblemCozumuTakibi>();
}
