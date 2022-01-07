CREATE PROCEDURE sp_Login()
BEGIN
 SELECT 
    Login_name, 
    Login_Email, 
    Login_UserorRecruiter(REGISER) 
   
FROM
    Login_Log
ORDER BY idLogin;
END