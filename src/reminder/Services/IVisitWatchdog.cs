﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Reminder
{
    public interface IVisitWatchdog
    {
        Task CheckVisits();
    }
}
