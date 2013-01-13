﻿using System;

namespace SimpleWinceGuiAutomation.Components
{
    public abstract class WinceComponent
    {
        protected IntPtr Handle { get; private set; }

        protected WinceComponent(IntPtr handle)
        {
            Handle = handle;
        }


        public WindowHelper.Size Size
        {
            get
            {
                return WindowHelper.GetSize(Handle);
            }
        }

        public WindowHelper.Location Location
        {
            get
            {
                return WindowHelper.GetLocation(Handle);
            }
        }
    }
}
