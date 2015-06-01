using DocuTrackerAutomation.Navigation;

namespace DocuTrackerAutomation.Pages.ArchivendDeletePage
{
    public class ArchivePage
    {
        public static void GotoClientArchive()
        {
            LeftNavigation.ArchiveDelete.ClientArchive.Select();
        }

        public static void GotoClientUnarchive()
        {
            LeftNavigation.ArchiveDelete.ClientUnarchive.Select();
        }

        public static void GotoClientEntityArchive()
        {
            LeftNavigation.ArchiveDelete.ClientEntityArchive.Select();
        }

        public static void GotoClientEntityUnarchive()
        {
            LeftNavigation.ArchiveDelete.ClientEntityUnarchive.Select();
        }

        public static void GotoISDAArchive()
        {
            LeftNavigation.ArchiveDelete.ISDAArchive.Select();
        }

        public static void GotoISDANegotiationDraftArchive()
        {
            LeftNavigation.ArchiveDelete.ISDANegotiationDraftArchive.Select();
        }

        public static void GotoPBArchive()
        {
            LeftNavigation.ArchiveDelete.PBArchive.Select();
        }

        public static void GotoPBNegotiationDraftArchive()
        {
            LeftNavigation.ArchiveDelete.PBNegotiationDraftArchive.Select();
        }

        public static void GotoISDAUnarchive()
        {
            LeftNavigation.ArchiveDelete.ISDAUnarchive.Select();
        }

        public static void GotoISDANegotiationDraftUnarchive()
        {
           LeftNavigation.ArchiveDelete.ISDANegotiationDraftUnarchive.Select();
        }

        public static void GotoPBUnarchive()
        {
         LeftNavigation.ArchiveDelete.PBUnarchive.Select();
        }

        public static void GotoPBNegotiationDraftUnarchive()
        {
           LeftNavigation.ArchiveDelete.PBNegotiaitonDraftUnarchive.Select();
        }
    }
}
