using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PtedarikciTuru
{
    public byte Id { get; set; }

    public string? TedarikciTuru { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();
}
