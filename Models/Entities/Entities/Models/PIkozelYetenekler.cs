using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkozelYetenekler
{
    public short OzelYetenekId { get; set; }

    public byte? YetenekKategorisiId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<IkcalisanYetenekleri> IkcalisanYetenekleris { get; set; } = new List<IkcalisanYetenekleri>();

    public virtual ICollection<IkegitimIhtiyaclari> IkegitimIhtiyaclaris { get; set; } = new List<IkegitimIhtiyaclari>();

    public virtual ICollection<IkegitimKatalogu> IkegitimKatalogus { get; set; } = new List<IkegitimKatalogu>();

    public virtual ICollection<IkegitimPlanlama> IkegitimPlanlamas { get; set; } = new List<IkegitimPlanlama>();

    public virtual ICollection<IkunvanYetkinlikleri> IkunvanYetkinlikleris { get; set; } = new List<IkunvanYetkinlikleri>();

    public virtual PIkyetenekKategorileri? YetenekKategorisi { get; set; }
}
