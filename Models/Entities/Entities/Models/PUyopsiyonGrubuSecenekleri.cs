using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PUyopsiyonGrubuSecenekleri
{
    public int OpsiyonGrubuSecenekId { get; set; }

    public short? OpsiyonGrubuId { get; set; }

    public bool? Varsayilan { get; set; }

    public string? SecenekAdi { get; set; }

    public string? RaporGorunumu { get; set; }

    public double? FiyatlandirmaYuzdesi { get; set; }

    public string? SecenekKodu { get; set; }

    public virtual PUyopsiyonGrubu? OpsiyonGrubu { get; set; }

    public virtual ICollection<UyurunAgaciHavuzu> UyurunAgaciHavuzus { get; set; } = new List<UyurunAgaciHavuzu>();
}
