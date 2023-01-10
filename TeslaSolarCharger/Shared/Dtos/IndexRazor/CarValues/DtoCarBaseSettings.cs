﻿using TeslaSolarCharger.Shared.Enums;

namespace TeslaSolarCharger.Shared.Dtos.IndexRazor.CarValues;

public class DtoCarBaseSettings
{
    public int CarId { get; set; }
    public ChargeMode ChargeMode { get; set; }
    public int MinimumStateOfCharge { get; set; }
    public DateTime LatestTimeToReachStateOfCharge { get; set; }
}
