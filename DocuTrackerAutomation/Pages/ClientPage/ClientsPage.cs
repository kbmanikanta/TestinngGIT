using DocuTrackerAutomation.Navigation;

namespace DocuTrackerAutomation.Pages.ClientPage
{
    public class ClientsPage
    {
        public static void GotoVIPAccess()
        {
            LeftNavigation.Clients.VIPAccess.Select();
        }
    }
}
