﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public interface IMvxDataContextChanged
    {
        event EventHandler DataContextChanged;
    }
}
