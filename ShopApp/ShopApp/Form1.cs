using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class Form1: Form
    {
        string connectionString = "Server=localhost;Database=KrylFondMarket;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sql = @"
              SELECT Поставщики.Наименование AS Поставщик, ТоварыНаименование AS Товар, Поставки.Количество, Поставки.[Дата поставки]
              FROM Поставки
              JOIN Поставщики ON Поставки.IDПоставщика = Поставщики.IDПоставщика
              JOIN Товары ON Поставки.IDТовара = Товары.IDТовара
              WHERE Поставки.IDМагазина = 1";
        }
    }
}
