using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyopsiyonGrubu
{
    public short OpsiyonGrubuId { get; set; }

    public string? Aciklama { get; set; }

    public string? RaporAciklama { get; set; }

    public string? OpsiyonTuru { get; set; }

    public byte? OpsiyonTuruId { get; set; }

    public bool? SiparisOpsiyonu { get; set; }

    public bool? RapordaGosterme { get; set; }

    public string? OpsiyonEtkiDuzeyi { get; set; }

    public virtual PUyopsiyonGrubuTuru? OpsiyonTuruNavigation { get; set; }

    public virtual ICollection<PUyopsiyonGrubuSecenekleri> PUyopsiyonGrubuSecenekleris { get; set; } = new List<PUyopsiyonGrubuSecenekleri>();

    public virtual ICollection<UyurunAgaciHavuzu> UyurunAgaciHavuzus { get; set; } = new List<UyurunAgaciHavuzu>();
}
