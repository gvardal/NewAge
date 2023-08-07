using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyyevmiyeDefteriDetayiBatch
{
    public long? YevmiyeDefteriDetayiId { get; set; }

    public int? YevmiyeDefteriId { get; set; }

    public byte? FirmaId { get; set; }

    public byte? IsAlaniId { get; set; }

    public DateTime? BelgeTarihi { get; set; }

    public string? BelgeNo { get; set; }

    public string? HesapPlaniId { get; set; }

    public string? Aciklama { get; set; }

    public decimal? BorcTutari { get; set; }

    public decimal? AlacakTutari { get; set; }

    public long? FaturaId { get; set; }

    public int? TahsilatOdemeId { get; set; }
}
