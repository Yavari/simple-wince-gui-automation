﻿using System;
using System.Text;
using SimpleWinceGuiAutomation.Core;

namespace SimpleWinceGuiAutomation
{
    static class WindowHelper
    {
        public static String GetText(IntPtr handle)
        {
            int length = PInvoke.GetWindowTextLength(handle);
            var sb = new StringBuilder(length + 1);
            PInvoke.GetWindowText(handle, sb, sb.Capacity);
            return sb.ToString();
        }

        public static void SetText(IntPtr handle, string value)
        {
            PInvoke.SetWindowText(handle, value);
        }

        public static void Click(IntPtr handle)
        {
            PInvoke.SendMessage(handle, PInvoke.WM_LBUTTONDOWN, (IntPtr)0x1, (IntPtr)0);
            PInvoke.SendMessage(handle, PInvoke.WM_LBUTTONUP, (IntPtr)0x1, (IntPtr)0);
        }
    }
}