CREATE PROCEDURE GetAllLogin_Log()
BEGIN
	SELECT Login_Log, User_Log, Register_Log, Recruiter_Log
    FROM mydb group by('schema(Table)' 'Values in database(mydb)' in (mySQL));
END