using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkpdksgirisCiki
{
    public int GirisCikisId { get; set; }

    public int? BordroId { get; set; }

    public int CalisanId { get; set; }

    public DateTime Tarih { get; set; }

    public bool? GirisCikis { get; set; }

    public string? CihazIp { get; set; }

    public byte[]? Resim { get; set; }

    public double? Enlem { get; set; }

    public double? Boylam { get; set; }

    public virtual Ikpdksbordro? Bordro { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;
}
