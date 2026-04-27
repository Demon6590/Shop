CREATE VIEW view_product_stock AS
SELECT
    p.id AS id,
    p.name AS name,
    p.stock AS stock
FROM table_product p;

CREATE VIEW view_product_sales AS
SELECT
    s.id AS sale_id,         
    s.sale_date AS sale_date,  
    s.buyer AS buyer,
    p.name AS product_name, 
    ph.price AS sale_price 
FROM table_sales s  
         JOIN table_product p ON s.product_id = p.id
         JOIN table_price_history ph ON s.price_id = ph.id