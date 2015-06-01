using DocuTrackerAutomation.Navigation;

namespace DocuTrackerAutomation.Pages.AgreementSettingspage
{
    public class AgreementsPage
    {
        public static void GotoCreateCounterparty()
        {
            LeftNavigation.Agreements.CreateCounterparty.Select();
        }

        public static void GotoISDADocumentTypesforUploading()
        {
            LeftNavigation.Agreements.DocumentTypes.Select();
        }

        public static void GotoUnlockISDAAgreements()
        {
            LeftNavigation.Agreements.UnlockISDAAgreements.Select();
        }

        public static void GotoReopenApprovedISDA()
        {
            LeftNavigation.Agreements.ReopenApprovedISDA.Select();
        }

        public static void GotoCounterpartiesList()
        {
            LeftNavigation.Agreements.CounterpartiesList.Select();
        }

        public static void GotoAffiliate()
        {
            LeftNavigation.Agreements.Affiliate.Select();
        }

        public static void GotoISDAAffiliateEntities()
        {
            LeftNavigation.Agreements.ISDAAffiliateEntities.Select();
        }

        public static void GotoPBDocumentTypesforUploading()
        {
            LeftNavigation.Agreements.DocumentTypesforUploading.Select();
        }

        public static void GotoUnlockPBAgreements()
        {
            LeftNavigation.Agreements.UnlockPBAgreements.Select();
        }

        public static void GotoReopenApprovedPB()
        {
            LeftNavigation.Agreements.ReopenApprovedPB.Select();
        }

        public static void GotoCreatePBEntity()
        {
            LeftNavigation.Agreements.CreatePBEntity.Select();
        }

        public static void GotoPBCounterpartiesList()
        {
            LeftNavigation.Agreements.PBCounterpartiesList.Select();
        }
    }
}
