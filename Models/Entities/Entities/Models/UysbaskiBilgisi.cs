using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UysbaskiBilgisi
{
    public int BaskiBilgisiId { get; set; }

    public int? AmbalajMalzemeId { get; set; }

    public string? GenelBilgiler { get; set; }

    public string? BaskiBilgisiI { get; set; }

    public string? BaskiBilgisiIi { get; set; }

    public string? BaskiBilgisiIii { get; set; }

    public virtual UysambalajMalzemeleri? AmbalajMalzeme { get; set; }
}
