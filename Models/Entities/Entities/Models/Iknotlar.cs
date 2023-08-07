using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Iknotlar
{
    public int NotId { get; set; }

    public int? CalisanId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual ICollection<Ikcalisanlar> Calisans { get; set; } = new List<Ikcalisanlar>();
}
