DELIMITER //

CREATE PROCEDURE Login(IN InputUsername VARCHAR(20), IN InputPass VARCHAR(15))
BEGIN
    SELECT u.ID, u.Username, u.FirstName, u.LastName, u.Phone, u.Email, u.Birthdate, u.UserRole
    FROM users AS u 
    WHERE u.Username = InputUsername
    AND u.Pass = InputPass 
    AND u.ActiveUser = 1; 
END //