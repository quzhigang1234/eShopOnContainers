﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events.IntegrationEventLog
{
    public enum EventStateEnum
    {
        NotPublished = 0,
        Published = 1,
        PublishedFailed = 2
    }
}