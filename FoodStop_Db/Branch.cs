using System;
using System.Collections.Generic;

namespace FoodStop_Db;

public partial class Branch
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public long PhoneNo { get; set; }
}
