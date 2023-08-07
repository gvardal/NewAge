using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KshedefOlcumleri
{
    public int HedefOlcumId { get; set; }

    public int? KurumsalHedefId { get; set; }

    public int? KisiselHedefId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? OlculenDeger { get; set; }

    public string? Aciklama { get; set; }

    public virtual Kshedefler? KisiselHedef { get; set; }
}
