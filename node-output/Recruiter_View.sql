CREATE VIEW Recruiter_View AS
SELECT User_name, User_email, User_password, User_Appointment
FROM idRecruiter_Log
WHERE Recruiter_Log