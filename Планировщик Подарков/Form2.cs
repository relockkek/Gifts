using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Планировщик_Подарков
{
    public partial class Form2 : Form
    {
        private readonly DB db;
        private Human human;
        private Holidays holidays;
        private Gifts gifts;
        public Form2(DB db)
        {
            InitializeComponent();
            this.db = db;
            human = new Human();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            human.FirstName = textFirstName.Text;
            human.LastName = textLastName.Text;
            human.PatronymicName = textPatronymicName.Text;
            human.DR = textDR.Text;
            if (db != null)
            {
                db.AddHuman(human);
                DialogResult = DialogResult.OK;
                Close();



            }
        }
    }
}
