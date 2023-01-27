namespace Mookie.WPF
{
    // ReSharper disable UnusedMember.Global
    // ReSharper disable InconsistentNaming
    public enum WM
    {

        /// <summary>
        /// 
        /// </summary>
        NULL,

        /// <summary>
        /// 
        /// </summary>
        CREATE,
        /// <summary>
        /// 
        /// </summary>
        DESTROY,

        /// <summary>
        /// 
        /// </summary>
        MOVE,

        /// <summary>
        /// 
        /// </summary>
        SIZE = 5,

        /// <summary>
        /// 
        /// </summary>
        ACTIVATE,

        /// <summary>
        /// 
        /// </summary>
        SETFOCUS,

        /// <summary>
        /// 
        /// </summary>
        KILLFOCUS,

        /// <summary>
        /// 
        /// </summary>
        ENABLE = 10,

        /// <summary>
        /// 
        /// </summary>
        SETREDRAW,

        /// <summary>
        /// 
        /// </summary>
        SETTEXT,

        /// <summary>
        /// 
        /// </summary>
        GETTEXT,

        /// <summary>
        /// 
        /// </summary>
        GETTEXTLENGTH,

        /// <summary>
        /// 
        /// </summary>
        PAINT,

        /// <summary>
        /// 
        /// </summary>
        CLOSE,

        /// <summary>
        /// 
        /// </summary>
        QUERYENDSESSIO,

        /// <summary>
        /// 
        /// </summary>N,
        QUIT,

        /// <summary>
        /// 
        /// </summary>
        QUERYOPEN,

        /// <summary>
        /// 
        /// </summary>
        ERASEBKGND,

        /// <summary>
        /// 
        /// </summary>
        SYSCOLORCHANGE,

        /// <summary>
        /// 
        /// </summary>
        SHOWWINDOW = 24,

        /// <summary>
        /// 
        /// </summary>
        ACTIVATEAPP = 28,

        /// <summary>
        /// 
        /// </summary>
        SETCURSOR = 32,

        /// <summary>
        /// 
        /// </summary>
        MOUSEACTIVATE,

        /// <summary>
        /// 
        /// </summary>
        CHILDACTIVATE,

        /// <summary>
        /// 
        /// </summary>
        QUEUESYNC,

        /// <summary>
        /// 
        /// </summary>
        GETMINMAXINFO,

        /// <summary>
        /// 
        /// </summary>
        WINDOWPOSCHANGING = 70,

        /// <summary>
        /// 
        /// </summary>
        WINDOWPOSCHANGED,

        /// <summary>
        /// 
        /// </summary>
        CONTEXTMENU = 123,

        /// <summary>
        /// 
        /// </summary>
        STYLECHANGING,

        /// <summary>
        /// 
        /// </summary>
        STYLECHANGED,

        /// <summary>
        /// 
        /// </summary>
        DISPLAYCHANGE,

        /// <summary>
        /// 
        /// </summary>
        GETICON,

        /// <summary>
        /// 
        /// </summary>
        SETICON,

        /// <summary>
        /// 
        /// </summary>
        NCCREATE,

        /// <summary>
        /// 
        /// </summary>
        NCDESTROY,

        /// <summary>
        /// 
        /// </summary>
        NCCALCSIZE,
        /// <summary>
        /// 
        /// </summary>
        NCHITTEST,
        /// <summary>
        /// 
        /// </summary>
        NCPAINT,
        /// <summary>
        /// 
        /// </summary>
        NCACTIVATE,

        /// <summary>
        /// 
        /// </summary>
        GETDLGCODE,

        /// <summary>
        /// 
        /// </summary>
        SYNCPAINT,

        /// <summary>
        /// 
        /// </summary>
        NCMOUSEMOVE = 160,

        /// <summary>
        /// 
        /// </summary>
        NCLBUTTONDOWN,

        /// <summary>
        /// 
        /// </summary>
        NCLBUTTONUP,

        /// <summary>
        /// 
        /// </summary>
        NCLBUTTONDBLCLK,

        /// <summary>
        /// 
        /// </summary>
        NCRBUTTONDOWN,

        /// <summary>
        /// 
        /// </summary>
        NCRBUTTONUP,

        /// <summary>
        /// 
        /// </summary>
        NCRBUTTONDBLCLK,

        /// <summary>
        /// 
        /// </summary>
        NCMBUTTONDOWN,

        /// <summary>
        /// 
        /// </summary>
        NCMBUTTONUP,

        /// <summary>
        /// 
        /// </summary>
        NCMBUTTONDBLCLK,

        /// <summary>
        /// 
        /// </summary>
        SYSKEYDOWN = 260,

        /// <summary>
        /// 
        /// </summary>
        SYSKEYUP,

        /// <summary>
        /// 
        /// </summary>
        SYSCHAR,

        /// <summary>
        /// 
        /// </summary>
        SYSDEADCHAR,

        /// <summary>
        /// 
        /// </summary>
        COMMAND = 273,

        /// <summary>
        /// 
        /// </summary>
        SYSCOMMAND,

        /// <summary>
        /// 
        /// </summary>
        MOUSEMOVE = 512,

        /// <summary>
        /// 
        /// </summary>
        LBUTTONDOWN,

        /// <summary>
        /// 
        /// </summary>
        LBUTTONUP,

        /// <summary>
        /// 
        /// </summary>
        LBUTTONDBLCLK,

        /// <summary>
        /// 
        /// </summary>
        RBUTTONDOWN,

        /// <summary>
        /// 
        /// </summary>
        RBUTTONUP,

        /// <summary>
        /// 
        /// </summary>
        RBUTTONDBLCLK,

        /// <summary>
        /// 
        /// </summary>
        MBUTTONDOWN,

        /// <summary>
        /// 
        /// </summary>
        MBUTTONUP,

        /// <summary>
        /// 
        /// </summary>
        MBUTTONDBLCLK,

        /// <summary>
        /// 
        /// </summary>
        MOUSEWHEEL,

        /// <summary>
        /// 
        /// </summary>
        XBUTTONDOWN,

        /// <summary>
        /// 
        /// </summary>
        XBUTTONUP,

        /// <summary>
        /// 
        /// </summary>
        XBUTTONDBLCLK,

        /// <summary>
        /// 
        /// </summary>
        MOUSEHWHEEL,

        /// <summary>
        /// 
        /// </summary>
        CAPTURECHANGED = 533,

        /// <summary>
        /// 
        /// </summary>
        ENTERSIZEMOVE = 561,

        /// <summary>
        /// 
        /// </summary>
        EXITSIZEMOVE,

        /// <summary>
        /// 
        /// </summary>
        IME_SETCONTEXT = 641,

        /// <summary>
        /// 
        /// </summary>
        IME_NOTIFY,

        /// <summary>
        /// 
        /// </summary>
        IME_CONTROL,

        /// <summary>
        /// 
        /// </summary>
        IME_COMPOSITIONFULL,

        /// <summary>
        /// 
        /// </summary>
        IME_SELECT,

        /// <summary>
        /// 
        /// </summary>
        IME_CHAR,

        /// <summary>
        /// 
        /// </summary>
        IME_REQUEST = 648,

        /// <summary>
        /// 
        /// </summary>
        IME_KEYDOWN = 656,

        /// <summary>
        /// 
        /// </summary>
        IME_KEYUP,

        /// <summary>
        /// 
        /// </summary>
        NCMOUSELEAVE = 674,

        /// <summary>
        /// 
        /// </summary>
        DWMCOMPOSITIONCHANGED = 798,

        /// <summary>
        /// 
        /// </summary>
        DWMNCRENDERINGCHANGED,

        /// <summary>
        /// 
        /// </summary>
        DWMCOLORIZATIONCOLORCHANGED,

        /// <summary>
        /// 
        /// </summary>
        DWMWINDOWMAXIMIZEDCHANGE,

        /// <summary>
        /// 
        /// </summary>
        DWMSENDICONICTHUMBNAIL = 803,

        /// <summary>
        /// 
        /// </summary>
        DWMSENDICONICLIVEPREVIEWBITMAP = 806,

        /// <summary>
        /// 
        /// </summary>
        USER = 1024,

        /// <summary>
        /// 
        /// </summary>
        TRAYMOUSEMESSAGE = 2048,
        /// <summary>
        /// 
        /// </summary>
        APP = 32768
    }
}
