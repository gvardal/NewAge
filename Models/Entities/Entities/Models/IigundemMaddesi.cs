using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IigundemMaddesi
{
    public int GundemMaddesiId { get; set; }

    public short? ToplantiTutanagiId { get; set; }

    public string? GundemMaddesi { get; set; }

    public int? SorumluId { get; set; }

    /// <summary>
    /// 1-Bekliyor 2-Başladı 3-Tamamlandı
    /// </summary>
    public byte? Durum { get; set; }

    public string? Sure { get; set; }

    public string? KararMetni { get; set; }

    public int? SorumluCalisanId { get; set; }

    public DateTime? SonTarih { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual Ikcalisanlar? Sorumlu { get; set; }

    public virtual Ikcalisanlar? SorumluCalisan { get; set; }

    public virtual IitoplantiTutanagi? ToplantiTutanagi { get; set; }
}
