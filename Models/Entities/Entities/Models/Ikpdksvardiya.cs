using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikpdksvardiya
{
    public byte VardiyaId { get; set; }

    public string? Ad { get; set; }

    public DateTime GunDonumSaati { get; set; }

    public DateTime? IseGirisSaati { get; set; }

    public DateTime? IstenCikisSaati { get; set; }

    public DateTime? ErkenGelmeToleransSaati { get; set; }

    public DateTime? GecGelmeToleransSaati { get; set; }

    public DateTime? ErkenCikmaToleransSaati { get; set; }

    public virtual ICollection<IkpdksgunlukCalismaPlani> IkpdksgunlukCalismaPlanis { get; set; } = new List<IkpdksgunlukCalismaPlani>();

    public virtual ICollection<Ikpdksmesai> Ikpdksmesais { get; set; } = new List<Ikpdksmesai>();

    public virtual ICollection<Ikpdksmola> Ikpdksmolas { get; set; } = new List<Ikpdksmola>();

    public virtual ICollection<UytoplamEkipmanEtkinligi> UytoplamEkipmanEtkinligis { get; set; } = new List<UytoplamEkipmanEtkinligi>();
}
