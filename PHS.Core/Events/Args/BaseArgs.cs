﻿using System;

namespace PHS.Core.Events.Args
{
    public abstract class BaseArgs
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public T GetType<T>() where T : BaseArgs
        {
            return this as T;
        }
    }
}
