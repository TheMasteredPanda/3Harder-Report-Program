using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _3Harder_Report_Program
{
    /**
     * Data manager.
     * 
     * Manager for managing data.
     * 
     * The Manager stores all information in an SQLite database. It's primary function is 
     * serializing, deserializing, and caching data in the respective table and dictionary.
     **/
    class DataManager
    {
        private SQLiteConnection connection;
        private static DataManager manager;
        public Dictionary<string, Report> reports = new Dictionary<string, Report>();
        public Dictionary<string, Account> accounts = new Dictionary<string, Account>();
        public Account currentAccount = null;
        public Report resolving = null;
        public Report viewing = null;
        private string idPrefix = "job-{0}";
        private int rowCount = 0;
        
        /**
         * Constructor of the DataManager. Instantiated lazily.
         *
         * When the constructor is invoked. It will do the following things in the order they are written in:
         * 1. Create a local database file is one doesn't exist in the programs working file.
         * 2. Create the reports and accounts table if they do not exist.
         * 3. Deserialize and cache both reports and accounts from the local database to the respective dictionary.
         **/
        public DataManager()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\data.db" )) 
            {
                SQLiteConnection.CreateFile(Directory.GetCurrentDirectory() + @"\data.db");
            }

            connection = new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + @"\data.db");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS reports(id TEXT PRIMARY KEY, date INTEGER, submittor_name TEXT, room_number TEXT, problem_type TEXT, priority TEXT, description TEXT, resolved BOOLEAN, resolved_by TEXT, resolved_description TEXT, resolved_date INTEGER); CREATE TABLE IF NOT EXISTS accounts(name TEXT, password TEXT, admin BOOLEAN);", connection);
            command.ExecuteNonQuery();

            SQLiteCommand countReports = new SQLiteCommand("SELECT COUNT(id) FROM reports;", connection);
            rowCount = Convert.ToInt32(countReports.ExecuteScalar());

            if (rowCount != 0)
            {
                SQLiteCommand getAllReports = new SQLiteCommand("SELECT * FROM reports", connection);
                SQLiteDataReader reader = getAllReports.ExecuteReader();

                while (reader.Read())
                {
                    Priority priority;
                    ProblemType type;

                    Enum.TryParse((String)reader["problem_type"], out type);
                    Enum.TryParse((String)reader["priority"], out priority);

                    Report r = new Report(
                        (String)reader["id"],
                        DateTime.FromBinary(Convert.ToInt64(reader["date"])),
                        (String)reader["submittor_name"],
                        (String)reader["room_number"],
                        type,
                        priority,
                        (String)reader["description"],
                        (Boolean)reader["resolved"],
                        reader["resolved_by"] is DBNull ? null : (String)reader["resolved_by"],
                        reader["resolved_description"] is DBNull ? null : (String)reader["resolved_description"],
                        reader["resolved_date"] is DBNull ? 0 : Convert.ToInt64(reader["resolved_date"])
                        );

                    reports.Add(r.id, r);
                }
            }

            SQLiteCommand countAccounts = new SQLiteCommand("SELECT COUNT(name) FROM accounts;", connection);
            int accounts = Convert.ToInt32(countAccounts.ExecuteScalar());

            Console.WriteLine("Accounts: " + accounts);

            if (accounts != 0)
            {
                SQLiteCommand getAllAccounts = new SQLiteCommand("SELECT * FROM accounts;", connection);
                SQLiteDataReader accountReader = getAllAccounts.ExecuteReader();

                while (accountReader.Read())
                {
                    Account account = new Account(
                        (String)accountReader["name"],
                        (String)accountReader["password"],
                        (Boolean)accountReader["admin"]
                        );

                    this.accounts.Add(account.username, account);
                }
            }

            Console.WriteLine("Loaded " + this.accounts.Count + " accounts and " + reports.Count + " reports.");
        }

        public static DataManager GetInstance()
        {
            if (manager == null)
            {
                manager = new DataManager();
            }

            return manager;
        }

        /**
         * Inserts a new report into the reports table and the dictionary, provided the report ID isn't already being used.
         **/
        public void Insert(Report report)
        {
            rowCount++;
            report.id = String.Format(idPrefix, rowCount.ToString());

            if (reports.ContainsKey(report.id))
            {
                MessageBox.Show("Report id already exists.");
                return;
            }

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO reports (id, date, submittor_name, room_number, problem_type, priority, description, resolved, resolved_by, resolved_description, resolved_date) VALUES(?,?,?,?,?,?,?,?,?,?,?)", connection);
            cmd.Parameters.AddWithValue("id", report.id);
            cmd.Parameters.AddWithValue("date", report.dateTime.ToBinary()); 
            cmd.Parameters.AddWithValue("submittor_name", report.submittorName);
            cmd.Parameters.AddWithValue("room_number", report.roomNumber);
            cmd.Parameters.AddWithValue("problem_type", report.problemType);
            cmd.Parameters.AddWithValue("priority", report.priority);
            cmd.Parameters.AddWithValue("description", report.description);
            cmd.Parameters.AddWithValue("resolved", report.resolved);
            cmd.Parameters.AddWithValue("resolved_by", report.resolvedBy);
            cmd.Parameters.AddWithValue("resolved_description", report.resolvedDescription);
            cmd.Parameters.AddWithValue("resolved_date", report.resolvedDate);
            cmd.ExecuteNonQuery();
            reports.Add(report.id, report);
        }

        /**
         * Removes a report from the reports table and the dictionary.
         **/
        public void RemoveReport(string reportId)
        {
            if (reports.ContainsKey(reportId))
            {
                reports.Remove(reportId);
            }

            SQLiteCommand removeReport = new SQLiteCommand("DELETE FROM reports WHERE id=?", connection);
            removeReport.Parameters.AddWithValue("id", reportId);
            removeReport.ExecuteNonQuery();
        }

        /**
         * Updates a report with the resolution data.
         **/
        public void Resolve(Report report)
        {
            if (reports.ContainsKey(report.id))
            {
                reports.Remove(report.id);
            }

            reports.Add(report.id, report);
            SQLiteCommand updateReport = new SQLiteCommand("UPDATE reports SET resolved=?, resolved_by=?, resolved_description=?, resolved_date=? WHERE id=?", connection);
            updateReport.Parameters.AddWithValue("resolved", report.resolved);
            updateReport.Parameters.AddWithValue("resolved_by", report.resolvedBy);
            updateReport.Parameters.AddWithValue("description", report.description);
            updateReport.Parameters.AddWithValue("resolved_date", report.resolvedDate);
            updateReport.Parameters.AddWithValue("id", report.id);

            updateReport.ExecuteNonQuery();
        }

        /**
         * Adds a new account to the account table and it's respective dictionary.
         **/
        public void AddAccount(Account account)
        {
            if (accounts.ContainsKey(account.username))
            {
                MessageBox.Show("Username already taken.");
                return;
            }
            
            if ((account.password is null) || (account.password.Length == 0))
            {
                MessageBox.Show("Password cannot be null.");
                return;
            }

            if (manager.IsPasswordTaken(account.username))
            {
                MessageBox.Show("Password already taken.");
                return;
            }

            SQLiteCommand addAccountCmd = new SQLiteCommand("INSERT INTO accounts (name, password, admin) VALUES (?, ?, ?);", connection);
            addAccountCmd.Parameters.AddWithValue("name", account.username);
            addAccountCmd.Parameters.AddWithValue("password", account.password);
            addAccountCmd.Parameters.AddWithValue("admin", account.admin);
            addAccountCmd.ExecuteNonQuery();
            accounts.Add(account.username, account);
        }

        /**
         * Removes an account from the accounts table and the respective dictionary.
         **/
        public void RemoveAccount(string username)
        {
            if (accounts.ContainsKey(username))
            {
                Account account = accounts[username];

                if (account.active)
                {
                    MessageBox.Show("You cannot delete an active account. Ask the account holder to log off of the system and then try again.");
                    return;
                }

                accounts.Remove(username);
            }

            SQLiteCommand removeAccountCmd = new SQLiteCommand("DELETE FROM accounts WHERE name=?;", connection);
            removeAccountCmd.Parameters.AddWithValue("name", username);
            removeAccountCmd.ExecuteNonQuery();
        }
        
        /**
         * Used to either promote or demote an account to or from admin.
         **/
        public void SetAdmin(string username, bool admin)
        {
            if (accounts.ContainsKey(username))
            {
                accounts[username].admin = admin;
            }

            SQLiteCommand adminCmd = new SQLiteCommand("UPDATE accounts SET admin=? WHERE name=?", connection);
            adminCmd.Parameters.AddWithValue("admin", admin);
            adminCmd.Parameters.AddWithValue("name", username);
            adminCmd.ExecuteNonQuery();
        }

        /**
         * Updates an accounts password.
         **/
        public void ChangePassword(string username, string newPassword)
        {
            if (accounts.ContainsKey(username))
            {
                accounts[username].password = newPassword;
            }

            SQLiteCommand updateAccount = new SQLiteCommand("UPDATE accounts SET password=? WHERE name=?", connection);
            updateAccount.Parameters.AddWithValue("password", newPassword);
            updateAccount.Parameters.AddWithValue("name", username);
            updateAccount.ExecuteNonQuery();
        }

        /**
         * Checks if the username inputted in the parameters is affiliated with an account on the system.
         **/
        public bool IsAccountUsername(string username)
        {
            return accounts.ContainsKey(username);
        }

        /**
         * Checks if the username if affiliated with an account that has admin priviledges.
         **/
        public bool IsAdmin(string username)
        {
            return accounts[username].admin;
        }

        /**
         * Checks if the password for an account is correct.
         **/
        public bool IsPasswordCorrect(string username, string password)
        {
            return accounts[username].password.Equals(password);
        }

        /**
         * Checks if a password has already been taken by an account.
         **/
        public bool IsPasswordTaken(string password)
        {
            foreach(Account a in accounts.Values)
            {
                if (!a.password.Equals(password))
                {
                    continue;
                }

                return true;
            }

            return false;
        }
    }

    /**
     * Template Data Class for storing information on one Report.
     **/
    class Report
    {
        public String id;
        public DateTime dateTime;
        public String submittorName;
        public String roomNumber;
        public ProblemType problemType;
        public Priority priority;
        public String description;
        public Boolean resolved = false;
        public String resolvedBy;
        public String resolvedDescription;
        public long resolvedDate;

        public Report(string id, DateTime date, string submittorName, string roomNumber, ProblemType problemType, Priority priority, string description, bool resolved, string resolvedBy, string resolvedDescription, long resolvedDate)
        {
            this.id = id;
            this.dateTime = date;
            this.submittorName = submittorName;
            this.roomNumber = roomNumber;
            this.problemType = problemType;
            this.priority = priority;
            this.description = description;
            this.resolved = resolved;
            this.resolvedBy = resolvedBy;
            this.resolvedDescription = resolvedDescription;
            this.resolvedDate = resolvedDate;
        }
    }

    /**
     * Problem Types.
     **/
    enum ProblemType
    {
        HARDWARE, SOFTWARE, TELECOMMUNICATIONS
    }

    /**
     * The priority of a report.
     **/
    enum Priority
    {
        HIGH, MEDIUM, LOW
    }

    /**
     * Template data class for storing all information on one account.
     **/
    class Account
    {
        public string username;
        public string password;
        public bool admin;
        public bool active = false;

        public Account(string username, string password, bool admin)
        {
            this.username = username;
            this.password = password;
            this.admin = admin;
        }
    }
}
