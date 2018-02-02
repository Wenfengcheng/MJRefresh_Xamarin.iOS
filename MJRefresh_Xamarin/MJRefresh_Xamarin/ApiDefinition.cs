using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MJRefresh{

partial interface Constants
{
    // extern const CGFloat MJRefreshLabelLeftInset __attribute__((visibility("default")));
    [Field("MJRefreshLabelLeftInset", "__Internal")]
    nfloat MJRefreshLabelLeftInset { get; }

    // extern const CGFloat MJRefreshHeaderHeight __attribute__((visibility("default")));
    [Field("MJRefreshHeaderHeight", "__Internal")]
    nfloat MJRefreshHeaderHeight { get; }

    // extern const CGFloat MJRefreshFooterHeight __attribute__((visibility("default")));
    [Field("MJRefreshFooterHeight", "__Internal")]
    nfloat MJRefreshFooterHeight { get; }

    // extern const CGFloat MJRefreshFastAnimationDuration __attribute__((visibility("default")));
    [Field("MJRefreshFastAnimationDuration", "__Internal")]
    nfloat MJRefreshFastAnimationDuration { get; }

    // extern const CGFloat MJRefreshSlowAnimationDuration __attribute__((visibility("default")));
    [Field("MJRefreshSlowAnimationDuration", "__Internal")]
    nfloat MJRefreshSlowAnimationDuration { get; }

    // extern NSString *const MJRefreshKeyPathContentOffset __attribute__((visibility("default")));
    [Field("MJRefreshKeyPathContentOffset", "__Internal")]
    NSString MJRefreshKeyPathContentOffset { get; }

    // extern NSString *const MJRefreshKeyPathContentSize __attribute__((visibility("default")));
    [Field("MJRefreshKeyPathContentSize", "__Internal")]
    NSString MJRefreshKeyPathContentSize { get; }

    // extern NSString *const MJRefreshKeyPathContentInset __attribute__((visibility("default")));
    [Field("MJRefreshKeyPathContentInset", "__Internal")]
    NSString MJRefreshKeyPathContentInset { get; }

    // extern NSString *const MJRefreshKeyPathPanState __attribute__((visibility("default")));
    [Field("MJRefreshKeyPathPanState", "__Internal")]
    NSString MJRefreshKeyPathPanState { get; }

    // extern NSString *const MJRefreshHeaderLastUpdatedTimeKey __attribute__((visibility("default")));
    [Field("MJRefreshHeaderLastUpdatedTimeKey", "__Internal")]
    NSString MJRefreshHeaderLastUpdatedTimeKey { get; }

    // extern NSString *const MJRefreshHeaderIdleText __attribute__((visibility("default")));
    [Field("MJRefreshHeaderIdleText", "__Internal")]
    NSString MJRefreshHeaderIdleText { get; }

    // extern NSString *const MJRefreshHeaderPullingText __attribute__((visibility("default")));
    [Field("MJRefreshHeaderPullingText", "__Internal")]
    NSString MJRefreshHeaderPullingText { get; }

    // extern NSString *const MJRefreshHeaderRefreshingText __attribute__((visibility("default")));
    [Field("MJRefreshHeaderRefreshingText", "__Internal")]
    NSString MJRefreshHeaderRefreshingText { get; }

    // extern NSString *const MJRefreshAutoFooterIdleText __attribute__((visibility("default")));
    [Field("MJRefreshAutoFooterIdleText", "__Internal")]
    NSString MJRefreshAutoFooterIdleText { get; }

    // extern NSString *const MJRefreshAutoFooterRefreshingText __attribute__((visibility("default")));
    [Field("MJRefreshAutoFooterRefreshingText", "__Internal")]
    NSString MJRefreshAutoFooterRefreshingText { get; }

    // extern NSString *const MJRefreshAutoFooterNoMoreDataText __attribute__((visibility("default")));
    [Field("MJRefreshAutoFooterNoMoreDataText", "__Internal")]
    NSString MJRefreshAutoFooterNoMoreDataText { get; }

    // extern NSString *const MJRefreshBackFooterIdleText __attribute__((visibility("default")));
    [Field("MJRefreshBackFooterIdleText", "__Internal")]
    NSString MJRefreshBackFooterIdleText { get; }

    // extern NSString *const MJRefreshBackFooterPullingText __attribute__((visibility("default")));
    [Field("MJRefreshBackFooterPullingText", "__Internal")]
    NSString MJRefreshBackFooterPullingText { get; }

    // extern NSString *const MJRefreshBackFooterRefreshingText __attribute__((visibility("default")));
    [Field("MJRefreshBackFooterRefreshingText", "__Internal")]
    NSString MJRefreshBackFooterRefreshingText { get; }

    // extern NSString *const MJRefreshBackFooterNoMoreDataText __attribute__((visibility("default")));
    [Field("MJRefreshBackFooterNoMoreDataText", "__Internal")]
    NSString MJRefreshBackFooterNoMoreDataText { get; }

    // extern NSString *const MJRefreshHeaderLastTimeText __attribute__((visibility("default")));
    [Field("MJRefreshHeaderLastTimeText", "__Internal")]
    NSString MJRefreshHeaderLastTimeText { get; }

    // extern NSString *const MJRefreshHeaderDateTodayText __attribute__((visibility("default")));
    [Field("MJRefreshHeaderDateTodayText", "__Internal")]
    NSString MJRefreshHeaderDateTodayText { get; }

    // extern NSString *const MJRefreshHeaderNoneLastDateText __attribute__((visibility("default")));
    [Field("MJRefreshHeaderNoneLastDateText", "__Internal")]
    NSString MJRefreshHeaderNoneLastDateText { get; }
}

// @interface MJExtension (UIView)
[Category]
[BaseType(typeof(UIView))]
interface UIView_MJExtension
{
    // @property (assign, nonatomic) CGFloat mj_x;
    [Export("mj_x")]
    nfloat Mj_x();

    // @property (assign, nonatomic) CGFloat mj_y;
    [Export("mj_y")]
    nfloat Mj_y();

    // @property (assign, nonatomic) CGFloat mj_w;
    [Export("mj_w")]
    nfloat Mj_w();

    // @property (assign, nonatomic) CGFloat mj_h;
    [Export("mj_h")]
    nfloat Mj_h();

    // @property (assign, nonatomic) CGSize mj_size;
    [Export("mj_size", ArgumentSemantic.Assign)]
    CGSize Mj_size();

    // @property (assign, nonatomic) CGPoint mj_origin;
    [Export("mj_origin", ArgumentSemantic.Assign)]
    CGPoint Mj_origin();
}

// @interface MJExtension (UIScrollView)
[Category]
[BaseType(typeof(UIScrollView))]
interface UIScrollView_MJExtension
{
        // @property (assign, nonatomic) CGFloat mj_insetT;
        [Export("mj_insetT")]
        nfloat Mj_insetT();

        // @property (assign, nonatomic) CGFloat mj_insetB;
        [Export("mj_insetB")]
        nfloat Mj_insetB();

        // @property (assign, nonatomic) CGFloat mj_insetL;
        [Export("mj_insetL")]
        nfloat Mj_insetL();

        // @property (assign, nonatomic) CGFloat mj_insetR;
        [Export("mj_insetR")]
        nfloat Mj_insetR();

        // @property (assign, nonatomic) CGFloat mj_offsetX;
        [Export("mj_offsetX")]
        nfloat Mj_offsetX();

        // @property (assign, nonatomic) CGFloat mj_offsetY;
        [Export("mj_offsetY")]
        nfloat Mj_offsetY();

        // @property (assign, nonatomic) CGFloat mj_contentW;
        [Export("mj_contentW")]
        nfloat Mj_contentW();

        // @property (assign, nonatomic) CGFloat mj_contentH;
        [Export("mj_contentH")]
        nfloat Mj_contentH();
}

// @interface MJRefresh (UIScrollView)
[Category]
[BaseType(typeof(UIScrollView))]
interface UIScrollView_MJRefresh
{
        // @property (nonatomic, strong) MJRefreshHeader * mj_header;
        [Export("header")]
        MJRefreshHeader Header();

        [Export("setHeader:")]
        void SetHeader(MJRefreshHeader header);

        // @property (nonatomic, strong) MJRefreshFooter * mj_footer;
        [Export("footer")]
        MJRefreshFooter Footer();

        [Export("setFooter:")]
        void SetFooter(MJRefreshFooter header);

        // -(NSInteger)mj_totalDataCount;
        [Export("mj_totalDataCount")]
        nint Mj_totalDataCount();

        // @property (copy, nonatomic) void (^mj_reloadDataBlock)(NSInteger);
        [Export("mj_reloadDataBlock", ArgumentSemantic.Copy)]
        Action<nint> Mj_reloadDataBlock();
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

// typedef void (^MJRefreshComponentRefreshingBlock)();
delegate void MJRefreshComponentRefreshingBlock();

// typedef void (^MJRefreshComponentbeginRefreshingCompletionBlock)();
delegate void MJRefreshComponentbeginRefreshingCompletionBlock();

// typedef void (^MJRefreshComponentEndRefreshingCompletionBlock)();
delegate void MJRefreshComponentEndRefreshingCompletionBlock();

// @interface MJRefreshComponent : UIView
[BaseType(typeof(UIView))]
interface MJRefreshComponent
{
    // @property (copy, nonatomic) MJRefreshComponentRefreshingBlock refreshingBlock;
    [Export("refreshingBlock", ArgumentSemantic.Copy)]
    MJRefreshComponentRefreshingBlock RefreshingBlock { get; set; }

    // -(void)setRefreshingTarget:(id)target refreshingAction:(SEL)action;
    [Export("setRefreshingTarget:refreshingAction:")]
    void SetRefreshingTarget(NSObject target, Selector action);

    // @property (nonatomic, weak) id refreshingTarget;
    [Export("refreshingTarget", ArgumentSemantic.Weak)]
    NSObject RefreshingTarget { get; set; }

    // @property (assign, nonatomic) SEL refreshingAction;
    [Export("refreshingAction", ArgumentSemantic.Assign)]
    Selector RefreshingAction { get; set; }

    // -(void)executeRefreshingCallback;
    [Export("executeRefreshingCallback")]
    void ExecuteRefreshingCallback();

    // -(void)beginRefreshing;
    [Export("beginRefreshing")]
    void BeginRefreshing();

    // -(void)beginRefreshingWithCompletionBlock:(void (^)())completionBlock;
    [Export("beginRefreshingWithCompletionBlock:")]
    void BeginRefreshingWithCompletionBlock(Action completionBlock);

    // @property (copy, nonatomic) MJRefreshComponentbeginRefreshingCompletionBlock beginRefreshingCompletionBlock;
    [Export("beginRefreshingCompletionBlock", ArgumentSemantic.Copy)]
    MJRefreshComponentbeginRefreshingCompletionBlock BeginRefreshingCompletionBlock { get; set; }

    // @property (copy, nonatomic) MJRefreshComponentEndRefreshingCompletionBlock endRefreshingCompletionBlock;
    [Export("endRefreshingCompletionBlock", ArgumentSemantic.Copy)]
    MJRefreshComponentEndRefreshingCompletionBlock EndRefreshingCompletionBlock { get; set; }

    // -(void)endRefreshing;
    [Export("endRefreshing")]
    void EndRefreshing();

    // -(void)endRefreshingWithCompletionBlock:(void (^)())completionBlock;
    [Export("endRefreshingWithCompletionBlock:")]
    void EndRefreshingWithCompletionBlock(Action completionBlock);

    // -(BOOL)isRefreshing;
    [Export("isRefreshing")]

    bool IsRefreshing { get; }

    // @property (assign, nonatomic) MJRefreshState state;
    [Export("state", ArgumentSemantic.Assign)]
    MJRefreshState State { get; set; }

    // @property (readonly, assign, nonatomic) UIEdgeInsets scrollViewOriginalInset;
    [Export("scrollViewOriginalInset", ArgumentSemantic.Assign)]
    UIEdgeInsets ScrollViewOriginalInset { get; }

    // @property (readonly, nonatomic, weak) UIScrollView * scrollView;
    [Export("scrollView", ArgumentSemantic.Weak)]
    UIScrollView ScrollView { get; }

    // -(void)prepare __attribute__((objc_requires_super));
    [Export("prepare")]

    void Prepare();

    // -(void)placeSubviews __attribute__((objc_requires_super));
    [Export("placeSubviews")]

    void PlaceSubviews();

    // -(void)scrollViewContentOffsetDidChange:(NSDictionary *)change __attribute__((objc_requires_super));
    [Export("scrollViewContentOffsetDidChange:")]

    void ScrollViewContentOffsetDidChange(NSDictionary change);

    // -(void)scrollViewContentSizeDidChange:(NSDictionary *)change __attribute__((objc_requires_super));
    [Export("scrollViewContentSizeDidChange:")]

    void ScrollViewContentSizeDidChange(NSDictionary change);

    // -(void)scrollViewPanStateDidChange:(NSDictionary *)change __attribute__((objc_requires_super));
    [Export("scrollViewPanStateDidChange:")]

    void ScrollViewPanStateDidChange(NSDictionary change);

    // @property (assign, nonatomic) CGFloat pullingPercent;
    [Export("pullingPercent")]
    nfloat PullingPercent { get; set; }

    // @property (getter = isAutoChangeAlpha, assign, nonatomic) BOOL autoChangeAlpha __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
    [Introduced(PlatformName.iOS, 2, 0, message: "请使用automaticallyChangeAlpha属性")]
    [Deprecated(PlatformName.iOS, 2, 0, message: "请使用automaticallyChangeAlpha属性")]
    [Export("autoChangeAlpha")]
    bool AutoChangeAlpha { [Bind("isAutoChangeAlpha")] get; set; }

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

// @interface MJRefreshFooter : MJRefreshComponent
[BaseType(typeof(MJRefreshComponent))]
interface MJRefreshFooter
{
    // +(instancetype)footerWithRefreshingBlock:(MJRefreshComponentRefreshingBlock)refreshingBlock;
    [Static]
    [Export("footerWithRefreshingBlock:")]
    MJRefreshFooter FooterWithRefreshingBlock(MJRefreshComponentRefreshingBlock refreshingBlock);

    // +(instancetype)footerWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
    [Static]
    [Export("footerWithRefreshingTarget:refreshingAction:")]
    MJRefreshFooter FooterWithRefreshingTarget(NSObject target, Selector action);

    // -(void)endRefreshingWithNoMoreData;
    [Export("endRefreshingWithNoMoreData")]
    void EndRefreshingWithNoMoreData();

    // -(void)noticeNoMoreData __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
    [Introduced(PlatformName.iOS, 2, 0, message: "使用endRefreshingWithNoMoreData")]
    [Deprecated(PlatformName.iOS, 2, 0, message: "使用endRefreshingWithNoMoreData")]
    [Export("noticeNoMoreData")]
    void NoticeNoMoreData();

    // -(void)resetNoMoreData;
    [Export("resetNoMoreData")]
    void ResetNoMoreData();

    // @property (assign, nonatomic) CGFloat ignoredScrollViewContentInsetBottom;
    [Export("ignoredScrollViewContentInsetBottom")]
    nfloat IgnoredScrollViewContentInsetBottom { get; set; }

    // @property (getter = isAutomaticallyHidden, assign, nonatomic) BOOL automaticallyHidden;
    [Export("automaticallyHidden")]
    bool AutomaticallyHidden { [Bind("isAutomaticallyHidden")] get; set; }
}

// @interface MJRefreshAutoFooter : MJRefreshFooter
[BaseType(typeof(MJRefreshFooter))]
interface MJRefreshAutoFooter
{
    // @property (getter = isAutomaticallyRefresh, assign, nonatomic) BOOL automaticallyRefresh;
    [Export("automaticallyRefresh")]
    bool AutomaticallyRefresh { [Bind("isAutomaticallyRefresh")] get; set; }

    // @property (assign, nonatomic) CGFloat appearencePercentTriggerAutoRefresh __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
    [Introduced(PlatformName.iOS, 2, 0, message: "请使用triggerAutomaticallyRefreshPercent属性")]
    [Deprecated(PlatformName.iOS, 2, 0, message: "请使用triggerAutomaticallyRefreshPercent属性")]
    [Export("appearencePercentTriggerAutoRefresh")]
    nfloat AppearencePercentTriggerAutoRefresh { get; set; }

    // @property (assign, nonatomic) CGFloat triggerAutomaticallyRefreshPercent;
    [Export("triggerAutomaticallyRefreshPercent")]
    nfloat TriggerAutomaticallyRefreshPercent { get; set; }
}

// @interface MJRefreshBackFooter : MJRefreshFooter
[BaseType(typeof(MJRefreshFooter))]
interface MJRefreshBackFooter
{
}

// @interface MJRefreshHeader : MJRefreshComponent
[BaseType(typeof(MJRefreshComponent))]
interface MJRefreshHeader
{
    // +(instancetype)headerWithRefreshingBlock:(MJRefreshComponentRefreshingBlock)refreshingBlock;
    [Static]
    [Export("headerWithRefreshingBlock:")]
    MJRefreshHeader HeaderWithRefreshingBlock(MJRefreshComponentRefreshingBlock refreshingBlock);

    // +(instancetype)headerWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
    [Static]
    [Export("headerWithRefreshingTarget:refreshingAction:")]
    MJRefreshHeader HeaderWithRefreshingTarget(NSObject target, Selector action);

    // @property (copy, nonatomic) NSString * lastUpdatedTimeKey;
    [Export("lastUpdatedTimeKey")]
    string LastUpdatedTimeKey { get; set; }

    // @property (readonly, nonatomic, strong) NSDate * lastUpdatedTime;
    [Export("lastUpdatedTime", ArgumentSemantic.Strong)]
    NSDate LastUpdatedTime { get; }

    // @property (assign, nonatomic) CGFloat ignoredScrollViewContentInsetTop;
    [Export("ignoredScrollViewContentInsetTop")]
    nfloat IgnoredScrollViewContentInsetTop { get; set; }
}

// @interface MJRefreshAutoStateFooter : MJRefreshAutoFooter
[BaseType(typeof(MJRefreshAutoFooter))]
interface MJRefreshAutoStateFooter
{
    // @property (assign, nonatomic) CGFloat labelLeftInset;
    [Export("labelLeftInset")]
    nfloat LabelLeftInset { get; set; }

    // @property (readonly, nonatomic, weak) UILabel * stateLabel;
    [Export("stateLabel", ArgumentSemantic.Weak)]
    UILabel StateLabel { get; }

    // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
    [Export("setTitle:forState:")]
    void SetTitle(string title, MJRefreshState state);

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

    // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
    [Export("setImages:duration:forState:")]

    void SetImages(NSObject[] images, double duration, MJRefreshState state);

    // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
    [Export("setImages:forState:")]

    void SetImages(NSObject[] images, MJRefreshState state);
}

// @interface MJRefreshAutoNormalFooter : MJRefreshAutoStateFooter
[BaseType(typeof(MJRefreshAutoStateFooter))]
interface MJRefreshAutoNormalFooter
{
    // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
    [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
    UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
}

// @interface MJRefreshBackStateFooter : MJRefreshBackFooter
[BaseType(typeof(MJRefreshBackFooter))]
interface MJRefreshBackStateFooter
{
    // @property (assign, nonatomic) CGFloat labelLeftInset;
    [Export("labelLeftInset")]
    nfloat LabelLeftInset { get; set; }

    // @property (readonly, nonatomic, weak) UILabel * stateLabel;
    [Export("stateLabel", ArgumentSemantic.Weak)]
    UILabel StateLabel { get; }

    // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
    [Export("setTitle:forState:")]
    void SetTitle(string title, MJRefreshState state);

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

    // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
    [Export("setImages:duration:forState:")]

    void SetImages(NSObject[] images, double duration, MJRefreshState state);

    // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
    [Export("setImages:forState:")]

    void SetImages(NSObject[] images, MJRefreshState state);
}

// @interface MJRefreshBackNormalFooter : MJRefreshBackStateFooter
[BaseType(typeof(MJRefreshBackStateFooter))]
interface MJRefreshBackNormalFooter
{
    // @property (readonly, nonatomic, weak) UIImageView * arrowView;
    [Export("arrowView", ArgumentSemantic.Weak)]
    UIImageView ArrowView { get; }

    // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
    [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
    UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
}

// @interface MJRefreshStateHeader : MJRefreshHeader
[BaseType(typeof(MJRefreshHeader))]
interface MJRefreshStateHeader
{
    // @property (copy, nonatomic) NSString * (^lastUpdatedTimeText)(NSDate *);
    [Export("lastUpdatedTimeText", ArgumentSemantic.Copy)]
    Func<NSDate, NSString> LastUpdatedTimeText { get; set; }

    // @property (readonly, nonatomic, weak) UILabel * lastUpdatedTimeLabel;
    [Export("lastUpdatedTimeLabel", ArgumentSemantic.Weak)]
    UILabel LastUpdatedTimeLabel { get; }

    // @property (assign, nonatomic) CGFloat labelLeftInset;
    [Export("labelLeftInset")]
    nfloat LabelLeftInset { get; set; }

    // @property (readonly, nonatomic, weak) UILabel * stateLabel;
    [Export("stateLabel", ArgumentSemantic.Weak)]
    UILabel StateLabel { get; }

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

    // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
    [Export("setImages:duration:forState:")]

        void SetImages(NSArray images, double duration, MJRefreshState state);

    // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
    [Export("setImages:forState:")]

        void SetImages(NSArray images, MJRefreshState state);
}

// @interface MJRefreshNormalHeader : MJRefreshStateHeader
[BaseType(typeof(MJRefreshStateHeader))]
interface MJRefreshNormalHeader
{
    // @property (readonly, nonatomic, weak) UIImageView * arrowView;
    [Export("arrowView", ArgumentSemantic.Weak)]
    UIImageView ArrowView { get; }

    // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
    [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
    UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
}

[Static]

partial interface Constants
{
    // extern double MJRefreshVersionNumber;
    [Field("MJRefreshVersionNumber", "__Internal")]
    double MJRefreshVersionNumber { get; }

    // extern const unsigned char [] MJRefreshVersionString;
    [Field("MJRefreshVersionString", "__Internal")]
    NSString MJRefreshVersionString { get; }
}
}