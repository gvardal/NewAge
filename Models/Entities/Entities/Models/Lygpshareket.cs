using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Lygpshareket
{
    public long Id { get; set; }

    public long Enlem { get; set; }

    public long Boylam { get; set; }

    public DateTime? Tarih { get; set; }

    public TimeSpan? Saat { get; set; }

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

    public decimal? Kumulatifmetre { get; set; }

    public short? AlarmId { get; set; }

    public virtual Lygpsalarm? Alarm { get; set; }

    public virtual Lygpstanim? Gps { get; set; }
}
