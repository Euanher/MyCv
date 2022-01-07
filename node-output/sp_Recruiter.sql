CREATE PROCEDURE sp_Recruiter()
BEGIN
 SELECT 
    Recruiter_name, 
    Recruiter_Email, 
   Recruiter_ContactNUM,
   Recruiter_Appointment(TIMEDATE)
   
FROM
  Recruiter_Log
ORDER BY idRecruiter_Log;
END