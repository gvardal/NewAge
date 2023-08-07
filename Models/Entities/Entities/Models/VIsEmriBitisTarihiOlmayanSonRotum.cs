using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VIsEmriBitisTarihiOlmayanSonRotum
{
    public int IsEmriRotaId { get; set; }

    public long IsEmriId { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }
}
