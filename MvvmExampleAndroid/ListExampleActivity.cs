

using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Core.ViewModels;
using MvvmCross.Droid.Support.V7.RecyclerView;
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

            var recyclerView = FindViewById<MvxRecyclerView>(Resource.Id.my_recycler_view);
            var layoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(layoutManager);

        }
	}
}

