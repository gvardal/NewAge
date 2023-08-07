using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PgorevAlani
{
    public short Id { get; set; }

    public string? GorevAlani { get; set; }

    public virtual ICollection<IkisDeneyimleri> IkisDeneyimleris { get; set; } = new List<IkisDeneyimleri>();
}
