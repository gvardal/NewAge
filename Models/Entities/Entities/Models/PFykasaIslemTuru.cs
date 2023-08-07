using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFykasaIslemTuru
{
    public byte KasaIslemTuruId { get; set; }

    public string? Aciklama { get; set; }

    public bool? GirisCikis { get; set; }
}
