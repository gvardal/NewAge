﻿using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PKycgeriDonusumYontemleri
{
    public int GeriDonusumYontemiId { get; set; }

    public string? GeriDonusumYontemi { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<KycatikTanimlari> KycatikTanimlaris { get; set; } = new List<KycatikTanimlari>();

    public virtual ICollection<KycatikToplamaDetayi> KycatikToplamaDetayis { get; set; } = new List<KycatikToplamaDetayi>();
}