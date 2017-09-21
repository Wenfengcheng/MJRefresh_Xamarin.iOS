using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MJRefresh
{
    // @interface MJRefresh (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_MJRefresh
    {
        // @property (nonatomic, strong) MJRefreshHeader * header;
        [Export("header")]
        MJRefreshHeader GetHeader();

        [Export("setHeader:")]
        void SetHeader(MJRefreshHeader header);

        // @property (nonatomic, strong) MJRefreshFooter * footer;
        [Export("footer")]
        MJRefreshFooter GetFooter();

        [Export("setFooter:")]
        void SetFooter(MJRefreshFooter footet);
    }

    // @interface MJExtension (UIScrollView)
    //    [Category]
    //    [BaseType (typeof(UIScrollView))]
    //    interface UIScrollView_MJExtension
    //    {
    //        // @property (assign, nonatomic) CGFloat mj_insetT;
    //        [Export ("mj_insetT", ArgumentSemantic.Assign)]
    //        nfloat Mj_insetT { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_insetB;
    //        [Export ("mj_insetB", ArgumentSemantic.Assign)]
    //        nfloat Mj_insetB { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_insetL;
    //        [Export ("mj_insetL", ArgumentSemantic.Assign)]
    //        nfloat Mj_insetL { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_insetR;
    //        [Export ("mj_insetR", ArgumentSemantic.Assign)]
    //        nfloat Mj_insetR { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_offsetX;
    //        [Export ("mj_offsetX", ArgumentSemantic.Assign)]
    //        nfloat Mj_offsetX { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_offsetY;
    //        [Export ("mj_offsetY", ArgumentSemantic.Assign)]
    //        nfloat Mj_offsetY { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_contentW;
    //        [Export ("mj_contentW", ArgumentSemantic.Assign)]
    //        nfloat Mj_contentW { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_contentH;
    //        [Export ("mj_contentH", ArgumentSemantic.Assign)]
    //        nfloat Mj_contentH { get; set; }
    //    }

    // @interface MJExtension (UIView)
    //    [Category]
    //    [BaseType (typeof(UIView))]
    //    interface UIView_MJExtension
    //    {
    //        // @property (assign, nonatomic) CGFloat mj_x;
    //        [Export ("mj_x", ArgumentSemantic.Assign)]
    //        nfloat Mj_x { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_y;
    //        [Export ("mj_y", ArgumentSemantic.Assign)]
    //        nfloat Mj_y { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_w;
    //        [Export ("mj_w", ArgumentSemantic.Assign)]
    //        nfloat Mj_w { get; set; }
    //
    //        // @property (assign, nonatomic) CGFloat mj_h;
    //        [Export ("mj_h", ArgumentSemantic.Assign)]
    //        nfloat Mj_h { get; set; }
    //
    //        // @property (assign, nonatomic) CGSize mj_size;
    //        [Export ("mj_size", ArgumentSemantic.Assign)]
    //        CGSize Mj_size { get; set; }
    //
    //        // @property (assign, nonatomic) CGPoint mj_origin;
    //        [Export ("mj_origin", ArgumentSemantic.Assign)]
    //        CGPoint Mj_origin { get; set; }
    //    }


    // typedef void (^MJRefreshComponentRefreshingBlock)();
    delegate void MJRefreshComponentRefreshingBlock();

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

        // -(void)endRefreshing;
        [Export("endRefreshing")]
        void EndRefreshing();

        // -(BOOL)isRefreshing;
        [Export("isRefreshing")]
        //        [Verify (MethodToProperty)]
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

        // -(void)prepare;
        [Export("prepare")]
        void Prepare();

        // -(void)placeSubviews;
        [Export("placeSubviews")]
        void PlaceSubviews();

        // -(void)scrollViewContentOffsetDidChange:(NSDictionary *)change;
        [Export("scrollViewContentOffsetDidChange:")]
        void ScrollViewContentOffsetDidChange(NSDictionary change);

        // -(void)scrollViewContentSizeDidChange:(NSDictionary *)change;
        [Export("scrollViewContentSizeDidChange:")]
        void ScrollViewContentSizeDidChange(NSDictionary change);

        // -(void)scrollViewContentInsetDidChange:(NSDictionary *)change;
        [Export("scrollViewContentInsetDidChange:")]
        void ScrollViewContentInsetDidChange(NSDictionary change);

        // -(void)scrollViewPanStateDidChange:(NSDictionary *)change;
        [Export("scrollViewPanStateDidChange:")]
        void ScrollViewPanStateDidChange(NSDictionary change);

        // @property (assign, nonatomic) CGFloat pullingPercent;
        [Export("pullingPercent", ArgumentSemantic.Assign)]
        nfloat PullingPercent { get; set; }

        // @property (getter = isAutoChangeAlpha, assign, nonatomic) BOOL autoChangeAlpha;
        [Export("autoChangeAlpha")]
        bool AutoChangeAlpha { [Bind("isAutoChangeAlpha")] get; set; }
    }

    // @interface MJRefresh (UILabel)
    [Category]
    [BaseType(typeof(UILabel))]
    interface UILabel_MJRefresh
    {
        // +(instancetype)label;
        [Static]
        [Export("label")]
        UILabel Label();
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

        // @property (readonly, nonatomic, weak) UILabel * stateLabel;
        [Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);
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

    // @interface MJRefreshGifHeader : MJRefreshStateHeader
    [BaseType(typeof(MJRefreshStateHeader))]
    interface MJRefreshGifHeader
    {
        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        //        [Verify (StronglyTypedNSArray)]
        void SetImages(UIImage[] images, double duration, MJRefreshState state);

        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        //        [Verify (StronglyTypedNSArray)]
        void SetImages(UIImage[] images, MJRefreshState state);
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

        // -(void)noticeNoMoreData;
        [Export("noticeNoMoreData")]
        void NoticeNoMoreData();

        // -(void)resetNoMoreData;
        [Export("resetNoMoreData")]
        void ResetNoMoreData();
    }


    // @interface MJRefreshBackFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshBackFooter
    {
    }

    // @interface MJRefreshBackStateFooter : MJRefreshBackFooter
    [BaseType(typeof(MJRefreshBackFooter))]
    interface MJRefreshBackStateFooter
    {
        // @property (readonly, nonatomic, weak) UILabel * stateLabel;
        [Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);
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

    // @interface MJRefreshBackGifFooter : MJRefreshBackStateFooter
    [BaseType(typeof(MJRefreshBackStateFooter))]
    interface MJRefreshBackGifFooter
    {
        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        //        [Verify (StronglyTypedNSArray)]
        void SetImages(UIImage[] images, double duration, MJRefreshState state);

        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        //        [Verify (StronglyTypedNSArray)]
        void SetImages(UIImage[] images, MJRefreshState state);
    }

    // @interface MJRefreshAutoFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshAutoFooter
    {
        // @property (getter = isAutomaticallyRefresh, assign, nonatomic) BOOL automaticallyRefresh;
        [Export("automaticallyRefresh")]
        bool AutomaticallyRefresh { [Bind("isAutomaticallyRefresh")] get; set; }

        // @property (assign, nonatomic) CGFloat appearencePercentTriggerAutoRefresh;
        [Export("appearencePercentTriggerAutoRefresh", ArgumentSemantic.Assign)]
        nfloat AppearencePercentTriggerAutoRefresh { get; set; }
    }

    // @interface MJRefreshAutoStateFooter : MJRefreshAutoFooter
    [BaseType(typeof(MJRefreshAutoFooter))]
    interface MJRefreshAutoStateFooter
    {
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

    // @interface MJRefreshAutoNormalFooter : MJRefreshAutoStateFooter
    [BaseType(typeof(MJRefreshAutoStateFooter))]
    interface MJRefreshAutoNormalFooter
    {
        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshAutoGifFooter : MJRefreshAutoStateFooter
    [BaseType(typeof(MJRefreshAutoStateFooter))]
    interface MJRefreshAutoGifFooter
    {
        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        //        [Verify(StronglyTypedNSArray)]
        void SetImages(UIImage[] images, double duration, MJRefreshState state);

        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        //        [Verify(StronglyTypedNSArray)]
        void SetImages(UIImage[] images, MJRefreshState state);
    }
}