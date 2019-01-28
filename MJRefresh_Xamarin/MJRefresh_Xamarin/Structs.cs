using System;
using ObjCRuntime;

namespace MJRefresh
{
    /** 刷新控件的状态 */
    [Native]
    public enum MJRefreshState : long
    {
        /** 普通闲置状态 */
        Idle = 1,
        /** 松开就可以进行刷新的状态 */
        Pulling,
        /** 正在刷新中的状态 */
        Refreshing,
        /** 即将刷新的状态 */
        WillRefresh,
        /** 所有数据加载完毕，没有更多的数据了 */
        NoMoreData
    }

}

