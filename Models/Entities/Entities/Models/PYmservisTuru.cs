using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PYmservisTuru
{
    public byte ServisTuruId { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniLotNo> YmmusteriBakimPlaniLotNos { get; set; } = new List<YmmusteriBakimPlaniLotNo>();

    public virtual ICollection<YmmusteriBakimPlaniUrun> YmmusteriBakimPlaniUruns { get; set; } = new List<YmmusteriBakimPlaniUrun>();
}
