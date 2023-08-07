using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PPyprojeTakimlari
{
    public short ProjeTakimiId { get; set; }

    public string? TakimAdi { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual ICollection<PyprojeAdimlariHavuzu> PyprojeAdimlariHavuzus { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual ICollection<PyprojeAdimlari> PyprojeAdimlaris { get; set; } = new List<PyprojeAdimlari>();

    public virtual ICollection<PyprojeHavuzuInsanKaynagi> PyprojeHavuzuInsanKaynagis { get; set; } = new List<PyprojeHavuzuInsanKaynagi>();

    public virtual ICollection<PyprojeInsanKaynagi> PyprojeInsanKaynagis { get; set; } = new List<PyprojeInsanKaynagi>();
}
