using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KyortamOlcumVerileri
{
    public long OrtamOlcumVeriId { get; set; }

    public DateTime? Tarih { get; set; }

    public int? KonumId { get; set; }

    public int? IsEmriRotaId { get; set; }

    public short? EtkenId { get; set; }

    public string? Aciklama { get; set; }

    public string? OlculenDeger { get; set; }

    public string? NominalDeger { get; set; }

    public byte? OlcuBirimi { get; set; }
}
