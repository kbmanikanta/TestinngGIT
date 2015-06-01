
namespace DocuTrackerAutomation.Navigation
{
    public class LeftNavigation
    {
        public class SearchAgreements
        {
            public class ExecutedAgreements
            {
                public static void Select()
                {
                    MenuSelector.Select("Search Agreements", "Executed Agreements");
                }
            }
            public class NegotiationDrafts
            {
                public static void Select()
                {
                    MenuSelector.Select("Search Agreements", "Negotiation Drafts");
                }
            }
        }

        public class ManageAgreements
        {
            public class CreateNewISDAAgreements
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "ISDA Agreements", "Create New ISDA Master Agreement");
                }
            }
            public class BenchMarkISDATerms
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "ISDA Agreements", "Input/View Benchmark ISDA Terms");
                }
            }
            public class ISDATrackingWorkflow
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "ISDA Agreements", "ISDA Agreement - Tracking Workflow");
                }
            }
            public class ISDAApprovedTrackingWorkflow
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "ISDA Agreements", "ISDA Approved Agreement - Tracking Workflow");
                }
            }
            public class UploadISDAAgreements
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "ISDA Agreements", "Upload ISDA Agreements");
                }
            }
            public class CreateISDANegotiationDrafts  
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "ISDA Negotiation Drafts", "Create New ISDA Negotiation Draft");
                }
            }
            public class ISDANegotiationDraftTrackingWorkflow
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "ISDA Negotiation Drafts", "ISDA Negotiation Draft Workflow");
                }
            }
            public class CreateNewPBAgreement  
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "PB Agreements", "Create New PB Agreement");
                }
            }
            public class BenchmarkPBTerms
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "PB Agreements", "Input/View Benchmark PB Terms");
                }
            }
            public class PBAgreementTrackingWorkflow
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "PB Agreements", "PB Agreement - Tracking Workflow");
                }
            }
            public class PBApprovedTrackingWorkflow
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "PB Agreements", "PB Approved Agreement - Tracking Workflow");
                }
            }
            public class UploadPBAgreements
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "PB Agreements", "Upload PB Agreements");
                }
            }
            public class CreatePBNegotiationDraft
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "PB Negotiation Drafts", "Create New PB Negotiation Draft");
                }
            }
            public class PBNegotiationDraftWorkflow
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "PB Negotiation Drafts", "PB Negotiation Draft Workflow");
                }
            }
            public class  TemplateAgreementTerms
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "Template Agreements", "Template Agreement Terms");
                }
            }
            public class CopyTemplatetoTemplate
            {
                public static void Select()
                {
                    MenuSelector.Select("Manage Agreements", "Template Agreements", "Copy Template to Template");
                }
            }
        }

        public class Reports
        {
            public class ISDAReports
            {
                public static void Select()
                {
                    MenuSelector.Select("Reports", "Predefined Reports", "ISDA Reports");
                }
            }
            public class PBReports  
            {
                public static void Select()
                {
                    MenuSelector.Select("Reports", "Predefined Reports", "PB Reports");
                }
            }
            public class GenerateReport
            {
                public static void Select()
                {
                    MenuSelector.Select("Reports", "Custom Reports", "Generate Report");
                }
            }
            public class SavedReports
            {
                public static void Select()
                {
                    MenuSelector.Select("Reports", "Custom Reports", "Saved Reports");
                }
            }
            public class CustomReports
            {
                public static void Select()
                {
                    MenuSelector.Select("Custom Report");
                }
            }
            public class Tree
            {
                public static void Select1()
                {
                    MenuSelector.Select1("LoadingTree");
                }
            }
            public class CreatePredefinedReports
            {
                public static void Select()
                {
                    MenuSelector.Select("Create Predefined Report");
                }
            }
        }

        public class Clients
        {
            public class VIPAccess
            {
                public static void Select()
                {
                    MenuSelector.Select("Clients", "VIP Access");
                }
            }
        }

        public class Agreements
        {
            public class CreateCounterparty
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "Create Counterparty");
                }
            }
            public class DocumentTypes
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "ISDA Agreements", "Document Types for Uploading");
                }
            }
            public class UnlockISDAAgreements
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "ISDA Agreements", "Unlock Locked ISDA Agreements");
                }
            }
            public class ReopenApprovedISDA
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "ISDA Agreements", "Reopen Approved ISDA Agreements");
                }
            }
            public class CounterpartiesList
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "ISDA Agreements", "Counterparties List");
                }
            }
            public class Affiliate
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "ISDA Agreements", "Affiliate");
                }
            }
            public class ISDAAffiliateEntities
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "ISDA Agreements", "Affiliate Entities");
                }
            }
            public class DocumentTypesforUploading
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "PB Agreements", "Document Types for Uploading");
                }
            }
            public class UnlockPBAgreements
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "PB Agreements", "Unlock Locked PB Agreements");
                }
            }
            public class ReopenApprovedPB
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "PB Agreements", "Reopen Approved PB Agreements");
                }
            }
            public class CreatePBEntity
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "PB Agreements", "Create Prime Broker Entity");
                }
            }
            public class PBCounterpartiesList
            {
                public static void Select()
                {
                    MenuSelector.Select("Agreement Settings", "PB Agreements", "Counterparties List");
                }
            }
        }

        public class UserManagement
        {
            public class RegisterDemoClientLogin
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Demo Client Logins", "Register Demo Client Login");
                }
            }
            public class DemoClientLoginList
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Demo Client Logins", "Demo Client Login List");
                }
            }
            public class RegisterClientLogin
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Client Logins", "Register Client Login");
                }
            }
            public class ClientLoginList
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Client Logins", "Client Login List");
                }
            }
            public class RegisterEmployee
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Employees", "Register Employee");
                }
            }
            public class EmployeeList
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Employees", "Employee List");
                }
            }
            public class VIPAccess
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Employees", "VIP Access");
                }
            }
            public class RegisterSubadmin
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Sub Admins", "Register Subadmin");
                }
            }
            public class SubadminList
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Sub Admins", "Subadmin List");
                }
            }
            public class RegisterMasteradmin
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Master Admins", "Register Master Admin");
                }
            }
            public class MasterAdminList
            {
                public static void Select()
                {
                    MenuSelector.Select("User Management", "Master Admins", "Master Admin List");
                }
            }
        }

        public class AccountSettings
        {
            public class Profile
            {
                public static void Select()
                {
                    MenuSelector.Select("Account Settings", "Profile");
                }
            }
            public class ChangePassword
            {
                public static void Select()
                {
                    MenuSelector.Select("Account Settings", "Change Password");
                }
            }
        }

        public class ArchiveDelete
        {
            public class ClientArchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Client", "Archive");
                }
            }
            public class ClientUnarchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Client", "Unarchive");
                }
            }
            public class ClientEntityArchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Client Entity", "Archive");
                }
            }
            public class ClientEntityUnarchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Client Entity", "Unarchive");
                }
            }
            public class ISDAArchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Agreements", "ISDA Archive");
                }
            }
            public class ISDANegotiationDraftArchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Agreements", "ISDA Negotiation Draft Archive");
                }
            }
            public class PBArchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Agreements", "PB Archive");
                }
            }
            public class PBNegotiationDraftArchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Agreements", "PB Negotiation Draft Archive");
                }
            }
            public class ISDAUnarchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Agreements", "ISDA Unarchive");
                }
            }
            public class ISDANegotiationDraftUnarchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Agreements", "ISDA Negotiation Draft Unarchive");
                }
            }
            public class PBUnarchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Agreements", "PB Unarchive");
                }
            }
            public class PBNegotiaitonDraftUnarchive
            {
                public static void Select()
                {
                    MenuSelector.Select("Archive & Delete", "Agreements", "PB Negotiation Draft Unarchive");
                }
            }
        }

        public class AuditLogs
        {
            public class ViewAuditLogs
            {
                public static void Select()
                {
                    MenuSelector.Select("Audit Logs", "View Audit Logs");
                }
            }
            public class ViewGeneralLogs
            {
                public static void Select()
                {
                    MenuSelector.Select("Audit Logs", "View General Logs");
                }
            }
            public class ViewExceptions
            {
                public static void Select()
                {
                    MenuSelector.Select("Audit Logs", "View Exceptions");
                }
            }
            public class AmendedISDAAgreements
            {
                public static void Select()
                {
                    MenuSelector.Select("Audit Logs", "Amended Agreements", "Amended ISDA Agreements");
                }
            }
            public class AmmendedPBAgreements
            {
                public static void Select()
                {
                    MenuSelector.Select("Audit Logs", "Amended Agreements", "Amended PB Agreements");
                }
            }
        }

    }
}
