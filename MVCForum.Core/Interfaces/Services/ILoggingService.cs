﻿namespace MvcForum.Core.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using DomainModel.General;

    public partial interface ILoggingService
    {
        void Error(string message);
        void Error(Exception ex);
        void Initialise(int maxLogSize);
        IList<LogEntry> ListLogFile();
        void Recycle();
        void ClearLogFiles();
    }
}