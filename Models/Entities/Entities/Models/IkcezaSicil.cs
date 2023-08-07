using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkcezaSicil
{
    public int CezaSicilId { get; set; }

    public int CalisanId { get; set; }

    public string? OlayinGerceklestigiYer { get; set; }

    public string? OlusSekli { get; set; }

    public byte? DavranisTuru { get; set; }

    public DateTime? OlduguTarih { get; set; }

    public string? TanikAdSoyadlari { get; set; }

    public string? Aciklama { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;
}
