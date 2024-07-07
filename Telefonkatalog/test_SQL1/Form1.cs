using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace test_SQL1
{
    public partial class Form1 : Form
    {
        WorkDB WDB = new WorkDB();
        public Form1()
        {
            InitializeComponent();

            //переход по текстбоксам номера телефона
            teleph1.KeyUp += new KeyEventHandler(teleph1_KeyUp);
            teleph2.KeyUp += new KeyEventHandler(teleph2_KeyUp);
            teleph3.KeyUp += new KeyEventHandler(teleph3_KeyUp);
            teleph4.KeyUp += new KeyEventHandler(teleph4_KeyUp);
            teleph5.KeyUp += new KeyEventHandler(teleph5_KeyUp);

            System.Windows.Forms.ToolTip btt1 = new System.Windows.Forms.ToolTip();
            btt1.ToolTipTitle = "Выбор сортировки";
            btt1.UseAnimation = true;
            btt1.IsBalloon = true;
            btt1.ShowAlways = true;
            btt1.AutoPopDelay = 4500;
            btt1.InitialDelay = 500;
            btt1.ReshowDelay = 500;
            btt1.SetToolTip(panel4, "Флажки слева сортировка по алфавиту, справа против.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //значения номера телефона
                string[] tel = new string[] { teleph1.Text , teleph2.Text , teleph3.Text , teleph4.Text , teleph5.Text, teleph6.Text };

                //выборка
                string where = null;
                // 0 - фамилия, 1 - улица, 2 - дом, 3 - квартира, 4 - телефон
                string[] where_all = new string[] { null, null, null, null, null };

                //сортировка
                string order = null;
                // 0 - фамилия, 1 - улица, 2 - дом, 3 - квартира, 4 - телефон
                string[] order_all = new string[] { null, null, null, null, null };

                //запрос
                string zapros = null;

                Cursor = Cursors.WaitCursor;

                //проверка на ввод фамилии и инициалов
                switch (!string.IsNullOrWhiteSpace(textBox_FIO.Text))
                {
                    case true:
                        switch (!string.IsNullOrWhiteSpace(textBox_IO.Text))
                        {
                            case true:
                                where_all[0] = "(FIO LIKE '" + textBox_FIO.Text + "% " + textBox_IO.Text + "%')";
                                break;
                            case false:
                                where_all[0] = "(FIO LIKE '" + textBox_FIO.Text + "%')";
                                break;
                        }
                        break;
                    case false:
                        switch (!string.IsNullOrWhiteSpace(textBox_IO.Text))
                        {
                            case true:
                                where_all[0] = "(FIO LIKE '% " + textBox_IO.Text + "%')";
                                break;
                            case false:
                                break;
                        }
                        break;
                }

                //проверка на ввод улицы
                if (!string.IsNullOrWhiteSpace(textBox_ULC.Text)) { where_all[1] = "(ULC LIKE '" + textBox_ULC.Text + "%')"; }

                //проверка на ввод дома
                if (textBox_DOM.Text == "А" || textBox_DOM.Text == "Б" || textBox_DOM.Text == "/" || textBox_DOM.Text == "-") { textBox_DOM.Text ="%" + textBox_DOM.Text; }
                if (!string.IsNullOrWhiteSpace(textBox_DOM.Text)) { where_all[2] = "(DOM LIKE '" + textBox_DOM.Text + "%')"; }
                //проверка на ввод квартиры
                if (!string.IsNullOrWhiteSpace(textBox_KVR.Text)) { where_all[3] = "(KVR LIKE '" + textBox_KVR.Text + "%')"; }

                //проверка на ввод номера телефона
                if (!string.IsNullOrWhiteSpace(tel[0]) || !string.IsNullOrWhiteSpace(tel[1]) || !string.IsNullOrWhiteSpace(tel[2]) || !string.IsNullOrWhiteSpace(tel[3]) || !string.IsNullOrWhiteSpace(tel[4]) || !string.IsNullOrWhiteSpace(tel[5])) 
                {
                    for (int i = 0; i < 6; i = i + 1)
                    {
                        if (string.IsNullOrWhiteSpace(tel[i])) { tel[i] = "_"; }
                    }

                    where_all[4] = "(TEL LIKE '" + tel[0] + tel[1] + tel[2] + tel[3] + tel[4] + tel[5] +  "')";
                }



                //проверка включенных флажков
                if (checkBox_fio_asc.Checked == true) { order_all[0] = "FIO ASC"; }
                if (checkBox_fio_desc.Checked == true) { order_all[0] = "FIO DESC"; }

                if (checkBox_ulc_asc.Checked == true) { order_all[1] = "ULC ASC"; }
                if (checkBox_ulc_desc.Checked == true) { order_all[1] = "ULC DESC"; }

                if (checkBox_dom_asc.Checked == true) { order_all[2] = "DOM ASC"; }
                if (checkBox_dom_desc.Checked == true) { order_all[2] = "DOM DESC"; }

                if (checkBox_kvr_asc.Checked == true) { order_all[3] = "KVR ASC"; }
                if (checkBox_kvr_desc.Checked == true) { order_all[3] = "KVR DESC"; }

                if (checkBox_tel_asc.Checked == true) { order_all[4] = "TEL ASC"; }
                if (checkBox_tel_desc.Checked == true) { order_all[4] = "TEL DESC"; }



                //добавление в запрос WHERE
                for (int i = 0; i < 5; i = i + 1)
                {
                    if (!string.IsNullOrWhiteSpace(where_all[i]))
                    {
                        switch (!string.IsNullOrWhiteSpace(where))
                        {
                            case true:
                                where = where + " AND " + where_all[i];
                                break;
                            case false:
                                where = "WHERE " + where_all[i];
                                break;
                        }
                    }
                }


                //добавление в запрос ORDER
                for (int i = 0; i < 5; i = i + 1)
                {
                    if (!string.IsNullOrWhiteSpace(order_all[i]))
                    {
                        switch (!string.IsNullOrWhiteSpace(order))
                        {
                            case true:
                                order = order + ", " + order_all[i];
                                break;
                            case false:
                                order = "ORDER BY " + order_all[i];
                                break;
                        }
                    }
                }


                //формирование всей строки запроса
                switch (!string.IsNullOrWhiteSpace(where))
                {
                    case true:
                        zapros = "SELECT FIO AS ФИО,TEL AS Телефон, ULC AS Улица,DOM AS Дом,KVR AS Квартира FROM TELEPH " + where;
                        break;
                    case false:
                        zapros = "SELECT FIO AS ФИО,TEL AS Телефон, ULC AS Улица,DOM AS Дом,KVR AS Квартира FROM TELEPH ";
                        break;
                }
                if (!string.IsNullOrWhiteSpace(order)) { zapros = zapros + order; }


                DataTable dt = WDB.Execute(zapros);
                dataGridView1.DataSource = dt;
                toolStripStatusLabel1.Text = string.Format("Количество строк: {0}", dt.Rows.Count);
                textBox_zapros.Text = zapros;
            }
            finally { Cursor = Cursors.Default; }

        }


        //фокус на номере
        private void teleph1_KeyUp(object sender, KeyEventArgs e)
        {
            if (teleph1.Text.Length == teleph1.MaxLength)
            {
                teleph2.Focus();
            }
        }
        private void teleph2_KeyUp(object sender, KeyEventArgs e)
        {
            if (teleph2.Text.Length == teleph2.MaxLength)
            {
                teleph3.Focus();
            }
        }
        private void teleph3_KeyUp(object sender, KeyEventArgs e)
        {
            if (teleph3.Text.Length == teleph3.MaxLength)
            {
                teleph4.Focus();
            }
        }
        private void teleph4_KeyUp(object sender, KeyEventArgs e)
        {
            if (teleph4.Text.Length == teleph4.MaxLength)
            {
                teleph5.Focus();
            }
        }
        private void teleph5_KeyUp(object sender, KeyEventArgs e)
        {
            if (teleph5.Text.Length == teleph5.MaxLength)
            {
                teleph6.Focus();
            }
        }

        //выбор флажка
        private void checkBox_fio_asc_CheckedChanged(object sender, EventArgs e) { checkBox_fio_desc.Checked = false; }
        private void checkBox_fio_desc_CheckedChanged(object sender, EventArgs e) { checkBox_fio_asc.Checked = false; }
        private void checkBox_ulc_asc_CheckedChanged(object sender, EventArgs e) { checkBox_ulc_desc.Checked = false; }
        private void checkBox_ulc_desc_CheckedChanged(object sender, EventArgs e) { checkBox_ulc_asc.Checked = false; }
        private void checkBox_dom_asc_CheckedChanged(object sender, EventArgs e) { checkBox_dom_desc.Checked = false; }
        private void checkBox_dom_desc_CheckedChanged(object sender, EventArgs e) { checkBox_dom_asc.Checked = false; }
        private void checkBox_kvr_asc_CheckedChanged(object sender, EventArgs e) { checkBox_kvr_desc.Checked = false; }
        private void checkBox_kvr_desc_CheckedChanged(object sender, EventArgs e) { checkBox_kvr_asc.Checked = false; }
        private void checkBox_tel_asc_CheckedChanged(object sender, EventArgs e) { checkBox_tel_desc.Checked = false; }
        private void checkBox_tel_desc_CheckedChanged(object sender, EventArgs e) { checkBox_tel_asc.Checked = false; }
        


        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
