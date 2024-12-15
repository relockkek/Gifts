using Планировщик_Подарков;

namespace Планировщик_Подарков
{
    public partial class Form1 : Form
    {
        DB db;

        public Form1()
        {
            InitializeComponent();
            db = new DB();
        }


        private void записьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }







        //Удалить
        private void подарокToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Gifts gift = listView2.SelectedItems[0].Tag as Gifts;
            db.RemoveGift(gift);
        }
        private void праздникToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Holidays holidays = listView2.SelectedItems[0].Tag as Holidays;
            db.RemoveHoliday(holidays);
        }

        private void челикToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                Human human = listView1.SelectedItems[0].Tag as Human;
                db.RemoveHuman(human);
            }
        }
        //
        private void подарокToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        private void челикToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void праздникToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }





        //1 окно
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            List<Human> result = db.Search(search);
            listView1.Items.Clear();
            foreach (Human item in result)
            {
                ListViewItem row = new ListViewItem();
                row.Text = item.LastName;
                row.Tag = item;
                row.SubItems.Add(item.FirstName);
                row.SubItems.Add(item.PatronymicName);

                row.SubItems.Add(item.DR);
                listView1.Items.Add(row);

            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Human human = listView1.SelectedItems[0].Tag as Human;
            db.Save(human);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(db);
            form2.Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Human human = listView1.SelectedItems[0].Tag as Human;
                if (MessageBox.Show("Вы точно собираетесь удалить запись из бд?",
                    "Страшное предупреждение", MessageBoxButtons.YesNo) ==
                     DialogResult.Yes)
                {
                    db.RemoveHuman(human);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            List<Human> result = db.Search(search);
            listView1.Items.Clear();
            listView2.Items.Clear();
        }
    }
}

