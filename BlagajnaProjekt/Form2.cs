using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlagajnaProjekt
{
    public partial class Form2 : Form
    {
        private Model3 context;

        public Form2()
        {         
            InitializeComponent();
            context = new Model3();
        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string hashedPassword = HashPassword(password); // Implement this method to hash the password


            List<Users> users = context.Users.ToList();

            foreach (Users user in users)
            {
                if (username == user.Username && password == user.PasswordHash)
                {
                    MessageBox.Show("Login successful!");
                    // Pass the user information to the main form
                    var mainForm = new Form1(user);
                    mainForm.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }

           
        }

        private string HashPassword(string password)
        {
            // Use a hashing library like BCrypt, SHA256, etc.
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password)); // Simplified example
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (context.Users.Any(u => u.Username == username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }

       

            Users newUser = new Users
            {
                Username = username,
                PasswordHash = password
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            MessageBox.Show("Sign up successful!");

        }
    }
}

