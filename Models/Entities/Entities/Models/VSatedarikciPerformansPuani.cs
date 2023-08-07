using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSatedarikciPerformansPuani
{
    public string? HesapKodu { get; set; }

    public string? FirmaAdi { get; set; }

    public int Id { get; set; }

    public bool? Oncelikli { get; set; }

    public short DonemId { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public string? Aciklama { get; set; }

    public decimal? TedarikciPerformansPuani { get; set; }
}
