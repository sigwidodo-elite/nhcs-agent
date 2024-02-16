using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class OdMsMSubDistrict
{
    public string SubDistrictId { get; set; } = null!;

    public string? SubDistrictName { get; set; }

    public string? PostCode { get; set; }
}
