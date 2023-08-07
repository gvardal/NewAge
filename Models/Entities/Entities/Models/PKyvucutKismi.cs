using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKyvucutKismi
{
    public byte VucutKismiId { get; set; }

    public string? VucutKismi { get; set; }

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();
}
