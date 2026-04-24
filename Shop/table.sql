CREATE TABLE table_price(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    price INTEGER CHECK ( price >= 0),
    issue_date TEXT NOT NULL
        
);

CREATE TABLE table_product
(
    id                 INTEGER PRIMARY KEY AUTOINCREMENT,
    name               TEXT    NOT NULL CHECK ( name != '' ),
    id_price_per_piece INTEGER NOT NULL ,
    stock              INTEGER NOT NULL DEFAULT 0,
    FOREIGN KEY (id_price_per_piece) REFERENCES table_price(id)
);
