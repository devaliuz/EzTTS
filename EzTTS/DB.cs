using System.Data.SQLite;

namespace EzTTS;

internal class DB
{
    public DB()
    {
        if (!File.Exists("./commands.sqlite3"))
        {
            SQLiteConnection.CreateFile("commands.sqlite3");
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = commands.sqlite3"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE 'Commands'('Command' TEXT NOT NULL)", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
    public int count()
    {
        int entries = 0;
        try
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = commands.sqlite3"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Commands", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                entries++;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return entries;
    }

    public string[] Load()
    {
        int entries = count();
        string[] arraytoreturn = new string[entries];
        try
        {
            int index = 0;

            using (SQLiteConnection connection = new SQLiteConnection("Data Source = commands.sqlite3"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand($"Select * From Commands ", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            arraytoreturn[index] = reader["Command"].ToString();
                            index++;
                        }
                    }
                }
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        if (arraytoreturn.Length>=1)
        {
            return arraytoreturn;
        }
        string[] fallback = new string[1];
        fallback[0] = "Nothing saved in DataBase yet";
        return fallback;
    }
}