using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class GgorevOnculleri
{
    public int GorevOnculId { get; set; }

    public int? OncekiGorevId { get; set; }

    public int? SonrakiGorev { get; set; }

    public byte? Tur { get; set; }

    public virtual Ggorevler? OncekiGorev { get; set; }

    public virtual Ggorevler? SonrakiGorevNavigation { get; set; }

    public virtual GgorevOnculTurleri? TurNavigation { get; set; }
}
