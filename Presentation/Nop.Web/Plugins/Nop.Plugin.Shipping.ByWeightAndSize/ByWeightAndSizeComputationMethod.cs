using System;
using System.Collections.Generic;
using Nop.Core;
using Nop.Core.Domain.Shipping;
using Nop.Services.Common;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Plugins;
using Nop.Services.Shipping;
using Nop.Services.Shipping.Tracking;

namespace Nop.Plugin.Shipping.ByWeightAndSize
{
    public class ByWeightAndSizeComputationMethod : BasePlugin, IShippingRateComputationMethod
    {
        public ShippingRateComputationMethodType ShippingRateComputationMethodType => throw new NotImplementedException();

        public IShipmentTracker ShipmentTracker => throw new NotImplementedException();

        public decimal? GetFixedRate(GetShippingOptionRequest getShippingOptionRequest)
        {
            throw new NotImplementedException();
        }

        public GetShippingOptionResponse GetShippingOptions(GetShippingOptionRequest getShippingOptionRequest)
        {
            throw new NotImplementedException();
        }
    }
}
