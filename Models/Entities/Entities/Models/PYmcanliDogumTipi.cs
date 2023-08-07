using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PYmcanliDogumTipi
{
    public int CanliDogumTipiId { get; set; }

    public string? CanliDogumTipiAdi { get; set; }

    public virtual ICollection<Ymcanlilar> Ymcanlilars { get; set; } = new List<Ymcanlilar>();
}
