using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PMiyteminatMektupDurumu
{
    public byte TeminatMektupDurumu { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<MiyihaleTeminatMektuplari> MiyihaleTeminatMektuplaris { get; set; } = new List<MiyihaleTeminatMektuplari>();
}
