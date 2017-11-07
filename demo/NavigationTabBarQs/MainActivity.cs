using Android.App;
using Android.Widget;
using Android.OS;
using Com.Gigamole.Navigationtabbar.Ntb;
using System.Collections.Generic;
using Android.Graphics;

namespace NavigationTabBarQs
{
    [Activity(Label = "NavigationTabBarQs", MainLauncher = true)]
    public class MainActivity : Activity
    {
        NavigationTabBar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
            toolbar = FindViewById<NavigationTabBar>(Resource.Id.ntb_vertical);


            toolbar.Models = GetModels();
            toolbar.IconSizeFraction = (0.2f);
            toolbar.IsTitled = true;
            toolbar.TitleSize = 24;
        }

        IList<NavigationTabBar.Model> GetModels()
        {
            List<NavigationTabBar.Model> models = new List<NavigationTabBar.Model>();
            models.Add(
                    new NavigationTabBar.Model.Builder(
                            Resources.GetDrawable(Resource.Drawable.ic_first, Theme),
                            Color.Red)
                            .Title("ic_first")
                            .Build()
            );
            models.Add(
                    new NavigationTabBar.Model.Builder(
                            Resources.GetDrawable(Resource.Drawable.ic_second, Theme),
                            Color.Blue)
                            .Title("ic_second")
                            .Build()
            );

            return models;
        }
    }
}

