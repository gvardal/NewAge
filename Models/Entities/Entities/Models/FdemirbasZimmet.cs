using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FdemirbasZimmet
{
    public long ZimmetId { get; set; }

    public int? DemirbasId { get; set; }

    public int? HesapId { get; set; }

    public int? ProjeId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public int? ZimmetEdilenCalisanId { get; set; }

    public DateTime? PlanlananTeslimEtmeTarihi { get; set; }

    public DateTime? PlanlananTeslimAlmaTarihi { get; set; }

    public DateTime? TeslimEdilmeTarihi { get; set; }

    public DateTime? TeslimAlmaTarihi { get; set; }

    public bool? Onaylandi { get; set; }

    public int? OnaylayanId { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? Yazdirildi { get; set; }

    public int? BelgeId { get; set; }

    public string? Aciklama { get; set; }

    public short? KullanimSuresi { get; set; }

    public decimal? KullanimBedeli { get; set; }

    public decimal? ToplamBedel { get; set; }

    public string? SeriNo { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public virtual Dybyevraklar? Belge { get; set; }

    public virtual Fdemirba? Demirbas { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Miysahesaplar? Hesap { get; set; }

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }

    public virtual Ikcalisanlar? ZimmetEdilenCalisan { get; set; }
}
