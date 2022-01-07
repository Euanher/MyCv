CREATE VIEW Login_View AS
SELECT
    idLogin,
        name,
        Email,
        User,
        Recruiter
   
FROM
    Login_View
INNER JOIN User USING (idUser_Logcol)
INNER JOIN Recruiter USING (idRecruiter_Log)
GROUP BY    Routines3