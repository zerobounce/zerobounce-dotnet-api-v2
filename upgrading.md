# Upgrading from v1

Things that changed between v1 and v2

These are the items that changed between v1 and v2.

1) Disposable and Toxic emails have been moved under the do_not_mail status with the appropriate sub-status (toxic, disposable)
2) The "DoNotMail" status was changed to "do_not_mail"
3) All statuses are now lowercase, instead of mixed case.
4) We added a free_email property to indicate if the email domain is a free email provider can be used for [fraud prevention]. 
5) We added a domain_age_days property, to let you know how old the domain is [fraud prevention]. 
6) We added the smtp_provider property for the email domain, this feature is in beta. 
7) We added the mx_found property, to let you know if the domain has an MX record
8) We added the mx_record property, to tell you the preferred MX record of the domain. 
9) We added the did_you_mean property, which will be populated if a typo is detected with a suggested correction. 
10) apiKey property was changed to api_key
11) IPAddress property was changed to ip_address
12) The validatewithip method was removed, it's now part of the validate method
13) The location property was removed (wasn't being used)
14) The creation_date property was removed (wasn't being used)
15) processedat property is now processed_at
16) We added a new sub-status called "role_based_catch_all"

