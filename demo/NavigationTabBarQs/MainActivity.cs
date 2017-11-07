using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Graphics;
using Devlight.IO.Library.Ntb;
using static Devlight.IO.Library.Ntb.NavigationTabBar;

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
            toolbar.IsBadged = true;
            toolbar.SetBadgeGravity(BadgeGravity.Bottom);
            toolbar.SetBadgePosition(BadgePosition.Center);
            toolbar.BadgeBgColor = Color.Yellow; 
        }

        IList<NavigationTabBar.Model> GetModels()
        {
            List<NavigationTabBar.Model> models = new List<NavigationTabBar.Model>();
            var model = new NavigationTabBar.Model.Builder(
                            Resources.GetDrawable(Resource.Drawable.ic_first, Theme),
                            Color.Red)
                            .Title("ic_first")
                            .BadgeTitle("Quynh Anh")
                            .Build();
            model.ShowBadge();
            models.Add(model);
            models.Add(
                    new NavigationTabBar.Model.Builder(
                            Resources.GetDrawable(Resource.Drawable.ic_second, Theme),
                            Color.Blue)
                            .BadgeTitle("Thuy Linh")
                            .Title("ic_second")
                            .Build()
            );

            return models;
        }
    }
}

