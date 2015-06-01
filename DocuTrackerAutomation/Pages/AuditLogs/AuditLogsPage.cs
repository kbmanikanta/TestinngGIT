using DocuTrackerAutomation.Navigation;

namespace DocuTrackerAutomation.Pages.AuditLogs
{
    public class AuditLogsPage
    {
        public static void GotoViewAuditLogs()
        {
            LeftNavigation.AuditLogs.ViewAuditLogs.Select();
        }

        public static void GotoGeneralLogs()
        {
            LeftNavigation.AuditLogs.ViewGeneralLogs.Select();
        }

        public static void GotoExceptions()
        {
            LeftNavigation.AuditLogs.ViewExceptions.Select();
        }

        public static void GotoAmmendedISDAAgreements()
        {
            LeftNavigation.AuditLogs.AmendedISDAAgreements.Select();
        }

        public static void GotoAmmendedPBAgreements()
        {
            LeftNavigation.AuditLogs.AmmendedPBAgreements.Select();
        }
    }
}
