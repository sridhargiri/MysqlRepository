create database MyTestDb;
use MyTestDb;
CREATE TABLE IF NOT EXISTS Players (
    PlayerID INT AUTO_INCREMENT PRIMARY KEY,
    PlayerName VARCHAR(100) NOT NULL,
    Kills INT NOT NULL,
    Score INT NOT NULL,
    `Rank` INT NOT NULL,
    MatchTime Datetime NOT NULL);