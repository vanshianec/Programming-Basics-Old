using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlFormApp
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        String query;
        int[] quantity;
        BindingList<String> products;
        Dictionary<int, String> idName;
        Dictionary<int, double> idPrice;
        Dictionary<int, String> idProducts;
        String[] shipments;
        String[] payments;

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;user id=root;database=12g;password=1234");
            connection.Open();

            products = new BindingList<String>();
            quantity = new int[20];
            idName = new Dictionary<int, string>();
            idPrice = new Dictionary<int, double>();
            idProducts = new Dictionary<int, string>();
            shipments = new string[] { "Ekont", "Speedy", "Fast and Furious" };
            payments = new string[] { "Cash", "Card", "Bank Account" };

            setCollectionValues(idName, idPrice, products);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = products;
            comboBox1.DataSource = bSource;

            for (int i = 0; i < 20; i++)
            {
                quantity[i] = i + 1;
            }
            comboBox2.DataSource = quantity;
        }

        private void setCollectionValues(Dictionary<int, String> name, Dictionary<int, double> price, BindingList<String> products)
        {
            String idSelector = "SELECT p_id FROM 12g.product;";
            String nameSelector = "SELECT name FROM 12g.product;";
            String priceSelector = "SELECT price FROM 12g.product;";

            this.command = new MySqlCommand(idSelector, this.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!name.ContainsKey(int.Parse(reader.GetString(0))))
                {
                    name.Add(int.Parse(reader.GetString(0)), "");
                }
                if (!price.ContainsKey(int.Parse(reader.GetString(0))))
                {
                    price.Add(int.Parse(reader.GetString(0)), 0);

                }
            }
            this.command = new MySqlCommand(nameSelector, this.connection);
            reader.Close();
            reader = command.ExecuteReader();
            int keyCount = 1;
            while (reader.Read())
            {

                name[keyCount] = reader.GetString(0);
                keyCount++;
            }
            this.command = new MySqlCommand(priceSelector, this.connection);
            reader.Close();
            reader = command.ExecuteReader();
            keyCount = 1;
            while (reader.Read())
            {
                price[keyCount] = double.Parse(reader.GetString(0));
                keyCount++;
            }
            reader.Close();
            products.Clear();
            foreach (KeyValuePair<int, String> pair in name)
            {
                products.Add(pair.Value);
            }

        }

        private int getCustomerId()
        {
            int id = 0;
            String lastCustomerQuery = "SELECT c_id FROM 12g.customer ORDER BY c_id DESC LIMIT 1;";
            this.command = new MySqlCommand(lastCustomerQuery, this.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader.GetString(0)) + 1;
            }
            reader.Close();
            return id;
        }

        private int getDetailOrderId()
        {
            int id = 0;
            String lastCustomerQuery = "SELECT o_id FROM 12g.order ORDER BY c_id DESC LIMIT 1;";
            this.command = new MySqlCommand(lastCustomerQuery, this.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader.GetString(0)) + 1;
            }
            reader.Close();
            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                double price = double.Parse(textBox2.Text);
                this.query = $"INSERT INTO `12g`.`product` (`name`, `price`) VALUES ('{name}', '{price}');";
                textBox1.Text = "";
                textBox2.Text = "";
                this.command = new MySqlCommand(query, this.connection);
                command.ExecuteNonQuery();
                setCollectionValues(this.idName, this.idPrice, this.products);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                String name = textBox3.Text;
                String phone = textBox4.Text;
                String email = textBox5.Text;
                String address = textBox6.Text;
                this.query = $"INSERT INTO `12g`.`customer` (`name`, `phone`, `email`, `address`) VALUES ('{name}', '{phone}', '{email}', '{address}');";

                int c_id = getCustomerId();
                String total = label12.Text.Substring(0, label12.Text.Length - 4);
                String payment = this.payments[random.Next(0, 3)];
                String shipment = this.shipments[random.Next(0, 3)];
                int p_id = comboBox1.SelectedIndex + 1;
                String orderQuery = $"INSERT INTO `12g`.`order` (`c_id`, `total`, `payments`, `shipment`, `p_id`) VALUES ('{c_id}', '{total}', '{payment}', '{shipment}', '{p_id}');";

                int o_id = getDetailOrderId();
                int quantity = int.Parse(comboBox2.SelectedItem.ToString());
                String detailQuery = $"INSERT INTO `12g`.`detail` (`o_id`, `p_id`, `quantity`) VALUES ({o_id}, {p_id},{quantity} )";

                this.command = new MySqlCommand(query, this.connection);
                command.ExecuteNonQuery();
                this.command = new MySqlCommand(orderQuery, this.connection);
                command.ExecuteNonQuery();
                this.command = new MySqlCommand(detailQuery, this.connection);
                command.ExecuteNonQuery();

                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            double price = this.idPrice[comboBox1.SelectedIndex + 1] * int.Parse(comboBox2.SelectedItem.ToString());
            label12.Text = $"{price} лв.";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = this.idPrice[comboBox1.SelectedIndex + 1] * int.Parse(comboBox2.SelectedItem.ToString());
            label12.Text = $"{price} лв.";
        }
    }
}
