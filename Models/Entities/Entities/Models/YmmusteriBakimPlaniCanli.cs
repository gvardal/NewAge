using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmmusteriBakimPlaniCanli
{
    public int BakimPlaniId { get; set; }

    public long CanliId { get; set; }

    public string? BarkodNo { get; set; }

    public byte? YapilanIslemId { get; set; }

    public DateTime IslemTarihi { get; set; }

    public int? IslemYapanCalisanId { get; set; }

    public string? Aciklama { get; set; }

    public string? Sonuc { get; set; }

    public virtual YmmusteriBakimPlani BakimPlani { get; set; } = null!;

    public virtual Ymcanlilar Canli { get; set; } = null!;

    public virtual Ikcalisanlar? IslemYapanCalisan { get; set; }

    public virtual PYmyapilanIslem? YapilanIslem { get; set; }
}
