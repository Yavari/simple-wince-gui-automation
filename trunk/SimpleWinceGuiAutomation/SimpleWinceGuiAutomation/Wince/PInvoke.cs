﻿using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SimpleWinceGuiAutomation.Core
{
    class PInvoke
    {
#if PocketPC
        [DllImport("coredll.dll", SetLastError = true)]
        public static extern IntPtr GetWindow(IntPtr hwnd, uint relationship);

        [DllImport("coredll.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("coredll.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        [DllImport("coredll.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetClassName(IntPtr hwnd, StringBuilder windowClass, int maxText);

        [DllImport("coredll.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("coredll.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("coredll.dll")]
        public static extern bool SetWindowText(IntPtr hwnd, string text);

        [DllImport("coredll.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("coredll.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
#else
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindow(IntPtr hwnd, uint relationship);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern bool SetWindowText(IntPtr hwnd, string text);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
#endif

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        public const int GWL_STYLE = (-16);

        public static int WM_LBUTTONDOWN = 0x0201;
        public static int WM_LBUTTONUP = 0x0202;
        public static int BM_GETCHECK = 0x00F0;
        public static int BM_SETCHECK = 0x00F1;
        public static int WM_SETTEXT = 0x000C;

        [Flags]
        public enum GetWindowFlags
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
        }




        [DllImport("coredll.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, StringBuilder lParam);
        [DllImport("coredll.dll", CharSet = CharSet.Auto, SetLastError =
false, EntryPoint = "SendMessage")]
        public static extern IntPtr SendRefMessage(IntPtr hWnd, uint Msg, int
        wParam, StringBuilder lParam);

        [DllImport("coredll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, byte[] lParam);
    }
}
