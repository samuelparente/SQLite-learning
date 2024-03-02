//Samuel Parente
//Exercises for learning SQLite
using System;
using System.Data.SQLite;

namespace SQLiteLearning
{
    class Program
    {   
        static void DisplayTable(SQLiteConnection connection)
        {
            SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM countries", connection);
            SQLiteDataReader reader = selectCommand.ExecuteReader();

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Country Name  | Capital    | Main Cities                   | Population   | Continent      | Language |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            while (reader.Read())
            {
                Console.WriteLine($"| {reader["name"],-13} | {reader["capital"],-10} | {reader["main_cities"],-30} | {reader["population"],-12} | {reader["continent"],-15} | {reader["language"],-8} |");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            reader.Close();
        }

        static void Main(string[] args)
        {
            string dbConnectionString = "Data Source=countries.db;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(dbConnectionString);

            // Create database and table
            SQLiteCommand createTableCommand = new SQLiteCommand(@"
                CREATE TABLE IF NOT EXISTS countries (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL,
                    capital TEXT NOT NULL,
                    main_cities TEXT NOT NULL,
                    population INT NOT NULL,
                    continent TEXT NOT NULL,
                    language TEXT NOT NULL
                )", connection);

            // Insert sample data
            SQLiteCommand insertDataCommand = new SQLiteCommand(@"
                INSERT INTO countries (name, capital, main_cities, population, continent, language)
                VALUES
                    ('United States', 'Washington', 'New York, Los Angeles, Chicago', 332000000, 'North America', 'English'),
                    ('France', 'Paris', 'Paris, Marseille, Lyon', 67000000, 'Europe', 'French'),
                    ('Brazil', 'Brasília', 'São Paulo, Rio de Janeiro', 213000000, 'South America', 'Portuguese'),
                    ('China', 'Beijing', 'Shanghai, Beijing, Guangzhou', 1441000000, 'Asia', 'Chinese'),
                    ('Australia', 'Canberra', 'Sydney, Melbourne, Brisbane', 25400000, 'Australia', 'English')
            ", connection);

            // Update population for United States
            SQLiteCommand updatePopulationCommand = new SQLiteCommand(@"
                UPDATE countries
                SET population = 350000000
                WHERE name = 'United States'
            ", connection);

            // Delete Australia
            SQLiteCommand deleteAustraliaCommand = new SQLiteCommand(@"
                DELETE FROM countries
                WHERE name = 'Australia'
            ", connection);

            connection.Open();

            // Create table
            createTableCommand.ExecuteNonQuery();

            Console.WriteLine("SQLite database created successfully.");
            Console.WriteLine("Table 'countries' created successfully.");

            // Insert sample data
            insertDataCommand.ExecuteNonQuery();
            Console.WriteLine("Inserting sample data into the table...");

            // Display original data
            DisplayTable(connection);

            // Update population for United States
            updatePopulationCommand.ExecuteNonQuery();
            Console.WriteLine("Updating population for United States...");

            // Display updated data
            DisplayTable(connection);

            // Delete Australia
            deleteAustraliaCommand.ExecuteNonQuery();
            Console.WriteLine("Deleting Australia from the database...");

            // Display final data
            DisplayTable(connection);

            connection.Close();
        }

    }
}
