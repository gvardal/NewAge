using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PMiysavarlikTuru
{
    public string VarlikTuruId { get; set; } = null!;

    public string? VarlikTuru { get; set; }

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();
}
