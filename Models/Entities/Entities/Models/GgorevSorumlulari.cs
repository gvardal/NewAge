using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class GgorevSorumlulari
{
    public long GorevSorumluId { get; set; }

    public int GorevId { get; set; }

    public int CalisanId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;

    public virtual Ggorevler Gorev { get; set; } = null!;
}
