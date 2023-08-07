using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PPyprojeAdimiDurumu
{
    public byte ProjeAdimiDurumu { get; set; }

    public byte? ProjeAdimiTuruId { get; set; }

    public string? Durum { get; set; }

    public virtual PPyprojeAdimiTuru? ProjeAdimiTuru { get; set; }

    public virtual ICollection<PyprojeAdimlariHavuzu> PyprojeAdimlariHavuzus { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual ICollection<PyprojeAdimlari> PyprojeAdimlaris { get; set; } = new List<PyprojeAdimlari>();

    public virtual ICollection<PyprojeCalismaKaydi> PyprojeCalismaKaydis { get; set; } = new List<PyprojeCalismaKaydi>();
}
