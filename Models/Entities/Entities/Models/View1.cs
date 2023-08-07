using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class View1
{
    public long MusteriEnvanterId { get; set; }

    public DateTime? StokGirisTarihi { get; set; }

    public long Ikincienvanterid { get; set; }

    public string? IkinciEnvanterNo { get; set; }

    public string? IkinciLotno { get; set; }

    public string? LotNo { get; set; }

    public DateTime? IkinciStokGirisTarihi { get; set; }

    public string? BirinciUrunId { get; set; }

    public string? BirinciUrunAdi { get; set; }

    public string? IkiniciUrunKodu { get; set; }

    public string? IkinciUrunAdi { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? TuketilenMiktar { get; set; }

    public decimal? Expr1 { get; set; }

    public decimal? Expr2 { get; set; }

    public long StokHareketiLotNoId { get; set; }

    public int StokAmbarFisiId { get; set; }

    public DateTime? Tarih { get; set; }

    public bool? Onaylandi { get; set; }

    public long StokHareketiId { get; set; }

    public decimal? Expr3 { get; set; }

    public int UrunStokDetayiId { get; set; }
}
