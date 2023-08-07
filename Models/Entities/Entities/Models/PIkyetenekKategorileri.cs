using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkyetenekKategorileri
{
    public byte YetenekKategorisiId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<PIkozelYetenekler> PIkozelYeteneklers { get; set; } = new List<PIkozelYetenekler>();
}
