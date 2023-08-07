using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class DybyiliskiliEvraklar
{
    public int EvrakId { get; set; }

    public int IliskiliEvrakId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Dybyevraklar Evrak { get; set; } = null!;

    public virtual Dybyevraklar IliskiliEvrak { get; set; } = null!;
}
