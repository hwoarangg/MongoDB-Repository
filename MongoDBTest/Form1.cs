using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using System.Dynamic;


namespace MongoDBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Customer item = new Customer();
            item.Name = textBox1.Text.TrimEnd();
            item.Phone = textBox2.Text.TrimEnd();
            int _age = 0;
            int.TryParse(textBox3.Text.TrimEnd(), out _age);
            item.Age = _age;
            item.Mail = textBox4.Text.TrimEnd();

            MongoDbRepository<Customer> Repository = new MongoDbRepository<Customer>();
            WriteConcernResult result = Repository.Insert(item);
            dataGridView1.DataSource = Repository.GetAll();
            MessageBox.Show("Kayıt başarı ile eklendi");

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MongoDbRepository<Customer> Repository = new MongoDbRepository<Customer>();
            dataGridView1.DataSource = Repository.SearchFor(p => p.Name.Contains(textBox1.Text.TrimEnd()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MongoDbRepository<Customer> Repository = new MongoDbRepository<Customer>();
            dataGridView1.DataSource = Repository.GetAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer item = new Customer();
            item.Name = textBox1.Text.TrimEnd();
            item.Phone = textBox2.Text.TrimEnd();
            int _age = 0;
            int.TryParse(textBox3.Text.TrimEnd(), out _age);
            item.Age = _age;
            item.Mail = textBox4.Text.TrimEnd();

            MongoDbRepository<Customer> Repository = new MongoDbRepository<Customer>();
            Customer p = Repository.GetById("5bfb98d78b359f3a54aa27f2");

           
            p.Name = textBox1.Text.TrimEnd();

            WriteConcernResult result = Repository.Update(p);
            if (!result.HasLastErrorMessage)
            {
                dataGridView1.DataSource = Repository.GetAll();
                MessageBox.Show("Kayıt başarı ile güncellendi");
            }
        }
    }
    
}
