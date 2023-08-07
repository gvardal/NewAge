using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Lygpstransaction
{
    public long Id { get; set; }

    public long? Enlem { get; set; }

    public long? Boylam { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public decimal? Hiz { get; set; }

    public decimal? Hdop { get; set; }

    public decimal? Metre { get; set; }

    public byte? VeriKaynagi { get; set; }

    public short? Gpsid { get; set; }

    public bool? Kontak { get; set; }

    public int? KaynakNo { get; set; }

    public int? Port1 { get; set; }

    public int? Port2 { get; set; }

    public double? Yukseklik { get; set; }

    public string? Tip { get; set; }

    public decimal? KumulatifMetre { get; set; }

    public virtual Lygpstanim? Gps { get; set; }
}
