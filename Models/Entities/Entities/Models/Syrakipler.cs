using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Syrakipler
{
    public int Id { get; set; }

    public int? TeklifSiparisId { get; set; }

    public byte? SiraNo { get; set; }

    public int? RakipHesapId { get; set; }

    public decimal? TeklifBedeli { get; set; }

    public byte? Durum { get; set; }

    public virtual PSyrakipDurumu? DurumNavigation { get; set; }

    public virtual Miysahesaplar? RakipHesap { get; set; }

    public virtual Sysiparisler? TeklifSiparis { get; set; }
}
