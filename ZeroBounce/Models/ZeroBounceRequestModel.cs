using System;


namespace ZeroBounce.Models
{
    public class ZeroBounceResultsModel
    {
        public string address { get; set; } //email address being validated
        public string status { get; set; } //: "[Valid |Invalid |Catch-All |Unknown |Spamtrap |Abuse |DoNotMail]"
        public string sub_status { get; set; } //: "[antispam_system |greylisted |mail_server_temporary_error |forcible_disconnect |mail_server_did_not_respond |timeout_exceeded |failed_smtp_connection |mailbox_quota_exceeded |exception_occurred |possible_traps |role_based |global_suppression |mailbox_not_found |no_dns_entries |failed_syntax_check |possible_typo |unroutable_ip_address |leading_period_removed |does_not_accept_mail ]"
        public string account { get; set; } //:  "portion before the @ symbol" 
        public string domain { get; set; } //: "portion after the @ symbol"
        public Boolean free_email { get; set; } //: If the email comes from a Free Provider true/false
        public string did_you_mean { get; set; } //: Suggestive Fix for an email typo true/false
        public string domain_age_days { get; set; } //: Age of the email domain in days, can be null
        public Boolean mx_found { get; set; } //: Did the domain have an MX record true/false
        public string mx_record { get; set; } //: The preferred MX record of the domain
        public string smtp_provider { get; set; } //: The SMTP Provider of the email
        public string firstName { get; set; } //: email owner's first name if available
        public string lastName { get; set; } //: email owner's last name if available
        public string gender { get; set; } //: email owner's gender if available
        public string country { get; set; } //: the country of the IP passed in
        public string region { get; set; } //: the region of the IP passed in
        public string city { get; set; } //: the city of the IP passed in
        public string zipcode { get; set; } //: the zipcode of the IP passed in
        public string processed_at { get; set; } //: "UTC time email was validated"
        public string error { get; set; } //: Error Message 
    }
}
