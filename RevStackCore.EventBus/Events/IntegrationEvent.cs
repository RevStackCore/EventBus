﻿using System;

namespace RevStackCore.EventBus
{
    public class IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public Guid Id  { get; }
        public DateTime CreationDate { get; }
    }
}
