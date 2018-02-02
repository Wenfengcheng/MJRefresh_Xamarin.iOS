using System;
using ObjCRuntime;

namespace MJRefresh{
    
    public enum MJRefreshState : long
    {
        Idle = 1,
        Pulling,
        Refreshing,
        WillRefresh,
        NoMoreData
    }

}

