using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KyolgunlukSeviyesi
{
    public int OlgunlukSeviyesiId { get; set; }

    public int? CalisanId { get; set; }

    public decimal? IsgriskBildirimleriPuani { get; set; }

    public decimal? IsgolgunlukSeviyesiPuani { get; set; }

    public decimal? IsgguvenliDavranisPuani { get; set; }

    public decimal? Isglmrapuani { get; set; }

    public decimal? IsgisSagligiveGuvenligiPuani { get; set; }

    public decimal? CibolumHedeflerineUyumPuani { get; set; }

    public decimal? CiprojelerPuani { get; set; }

    public decimal? CikademeliDenetimPuani { get; set; }

    public decimal? Ci5spuani { get; set; }

    public decimal? CioneriveKokNedenPuani { get; set; }

    public decimal? CisurekliIyilestirmePuani { get; set; }

    public decimal? PrprosesSinavPuani { get; set; }

    public decimal? PryoneticiDegerlendirmePuani { get; set; }

    public decimal? PrprosesPuani { get; set; }

    public decimal? IkdisiplinPuani { get; set; }

    public decimal? IkdevamlilikPuani { get; set; }

    public decimal? IkinsanKaynaklariPuani { get; set; }

    public decimal? GenelOlgunlukPuani { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }
}
