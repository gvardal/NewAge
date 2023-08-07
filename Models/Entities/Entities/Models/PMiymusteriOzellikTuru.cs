using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PMiymusteriOzellikTuru
{
    public short OzellikTuruId { get; set; }

    public string? Aciklama { get; set; }

    public string? UzunAciklama { get; set; }

    public short? UstOzellikTuruId { get; set; }

    public virtual ICollection<PMiymusteriOzellikTuru> InverseUstOzellikTuru { get; set; } = new List<PMiymusteriOzellikTuru>();

    public virtual ICollection<MiymusteriOzellikleri> MiymusteriOzellikleris { get; set; } = new List<MiymusteriOzellikleri>();

    public virtual PMiymusteriOzellikTuru? UstOzellikTuru { get; set; }
}
