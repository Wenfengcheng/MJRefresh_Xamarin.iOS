using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MJRefresh
{
    [Static]
    partial interface MJRefreshConstants
    {
        // extern const CGFloat MJRefreshLabelLeftInset __attribute__((visibility("default")));
        [Field("MJRefreshLabelLeftInset", "__Internal")]
        nfloat LabelLeftInset { get; }

        // extern const CGFloat MJRefreshHeaderHeight __attribute__((visibility("default")));
        [Field("MJRefreshHeaderHeight", "__Internal")]
        nfloat HeaderHeight { get; }

        // extern const CGFloat MJRefreshFooterHeight __attribute__((visibility("default")));
        [Field("MJRefreshFooterHeight", "__Internal")]
        nfloat FooterHeight { get; }

        // extern const CGFloat MJRefreshFastAnimationDuration __attribute__((visibility("default")));
        [Field("MJRefreshFastAnimationDuration", "__Internal")]
        nfloat FastAnimationDuration { get; }

        // extern const CGFloat MJRefreshSlowAnimationDuration __attribute__((visibility("default")));
        [Field("MJRefreshSlowAnimationDuration", "__Internal")]
        nfloat SlowAnimationDuration { get; }

        // extern NSString *const MJRefreshKeyPathContentOffset __attribute__((visibility("default")));
        [Field("MJRefreshKeyPathContentOffset", "__Internal")]
        NSString KeyPathContentOffset { get; }

        // extern NSString *const MJRefreshKeyPathContentSize __attribute__((visibility("default")));
        [Field("MJRefreshKeyPathContentSize", "__Internal")]
        NSString KeyPathContentSize { get; }

        // extern NSString *const MJRefreshKeyPathContentInset __attribute__((visibility("default")));
        [Field("MJRefreshKeyPathContentInset", "__Internal")]
        NSString KeyPathContentInset { get; }

        // extern NSString *const MJRefreshKeyPathPanState __attribute__((visibility("default")));
        [Field("MJRefreshKeyPathPanState", "__Internal")]
        NSString KeyPathPanState { get; }

        // extern NSString *const MJRefreshHeaderLastUpdatedTimeKey __attribute__((visibility("default")));
        [Field("MJRefreshHeaderLastUpdatedTimeKey", "__Internal")]
        NSString HeaderLastUpdatedTimeKey { get; }

        // extern NSString *const MJRefreshHeaderIdleText __attribute__((visibility("default")));
        [Field("MJRefreshHeaderIdleText", "__Internal")]
        NSString HeaderIdleText { get; }

        // extern NSString *const MJRefreshHeaderPullingText __attribute__((visibility("default")));
        [Field("MJRefreshHeaderPullingText", "__Internal")]
        NSString HeaderPullingText { get; }

        // extern NSString *const MJRefreshHeaderRefreshingText __attribute__((visibility("default")));
        [Field("MJRefreshHeaderRefreshingText", "__Internal")]
        NSString HeaderRefreshingText { get; }

        // extern NSString *const MJRefreshAutoFooterIdleText __attribute__((visibility("default")));
        [Field("MJRefreshAutoFooterIdleText", "__Internal")]
        NSString AutoFooterIdleText { get; }

        // extern NSString *const MJRefreshAutoFooterRefreshingText __attribute__((visibility("default")));
        [Field("MJRefreshAutoFooterRefreshingText", "__Internal")]
        NSString AutoFooterRefreshingText { get; }

        // extern NSString *const MJRefreshAutoFooterNoMoreDataText __attribute__((visibility("default")));
        [Field("MJRefreshAutoFooterNoMoreDataText", "__Internal")]
        NSString AutoFooterNoMoreDataText { get; }

        // extern NSString *const MJRefreshBackFooterIdleText __attribute__((visibility("default")));
        [Field("MJRefreshBackFooterIdleText", "__Internal")]
        NSString BackFooterIdleText { get; }

        // extern NSString *const MJRefreshBackFooterPullingText __attribute__((visibility("default")));
        [Field("MJRefreshBackFooterPullingText", "__Internal")]
        NSString BackFooterPullingText { get; }

        // extern NSString *const MJRefreshBackFooterRefreshingText __attribute__((visibility("default")));
        [Field("MJRefreshBackFooterRefreshingText", "__Internal")]
        NSString BackFooterRefreshingText { get; }

        // extern NSString *const MJRefreshBackFooterNoMoreDataText __attribute__((visibility("default")));
        [Field("MJRefreshBackFooterNoMoreDataText", "__Internal")]
        NSString BackFooterNoMoreDataText { get; }

        // extern NSString *const MJRefreshHeaderLastTimeText __attribute__((visibility("default")));
        [Field("MJRefreshHeaderLastTimeText", "__Internal")]
        NSString HeaderLastTimeText { get; }

        // extern NSString *const MJRefreshHeaderDateTodayText __attribute__((visibility("default")));
        [Field("MJRefreshHeaderDateTodayText", "__Internal")]
        NSString HeaderDateTodayText { get; }

        // extern NSString *const MJRefreshHeaderNoneLastDateText __attribute__((visibility("default")));
        [Field("MJRefreshHeaderNoneLastDateText", "__Internal")]
        NSString HeaderNoneLastDateText { get; }
    }

    // @interface MJRefresh (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_MJRefresh
    {
        // @property (nonatomic, strong) MJRefreshHeader * mj_header;
        [Export("mj_header", ArgumentSemantic.Strong)]
        MJRefreshHeader Mj_header();

        // @property (nonatomic, strong) MJRefreshHeader * mj_header;
        [Export("setMj_header:", ArgumentSemantic.Strong)]
        void SetMj_header(MJRefreshHeader header);

        // @property (nonatomic, strong) MJRefreshHeader * header __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        //[Introduced(PlatformName.iOS, 2, 0, message: "使用mj_header")]
        //[Deprecated(PlatformName.iOS, 2, 0, message: "使用mj_header")]
        //[Export("header", ArgumentSemantic.Strong)]
        //MJRefreshHeader Header();

        // @property (nonatomic, strong) MJRefreshHeader * header __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        //[Introduced(PlatformName.iOS, 2, 0, message: "使用mj_header")]
        //[Deprecated(PlatformName.iOS, 2, 0, message: "使用mj_header")]
        //[Export("setHeader:", ArgumentSemantic.Strong)]
        //void SetHeader(MJRefreshHeader header);

        // @property (nonatomic, strong) MJRefreshFooter * mj_footer;
        [Export("mj_footer", ArgumentSemantic.Strong)]
        MJRefreshFooter Mj_footer();

        // @property (nonatomic, strong) MJRefreshFooter * mj_footer;
        [Export("setMj_footer:", ArgumentSemantic.Strong)]
        void SetMj_footer(MJRefreshFooter footer);

        // @property (nonatomic, strong) MJRefreshFooter * footer __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        //[Introduced(PlatformName.iOS, 2, 0, message: "使用mj_footer")]
        //[Deprecated(PlatformName.iOS, 2, 0, message: "使用mj_footer")]
        //[Export("footer", ArgumentSemantic.Strong)]
        //MJRefreshFooter Footer();

        // @property (nonatomic, strong) MJRefreshFooter * footer __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        //[Introduced(PlatformName.iOS, 2, 0, message: "使用setMj_footer")]
        //[Deprecated(PlatformName.iOS, 2, 0, message: "使用setMj_footer")]
        //[Export("setFooter:", ArgumentSemantic.Strong)]
        //void SetFooter(MJRefreshFooter footer);

        // -(NSInteger)mj_totalDataCount;
        [Export("mj_totalDataCount")]
        nint Mj_totalDataCount();

        // @property (copy, nonatomic) void (^mj_reloadDataBlock)(NSInteger);
        [Export("mj_reloadDataBlock", ArgumentSemantic.Copy)]
        Action<nint> Mj_reloadDataBlock();

        // @property (copy, nonatomic) void (^mj_reloadDataBlock)(NSInteger);
        [Export("setMj_reloadDataBlock:", ArgumentSemantic.Copy)]
        void Mj_reloadDataBlock(Action<nint> block);
    }

    // @interface MJRefresh (NSBundle)
    [Category]
    [BaseType(typeof(NSBundle))]
    interface NSBundle_MJRefresh
    {
        // +(instancetype)mj_refreshBundle;
        [Static]
        [Export("mj_refreshBundle")]
        NSBundle Mj_refreshBundle();

        // +(UIImage *)mj_arrowImage;
        [Static]
        [Export("mj_arrowImage")]
        UIImage Mj_arrowImage { get; }

        // +(NSString *)mj_localizedStringForKey:(NSString *)key value:(NSString *)value;
        [Static]
        [Export("mj_localizedStringForKey:value:")]
        string Mj_localizedStringForKey(string key, string value);

        // +(NSString *)mj_localizedStringForKey:(NSString *)key;
        [Static]
        [Export("mj_localizedStringForKey:")]
        string Mj_localizedStringForKey(string key);
    }

    /// <summary>
    /// 进入刷新状态的回调
    /// </summary>
    // typedef void (^MJRefreshComponentRefreshingBlock)();
    delegate void MJRefreshComponentRefreshingBlock();

    /// <summary>
    /// 开始刷新后的回调(进入刷新状态后的回调)
    /// </summary>
    // typedef void (^MJRefreshComponentbeginRefreshingCompletionBlock)();
    delegate void MJRefreshComponentbeginRefreshingCompletionBlock();

    /// <summary>
    /// 结束刷新后的回调
    /// </summary>
    // typedef void (^MJRefreshComponentEndRefreshingCompletionBlock)();
    delegate void MJRefreshComponentEndRefreshingCompletionBlock();

    /// <summary>
    /// 刷新控件的基类
    /// </summary>
    // @interface MJRefreshComponent : UIView
    [BaseType(typeof(UIView))]
    interface MJRefreshComponent
    {
        /** 正在刷新的回调 */
        // @property (copy, nonatomic) MJRefreshComponentRefreshingBlock refreshingBlock;
        [Export("refreshingBlock", ArgumentSemantic.Copy)]
        MJRefreshComponentRefreshingBlock RefreshingBlock { get; set; }

        /** 设置回调对象和回调方法 */
        // -(void)setRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Export("setRefreshingTarget:refreshingAction:")]
        void SetRefreshingTarget(NSObject target, Selector action);

        /** 回调对象 */
        // @property (nonatomic, weak) id refreshingTarget;
        [Export("refreshingTarget", ArgumentSemantic.Weak)]
        NSObject RefreshingTarget { get; set; }

        /** 回调方法 */
        // @property (assign, nonatomic) SEL refreshingAction;
        [Export("refreshingAction", ArgumentSemantic.Assign)]
        Selector RefreshingAction { get; set; }

        /** 触发回调（交给子类去调用） */
        // -(void)executeRefreshingCallback;
        [Export("executeRefreshingCallback")]
        void ExecuteRefreshingCallback();

        /** 进入刷新状态 */
        // -(void)beginRefreshing;
        [Export("beginRefreshing")]
        void BeginRefreshing();

        /** 进入刷新状态 */
        // -(void)beginRefreshingWithCompletionBlock:(void (^)(void))completionBlock;
        [Export("beginRefreshingWithCompletionBlock:")]
        void BeginRefreshingWithCompletionBlock(Action completionBlock);

        /** 开始刷新后的回调(进入刷新状态后的回调) */
        // @property (copy, nonatomic) MJRefreshComponentbeginRefreshingCompletionBlock beginRefreshingCompletionBlock;
        [Export("beginRefreshingCompletionBlock", ArgumentSemantic.Copy)]
        MJRefreshComponentbeginRefreshingCompletionBlock BeginRefreshingCompletionBlock { get; set; }

        /** 结束刷新的回调 */
        // @property (copy, nonatomic) MJRefreshComponentEndRefreshingCompletionBlock endRefreshingCompletionBlock;
        [Export("endRefreshingCompletionBlock", ArgumentSemantic.Copy)]
        MJRefreshComponentEndRefreshingCompletionBlock EndRefreshingCompletionBlock { get; set; }

        /** 结束刷新状态 */
        // -(void)endRefreshing;
        [Export("endRefreshing")]
        void EndRefreshing();

        /** 结束刷新状态 */
        // -(void)endRefreshingWithCompletionBlock:(void (^)(void))completionBlock;
        [Export("endRefreshingWithCompletionBlock:")]
        void EndRefreshingWithCompletionBlock(Action completionBlock);

        /** 是否正在刷新 */
        // @property (readonly, getter = isRefreshing, assign, nonatomic) BOOL refreshing;
        [Export("refreshing")]
        bool Refreshing { [Bind("isRefreshing")] get; }

        /** 刷新状态 一般交给子类内部实现 */
        // @property (assign, nonatomic) MJRefreshState state;
        [Export("state", ArgumentSemantic.Assign)]
        MJRefreshState State { get; set; }

        /** 记录scrollView刚开始的inset */
        // @property (readonly, assign, nonatomic) UIEdgeInsets scrollViewOriginalInset;
        [Export("scrollViewOriginalInset", ArgumentSemantic.Assign)]
        UIEdgeInsets ScrollViewOriginalInset { get; }

        /** 父控件 */
        // @property (readonly, nonatomic, weak) UIScrollView * scrollView;
        [Export("scrollView", ArgumentSemantic.Weak)]
        UIScrollView ScrollView { get; }

        /** 初始化 */
        // -(void)prepare __attribute__((objc_requires_super));
        [Export("prepare")]
        [RequiresSuper]
        void Prepare();

        /** 摆放子控件frame */
        // -(void)placeSubviews __attribute__((objc_requires_super));
        [Export("placeSubviews")]
        [RequiresSuper]
        void PlaceSubviews();

        /** 当scrollView的contentOffset发生改变的时候调用 */
        // -(void)scrollViewContentOffsetDidChange:(NSDictionary *)change __attribute__((objc_requires_super));
        [Export("scrollViewContentOffsetDidChange:")]
        [RequiresSuper]
        void ScrollViewContentOffsetDidChange(NSDictionary change);

        /** 当scrollView的contentSize发生改变的时候调用 */
        // -(void)scrollViewContentSizeDidChange:(NSDictionary *)change __attribute__((objc_requires_super));
        [Export("scrollViewContentSizeDidChange:")]
        [RequiresSuper]
        void ScrollViewContentSizeDidChange(NSDictionary change);

        /** 当scrollView的拖拽状态发生改变的时候调用 */
        // -(void)scrollViewPanStateDidChange:(NSDictionary *)change __attribute__((objc_requires_super));
        [Export("scrollViewPanStateDidChange:")]
        [RequiresSuper]
        void ScrollViewPanStateDidChange(NSDictionary change);

        /** 拉拽的百分比(交给子类重写) */
        // @property (assign, nonatomic) CGFloat pullingPercent;
        [Export("pullingPercent")]
        nfloat PullingPercent { get; set; }

        // @property (getter = isAutoChangeAlpha, assign, nonatomic) BOOL autoChangeAlpha __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        //[Introduced(PlatformName.iOS, 2, 0, message: "请使用automaticallyChangeAlpha属性")]
        //[Deprecated(PlatformName.iOS, 2, 0, message: "请使用automaticallyChangeAlpha属性")]
        //[Export("autoChangeAlpha")]
        //bool AutoChangeAlpha { [Bind("isAutoChangeAlpha")] get; set; }

        /** 根据拖拽比例自动切换透明度 */
        // @property (getter = isAutomaticallyChangeAlpha, assign, nonatomic) BOOL automaticallyChangeAlpha;
        [Export("automaticallyChangeAlpha")]
        bool AutomaticallyChangeAlpha { [Bind("isAutomaticallyChangeAlpha")] get; set; }
    }

    // @interface MJRefresh (UILabel)
    [Category]
    [BaseType(typeof(UILabel))]
    interface UILabel_MJRefresh
    {
        // +(instancetype)mj_label;
        [Static]
        [Export("mj_label")]
        UILabel Mj_label();

        // -(CGFloat)mj_textWith;
        [Export("mj_textWith")]
        nfloat Mj_textWith();
    }

    #region Footer
    // @interface MJRefreshFooter : MJRefreshComponent
    [BaseType(typeof(MJRefreshComponent))]
    interface MJRefreshFooter
    {
        /** 创建footer */
        // +(instancetype)footerWithRefreshingBlock:(MJRefreshComponentRefreshingBlock)refreshingBlock;
        [Static]
        [Export("footerWithRefreshingBlock:")]
        MJRefreshFooter FooterWithRefreshingBlock(MJRefreshComponentRefreshingBlock refreshingBlock);

        /** 创建footer */
        // +(instancetype)footerWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Static]
        [Export("footerWithRefreshingTarget:refreshingAction:")]
        MJRefreshFooter FooterWithRefreshingTarget(NSObject target, Selector action);

        /** 提示没有更多的数据 */
        // -(void)endRefreshingWithNoMoreData;
        [Export("endRefreshingWithNoMoreData")]
        void EndRefreshingWithNoMoreData();

        // -(void)noticeNoMoreData __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        //[Introduced(PlatformName.iOS, 2, 0, message: "使用endRefreshingWithNoMoreData")]
        //[Deprecated(PlatformName.iOS, 2, 0, message: "使用endRefreshingWithNoMoreData")]
        //[Export("noticeNoMoreData")]
        //void NoticeNoMoreData();

        /** 重置没有更多的数据（消除没有更多数据的状态） */
        // -(void)resetNoMoreData;
        [Export("resetNoMoreData")]
        void ResetNoMoreData();

        /** 忽略多少scrollView的contentInset的bottom */
        // @property (assign, nonatomic) CGFloat ignoredScrollViewContentInsetBottom;
        [Export("ignoredScrollViewContentInsetBottom")]
        nfloat IgnoredScrollViewContentInsetBottom { get; set; }

        // @property (getter = isAutomaticallyHidden, assign, nonatomic) BOOL automaticallyHidden __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        //[Introduced(PlatformName.iOS, 2, 0, message: "不建议使用此属性，开发者请自行控制footer的显示和隐藏。基于安全考虑，在未来的某些版本此属性可能作废")]
        //[Deprecated(PlatformName.iOS, 2, 0, message: "不建议使用此属性，开发者请自行控制footer的显示和隐藏。基于安全考虑，在未来的某些版本此属性可能作废")]
        //[Export("automaticallyHidden")]
        //bool AutomaticallyHidden { [Bind("isAutomaticallyHidden")] get; set; }
    }

    // @interface MJRefreshAutoFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshAutoFooter
    {
        /** 是否自动刷新(默认为YES) */
        // @property (getter = isAutomaticallyRefresh, assign, nonatomic) BOOL automaticallyRefresh;
        [Export("automaticallyRefresh")]
        bool AutomaticallyRefresh { [Bind("isAutomaticallyRefresh")] get; set; }

        // @property (assign, nonatomic) CGFloat appearencePercentTriggerAutoRefresh __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        //[Introduced(PlatformName.iOS, 2, 0, message: "请使用triggerAutomaticallyRefreshPercent属性")]
        //[Deprecated(PlatformName.iOS, 2, 0, message: "请使用triggerAutomaticallyRefreshPercent属性")]
        //[Export("appearencePercentTriggerAutoRefresh")]
        //nfloat AppearencePercentTriggerAutoRefresh { get; set; }

        /** 当底部控件出现多少时就自动刷新(默认为1.0，也就是底部控件完全出现时，才会自动刷新) */
        // @property (assign, nonatomic) CGFloat triggerAutomaticallyRefreshPercent;
        [Export("triggerAutomaticallyRefreshPercent")]
        nfloat TriggerAutomaticallyRefreshPercent { get; set; }

        /** 是否每一次拖拽只发一次请求 */
        // @property (getter = isOnlyRefreshPerDrag, assign, nonatomic) BOOL onlyRefreshPerDrag;
        [Export("onlyRefreshPerDrag")]
        bool OnlyRefreshPerDrag { [Bind("isOnlyRefreshPerDrag")] get; set; }
    }

    // @interface MJRefreshAutoNormalFooter : MJRefreshAutoStateFooter
    [BaseType(typeof(MJRefreshAutoStateFooter))]
    interface MJRefreshAutoNormalFooter
    {
        /** 菊花的样式 */
        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshAutoStateFooter : MJRefreshAutoFooter
    [BaseType(typeof(MJRefreshAutoFooter))]
    interface MJRefreshAutoStateFooter
    {
        /** 文字距离圈圈、箭头的距离 */
        // @property (assign, nonatomic) CGFloat labelLeftInset;
        [Export("labelLeftInset")]
        nfloat LabelLeftInset { get; set; }

        /** 显示刷新状态的label */
        // @property (readonly, nonatomic, weak) UILabel * stateLabel;
        [Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        /** 设置state状态下的文字 */
        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);

        /** 隐藏刷新状态的文字 */
        // @property (getter = isRefreshingTitleHidden, assign, nonatomic) BOOL refreshingTitleHidden;
        [Export("refreshingTitleHidden")]
        bool RefreshingTitleHidden { [Bind("isRefreshingTitleHidden")] get; set; }
    }

    // @interface MJRefreshAutoGifFooter : MJRefreshAutoStateFooter
    [BaseType(typeof(MJRefreshAutoStateFooter))]
    interface MJRefreshAutoGifFooter
    {
        // @property (readonly, nonatomic, weak) UIImageView * gifView;
        [Export("gifView", ArgumentSemantic.Weak)]
        UIImageView GifView { get; }

        /** 设置state状态下的动画图片images 动画持续时间duration*/
        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        void SetImages(NSObject[] images, double duration, MJRefreshState state);

        /** 设置state状态下的动画图片images 动画持续时间duration*/
        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        void SetImages(NSObject[] images, MJRefreshState state);
    }

    // @interface MJRefreshBackFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshBackFooter
    {
    }

    // @interface MJRefreshBackNormalFooter : MJRefreshBackStateFooter
    [BaseType(typeof(MJRefreshBackStateFooter))]
    interface MJRefreshBackNormalFooter
    {
        // @property (readonly, nonatomic, weak) UIImageView * arrowView;
        [Export("arrowView", ArgumentSemantic.Weak)]
        UIImageView ArrowView { get; }

        /** 菊花的样式 */
        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshBackStateFooter : MJRefreshBackFooter
    [BaseType(typeof(MJRefreshBackFooter))]
    interface MJRefreshBackStateFooter
    {
        /** 文字距离圈圈、箭头的距离 */
        // @property (assign, nonatomic) CGFloat labelLeftInset;
        [Export("labelLeftInset")]
        nfloat LabelLeftInset { get; set; }

        /** 显示刷新状态的label */
        // @property (readonly, nonatomic, weak) UILabel * stateLabel;
        [Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        /** 设置state状态下的文字 */
        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);

        /** 获取state状态下的title */
        // -(NSString *)titleForState:(MJRefreshState)state;
        [Export("titleForState:")]
        string TitleForState(MJRefreshState state);
    }

    // @interface MJRefreshBackGifFooter : MJRefreshBackStateFooter
    [BaseType(typeof(MJRefreshBackStateFooter))]
    interface MJRefreshBackGifFooter
    {
        // @property (readonly, nonatomic, weak) UIImageView * gifView;
        [Export("gifView", ArgumentSemantic.Weak)]
        UIImageView GifView { get; }

        /** 设置state状态下的动画图片images 动画持续时间duration*/
        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        void SetImages(NSObject[] images, double duration, MJRefreshState state);

        /** 设置state状态下的动画图片images 动画持续时间duration*/
        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        void SetImages(NSObject[] images, MJRefreshState state);
    }
    #endregion

    #region Header
    // @interface MJRefreshHeader : MJRefreshComponent
    [BaseType(typeof(MJRefreshComponent))]
    interface MJRefreshHeader
    {
        /** 创建header */
        // +(instancetype)headerWithRefreshingBlock:(MJRefreshComponentRefreshingBlock)refreshingBlock;
        [Static]
        [Export("headerWithRefreshingBlock:")]
        MJRefreshHeader HeaderWithRefreshingBlock(MJRefreshComponentRefreshingBlock refreshingBlock);

        /** 创建header */
        // +(instancetype)headerWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Static]
        [Export("headerWithRefreshingTarget:refreshingAction:")]
        MJRefreshHeader HeaderWithRefreshingTarget(NSObject target, Selector action);

        /** 这个key用来存储上一次下拉刷新成功的时间 */
        // @property (copy, nonatomic) NSString * lastUpdatedTimeKey;
        [Export("lastUpdatedTimeKey")]
        string LastUpdatedTimeKey { get; set; }

        /** 上一次下拉刷新成功的时间 */
        // @property (readonly, nonatomic, strong) NSDate * lastUpdatedTime;
        [Export("lastUpdatedTime", ArgumentSemantic.Strong)]
        NSDate LastUpdatedTime { get; }

        /** 忽略多少scrollView的contentInset的top */
        // @property (assign, nonatomic) CGFloat ignoredScrollViewContentInsetTop;
        [Export("ignoredScrollViewContentInsetTop")]
        nfloat IgnoredScrollViewContentInsetTop { get; set; }
    }

    // @interface MJRefreshNormalHeader : MJRefreshStateHeader
    [BaseType(typeof(MJRefreshStateHeader))]
    interface MJRefreshNormalHeader
    {
        // @property (readonly, nonatomic, weak) UIImageView * arrowView;
        [Export("arrowView", ArgumentSemantic.Weak)]
        UIImageView ArrowView { get; }

        /** 菊花的样式 */
        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshStateHeader : MJRefreshHeader
    [BaseType(typeof(MJRefreshHeader))]
    interface MJRefreshStateHeader
    {
        /** 利用这个block来决定显示的更新时间文字 */
        // @property (copy, nonatomic) NSString * (^lastUpdatedTimeText)(NSDate *);
        [Export("lastUpdatedTimeText", ArgumentSemantic.Copy)]
        Func<NSDate, NSString> LastUpdatedTimeText { get; set; }

        /** 显示上一次刷新时间的label */
        // @property (readonly, nonatomic, weak) UILabel * lastUpdatedTimeLabel;
        [Export("lastUpdatedTimeLabel", ArgumentSemantic.Weak)]
        UILabel LastUpdatedTimeLabel { get; }

        /** 文字距离圈圈、箭头的距离 */
        // @property (assign, nonatomic) CGFloat labelLeftInset;
        [Export("labelLeftInset")]
        nfloat LabelLeftInset { get; set; }

        /** 显示刷新状态的label */
        // @property (readonly, nonatomic, weak) UILabel * stateLabel;
        [Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        /** 设置state状态下的文字 */
        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);
    }

    // @interface MJRefreshGifHeader : MJRefreshStateHeader
    [BaseType(typeof(MJRefreshStateHeader))]
    interface MJRefreshGifHeader
    {
        // @property (readonly, nonatomic, weak) UIImageView * gifView;
        [Export("gifView", ArgumentSemantic.Weak)]
        UIImageView GifView { get; }

        /** 设置state状态下的动画图片images 动画持续时间duration*/
        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        void SetImages(UIImage[] images, double duration, MJRefreshState state);

        /** 设置state状态下的动画图片images 动画持续时间duration*/
        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        void SetImages(UIImage[] images, MJRefreshState state);
    }
    #endregion
}