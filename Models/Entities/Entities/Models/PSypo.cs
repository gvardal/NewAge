using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PSypo
{
    public int PosId { get; set; }

    public string? PosAdi { get; set; }

    public string? Apihost { get; set; }

    public string? Webhost { get; set; }

    public string? Pphost { get; set; }

    public string? MerchantId { get; set; }

    public string? TerminalId { get; set; }

    public string? PosnetId { get; set; }

    public string? KulaniciAdi { get; set; }

    public string? Sifre { get; set; }

    public bool? Use3Dsecure { get; set; }

    public string? Use3Dkey { get; set; }

    public string? MdStatus { get; set; }

    public decimal? MinimumTaksitTutari { get; set; }

    public bool? YetkilendirmeTuru { get; set; }

    public bool? VarsayilanPos { get; set; }

    public bool? Aktif { get; set; }

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemes { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<PSyposTaksitleri> PSyposTaksitleris { get; set; } = new List<PSyposTaksitleri>();

    public virtual ICollection<PSysavadeDetayi> PSysavadeDetayis { get; set; } = new List<PSysavadeDetayi>();
}
