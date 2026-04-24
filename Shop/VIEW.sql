CREATE VIEW view_product_stock_and_sales AS
SELECT p.id          AS product_id,
       p.name        AS product_name,
       p.stock       AS current_stock,
       tp.price      AS current_price,
       tp.issue_date AS price_issue_date
FROM table_product p
         JOIN table_price tp
              ON p.id_price_per_piece = tp.id;  

