using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyaksiyonHavuzuDokumanlari
{
    public long AksiyonHavuzuDokumanId { get; set; }

    public short? DokumanId { get; set; }

    public int? AksiyonHavuzuId { get; set; }

    public string? Aciklama { get; set; }

    public virtual PyprojeAdimlariHavuzu? AksiyonHavuzu { get; set; }
}
