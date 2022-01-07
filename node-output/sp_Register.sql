CREATE PROCEDURE sp_Register()
BEGIN
 SELECT 
    Register_Name, 
    Register_Email, 
   Register_ContactNUM
   
FROM
    Register_Log
ORDER BY idRegister_Log;
END