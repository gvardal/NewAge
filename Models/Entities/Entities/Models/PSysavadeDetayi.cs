using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSysavadeDetayi
{
    public short SysavadeDetayiId { get; set; }

    public byte? SavadelerId { get; set; }

    public byte? SyvadelerId { get; set; }

    public decimal? TutarinYuzdeOrani { get; set; }

    public bool? SiparisTesliminde { get; set; }

    public short? VadeSuresi { get; set; }

    public byte? OdemeTuruId { get; set; }

    public int? PosId { get; set; }

    public string? Aciklama { get; set; }

    public virtual PFytahsilatOdemeTuru? OdemeTuru { get; set; }

    public virtual PSypo? Pos { get; set; }

    public virtual PSavadeler? Savadeler { get; set; }

    public virtual PSyvadeler? Syvadeler { get; set; }
}
