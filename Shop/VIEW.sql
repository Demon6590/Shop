CREATE VIEW view_stock AS
SELECT p.id,
       p.name,
       p.stock AS available_stock
FROM table_product p;

CREATE VIEW view_single_sales AS
SELECT s.id   AS sale_id,
       s.sale_date,
       s.buyer,
       p.name AS product_name
FROM table_sales s
         JOIN table_product p ON s.product_id = p.id;