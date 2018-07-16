# Upgrading from v1

Things that changed between v1 and v2

1) Disposable and Toxic emails have been moved under the Do Not Mail Status with the appropiate sub-status
2) We added a free_email property to indicate if the email domain is a free email provider can be used for [fraud prevention]. 
3) We added a domain_age_days property, to let you know how old the domain is [fraud prevention]. 
4) We added the smtp_provider property for the email domain, this feature is in beta. 
5) We added the mx_found property, to let you know if the domain has an MX record
6) We added the mx_record property, to tell you the preferred MX record of the domain. 
7) We added the did_you_mean propery, which will be populated if a typo is detected. 
8) apiKey changed to api_key
9) IPAddress changed to ip_address
10) The validatewithip method was removed, it's now part of the validate method
11) The location property was removed (wasn't being used)
12) The creation date property was removed (wasn't being used)
13) processedat property is now processed_at
14) We added a new sub-status called "role_based_catch_all"

