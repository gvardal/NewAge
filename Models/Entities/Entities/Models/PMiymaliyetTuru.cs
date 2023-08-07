using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PMiymaliyetTuru
{
    public short MaliyetTuruId { get; set; }

    public string? Aciklama { get; set; }

    /// <summary>
    /// Proje Yönetimi İçindeki Maliyet Merkezlerini temsil eder.  
    /// Personel Maliyeti 1 - 
    /// Seyahat Maliyeti 2 - 
    /// Donanım Maliyeti 3 - 
    /// Hizmet Alım Maliyeti 4 - 
    /// Malzeme Maliyeti 5 - 
    /// Diğer Maliyetler 6 yı Temsil eder.
    /// </summary>
    public byte? ProjeMaliyetMerkezi { get; set; }
}
