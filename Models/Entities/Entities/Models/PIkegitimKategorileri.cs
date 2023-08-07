using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkegitimKategorileri
{
    public short EgitimKategorisiId { get; set; }

    public short? UstEgitimKategorisiId { get; set; }

    public string? Aciklama { get; set; }

    /// <summary>
    /// 1=İç Eğitim, 2=Dış Eğitim, 3= İç/Dış Eğitim
    /// </summary>
    public byte? VideoTuru { get; set; }

    public bool? EgitimOnayGerekli { get; set; }

    public virtual ICollection<IkegitimKatalogu> IkegitimKatalogus { get; set; } = new List<IkegitimKatalogu>();

    public virtual ICollection<IkegitimPlanlama> IkegitimPlanlamas { get; set; } = new List<IkegitimPlanlama>();

    public virtual ICollection<PIkegitimKategorileri> InverseUstEgitimKategorisi { get; set; } = new List<PIkegitimKategorileri>();

    public virtual PIkegitimKategorileri? UstEgitimKategorisi { get; set; }
}
