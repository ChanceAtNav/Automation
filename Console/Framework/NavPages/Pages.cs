
namespace Framework.NavPages
{
    public class Pages
    {
        public static LoginPage Login;
        public static DashboardPage Dashboard;
        //public static BusinessLauncherPage BusinessLauncher;
        public static DisputesPage Disputes;

        public Pages()
        {
            Login = new LoginPage();
            Dashboard = new DashboardPage();
            //BusinessLauncher = new  BusinessLauncherPage();
            Disputes = new DisputesPage();
        }
    }
}
