using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KyornekAlmaPlani
{
    public short OrnekAlmaPlaniId { get; set; }

    public string? OrnekPlaniTanimi { get; set; }

    public string? MuayenePlaniTuru { get; set; }

    public string? KarakteristiginOnemi { get; set; }

    public bool? VarsayilanPlan { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public virtual ICollection<KyornekAlmaTablosu> KyornekAlmaTablosus { get; set; } = new List<KyornekAlmaTablosu>();

    public virtual ICollection<UyisAkisSorulari> UyisAkisSorularis { get; set; } = new List<UyisAkisSorulari>();

    public virtual ICollection<UyisAkisVerileri> UyisAkisVerileris { get; set; } = new List<UyisAkisVerileri>();
}
