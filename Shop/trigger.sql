CREATE TRIGGER trg_decrease_stock
    AFTER INSERT ON table_sales
    FOR EACH ROW
BEGIN
    UPDATE table_product
    SET stock = stock - 1
    WHERE id = NEW.product_id
      AND stock > 0;
END;