using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUybostakiCalisanlar
{
    public int Id { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public string? Birimi { get; set; }

    public string? Unvani { get; set; }

    public string? CalismaGrubu { get; set; }
}
