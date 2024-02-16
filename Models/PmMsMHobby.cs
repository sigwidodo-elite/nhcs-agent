using System;
using System.Collections.Generic;

namespace nhcs_agent.Models;

public partial class PmMsMHobby : BaseEntity
{
    public int HobbyId { get; set; }

    public string? HobbyCode { get; set; }

    public string? HobbyName { get; set; }

    public char? IsActive { get; set; }

    public DateTime? OnChangeDate { get; set; }
}
