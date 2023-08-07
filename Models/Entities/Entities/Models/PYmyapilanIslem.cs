using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PYmyapilanIslem
{
    public byte YapilanIslemId { get; set; }

    public string? YapilanIslem { get; set; }

    public virtual ICollection<YmmusteriBakimPlaniCanli> YmmusteriBakimPlaniCanlis { get; set; } = new List<YmmusteriBakimPlaniCanli>();

    public virtual ICollection<YmmusteriBakimPlaniLotNo> YmmusteriBakimPlaniLotNos { get; set; } = new List<YmmusteriBakimPlaniLotNo>();

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
