using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UysauretimPlaniSiparisDetayi
{
    public long UretimPlaniSiparisDetayiId { get; set; }

    public long? UretimPlani { get; set; }

    public long? SiparisDetayi { get; set; }

    public long? IsEmriId { get; set; }

    public long? UrunAgaciPlanlamaId { get; set; }

    public decimal? Miktar { get; set; }

    public bool? AnaKayit { get; set; }

    public virtual UyisEmri? IsEmri { get; set; }

    public virtual UyuretimPlani? UretimPlaniNavigation { get; set; }

    public virtual UyurunAgaciPlanlama? UrunAgaciPlanlama { get; set; }
}
