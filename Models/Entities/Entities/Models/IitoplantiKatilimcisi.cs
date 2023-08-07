using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IitoplantiKatilimcisi
{
    public int ToplantiKatilimcisiId { get; set; }

    public short? ToplantiTutanagiId { get; set; }

    public bool? Gorev { get; set; }

    public int? KatilimciCalisanId { get; set; }

    public byte? KatilimDurumu { get; set; }

    public DateTime? KatilimBildirimTarihi { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual Ikcalisanlar? KatilimciCalisan { get; set; }

    public virtual IitoplantiTutanagi? ToplantiTutanagi { get; set; }
}
