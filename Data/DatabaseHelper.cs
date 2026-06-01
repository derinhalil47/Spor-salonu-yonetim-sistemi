using Microsoft.Data.Sqlite;

namespace GymManagement.Data
{
    public static class DatabaseHelper
    {
        private static string _connectionString = string.Empty;

        public static void Initialize()
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gymmanagement.db");
            _connectionString = $"Data Source={dbPath}";
            CreateTables();
        }

        public static SqliteConnection GetConnection()
        {
            var connection = new SqliteConnection(_connectionString);
            connection.Open();
            return connection;
        }

        private static void CreateTables()
        {
            using var connection = GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Members (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FirstName TEXT NOT NULL,
                    LastName TEXT NOT NULL,
                    Phone TEXT,
                    Email TEXT,
                    Gender TEXT,
                    BirthDate TEXT,
                    RegistrationDate TEXT NOT NULL,
                    PhotoPath TEXT,
                    IsActive INTEGER DEFAULT 1
                );

                CREATE TABLE IF NOT EXISTS Memberships (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MemberId INTEGER NOT NULL,
                    StartDate TEXT NOT NULL,
                    EndDate TEXT NOT NULL,
                    DurationMonths INTEGER NOT NULL,
                    TotalFee REAL NOT NULL,
                    MembershipType TEXT NOT NULL,
                    FOREIGN KEY (MemberId) REFERENCES Members(Id)
                );

                CREATE TABLE IF NOT EXISTS Payments (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MemberId INTEGER NOT NULL,
                    MembershipId INTEGER,
                    Amount REAL NOT NULL,
                    PaymentDate TEXT NOT NULL,
                    PaymentMethod TEXT,
                    FOREIGN KEY (MemberId) REFERENCES Members(Id),
                    FOREIGN KEY (MembershipId) REFERENCES Memberships(Id)
                );

                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    Role TEXT NOT NULL DEFAULT 'User'
                );

                CREATE TABLE IF NOT EXISTS PhysicalStats (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MemberId INTEGER NOT NULL,
                    Height REAL NOT NULL,
                    Weight REAL NOT NULL,
                    BodyFat REAL NOT NULL,
                    DateRecorded TEXT NOT NULL,
                    FOREIGN KEY (MemberId) REFERENCES Members(Id)
                );

                CREATE TABLE IF NOT EXISTS PTPrograms (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MemberId INTEGER NOT NULL,
                    DateCreated TEXT NOT NULL,
                    FOREIGN KEY (MemberId) REFERENCES Members(Id)
                );

                CREATE TABLE IF NOT EXISTS PTProgramExercises (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    PTProgramId INTEGER NOT NULL,
                    ExerciseName TEXT NOT NULL,
                    Sets INTEGER NOT NULL,
                    Reps INTEGER NOT NULL,
                    FOREIGN KEY (PTProgramId) REFERENCES PTPrograms(Id) ON DELETE CASCADE
                );
            ";
            cmd.ExecuteNonQuery();
        }
    }
}
