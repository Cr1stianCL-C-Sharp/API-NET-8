/*  
 CREATE DATABASE my_database
 */
CREATE DATABASE IF NOT EXISTS my_database -- CREATE DATABASE
SHOW DATABASES -- SHOW DATABASES, must show my_database
USE my_database -- SET my_database To be used
/*  
 CREATE TABLE products
 */
CREATE TABLE IF NOT EXISTS products (
    productID INT UNSIGNED NOT NULL AUTO_INCREMENT,
    productCode CHAR(3) NOT NULL DEFAULT '',
    name VARCHAR(30) NOT NULL DEFAULT '',
    quantity INT UNSIGNED NOT NULL DEFAULT 0,
    price DECIMAL(7, 2) NOT NULL DEFAULT 99999.99,
    PRIMARY KEY (productID) -- SET productID AS Primmary Key
);

/*  
 SHOW CREATED TABLE products
 */
SHOW CREATE TABLE products