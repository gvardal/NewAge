using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikpdkscihazlar
{
    public short PdkscihazId { get; set; }

    public string? CihazKonumu { get; set; }

    public string? Ipadresi { get; set; }

    public string? Model { get; set; }

    public string? Sifre { get; set; }

    public string? MakinaNo { get; set; }

    public string? Port { get; set; }
}
