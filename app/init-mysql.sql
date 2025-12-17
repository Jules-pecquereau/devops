CREATE database IF NOT EXISTS forecast;
USE forecast;
CREATE TABLE IF NOT EXISTS forecasts (
    id char(36) NOT NULL PRIMARY KEY,
    city varchar(255) NOT NULL,
    temperate FLOAT NOT NULL DEFAULT 0
);

INSERT INTO forecasts VALUES
    ('e86ee917-e973-46b6-8fbd-773a982676d1', 'Saint-Nazaire', 11),
    ('b0f4b35a-5140-4b5e-9304-4473c8991148', 'Saint-Berthevin', 9),
    ('7bdd8bff-f4f6-45d4-9a53-88de91ad289f', 'Paris', 50.4),
    ('0212d319-e470-4546-8938-d844f5a0137c', 'Lille', -12.79)
;