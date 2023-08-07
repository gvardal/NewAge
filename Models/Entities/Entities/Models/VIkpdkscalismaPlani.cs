using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VIkpdkscalismaPlani
{
    public byte CalismaGrubuId { get; set; }

    public DateTime Tarih { get; set; }

    public byte? VardiyaId { get; set; }

    public DateTime GunDonumSaati { get; set; }

    public DateTime? IseGirisSaati { get; set; }

    public DateTime? IstenCikisSaati { get; set; }

    public DateTime? ErkenGelmeToleransSaati { get; set; }
}
