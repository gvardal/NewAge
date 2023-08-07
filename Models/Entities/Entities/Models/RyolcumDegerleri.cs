using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RyolcumDegerleri
{
    public int OlcumDegeriId { get; set; }

    public int? OlcumDegeriAnalizId { get; set; }

    public int? MedikalTahlilId { get; set; }

    public int? IlgiliMuayene { get; set; }

    public string? OlcumDegeriSonuc { get; set; }

    public string? OlcumDegeriNot { get; set; }

    public virtual RymedikalMuayeneKayitlari? IlgiliMuayeneNavigation { get; set; }

    public virtual RymedikalTahlil? MedikalTahlil { get; set; }

    public virtual PRyolcumDegeriAnaliz? OlcumDegeriAnaliz { get; set; }
}
