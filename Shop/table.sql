CREATE TABLE table_product
(
    id    INTEGER PRIMARY KEY AUTOINCREMENT,
    name  TEXT    NOT NULL CHECK ( name != '' ),
    stock INTEGER NOT NULL DEFAULT 0
);

CREATE TABLE table_price_history(
    id          INTEGER PRIMARY KEY AUTOINCREMENT,
    product_id  INTEGER NOT NULL,
    price       REAL NOT NULL CHECK (price >= 0),
    change_date TEXT    NOT NULL,
    FOREIGN KEY (product_id) REFERENCES table_product (id)
);

CREATE TABLE table_sales
(
    id         INTEGER PRIMARY KEY AUTOINCREMENT,
    product_id INTEGER NOT NULL,
    price_id INTEGER NOT NULL,
    buyer TEXT NOT NULL,
    sale_date  TEXT    NOT NULL,
    FOREIGN KEY (product_id) REFERENCES table_product (id),
    FOREIGN KEY (price_id) REFERENCES table_price_history (id),
    FOREIGN KEY (product_id, price_id) REFERENCES table_price_history (product_id, id)
);