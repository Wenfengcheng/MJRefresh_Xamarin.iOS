using System;
using ObjCRuntime;

namespace MJRefresh
{
    [Native]
    public enum MJRefreshState : long
    {
        Idle = 1,
        Pulling,
        Refreshing,
        WillRefresh,
        NoMoreData
    }

}

