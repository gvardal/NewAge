using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKytehlikeliMadde
{
    public short TehllikeliMaddeId { get; set; }

    public string? TehlikeliMaddeAdi { get; set; }

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();
}
