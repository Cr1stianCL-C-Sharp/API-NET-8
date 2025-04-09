/*  
 USE DATABASE my_database
 */
USE my_database
/*  
 INSERT DATA INTO TABLE CALLED products inside my_database
 */
INSERT INTO
    products (productCode, name, quantity, price)
VALUES
    ('CRO', 'Pencil 2B', 10000, 0.27),
    ('NOT', 'notebook college', 10000, 0.48),
    ('NOT', 'notebook classic', 10000, 0.48),
    ('BOK', 'english learning book', 10000, 6.99),
    ('BOK', 'french learning book', 10000, 5.99),
    ('CRO', 'eraser standard', 10000, 0.23),
    ('CRO', 'pen', 10000, 0.28),
    ('CRO', 'scissors', 10000, 0.35),
    ('CRO', 'glue', 10000, 0.20),
    ('CRO', 'sharpener', 10000, 0.22),
    ('CRO', 'chalk', 10000, 0.22),
    ('CRO', 'ruber', 8000, 0.49);

/*  
 SELECT ALL THE DATA INSIDE products
 */
select
    *
from
    products p