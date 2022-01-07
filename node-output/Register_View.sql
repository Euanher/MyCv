CREATE OR REPLACE VIEW Register_View AS
SELECT User_name, 
User_email, 
User_password, 
User_QUESTION
FROM idUser_Logcol
WHERE User_Log