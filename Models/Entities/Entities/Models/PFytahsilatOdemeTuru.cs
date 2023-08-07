using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFytahsilatOdemeTuru
{
    public byte TahsilatOdemeTuruId { get; set; }

    public string? Aciklama { get; set; }

    public string? Unedifact4461 { get; set; }

    public bool? B2b { get; set; }

    public bool? B2c { get; set; }

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemeGerceklesenTahsilatOdemeTurus { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<FytahsilatOdeme> FytahsilatOdemePlanlananTahsilatOdemeTurus { get; set; } = new List<FytahsilatOdeme>();

    public virtual ICollection<PSavadeler> PSavadelers { get; set; } = new List<PSavadeler>();

    public virtual ICollection<PSysavadeDetayi> PSysavadeDetayis { get; set; } = new List<PSysavadeDetayi>();

    public virtual ICollection<PSyvadeler> PSyvadelers { get; set; } = new List<PSyvadeler>();
}
