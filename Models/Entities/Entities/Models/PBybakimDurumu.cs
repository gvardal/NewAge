using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PBybakimDurumu
{
    public byte DurumId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<BydegisenParcaListesi> BydegisenParcaListesis { get; set; } = new List<BydegisenParcaListesi>();

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();
}
