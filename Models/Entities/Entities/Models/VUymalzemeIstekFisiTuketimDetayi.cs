using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUymalzemeIstekFisiTuketimDetayi
{
    public long MalzemeIstekFisiDetayiId { get; set; }

    public long MalzemeIstekFisiId { get; set; }

    public int? SiparisNo { get; set; }

    public long? UretimPlaniId { get; set; }

    public long? IsEmriNo { get; set; }

    public DateTime? Tarih { get; set; }

    public string? TalepEden { get; set; }

    public string? TeslimEden { get; set; }

    public int IlkMaddeVeMalzemeNo { get; set; }

    public string? UrunKoduAdi { get; set; }

    public string? TalepEdilenKonum { get; set; }

    public int? TalepEdilenKonumId { get; set; }

    public string? CikisDeposu { get; set; }

    public int? CikisDeposuId { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? PlanlananBirimFiyat { get; set; }

    public decimal? GerceklesenBirimFiyat { get; set; }

    public decimal? PlanlananTutar { get; set; }

    public decimal? GerceklesenTutar { get; set; }

    public string? Aciklama { get; set; }

    public bool? Gerceklesti { get; set; }
}
