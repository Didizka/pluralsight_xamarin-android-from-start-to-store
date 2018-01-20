using Android.OS;
using Android.Views;

namespace RaysHotDogs.Fragments
{
    public class VeggieLoversFragment : BaseFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            FindViews();

            HandleEvents();

            hotDogs = hotDogDataService.GetHotDogsForGroup(2);
            listView.Adapter = new HotDogListAdapter(this.Activity, hotDogs);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.VeggieLoversFragment, container, false);
        }
    }
}