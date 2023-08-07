using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiyisbitirmeBelgeleri
{
    public short IsBitirmeBelgeId { get; set; }

    public int? IsVerenId { get; set; }

    public string? IsVerenBitirmeNo { get; set; }

    public int? FirsatId { get; set; }

    public string? IsinTanimi { get; set; }

    public string? Yuklenici { get; set; }

    public string? IsOrtakligi { get; set; }

    public DateTime? SozlesmeTarihi { get; set; }

    public decimal? IlkSozlesmeBedeli { get; set; }

    public decimal? GerceklestirilenIsinTutari { get; set; }

    public decimal? ToplamSozlesmeTutari { get; set; }

    public byte? ParaBirimiId { get; set; }

    public DateTime? KabulTarihi { get; set; }

    public decimal? BelgeTutari { get; set; }

    public byte? OrtaklikHisseOrani { get; set; }

    public string? IsMiktari { get; set; }

    public string? HisseyeGoreIsMiktari { get; set; }

    public string? KanitlayiciBelge { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Miyfirsatlar? Firsat { get; set; }

    public virtual Miysahesaplar? IsVeren { get; set; }

    public virtual PparaBirimi? ParaBirimi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
