using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PMiybelgeTurleri
{
    public byte BelgeTuruId { get; set; }

    public string? Aciklama { get; set; }

    public string? IlgiliBolum { get; set; }

    public virtual ICollection<MiyihaleDokumanlari> MiyihaleDokumanlaris { get; set; } = new List<MiyihaleDokumanlari>();
}
