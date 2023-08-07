using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKyyaralanmaSekli
{
    public short YaralanmaSekliId { get; set; }

    public string? YaralanmaSekli { get; set; }

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();
}
