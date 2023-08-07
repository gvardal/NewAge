using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmproblemCozumuTakibiYorumlar
{
    public int Id { get; set; }

    public int? ProblemCozumTakibiId { get; set; }

    public int? KullanıcıId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Ikcalisanlar? Kullanıcı { get; set; }

    public virtual YmproblemCozumuTakibi? ProblemCozumTakibi { get; set; }
}
