CREATE DEFINER=`root`@`localhost` PROCEDURE `Register_sp`()
BEGIN
 SELECT 
    Register_Username, 
    Register_Allocate, 
    Register_Allocate, 
    Register_Email
FROM
    Regiser_Log
ORDER BY Login_Log ;
END