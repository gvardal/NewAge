using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikpdksmesai
{
    public short MesaiId { get; set; }

    public byte? VardiyaId { get; set; }

    public string? Ad { get; set; }

    public DateTime? BaslangicZamani { get; set; }

    public DateTime? BitisZamani { get; set; }

    public string? MesaiTuruId { get; set; }

    public virtual IkpdksmesaiTuru? MesaiTuru { get; set; }

    public virtual Ikpdksvardiya? Vardiya { get; set; }
}
