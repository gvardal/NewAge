using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class BirlestirilmisMifdetayi
{
    public long MalzemeIstekFisiId { get; set; }

    public long MalzemeIstekFisiDetayiId { get; set; }

    public int? SiparisNo { get; set; }

    public long? IsEmriNo { get; set; }

    public int? KonumId { get; set; }

    public long? UretimPlaniId { get; set; }

    public int IlkMaddeVeMalzemeNo { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public decimal? PlanlananBirimFiyat { get; set; }

    public decimal? PlanlananTutar { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? GerceklesenBirimFiyat { get; set; }

    public decimal? GerceklesenTutar { get; set; }

    public string? Aciklama { get; set; }
}
