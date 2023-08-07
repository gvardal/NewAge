using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class RymedikalTahlil
{
    public int MedikalTahlilId { get; set; }

    public int? IlgiliMuayene { get; set; }

    public short? MedikalTestGrubuId { get; set; }

    public string? MedikalTestTanimi { get; set; }

    public DateTime? TahlilTarihi { get; set; }

    public int? OlcumDegeriAnalizId { get; set; }

    public string? OlcumDegeriSonuc { get; set; }

    public string? OlcumDegeriNot { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public string? Aciklama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual RymedikalMuayeneKayitlari? IlgiliMuayeneNavigation { get; set; }

    public virtual PRymedikalTestGrubu? MedikalTestGrubu { get; set; }

    public virtual PRyolcumDegeriAnaliz? OlcumDegeriAnaliz { get; set; }

    public virtual ICollection<RyolcumDegerleri> RyolcumDegerleris { get; set; } = new List<RyolcumDegerleri>();
}
