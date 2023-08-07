using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkcalisanYetenekleri
{
    public short OzelYetenekId { get; set; }

    public int CalisanId { get; set; }

    public string? Degerlendirme { get; set; }

    public string? Aciklama { get; set; }

    public byte? Seviye { get; set; }

    public virtual Ikcalisanlar Calisan { get; set; } = null!;

    public virtual PIkozelYetenekler OzelYetenek { get; set; } = null!;
}
