using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;

namespace BottomNavigationViewExample
{
    [Activity(Label = "BottomNavigationViewExample", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/Theme.AppCompat.Light.DarkActionBar")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var textView = FindViewById<TextView>(Resource.Id.textView);
            var bottomBar = FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView);
            textView.Text = "All";
            bottomBar.NavigationItemSelected += (s,a) => {
                textView.Text = a.Item.TitleFormatted.ToString();
            };
        }
    }
}

