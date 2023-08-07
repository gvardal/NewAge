using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikpysperforman
{
    public int PerformansId { get; set; }

    public int? CalisanId { get; set; }

    public short? DonemId { get; set; }

    public byte? DurumId { get; set; }

    public byte? SoruGrubuId { get; set; }

    public bool? Hedef { get; set; }

    public bool? Kendisi { get; set; }

    public bool? Ustu { get; set; }

    public bool? Asti { get; set; }

    public bool? Esdegeri { get; set; }

    public DateTime? DegerlendirmeTarihi { get; set; }

    public int? DegerlendirenId { get; set; }

    public byte? KurumPerformansPuani { get; set; }

    public byte? BirimPerformansPuani { get; set; }

    public byte? IsBasarmaPuani { get; set; }

    public byte? SorumlulukPuani { get; set; }

    public byte? YoneticiGorusu { get; set; }

    public byte? DisiplinPuani { get; set; }

    public byte? ToplamPuan { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Ikcalisanlar? Degerlendiren { get; set; }

    public virtual Ikpysdonemler? Donem { get; set; }

    public virtual PIkpysperformansDurum? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<IkpysperformansDegerlendirme> IkpysperformansDegerlendirmes { get; set; } = new List<IkpysperformansDegerlendirme>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual PIkpyssoruGrubu? SoruGrubu { get; set; }
}
