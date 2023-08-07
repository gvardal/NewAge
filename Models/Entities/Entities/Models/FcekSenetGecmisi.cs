using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FcekSenetGecmisi
{
    public int CekSenetGecmisiId { get; set; }

    public int CekSenetId { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal? KurOrani { get; set; }

    public byte? DurumId { get; set; }

    public byte? YerId { get; set; }

    public byte? OncekiDurumId { get; set; }

    public byte? OncekiYerId { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public int? YevmiyeDefteriId { get; set; }

    public int? TahsilatOdemeId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public virtual FcekSenet CekSenet { get; set; } = null!;

    public virtual PFcekSenetDurum? Durum { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FyyevmiyeDefteri> FyyevmiyeDefteris { get; set; } = new List<FyyevmiyeDefteri>();

    public virtual PFcekSenetDurum? OncekiDurum { get; set; }

    public virtual PFcekSenetYeri? OncekiYer { get; set; }

    public virtual FytahsilatOdeme? TahsilatOdeme { get; set; }

    public virtual PFcekSenetYeri? Yer { get; set; }
}
