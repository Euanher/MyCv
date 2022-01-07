CREATE DEFINER=`root`@`localhost` PROCEDURE `Recruiter_sp`()
BEGIN
 SELECT 
    Recruiter_Name, 
    Recruiter_Email, 
    Recruiter_ContactNUM, 
    Register_Email, 
    Recruiter_Appointmentdate
FROM
    Recruiter_Log
ORDER BY Recruiter_Name;
END