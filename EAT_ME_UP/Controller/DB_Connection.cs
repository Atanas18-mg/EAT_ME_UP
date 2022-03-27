using System.Data;
using MySql.Data.MySqlClient;

namespace EatMeUp.Model
{
    public class DB_Connection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "server=localhost;user=root;database=eatmeup;port=3306;password=nasi235689";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (MySqlException exeption)
            {
                MessageBox.Show($"MySQL Connection!\n{exeption.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static void InsertRecipe(Recipe recipe)
        {
            int recipeID = GetRedipesCount() + 1;
            string sqlCode = String.Empty;

            if (recipe.ShotDescription == "NULL")
            {
                sqlCode = $"insert into recipe_info values (\"{recipeID}\", \"{recipe.UserName}\", \"{recipe.RecipeTitle}\"," +
                                $" NULL, \"{recipe.NecessaryProducts}\", \"{recipe.MethodOfPreparation}\", " +
                                $"\"{recipe.Category}\", \"{recipe.PreparationTime}\", \"{recipe.CookingTime}\", \"{recipe.Subcategory}\"," +
                                $" \"{recipe.Portions}\", \"{recipe.DegreeOfDifficulty}\", @Image);";
            }
            else
            {
                sqlCode = $"insert into recipe_info values (\"{recipeID}\", \"{recipe.UserName}\", \"{recipe.RecipeTitle}\"," +
                                 $" \"{recipe.ShotDescription}\", \"{recipe.NecessaryProducts}\", \"{recipe.MethodOfPreparation}\", " +
                                 $"\"{recipe.Category}\", \"{recipe.PreparationTime}\", \"{recipe.CookingTime}\", \"{recipe.Subcategory}\"," +
                                 $" \"{recipe.Portions}\", \"{recipe.DegreeOfDifficulty}\", @Image);";
            }

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);

            MySqlParameter blob = new MySqlParameter("@Image", MySqlDbType.LongBlob, recipe.Image.Length);
            blob.Value = recipe.Image;

            command.Parameters.Add(blob);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Аdded Сuccessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exeption)
            {
                MessageBox.Show($"Recipe not insertet,\n{exeption.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void AddCustommer(Custommer custommer)
        {
            int custommerCount = GerCustommerCount() + 1;

            string sqlCode = $"insert into custommeraccount value (\"{custommerCount}\", \"{custommer.Username}\", \"{custommer.Password}\"," +
                $"\"{custommer.FirstName}\", \"{custommer.LastName}\", \"{custommer.Gender}\", @Image);";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);

            MySqlParameter blob = new MySqlParameter("@Image", MySqlDbType.LongBlob, custommer.Image.Length);
            blob.Value = custommer.Image;

            command.Parameters.Add(blob);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Registration completed! Now go to LOG IN section in teh menu and acces your account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration faild!\n{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteRecipe(string necessaryProducts)
        {
            string sqlCode = "delete from recipe_info where recipeTitle = @necessaryProducts";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);

            command.CommandType = System.Data.CommandType.Text;
            command.Parameters.Add("@necessaryProducts", MySqlDbType.LongText).Value = necessaryProducts;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted Сuccessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException exeption)
            {
                MessageBox.Show($"Redipe not deleted,\n{exeption.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static List<Recipe> GetAllRecipes()
        {
            string sqlCode = $"select * from recipe_info;";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);

            //variables
            List<Recipe> recipies = new List<Recipe>();
            DataTable dataTable = new DataTable();
            List<byte[]> images = new List<byte[]>();
            List<string> shortDiscriptions = new List<string>();

            //copy quary table and paste it here
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
            {
                dataAdapter.Fill(dataTable);
            }
            connection.Close();

            //det all rows in the table
            DataRow[] dataRows = dataTable.Select();

            //take care of fields that are null
            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][12].ToString()))
                {
                    byte[] array = new byte[0];
                    images.Add(array);
                }
                else images.Add((byte[])dataRows[counter][12]);
            }

            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][3].ToString()))
                {
                    string str = String.Empty;
                    shortDiscriptions.Add(str);
                }
                else shortDiscriptions.Add((string)dataRows[counter][3]);
            }

            //creat Recipe for 1 recipe from all row 
            for (int position = 0; position < dataRows.Length; position++)
            {
                recipies.Add(new Recipe((string)dataRows[position][1], (string)dataRows[position][2], shortDiscriptions[position], (string)dataRows[position][4], (string)dataRows[position][5],
                                       (string)dataRows[position][6], (int)dataRows[position][7], (int)dataRows[position][8], (string)dataRows[position][9], (int)dataRows[position][10],
                                        (string)dataRows[position][11], images[position]));
            }

            return recipies;
        }

        public static List<Recipe> GetAllRecipesContainsInThereTitleString(string searchString)
        {
            string sqlCode = $"select * from recipe_info where recipeTitle like \'%{searchString}%\';";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);

            //variables
            List<Recipe> recipies = new List<Recipe>();
            DataTable dataTable = new DataTable();
            List<byte[]> images = new List<byte[]>();
            List<string> shortDiscriptions = new List<string>();

            //copy quary table and paste it here
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
            {
                dataAdapter.Fill(dataTable);
            }
            connection.Close();

            //det all rows in the table
            DataRow[] dataRows = dataTable.Select();

            //take care of fields that are null
            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][12].ToString()))
                {
                    byte[] array = new byte[0];
                    images.Add(array);
                }
                else images.Add((byte[])dataRows[counter][12]);
            }

            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][3].ToString()))
                {
                    string str = String.Empty;
                    shortDiscriptions.Add(str);
                }
                else shortDiscriptions.Add((string)dataRows[counter][3]);
            }

            //creat Recipe for 1 recipe from all row 
            for (int position = 0; position < dataRows.Length; position++)
            {
                recipies.Add(new Recipe((string)dataRows[position][1], (string)dataRows[position][2], shortDiscriptions[position], (string)dataRows[position][4], (string)dataRows[position][5],
                                       (string)dataRows[position][6], (int)dataRows[position][7], (int)dataRows[position][8], (string)dataRows[position][9], (int)dataRows[position][10],
                                        (string)dataRows[position][11], images[position]));
            }

            return recipies;
        }

        public static List<Recipe> GetRecipesSortedByCatagoryAndSubcategory(string category, string subcategory)
        {
            string sqlCode = $"select * from recipe_info where category = \"{category}\" and subcategory = \"{subcategory}\";";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);

            //variables
            List<Recipe> recipies = new List<Recipe>();
            DataTable dataTable = new DataTable();
            List<byte[]> images = new List<byte[]>();
            List<string> shortDiscriptions = new List<string>();

            //copy quary table and paste it here
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
            {
                dataAdapter.Fill(dataTable);
            }
            connection.Close();

            //det all rows in the table
            DataRow[] dataRows = dataTable.Select();

            //take care of fields that are null
            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][12].ToString()))
                {
                    byte[] array = new byte[0];
                    images.Add(array);
                }
                else images.Add((byte[])dataRows[counter][12]);
            }

            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][3].ToString()))
                {
                    string str = String.Empty;
                    shortDiscriptions.Add(str);
                }
                else shortDiscriptions.Add((string)dataRows[counter][3]);
            }

            //creat Recipe for 1 recipe from all row 
            for (int position = 0; position < dataRows.Length; position++)
            {
                recipies.Add(new Recipe((string)dataRows[position][1], (string)dataRows[position][2], shortDiscriptions[position], (string)dataRows[position][4], (string)dataRows[position][5],
                                       (string)dataRows[position][6], (int)dataRows[position][7], (int)dataRows[position][8], (string)dataRows[position][9], (int)dataRows[position][10],
                                        (string)dataRows[position][11], images[position]));
            }

            return recipies;
        }

        public static List<Recipe> GetRecipesSortedByCatagory(string category)
        {
            string sqlCode = $"select * from recipe_info where category = \"{category}\";";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);

            //variables
            List<Recipe> recipies = new List<Recipe>();
            DataTable dataTable = new DataTable();
            List<byte[]> images = new List<byte[]>();
            List<string> shortDiscriptions = new List<string>();

            //copy quary table and paste it here
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
            {
                dataAdapter.Fill(dataTable);
            }
            connection.Close();

            //det all rows in the table
            DataRow[] dataRows = dataTable.Select();

            //take care of fields that are null
            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][12].ToString()))
                {
                    byte[] array = new byte[0];
                    images.Add(array);
                }
                else images.Add((byte[])dataRows[counter][12]);
            }

            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][3].ToString()))
                {
                    string str = String.Empty;
                    shortDiscriptions.Add(str);
                }
                else shortDiscriptions.Add((string)dataRows[counter][3]);
            }

            //creat Recipe for 1 recipe from all row 
            for (int position = 0; position < dataRows.Length; position++)
            {
                recipies.Add(new Recipe((string)dataRows[position][1], (string)dataRows[position][2], shortDiscriptions[position], (string)dataRows[position][4], (string)dataRows[position][5],
                                       (string)dataRows[position][6], (int)dataRows[position][7], (int)dataRows[position][8], (string)dataRows[position][9], (int)dataRows[position][10],
                                        (string)dataRows[position][11], images[position]));
            }

            return recipies;
        }

        public static List<Recipe> GetAllRecipiesFromAccount(string username)
        {
            string sqlCode = $"select*from recipe_info where username = \"{username}\";";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);

            //variables
            List<Recipe> recipies = new List<Recipe>();
            DataTable dataTable = new DataTable();
            List<byte[]> images = new List<byte[]>();
            List<string> shortDiscriptions = new List<string>();

            //copy quary table and paste it here
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
            {
                dataAdapter.Fill(dataTable);
            }
            connection.Close();

            //det all rows in the table
            DataRow[] dataRows = dataTable.Select();

            //take care of fields that are null
            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][12].ToString()))
                {
                    byte[] array = new byte[0];
                    images.Add(array);
                }
                else images.Add((byte[])dataRows[counter][12]);
            }

            for (int counter = 0; counter < dataRows.Length; counter++)
            {
                if (string.IsNullOrEmpty(dataRows[counter][3].ToString()))
                {
                    string str = String.Empty;
                    shortDiscriptions.Add(str);
                }
                else shortDiscriptions.Add((string)dataRows[counter][3]);
            }

            //creat Recipe for 1 recipe from all row 
            for (int position = 0; position < dataRows.Length; position++)
            {
                recipies.Add(new Recipe((string)dataRows[position][1], (string)dataRows[position][2], shortDiscriptions[position], (string)dataRows[position][4], (string)dataRows[position][5],
                                       (string)dataRows[position][6], (int)dataRows[position][7], (int)dataRows[position][8], (string)dataRows[position][9], (int)dataRows[position][10],
                                        (string)dataRows[position][11], images[position]));
            }

            return recipies;
        }

        public static Dictionary<string, string> GetCreatedAccounts()
        {
            string sqlCode = "select username,password from custommeraccount;";

            MySqlConnection connection = GetConnection();
            MySqlCommand getAccounts = new MySqlCommand(sqlCode, connection);
            MySqlDataReader DbAcounts = getAccounts.ExecuteReader();

            //variables
            Dictionary<string, string> result = new Dictionary<string, string>();
            List<string> keys = new List<string>();
            List<string> values = new List<string>();

            while (DbAcounts.Read())
            {
                keys.Add(DbAcounts.GetString("username"));
                values.Add(DbAcounts.GetString("password"));
            }
            connection.Close();

            for (int counter = 0; counter < keys.Count; counter++)
            {
                result.Add(keys[counter], values[counter]);
            }

            return result;
        }

        /// <summary>
        /// Gets recipe necessaryProducts and methodOfPreparation by title
        /// </summary>
        /// <param name="title"></param>
        /// <returns>string that you have to split by '$'</returns>
        public static string GetRecipeInfoFromTitle(string title)
        {
            string sqlCode = $"select necessaryProducts,methodOfPreparation from recipe_info where recipeTitle = \"{title}\";";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);
            MySqlDataReader reader = command.ExecuteReader();

            string necessaryProducts = String.Empty;
            string methodOfPreparation = string.Empty;

            while (reader.Read())
            {
                necessaryProducts = reader.GetString("necessaryProducts");
                methodOfPreparation = reader.GetString("methodOfPreparation");
            }

            return string.Concat(necessaryProducts, "$", methodOfPreparation);
        }

        public static Custommer GetCustommerInfo(string username)
        {
            string sqlCode = $"select * from custommeraccount where username = \"{username}\";";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);

            //variables
            byte[] image = Array.Empty<byte>();
            DataTable dataTable = new DataTable();

            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
            {
                dataAdapter.Fill(dataTable);
            }
            connection.Close();

            DataRow[] dataRow = dataTable.Select();

            //check if image is not null
            if (!string.IsNullOrEmpty(dataRow[0][6].ToString()))
            {
                image = (byte[])dataRow[0][6];
            }

            return new Custommer((string)dataRow[0][1], (string)dataRow[0][2], (string)dataRow[0][3], (string)dataRow[0][4], (string)dataRow[0][5], image, (string)dataRow[0][7]);
        }

        public static List<string> GetCustommersUsernames()
        {
            string getAllUsernames = "select username from custommeraccount;";

            MySqlConnection connection = GetConnection();
            MySqlCommand getAllUsernamesCOmmand = new MySqlCommand(getAllUsernames, connection);
            MySqlDataReader usernames = getAllUsernamesCOmmand.ExecuteReader();

            List<string> users = new List<string>();

            while (usernames.Read())
            {
                users.Add(usernames.GetString("username"));
            }
            connection.Close();

            return users;
        }

        private static int GetRedipesCount()
        {
            string getRecipeCount = "select count(*) from recipe_info;";

            MySqlConnection connection = GetConnection();
            MySqlCommand getRecipeCountCommand = new MySqlCommand(getRecipeCount, connection);
            MySqlDataReader recipeCount = getRecipeCountCommand.ExecuteReader();

            int count = 0;

            while (recipeCount.Read())
            {
                count = recipeCount.GetInt32("count(*)");
            }
            connection.Close();

            return count;
        }

        private static int GerCustommerCount()
        {
            string getRecipeCount = "select count(*) from custommeraccount;";

            MySqlConnection connection = GetConnection();
            MySqlCommand getRecipeCountCommand = new MySqlCommand(getRecipeCount, connection);
            MySqlDataReader recipeCount = getRecipeCountCommand.ExecuteReader();

            int count = 0;

            while (recipeCount.Read())
            {
                count = recipeCount.GetInt32("count(*)");
            }
            connection.Close();

            return count;
        }

        public static void ResetTabelAutoIncrementId(string tabelName)
        {
            string sqlCode = $"alter table {tabelName} auto_increment = 1;";

            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(sqlCode, connection);
            command.ExecuteNonQuery();
        }

        public static Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
    }
}
