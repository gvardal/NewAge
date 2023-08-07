using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKycalisanIsKazaKutugu
{
    public int CalisanIsKazaKutuguId { get; set; }

    public int CalisanId { get; set; }

    public int IsKazaId { get; set; }

    public bool? Okundu { get; set; }

    public DateTime? OkumaTarihi { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;

    public virtual KyisKazalari IsKaza { get; set; } = null!;
}
