

using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace MvvmExampleAndroid
{
    [Activity(Label = "ViewActivity", MainLauncher = true)]
    public class ViewActivity : MvxActivity<MainViewModel>
    {

        Button button;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            button = FindViewById<Button>(Resource.Id.NextButton);

            button.Click += OnButtonClick;

        }

        private void OnButtonClick(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(ListExampleActivity));
            StartActivity(intent);
        }
    }
}

