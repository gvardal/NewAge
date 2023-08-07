using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkpdksgunlukCalismaPlani
{
    public byte CalismaGrubuId { get; set; }

    public DateTime Tarih { get; set; }

    public byte? VardiyaId { get; set; }

    public byte? AylikCalismaSaati { get; set; }

    public virtual IkpdkscalismaGrubu CalismaGrubu { get; set; } = null!;

    public virtual Ikpdksvardiya? Vardiya { get; set; }
}
