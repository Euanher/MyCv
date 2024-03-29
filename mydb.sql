-- MySQL Script generated by MySQL Workbench
-- Fri Jan  7 22:28:18 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- https://virtserver.swaggerhub.com/Euanher/MyCV/1.0.0
DROP SCHEMA IF EXISTS `mydb` ;

-- -----------------------------------------------------
-- Schema mydb
--
-- https://virtserver.swaggerhub.com/Euanher/MyCV/1.0.0
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin ;
SHOW WARNINGS;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `Login_Log`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Login_Log` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Login_Log` (
  `idLogin_Log` BIGINT(100) GENERATED ALWAYS AS (PRIMARY),
  `Login_Name` VARCHAR(45) CHARACTER SET 'utf8' COLLATE 'utf8_bin' GENERATED ALWAYS AS (NULL) VIRTUAL,
  `Login_Email` VARCHAR(45) CHARACTER SET 'utf8' COLLATE 'utf8_bin' GENERATED ALWAYS AS (NULL) VIRTUAL,
  `Login_Password` VARCHAR(45) GENERATED ALWAYS AS (NULL) VIRTUAL,
  PRIMARY KEY (`idLogin_Log`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Recruiter_Log`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Recruiter_Log` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Recruiter_Log` (
  `idRecruiter_Log` BIGINT(100) GENERATED ALWAYS AS () VIRTUAL,
  `Recruiter_Username` VARCHAR(25) CHARACTER SET 'utf8' COLLATE 'utf8_bin' GENERATED ALWAYS AS (NULL) STORED,
  `Recruiter_Password` VARCHAR(45) GENERATED ALWAYS AS () STORED,
  `Recruiter_ConNum` VARCHAR(45) NULL,
  PRIMARY KEY (`idRecruiter_Log`))
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE UNIQUE INDEX `Recruiter_Password_UNIQUE` ON `Recruiter_Log` (`Recruiter_Password` ASC) VISIBLE;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Register_Log`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Register_Log` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Register_Log` (
  `idRegister_Log` BIGINT(100) GENERATED ALWAYS AS (PRIMARY) VIRTUAL,
  `Register_Name` VARCHAR(45) CHARACTER SET 'utf8' COLLATE 'utf8_bin' GENERATED ALWAYS AS (NULL) VIRTUAL,
  `Register_Email` VARCHAR(45) CHARACTER SET 'utf8' COLLATE 'utf8_bin' GENERATED ALWAYS AS (NULL) VIRTUAL,
  `Register_Password` VARCHAR(45) CHARACTER SET 'utf8' COLLATE 'utf8_bin' GENERATED ALWAYS AS (NULL) STORED,
  PRIMARY KEY (`idRegister_Log`))
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE UNIQUE INDEX `Register_Name_UNIQUE` ON `Register_Log` (`Register_Name` ASC) VISIBLE;

SHOW WARNINGS;
CREATE UNIQUE INDEX `Register_Email_UNIQUE` ON `Register_Log` (`Register_Email` ASC) VISIBLE;

SHOW WARNINGS;
CREATE UNIQUE INDEX `Register_Passwordl_UNIQUE` ON `Register_Log` (`Register_Password` ASC) VISIBLE;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `User_Log`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `User_Log` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `User_Log` (
  `idUser_Log` BIGINT(100) GENERATED ALWAYS AS (PRIMARY) STORED,
  `User_Name` BIGINT(100) GENERATED ALWAYS AS (),
  `User_Email` VARCHAR(45) CHARACTER SET 'utf8' COLLATE 'utf8_bin' GENERATED ALWAYS AS (NULL) STORED,
  `User_Password` VARCHAR(45) CHARACTER SET 'utf8' COLLATE 'utf8_bin' GENERATED ALWAYS AS (NULL) STORED,
  `User_Questions` VARCHAR(45) CHARACTER SET 'utf8' COLLATE 'utf8_bin' GENERATED ALWAYS AS (NULL) STORED,
  PRIMARY KEY (`idUser_Log`))
ENGINE = InnoDB;

SHOW WARNINGS;
CREATE UNIQUE INDEX `Use_Email_UNIQUE` ON `User_Log` (`User_Email` ASC) VISIBLE;

SHOW WARNINGS;
CREATE UNIQUE INDEX `Use_Logcol_UNIQUE` ON `User_Log` (`User_Password` ASC) VISIBLE;

SHOW WARNINGS;
CREATE UNIQUE INDEX `User_Questions_UNIQUE` ON `User_Log` (`User_Questions` ASC) VISIBLE;

SHOW WARNINGS;
CREATE UNIQUE INDEX `User_Name_UNIQUE` ON `User_Log` (`User_Name` ASC) VISIBLE;

SHOW WARNINGS;
USE `mydb` ;

-- -----------------------------------------------------
-- procedure sp_name
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `sp_name`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
CREATE PROCEDURE sp_name()
BEGIN
 
END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- procedure sp_Login
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `sp_Login`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
CREATE PROCEDURE sp_Login()
BEGIN
 SELECT 
    Login_name, 
    Login_Email, 
    Login_UserorRecruiter(REGISER) 
   
FROM
    Login_Log
ORDER BY idLogin;
END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- procedure GetAllLogin_Log
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `GetAllLogin_Log`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
CREATE PROCEDURE GetAllLogin_Log()
BEGIN
	SELECT Login_Log, User_Log, Register_Log, Recruiter_Log
    FROM mydb group by('schema(Table)' 'Values in database(mydb)' in (mySQL));
END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- procedure GetAllid
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `GetAllid`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
CREATE PROCEDURE GetAllid()
BEGIN
	SELECT 
 
    idRegister_Log, 
   idUser_Log,
   idRecruiter_Log

      FROM MySQLLocaldb   
ORDER BY  idLogin_Logcol,

END;
    
 

END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- procedure sp_Register
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `sp_Register`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
CREATE PROCEDURE sp_Register()
BEGIN
 SELECT 
    Register_Name, 
    Register_Email, 
   Register_ContactNUM
   
FROM
    Register_Log
ORDER BY idRegister_Log;
END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- procedure sp_User
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `sp_User`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
CREATE PROCEDURE sp_User()
BEGIN
 SELECT 
    User_name, 
    User_email, 
   User_password,
   User_QUESTION
   
FROM
    User_Log
ORDER BY idUser_Logcol;
END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- procedure sp_Recruiter
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `sp_Recruiter`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
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
END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- procedure Allocate_sp
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `Allocate_sp`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Allocate_sp`()
BEGIN
    SELECT 
        SUM(User_Log ) 
    FROM Register_Log;
END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- procedure Recruiter_sp
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `Recruiter_sp`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Recruiter_sp`()
BEGIN
 SELECT 
    Recruiter_Name, 
    Recruiter_Email, 
    Recruiter_ContactNUM, 
    Register_Email, 
    Recruiter_Appointmentdate
FROM
    Recruiter_Log
ORDER BY Recruiter_Name;
END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- procedure Register_sp
-- -----------------------------------------------------

USE `mydb`;
DROP procedure IF EXISTS `Register_sp`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Register_sp`()
BEGIN
 SELECT 
    Register_Username, 
    Register_Allocate, 
    Register_Allocate, 
    Register_Email
FROM
    Regiser_Log
ORDER BY idLogin_Logcol ;
END$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
--  routine1
-- -----------------------------------------------------

USE `mydb`;
DROP  IF EXISTS `routine1`;
SHOW WARNINGS;

DELIMITER $$
USE `mydb`$$
$$

DELIMITER ;
SHOW WARNINGS;

-- -----------------------------------------------------
-- View `Register_Replace`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `Register_Replace` ;
SHOW WARNINGS;
USE `mydb`;
CREATE OR REPLACE VIEW Register_Replace AS
SELECT Register_Name, Register_Email, Register_Email
FROM idRegister_Log
WHERE Register_Log  = 'Register_Name';
output
 
use idRegister_Replace 
INNER JOIN User USING (idUser_Logcol)
INNER JOIN Register USING (idRegister_Log)
GROUP BY    Routine;

return Register View values to [idRegister_Log] from REPLACE view;

drop select view Register_Replace;
SHOW WARNINGS;

-- -----------------------------------------------------
-- View `Recruiter_View`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `Recruiter_View` ;
SHOW WARNINGS;
USE `mydb`;
CREATE  OR REPLACE VIEW Recruiter_View AS
SELECT
 Recruiter_name,
 Recruiter_email, 
 Recruiter_password, 
 Recruiter_Appointment
FROM idRecruiter_Log
INNER JOIN User USING (idlogin_Logcol)
INNER JOIN Recruiter USING (idRecruiter_Log)
GROUP BY    Routine;

return Recruiter view from group Routine;

drop select View Recruiter_View;
SHOW WARNINGS;

-- -----------------------------------------------------
-- View `User_Replace`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `User_Replace` ;
SHOW WARNINGS;
USE `mydb`;
CREATE OR REPLACE VIEW User_Replace AS
SELECT User_Name, User_Email, User_Email, User_Question
FROM idRegister_Log
WHERE User_Log  = 'User_Name';
output
 
use idUser_Replace
INNER JOIN User USING (idRegister_Log)
INNER JOIN Login_Log USING (idLogin_Logcol)
GROUP BY    Routine;

return User View values to [idUser_Log] from REPLACE view;

drop select view User_Replace;
SHOW WARNINGS;

-- -----------------------------------------------------
-- View `Register_View`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `Register_View` ;
SHOW WARNINGS;
USE `mydb`;
CREATE OR REPLACE VIEW Register_View AS
SELECT User_name, 
User_email, 
User_password, 
User_QUESTION
FROM idUser_Logcol
INNER JOIN Register USING (idLogin_Logcol)
INNER JOIN Recruiter USING (idRecruiter_Log)
INNER JOIN User USING (idUser_Logcol)
GROUP BY    Routine;

return User view by group Routine;

drop select view Register_View;
SHOW WARNINGS;

-- -----------------------------------------------------
-- View `Login_View`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `Login_View` ;
SHOW WARNINGS;
USE `mydb`;
CREATE  OR REPLACE VIEW Login_View AS
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
GROUP BY    Routine;

return Login View from Routine;

drop select view Login_View;
SHOW WARNINGS;

-- -----------------------------------------------------
-- View `User_View`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `User_View` ;
SHOW WARNINGS;
USE `mydb`;
CREATE  OR REPLACE VIEW User_View AS
SELECT 
User_name,
 User_email, 
 User_password,
 User_QUESTION
FROM User_Log
INNER JOIN Login_Log USING (idLogin_Logcol)
INNER JOIN User_Log USING (idUser_Log)
GROUP BY    Routine;

return User view from group Routine;

drop select view User_View;
SHOW WARNINGS;

-- -----------------------------------------------------
-- View `Recruiter_Replace`
-- -----------------------------------------------------
DROP VIEW IF EXISTS `Recruiter_Replace` ;
SHOW WARNINGS;
USE `mydb`;
CREATE OR REPLACE VIEW Recruiter_Replace AS
SELECT Recruiter_Name, Recruiter_Email, Recruiter_Email, Recruiter_Appointment
FROM idRegister_Log
WHERE idRecruiter_Log  = 'Recruiter_Name';

output
 
use idRecruiter_Log
INNER JOIN User USING (idUser_Logcol)
INNER JOIN Recruiter USING (idRecruiter_Log)
GROUP BY    Routine;

return Recruiter View values to [idRecruiter_Log] from REPLACE view;

drop select view Recruiter_Replace;
SHOW WARNINGS;
SET SQL_MODE = '';
DROP USER IF EXISTS Owner;
SET SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';
SHOW WARNINGS;
CREATE USER 'Owner' IDENTIFIED BY 'Euanher0721';

GRANT ALL ON * TO 'Owner';
GRANT SELECT, INSERT, TRIGGER ON TABLE * TO 'Owner';
GRANT SELECT, INSERT, TRIGGER, UPDATE, DELETE ON TABLE * TO 'Owner';
GRANT EXECUTE ON ROUTINE * TO 'Owner';
SHOW WARNINGS;
SET SQL_MODE = '';
DROP USER IF EXISTS user1;
SET SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';
SHOW WARNINGS;
CREATE USER 'user1';

GRANT SELECT ON TABLE * TO 'user1';
GRANT EXECUTE ON ROUTINE * TO 'user1';
SHOW WARNINGS;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
