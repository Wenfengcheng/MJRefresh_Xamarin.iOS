using System;
using ObjCRuntime;

public enum MJRefreshState : int
{
    Idle = 1,
    Pulling,
    Refreshing,
    WillRefresh,
    NoMoreData
}