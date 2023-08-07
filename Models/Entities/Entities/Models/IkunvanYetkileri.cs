using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkunvanYetkileri
{
    public int Id { get; set; }

    public int YetkiId { get; set; }

    public short UnvanId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Ikunvanlar Unvan { get; set; } = null!;

    public virtual Ikyetkiler Yetki { get; set; } = null!;
}
