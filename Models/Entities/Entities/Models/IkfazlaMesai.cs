using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkfazlaMesai
{
    public int MesaiTalebiId { get; set; }

    public byte? FirmaId { get; set; }

    public int? CalisanId { get; set; }

    public string? IsteginKonusu { get; set; }

    public DateTime? MesaiBaslangic { get; set; }

    public DateTime? MesaiBitis { get; set; }

    public decimal? TahminiSure { get; set; }

    public int? IlgiliProje { get; set; }

    public bool? Onay { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public string? Aciklama { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual Pyprojeler? IlgiliProjeNavigation { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }
}
