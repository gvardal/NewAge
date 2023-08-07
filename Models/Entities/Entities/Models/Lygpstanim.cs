using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Lygpstanim
{
    public short Gpsid { get; set; }

    public string? Kod { get; set; }

    public string? BulunduguAdres { get; set; }

    public bool? Aktif { get; set; }

    public DateTime? GuncellemeTarihi { get; set; }

    public DateTime? Aktivasyon { get; set; }

    public long? SonEnlem { get; set; }

    public long? SonBoylam { get; set; }

    public long? SonVeriKaynagi { get; set; }

    public string? SimTelefonNo { get; set; }

    public string? SimSeriNo { get; set; }

    public decimal? KatEttigiKm { get; set; }

    public string Imei { get; set; } = null!;

    public string? Sifre { get; set; }

    public virtual ICollection<Lyaraclar> Lyaraclars { get; set; } = new List<Lyaraclar>();

    public virtual ICollection<LycihazAlanDurumu> LycihazAlanDurumus { get; set; } = new List<LycihazAlanDurumu>();

    public virtual ICollection<Lygpshareket> Lygpsharekets { get; set; } = new List<Lygpshareket>();

    public virtual ICollection<Lygpstransaction> Lygpstransactions { get; set; } = new List<Lygpstransaction>();
}
