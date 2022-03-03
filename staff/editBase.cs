using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace staff
{




    public partial class editBase : Form
    {
        public string key = "abc123";

        static public string EncodeASCII(string inputString)
        {
            string returnString = String.Empty;
            foreach(char symbol in inputString)
            {
                returnString += Convert.ToInt32(symbol) + " "; 
            }
            return returnString;
        }
        static public string DecodeASCII(string inputString)
        {
            try
            {
                string[] splited = inputString.Split(' ');
                string returnedString = String.Empty;
                foreach (string word in splited)
                {
                    if (String.IsNullOrEmpty(word))
                    {
                        continue;
                    }
                    returnedString += Convert.ToChar(Convert.ToInt32(word));

                }
                return returnedString;
            }
            catch
            {
                MessageBox.Show("Something wrong with DecodeASCII");
                return String.Empty;
            }
        }

        static public string EncodeGamma(string inputString, string key)//Непосредственно алгоритм шифрования
        {
            while (inputString.Length != key.Length)
            {
                if (inputString.Length == 0)
                {
                    continue;
                }
                if (inputString.Length > key.Length)
                {
                    key += key;
                }
                else if (inputString.Length < key.Length)
                {
                    key = key.Remove(inputString.Length - 1, key.Length - inputString.Length);
                }

            }
            string encodedString = String.Empty;

            for (int i = 0; i < key.Length; i++)
            {
                encodedString += Convert.ToChar((Convert.ToInt32(Convert.ToChar(inputString.Substring(i, 1))) ^ Convert.ToInt32(Convert.ToChar(key.Substring(i, 1)))));
            }
            return encodedString;
        }   

        public string ChangeRowQuereMaker((TextBox textID,TextBox textSurname, TextBox textName, TextBox textPatronymic, TextBox textAdress, TextBox textDepartment, TextBox textAboutMe,  DateTimePicker dateBirthDate) columns)
        {
            List<TextBox> notEmptyTextBox = new List<TextBox>();
            List<DateTimePicker> notEmptyDateTimePicker = new List<DateTimePicker>();
            Dictionary<string, string> keys = new Dictionary<string, string>
            {
                {"textSurname", "Surname"},
                {"textName", "Name"},
                {"textPatronymic", "Patronymic"},
                {"textAdress", "Adress"},
                {"textDepartment", "Department"},
                {"textAboutMe", "About me"},
                {"dateBirthDate", "Birth date" }
            };
            string query = "UPDATE Stuff SET";
            try
            {
                switch(columns.textSurname.Text != String.Empty)
                {
                    case true:
                        notEmptyTextBox.Add(columns.textSurname);
                        break;
                    default:
                        break;
                }
                switch(columns.textName.Text != String.Empty)
                {
                    case true:
                        notEmptyTextBox.Add(columns.textName);
                        break;
                    default:
                        break;
                }
                switch (columns.textPatronymic.Text != String.Empty)
                {
                    case true:
                        notEmptyTextBox.Add(columns.textPatronymic);
                        break;
                    default:
                        break;
                }
                switch (columns.textAdress.Text != String.Empty)
                {
                    case true:
                        notEmptyTextBox.Add(columns.textAdress);
                        break;
                    default:
                        break;
                }
                switch (columns.textDepartment.Text != String.Empty)
                {
                    case true:
                        notEmptyTextBox.Add(columns.textDepartment);
                        break;
                    default:
                        break;
                }
                switch (columns.textAboutMe.Text != String.Empty)
                {
                    case true:
                        notEmptyTextBox.Add(columns.textAboutMe);
                        break;
                    default:
                        break;
                }
                switch (columns.dateBirthDate.Value != DateTime.Today)
                {
                    case true:
                        notEmptyDateTimePicker.Add(columns.dateBirthDate);
                        break;
                    default:
                        break;
                }

                if(notEmptyTextBox.Count > 0 || notEmptyDateTimePicker.Count > 0)
                {
                    switch (notEmptyTextBox.Count)
                    {
                        case 0:
                            query += $" [{keys[dateBirthDate.Name]}]='{EncodeASCII(EncodeGamma(Convert.ToString(dateBirthDate.Value), key))}'";
                            break;
                        default:
                            switch (notEmptyDateTimePicker.Count)
                            {
                                case 0:
                                    foreach(TextBox box in notEmptyTextBox)
                                    {
                                        if (notEmptyTextBox.IndexOf(box, 0) == notEmptyTextBox.Count - 1)
                                        {
                                            query += $"[{keys[box.Name]}] = '{EncodeASCII(EncodeGamma(box.Text, key))}'";
                                        }
                                        else
                                        {
                                            query += $"[{keys[box.Name]}] = '{EncodeASCII(EncodeGamma(box.Text, key))}', ";
                                        }
                                    }
                                    break;
                                default:
                                    foreach(TextBox box in notEmptyTextBox)
                                    {
                                        query += $"[{keys[box.Name]}] = '{EncodeASCII(EncodeGamma(box.Text, key))}', ";
                                    }
                                    query += $" [{keys[dateBirthDate.Name]}]='{EncodeASCII(EncodeGamma(Convert.ToString(dateBirthDate.Value), key))}'";
                                    break;
                            }
                            break;
                    }
                }
                
                query += $" WHERE ID = {columns.textID.Text};"; 
                return query;
            }
            catch
            {
                return query;
            }
            
            
        }

        public void Finding(int ID)
            {
                OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connString);
                connection.Open();
                string query = $"SELECT*FROM Stuff WHERE ID = {ID}";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("ERRORE!");
                
                }
                else
                {
                dataGridView1.Rows.Clear();
                    while (reader.Read())
                    {
                    dataGridView1.Rows.Add(reader[0], EncodeGamma(DecodeASCII(Convert.ToString(reader[1])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[2])),key), EncodeGamma(DecodeASCII(Convert.ToString(reader[3])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[4])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[5])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[6])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[7])), key));
                    textID.Text = Convert.ToString(reader[0]);
                    textSurname.Text = EncodeGamma(DecodeASCII(Convert.ToString(reader[1])), key);
                    textName.Text = EncodeGamma(DecodeASCII(Convert.ToString(reader[2])), key);
                    textPatronymic.Text = EncodeGamma(DecodeASCII(Convert.ToString(reader[3])), key);
                    dateBirthDate.Value = Convert.ToDateTime(EncodeGamma(DecodeASCII(Convert.ToString(reader[4])), key));
                    textAdress.Text = EncodeGamma(DecodeASCII(Convert.ToString(reader[5])), key);
                    textDepartment.Text = EncodeGamma(DecodeASCII(Convert.ToString(reader[6])), key);
                    textAboutMe.Text = EncodeGamma(DecodeASCII(Convert.ToString(reader[7])), key);
                }

                }

            }
        public void Finding(string Name)
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connString);
            connection.Open();
            string query = $"SELECT*FROM Stuff WHERE NAME = '{EncodeASCII(EncodeGamma(Name, key))}'";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("ERRORE!");

            }
            else
            {
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], EncodeGamma(DecodeASCII(Convert.ToString(reader[1])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[2])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[3])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[4])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[5])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[6])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[7])), key));

                }

            }
        }
        public void Finding(string Name, string Surname)
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connString);
            connection.Open();
            string query = $"SELECT*FROM Stuff WHERE Name = '{EncodeASCII(EncodeGamma(Name, key))}' and Surname = '{EncodeASCII(EncodeGamma(Surname, key))}'";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("ERRORE!");

            }
            else
            {
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], EncodeGamma(DecodeASCII(Convert.ToString(reader[1])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[2])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[3])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[4])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[5])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[6])), key), EncodeGamma(DecodeASCII(Convert.ToString(reader[7])), key));

                }

            }
        }

        private void ReloadTable()
        {
            dataGridView1.Rows.Clear();
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connString);
            connection.Open();
            string quere = "SELECT*FROM Stuff";
            OleDbCommand command = new OleDbCommand(quere, connection);
            OleDbDataReader dbReader = command.ExecuteReader();

            if (!dbReader.HasRows)
            {
                MessageBox.Show("ERRORE!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader[0], EncodeGamma(DecodeASCII(Convert.ToString(dbReader[1])), key), EncodeGamma(DecodeASCII(Convert.ToString(dbReader[2])), key), EncodeGamma(DecodeASCII(Convert.ToString(dbReader[3])), key), EncodeGamma(DecodeASCII(Convert.ToString(dbReader[4])), key), EncodeGamma(DecodeASCII(Convert.ToString(dbReader[5])), key), EncodeGamma(DecodeASCII(Convert.ToString(dbReader[6])), key), EncodeGamma(DecodeASCII(Convert.ToString(dbReader[7])), key));

                }
            }


            dbReader.Close();
            connection.Close();
        }
        private void AutoID()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connString);
                connection.Open();
                string query = "SELECT MAX(ID) FROM Stuff";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    textID.Text = Convert.ToString(1);

                }
                while (reader.Read())
                {
                    textID.Text = Convert.ToString(Convert.ToInt32(reader[0]) + 1);
                }
                reader.Close();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("AutoID has some troubles. Mb bc database is empty");
            }

    }
            

        private bool SomeTextEmpty()
        {
            bool boolSurname = String.IsNullOrEmpty(textSurname.Text);
            bool boolName = String.IsNullOrEmpty(textName.Text);
            bool boolPatronymic = String.IsNullOrEmpty(textPatronymic.Text);
            bool boolAdress = String.IsNullOrEmpty(textAdress.Text);
            bool boolDepartment = String.IsNullOrEmpty(textDepartment.Text);


            if (boolSurname || boolName || boolPatronymic || boolAdress || boolDepartment)
            {
                MessageBox.Show("Lines empty!");
                return false;
            }
            else
            {
                return true;
            }
        }

        
        
        
        public editBase()
        {
            
            InitializeComponent();
        }



        


        private void editBase_Load(object sender, EventArgs e)
        {
            ReloadTable();
            AutoID();


        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (SomeTextEmpty())
            {
                OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connString);
                connection.Open();

                string query = $"INSERT INTO stuff VALUES ({Convert.ToInt32(textID.Text)}, '{EncodeASCII(EncodeGamma(textSurname.Text, key))}', '{EncodeASCII(EncodeGamma(textName.Text, key))}', '{EncodeASCII(EncodeGamma(textPatronymic.Text, key))}', '{EncodeASCII(EncodeGamma(Convert.ToString(dateBirthDate.Value), key))}', '{EncodeASCII(EncodeGamma(textAdress.Text, key))}', '{EncodeASCII(EncodeGamma(textDepartment.Text, key))}', '{EncodeASCII(EncodeGamma(textAboutMe.Text, key))}');";

                OleDbCommand command = new OleDbCommand(query, connection);

                switch (command.ExecuteNonQuery())
                {
                    case 1:
                        MessageBox.Show("Data added");
                        break;
                    default:
                        MessageBox.Show("ERRORE");
                        break;
                }

                connection.Close();
            }
            
            ReloadTable();
            AutoID();


        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (textID.Text == "")
                {
                    MessageBox.Show("Choise ID");
                }
                else
                {
                    OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connString);
                    connection.Open();
                    string query = $"DELETE FROM Stuff WHERE ID = {Convert.ToInt32(textID.Text)};";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    switch (command.ExecuteNonQuery())
                    {
                        case 1:
                            MessageBox.Show("Row deleted");
                            break;
                        default:
                            MessageBox.Show("not deleted");
                            break;
                    }


                    connection.Close();

                }
            }
            catch
            {
                MessageBox.Show("ERRORE!");
            }
            ReloadTable();
            AutoID();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textID.Text = String.Empty;
            textSurname.Text = String.Empty;
            textName.Text = String.Empty;
            textPatronymic.Text = String.Empty;
            textAdress.Text = String.Empty;
            textDepartment.Text = String.Empty;
            textAboutMe.Text = String.Empty;
            dateBirthDate.Value = DateTime.Today;
            AutoID();

        }

        private void ChangeInformation_Click(object sender, EventArgs e)
        {
            (TextBox, TextBox, TextBox, TextBox, TextBox, TextBox, TextBox, DateTimePicker) columns = (textID, textSurname, textName, textPatronymic, textAdress, textDepartment, textAboutMe, dateBirthDate);

            
            string query = ChangeRowQuereMaker(columns);

            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connString);
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection);
            
            switch (command.ExecuteNonQuery())
            {
                case 1:
                    MessageBox.Show("Data changed");
                    break;
                default:
                    MessageBox.Show("ERRORE");
                    break;
            }
            
            connection.Close();

            ReloadTable();
            AutoID();

        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textID.Text) & String.IsNullOrEmpty(textName.Text) & String.IsNullOrEmpty(textSurname.Text))
            {
                Finding(Convert.ToInt32(textID.Text));
            }
            else if (String.IsNullOrEmpty(textID.Text) & !String.IsNullOrEmpty(textName.Text) & String.IsNullOrEmpty(textSurname.Text))
            {
                Finding(textName.Text);
            }
            else if (String.IsNullOrEmpty(textID.Text) & !String.IsNullOrEmpty(textName.Text) & !String.IsNullOrEmpty(textSurname.Text))
            {
                Finding(textName.Text, textSurname.Text);
            }
        }

        

        private void btnRelTable_Click(object sender, EventArgs e)
        {
            AutoID();
            ReloadTable();
        }

        
    }
}
