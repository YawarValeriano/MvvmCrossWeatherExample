

using Android.App;
using Android.OS;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace MvvmExampleAndroid
{
	[Activity (Label = "ListExampleActivity")]			
	public class ListExampleActivity : MvxActivity<ListViewModel>
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
            SetContentView(Resource.Layout.activity_list_example);
            // Create your application here
        }
	}
}

