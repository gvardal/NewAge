using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkpdksizinTuru
{
    public byte BordroIzinTuruId { get; set; }

    public string? IzinTuruAdi { get; set; }

    public string? SgkizinKodu { get; set; }

    public byte? TekSeferlikMaksIzinGunu { get; set; }

    public byte? YillikIzinGunu { get; set; }

    public string? Aciklama { get; set; }

    public bool? IzinHakkindanDus { get; set; }

    public bool? Ucretli { get; set; }

    public bool? IzinHakkindanTakvimGunu { get; set; }

    public bool? SaatlikOlarakHesapla { get; set; }

    public bool? GunlukOlarakHesapla { get; set; }

    public virtual ICollection<IkpdksbordroIzin> IkpdksbordroIzins { get; set; } = new List<IkpdksbordroIzin>();
}
