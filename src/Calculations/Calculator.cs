using System.Data.SqlClient;
using System.Diagnostics;

namespace Calculations;

public class Calculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second number from the first.
    /// </summary>
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Divides the first number by the second.
    /// </summary>
    public double Divide(int a, int b)
    {
        return (double)a / b;
    }

    /// <summary>
    /// Calculates the power of a number.
    /// </summary>
    public double Power(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }

    /// <summary>
    /// Calculates the square root of a number.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the input is negative.</exception>
    public double SquareRoot(double number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Cannot calculate square root of a negative number.");
        }
        return Math.Sqrt(number);
    }

    /// <summary>
    /// Calculates the percentage of a number.
    /// </summary>
    public double Percentage(double number, double percent)
    {
        return (number * percent) / 100;
    }

    /// <summary>
    /// Calculates the average of an array of numbers.
    /// </summary>
    public double Average(params int[] numbers)
    {
        return numbers.Average();
    }

    /// <summary>
    /// Finds the maximum value in an array of numbers.
    /// </summary>
    public int Max(params int[] numbers)
    {
        return numbers.Max();
    }

    /// <summary>
    /// Finds the minimum value in an array of numbers.
    /// </summary>
    public int Min(params int[] numbers)
    {
        return numbers.Min();
    }

    public string GetCalculationHistory(string userId, string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            // SQL Injection vulnerability - concatenating user input directly into SQL query
            string query = "SELECT * FROM CalculationHistory WHERE UserId = '" + userId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return reader[0].ToString();
                }
            }
        }
        return string.Empty;
    }

    
    public string ConvertResultFormat(string fileName, string outputFormat)
    {
        // Command injection vulnerability - using user input directly in system command
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            Arguments = $"-c \"convert {fileName} {outputFormat}\"",
            RedirectStandardOutput = true,
            UseShellExecute = false
        };
        
        Process process = Process.Start(startInfo);
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        return output;
    }

    
    public string LoadCalculationData(string filename)
    {
        // Path traversal vulnerability - not validating or sanitizing the file path
        string baseDirectory = "/var/data/calculations/";
        string fullPath = baseDirectory + filename;
        
        if (File.Exists(fullPath))
        {
            return File.ReadAllText(fullPath);
        }
        return string.Empty;
    }

    
    public SqlConnection GetDatabaseConnection()
    {
        // Hardcoded credentials vulnerability
        string connectionString = "Server=localhost;Database=Calculations;User Id=admin;Password=P@ssw0rd123!;";
        return new SqlConnection(connectionString);
    }

    
    public string GenerateSessionToken()
    {
        // Weak random number generation - using Random instead of cryptographically secure RNG
        Random random = new Random();
        byte[] tokenBytes = new byte[16];
        random.NextBytes(tokenBytes);
        return Convert.ToBase64String(tokenBytes);
    }

    
    public List<string> SearchCalculations(string searchTerm, string connectionString)
    {
        List<string> results = new List<string>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            // SQL Injection vulnerability - string interpolation with user input
            string query = $"SELECT CalcId, Result FROM Calculations WHERE Description LIKE '%{searchTerm}%'";
            SqlCommand command = new SqlCommand(query, connection);
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    results.Add(reader["CalcId"].ToString());
                }
            }
        }
        return results;
    }
}
