using System;
using Core.ViewModels;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace MvvmExampleiOS.Views
{
    [MvxFromStoryboard("Main")]
    //[MvxRootPresentation(WrapInNavigationController = true)]
    public partial class MyViewController : MvxViewController<MainViewModel>
    {
        public MyViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = CreateBindingSet();
            set.Bind(TipLabel).To(vm => vm.Tip);
            set.Bind(SubTotalTextField).To(vm => vm.SubTotal);
            set.Bind(GenerositySlider).To(vm => vm.Generosity);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
