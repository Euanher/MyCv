CREATE PROCEDURE Allocate_sp()
BEGIN
    SELECT 
        SUM(User_Log ) 
    FROM Register_Log;
END