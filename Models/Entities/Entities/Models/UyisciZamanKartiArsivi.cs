﻿using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyisciZamanKartiArsivi
{
    public long IsciZamanKartiId { get; set; }

    public int? CalisanId { get; set; }

    public int? IsEmriRotasiId { get; set; }

    public bool? Hazirlik { get; set; }

    public bool? UretimDurus { get; set; }

    public byte? DurusTuruId { get; set; }

    public DateTime? BaslamaSaati { get; set; }

    public DateTime? BitisSaati { get; set; }

    public decimal? CalisilanZaman { get; set; }

    public bool? Tamamlandi { get; set; }

    public decimal? SaatlikUcreti { get; set; }

    public decimal? ToplamUcret { get; set; }

    public string? Aciklama { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual UydurusTuru? DurusTuru { get; set; }

    public virtual UyisEmriRotasiArsivi? IsEmriRotasi { get; set; }
}
