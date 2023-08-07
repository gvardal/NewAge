using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IitoplantiDagitimListesi
{
    public long ToplantiDagitimListesiId { get; set; }

    public short? ToplantiTutanagiId { get; set; }

    public int? KisiUnvanCalisanId { get; set; }

    public bool? Gorev { get; set; }

    public virtual Ikcalisanlar? KisiUnvanCalisan { get; set; }

    public virtual IitoplantiTutanagi? ToplantiTutanagi { get; set; }
}
