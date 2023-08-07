using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKystandart
{
    public byte StandartId { get; set; }

    public string? StandartAdi { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<UyisAkisSoruGruplari> UyisAkisSoruGruplaris { get; set; } = new List<UyisAkisSoruGruplari>();
}
