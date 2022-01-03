CREATE PROCEDURE Register_Log()
BEGIN
 SELECT 
    Register_Username, 
    Register_Allocate, 
    Register_Allocate, 
    Register_Email, 
    country
FROM
    customers
ORDER BY customerName;
END