using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KycatikTanimlari
{
    public int AtikTuruId { get; set; }

    public string? AtikTanimi { get; set; }

    public string? AtikKodu { get; set; }

    public int? SiniflId { get; set; }

    public string? AtikTipi { get; set; }

    public string? Msdsno { get; set; }

    public string? Toplanma { get; set; }

    public string? Tasima { get; set; }

    public int? BertarafYontemiId { get; set; }

    public bool? GeriDonusturulebilir { get; set; }

    public int? GeriDonusumYontemiId { get; set; }

    public string? GeriDonusumAciklama { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual PKycbertarafYontemleri? BertarafYontemi { get; set; }

    public virtual PKycgeriDonusumYontemleri? GeriDonusumYontemi { get; set; }

    public virtual ICollection<KycatikToplamaDetayi> KycatikToplamaDetayis { get; set; } = new List<KycatikToplamaDetayi>();

    public virtual PKycatikSiniflandirmasi? Sinifl { get; set; }
}
