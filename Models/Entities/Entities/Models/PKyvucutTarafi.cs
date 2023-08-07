using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKyvucutTarafi
{
    public byte VucutTarafiId { get; set; }

    public string? VucutTarafi { get; set; }

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();
}
