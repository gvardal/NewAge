using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkpysperformansDurum
{
    public byte DurumId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Ikpysdonemler> Ikpysdonemlers { get; set; } = new List<Ikpysdonemler>();

    public virtual ICollection<IkpysperformansDegerlendirme> IkpysperformansDegerlendirmes { get; set; } = new List<IkpysperformansDegerlendirme>();

    public virtual ICollection<Ikpysperforman> Ikpysperformen { get; set; } = new List<Ikpysperforman>();

    public virtual ICollection<PSatedarikciDegerlendirmeDonemler> PSatedarikciDegerlendirmeDonemlers { get; set; } = new List<PSatedarikciDegerlendirmeDonemler>();
}
