using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkoryantasyonTakip
{
    public int OryantasyonId { get; set; }

    public int? CalisanId { get; set; }

    public long? BasvurulanPozisyon { get; set; }

    public DateTime? OryantasyonTarihi { get; set; }

    public int? OryantasyonuYapanId { get; set; }

    public bool? IsSagligiveGuvenligi2 { get; set; }

    public int? IsgdegerlendirenId2 { get; set; }

    public bool? Enerji2 { get; set; }

    public int? EnerjiDegerlendirenId2 { get; set; }

    public bool? Cevre2 { get; set; }

    public int? CevreDegerlendirenId2 { get; set; }

    public bool? Kalite2 { get; set; }

    public int? KaliteDegerlendirenId2 { get; set; }

    public bool? SurekliIyilestirme2 { get; set; }

    public int? SidegerlendirenId2 { get; set; }

    public bool? Surec2 { get; set; }

    public int? SurecDegerlendirenId2 { get; set; }

    public bool? IsSagligiveGuvenligi5 { get; set; }

    public int? IsgdegerlendirenId5 { get; set; }

    public bool? Enerji5 { get; set; }

    public int? EnerjiDegerlendirenId5 { get; set; }

    public bool? Cevre5 { get; set; }

    public int? CevreDegerlendirenId5 { get; set; }

    public bool? Kalite5 { get; set; }

    public int? KaliteDegerlendirenId5 { get; set; }

    public bool? SurekliIyilestirme5 { get; set; }

    public int? SidegerlendirenId5 { get; set; }

    public bool? Surec5 { get; set; }

    public int? SurecDegerlendirenId5 { get; set; }

    public virtual IkacikPozisyonlar? BasvurulanPozisyonNavigation { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Ikcalisanlar? CevreDegerlendirenId2Navigation { get; set; }

    public virtual Ikcalisanlar? CevreDegerlendirenId5Navigation { get; set; }

    public virtual Ikcalisanlar? EnerjiDegerlendirenId2Navigation { get; set; }

    public virtual Ikcalisanlar? EnerjiDegerlendirenId5Navigation { get; set; }

    public virtual Ikcalisanlar? IsgdegerlendirenId2Navigation { get; set; }

    public virtual Ikcalisanlar? IsgdegerlendirenId5Navigation { get; set; }

    public virtual Ikcalisanlar? KaliteDegerlendirenId2Navigation { get; set; }

    public virtual Ikcalisanlar? KaliteDegerlendirenId5Navigation { get; set; }

    public virtual Ikcalisanlar? OryantasyonuYapan { get; set; }

    public virtual Ikcalisanlar? SidegerlendirenId2Navigation { get; set; }

    public virtual Ikcalisanlar? SidegerlendirenId5Navigation { get; set; }

    public virtual Ikcalisanlar? SurecDegerlendirenId2Navigation { get; set; }

    public virtual Ikcalisanlar? SurecDegerlendirenId5Navigation { get; set; }
}
