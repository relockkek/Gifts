namespace Планировщик_Подарков
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            записьToolStripMenuItem = new ToolStripMenuItem();
            новаяToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            подарокToolStripMenuItem1 = new ToolStripMenuItem();
            челикToolStripMenuItem1 = new ToolStripMenuItem();
            праздникToolStripMenuItem1 = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            подарокToolStripMenuItem2 = new ToolStripMenuItem();
            челикToolStripMenuItem2 = new ToolStripMenuItem();
            праздникToolStripMenuItem2 = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            listView3 = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader6 });
            listView1.Location = new Point(12, 121);
            listView1.Name = "listView1";
            listView1.Size = new Size(426, 417);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Фамилия";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Имя";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Отчество";
            columnHeader3.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Днюха";
            columnHeader6.Width = 100;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { записьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1490, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // записьToolStripMenuItem
            // 
            записьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новаяToolStripMenuItem, редактироватьToolStripMenuItem, удалитьToolStripMenuItem, сохранитьToolStripMenuItem, загрузитьToolStripMenuItem });
            записьToolStripMenuItem.Name = "записьToolStripMenuItem";
            записьToolStripMenuItem.Size = new Size(58, 20);
            записьToolStripMenuItem.Text = "Запись";
            записьToolStripMenuItem.Click += записьToolStripMenuItem_Click;
            // 
            // новаяToolStripMenuItem
            // 
            новаяToolStripMenuItem.Name = "новаяToolStripMenuItem";
            новаяToolStripMenuItem.Size = new Size(154, 22);
            новаяToolStripMenuItem.Text = "Новая";
            новаяToolStripMenuItem.Click += новаяToolStripMenuItem_Click;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { подарокToolStripMenuItem1, челикToolStripMenuItem1, праздникToolStripMenuItem1 });
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(154, 22);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            редактироватьToolStripMenuItem.Click += редактироватьToolStripMenuItem_Click;
            // 
            // подарокToolStripMenuItem1
            // 
            подарокToolStripMenuItem1.Name = "подарокToolStripMenuItem1";
            подарокToolStripMenuItem1.Size = new Size(127, 22);
            подарокToolStripMenuItem1.Text = "Подарок";
            // 
            // челикToolStripMenuItem1
            // 
            челикToolStripMenuItem1.Name = "челикToolStripMenuItem1";
            челикToolStripMenuItem1.Size = new Size(127, 22);
            челикToolStripMenuItem1.Text = "Челик";
            // 
            // праздникToolStripMenuItem1
            // 
            праздникToolStripMenuItem1.Name = "праздникToolStripMenuItem1";
            праздникToolStripMenuItem1.Size = new Size(127, 22);
            праздникToolStripMenuItem1.Text = "Праздник";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { подарокToolStripMenuItem2, челикToolStripMenuItem2, праздникToolStripMenuItem2 });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(154, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // подарокToolStripMenuItem2
            // 
            подарокToolStripMenuItem2.Name = "подарокToolStripMenuItem2";
            подарокToolStripMenuItem2.Size = new Size(127, 22);
            подарокToolStripMenuItem2.Text = "Подарок";
            подарокToolStripMenuItem2.Click += подарокToolStripMenuItem2_Click_1;
            // 
            // челикToolStripMenuItem2
            // 
            челикToolStripMenuItem2.Name = "челикToolStripMenuItem2";
            челикToolStripMenuItem2.Size = new Size(127, 22);
            челикToolStripMenuItem2.Text = "Челик";
            челикToolStripMenuItem2.Click += челикToolStripMenuItem2_Click;
            // 
            // праздникToolStripMenuItem2
            // 
            праздникToolStripMenuItem2.Name = "праздникToolStripMenuItem2";
            праздникToolStripMenuItem2.Size = new Size(127, 22);
            праздникToolStripMenuItem2.Text = "Праздник";
            праздникToolStripMenuItem2.Click += праздникToolStripMenuItem2_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(154, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(154, 22);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9 });
            listView2.Location = new Point(968, 121);
            listView2.Name = "listView2";
            listView2.Size = new Size(471, 417);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Наименования";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Дата";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Описание";
            columnHeader9.Width = 100;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader16, columnHeader17 });
            listView3.Location = new Point(444, 121);
            listView3.Name = "listView3";
            listView3.Size = new Size(505, 417);
            listView3.TabIndex = 6;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Наименование";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Стоимость (руб)";
            columnHeader14.Width = 100;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Идентификатор персоны";
            columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Идентификатор праздника";
            columnHeader17.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Чебоксары";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(968, 91);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Праздник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 91);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 9;
            label3.Text = "Ядерка";
            // 
            // button1
            // 
            button1.Location = new Point(409, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 751);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem записьToolStripMenuItem;
        private ToolStripMenuItem новаяToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private TextBox textBox1;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ListView listView3;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ToolStripMenuItem подарокToolStripMenuItem1;
        private ToolStripMenuItem челикToolStripMenuItem1;
        private ToolStripMenuItem праздникToolStripMenuItem1;
        private ToolStripMenuItem подарокToolStripMenuItem2;
        private ToolStripMenuItem челикToolStripMenuItem2;
        private ToolStripMenuItem праздникToolStripMenuItem2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
