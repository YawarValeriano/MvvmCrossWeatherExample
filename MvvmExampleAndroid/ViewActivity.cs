

using Android.App;
using Android.OS;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace MvvmExampleAndroid
{
    [Activity(Label = "ViewActivity", MainLauncher = true)]
    public class ViewActivity : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

        }
    }
}

