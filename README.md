DVTA 2.0 
--------

DVTA is a Vulnerable Thick Client Application developed in C# .NET

Most of the vulnerabilities that were built into DVTA were found during my real world pentests.

Some of the vulnerabilities covered in this Application.
-------------------------------------------------------
    Insecure local data storage
    Insecure logging
    Weak cryptography
    Lack of code obfuscation
    Exposed decryption logic
    SQL Injection
    CSV Injection
    Sensitive data in memory
    DLL Hijacking
    Clear text data in transit
    Client side protection bypasses using Reverse Engineering

Requires .NET version 4.5

Usage:
------
1. Get the compiled binary from releases. Alternatively, clone the project and compile from the source.
2. Set up SQL Server and FTP Server - instructions shown here https://youtu.be/rx8mtI1HU5c

        Queries used in the video:

        QUERY TO CREATE "USERS" TABLE:

        CREATE TABLE "users" (
            "id" INT IDENTITY(0,1) NOT NULL,
            "username" VARCHAR(100) NOT NULL,
            "password" VARCHAR(100) NOT NULL,
            "email" VARCHAR(100) NULL DEFAULT NULL,
            "isadmin" INT NULL DEFAULT '0',
            PRIMARY KEY ("id")
        )


        QUERY TO INSERT DATA INTO "USERS" TABLE:

        INSERT INTO dbo.users (username, password, email, isadmin)
        VALUES
        ('admin','admin123','admin@damnvulnerablethickclientapp.com',1),
        ('rebecca','rebecca','rebecca@test.com',0),
        ('raymond','raymond','raymond@test.com',0);


        QUERY TO CREATE "EXPENSES" TABLE:

        CREATE TABLE "expenses" (
            "id" INT IDENTITY(0,1) NOT NULL,
            "email" VARCHAR(100) NOT NULL,
            "item" VARCHAR(100) NOT NULL,
            "price" VARCHAR(100) NOT NULL,
            "date" VARCHAR(100) NOT NULL,
            "time" VARCHAR(100) NULL DEFAULT NULL,
            PRIMARY KEY ("id")
        )


3. Configure the client application to communicate with SQL Server and FTP Server - Instructions shown here https://youtu.be/IBdk2uOessc
4. Explore and exploit
