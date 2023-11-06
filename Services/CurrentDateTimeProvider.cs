﻿using Lab3App.Contracts;

namespace Lab3App.Services;

public class CurrentDateTimeProvider : IDateTimeProvider
{
    public DateTime GetDate()
    {
        return DateTime.Now;
    }
}
