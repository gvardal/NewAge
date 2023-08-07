using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PPyprojeAdimiTuru
{
    public byte ProjeAdimiTuruId { get; set; }

    public string? ProjeAdimiTuru { get; set; }

    public virtual ICollection<PPyprojeAdimiDurumu> PPyprojeAdimiDurumus { get; set; } = new List<PPyprojeAdimiDurumu>();

    public virtual ICollection<PyprojeAdimlariHavuzu> PyprojeAdimlariHavuzus { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual ICollection<PyprojeAdimlari> PyprojeAdimlaris { get; set; } = new List<PyprojeAdimlari>();
}
