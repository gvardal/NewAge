using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyprojeAdimiSorumlulari
{
    public int ProjeAdimiSorumluId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public int? CalisanId { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }
}
