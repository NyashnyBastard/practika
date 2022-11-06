using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet4.Выдача_Запрос". При необходимости она может быть перемещена или удалена.
            this.выдача_ЗапросTableAdapter1.Fill(this.biblDataSet4.Выдача_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet3.Читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.biblDataSet3.Читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet2.Выдача". При необходимости она может быть перемещена или удалена.
            this.выдачаTableAdapter.Fill(this.biblDataSet2.Выдача);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet1.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.biblDataSet1.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet.Выдача_Запрос". При необходимости она может быть перемещена или удалена.
            this.выдача_ЗапросTableAdapter.Fill(this.biblDataSet.Выдача_Запрос);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
        }

       

    }
}
    

