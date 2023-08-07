using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiysahesapTuru
{
    public string HesapTuruId { get; set; } = null!;

    public string? HesapTuru { get; set; }

    public int? VarsayilanHesapPlaniId { get; set; }

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual FyhesapPlani? VarsayilanHesapPlani { get; set; }
}
