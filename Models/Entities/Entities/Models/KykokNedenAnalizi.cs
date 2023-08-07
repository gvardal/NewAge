using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KykokNedenAnalizi
{
    public int KokNedenAnaliziId { get; set; }

    public int? Dofid { get; set; }

    public string? Kategorisi { get; set; }

    public string? OlasiNeden { get; set; }

    public string? AltNeden { get; set; }

    public byte? Oncelik { get; set; }

    /// <summary>
    /// Problemin sebebi önerildikten sonra Lider tarafından Kök Neden olarak seçilir
    /// </summary>
    public bool? KokNeden { get; set; }

    public bool? Anonim { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Kydof? Dof { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<KyriskYonetimi> KyriskYonetimis { get; set; } = new List<KyriskYonetimi>();
}
