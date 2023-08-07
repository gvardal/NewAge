using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyozellikTuruSecenekleri
{
    public short OzellikTuruSecenekId { get; set; }

    public short OzellikTuruId { get; set; }

    public string? SecenekAdi { get; set; }

    public short? SonrakiOzellikTuruId { get; set; }

    public string? Aciklama { get; set; }

    public virtual PUyozellikTuru OzellikTuru { get; set; } = null!;

    public virtual PUyozellikTuru? SonrakiOzellikTuru { get; set; }
}
