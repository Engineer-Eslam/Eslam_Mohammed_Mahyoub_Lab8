using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //استدعاء داله اضافه العشرة العناصر العشوائية للقائمة 
            InitializeRandomNumbers();
            txtSumItems.ReadOnly = txtAverageItems.ReadOnly = true;
            txtAddItem.TextAlign =txtSumItems.TextAlign= txtAverageItems.TextAlign= HorizontalAlignment.Center;
        }

        //داله لإضافه عشره عناصر عشوائية للقائمة عند بدأ التنفيذ
        private void InitializeRandomNumbers()
        {
            Random random = new Random();
            HashSet<int> randomNumbers = new HashSet<int>(); // استخدام HashSet لضمان عدم التكرار
            while (randomNumbers.Count < 10)
            {
                int number = random.Next(1, 101); // توليد رقم عشوائي بين 1 و 100
                randomNumbers.Add(number); // الإضافة إلى المجموعه
            }
            foreach (double number in randomNumbers)
            {
                listBox1.Items.Add(number); // إضافة الأرقام إلى القائمة
            }
        }
        

        private void txtAddItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar != 45))
                e.Handled = true;
            // السماح بإدخال إشارة السالب فقط إذا كانت غير موجودة وفي البداية
            if (e.KeyChar == 45)
            {
                if (txtAddItem.Text.Contains("-") || txtAddItem.SelectionStart != 0)
                {
                    e.Handled = true; // منع إدخال إشارة السالب إذا كانت موجودة بالفعل أو إذا لم يكن المؤشر في البداية
                }
            }
            // السماح بإدخال النقطة العشرية فقط إذا لم تكن موجودة بالفعل
            if (e.KeyChar == 46)
            {
                if (txtAddItem.Text.Contains("."))
                {
                    e.Handled = true; // منع إدخال نقطة إضافية إذا كانت النقطة موجودة بالفعل
                }
            }
        }

        private void txtAddItem_MouseClick(object sender, MouseEventArgs e)
        {
            // منع النقر ووضع المؤشر قبل إشارة السالب
            if (txtAddItem.Text.StartsWith("-") && txtAddItem.SelectionStart == 0)
            {
                txtAddItem.SelectionStart = 1; // نقل المؤشر تلقائيًا إلى بعد السالب
            }
        }

        private void txtAddItem_KeyUp(object sender, KeyEventArgs e)
        {
            // منع نقل المؤشر إلى ما قبل إشارة السالب بعد كتابة أي نص
            if (txtAddItem.Text.StartsWith("-") && txtAddItem.SelectionStart == 0)
            {
                txtAddItem.SelectionStart = 1; // نقل المؤشر تلقائيًا إلى بعد السالب
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtAddItem.Text.Trim() != "")
            {
                double item = Convert.ToDouble(txtAddItem.Text);
                if (item > 100)
                {
                    MessageBox.Show("القيمة التالية أكبر من 100 فلايمكن إضافتها إلى القائمة", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    txtAddItem.Text = "";
                    txtAddItem.Focus();
                    return;
                }

                if (listBox1.Items.Contains(item))
                {
                    MessageBox.Show("القيمة التالية موجودة في القائمة لايمكن إضافتها", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    txtAddItem.Text = "";
                    txtAddItem.Focus();
                    return;
                }

                if (listBox1.Items.Count >= 20)
                {
                    listBox1.Items.RemoveAt(0);
                }

                listBox1.Items.Add(item); // إضافة الرقم إلى القائمة
                txtAddItem.Text = txtSumItems.Text = txtAverageItems.Text = ""; // مسح المربعات النصية
                txtAddItem.Focus();
            }
            else
            {
                MessageBox.Show("لايوجد قيمة يمكن إضافتها إلى القائمة", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                txtAddItem.Focus();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                txtAddItem.Text = txtSumItems.Text = txtAverageItems.Text = ""; // مسح المربعات النصية
            }
            else
                MessageBox.Show("لم يتم تحديد أي عنصر ليتم حذفه من القائمة", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            txtAddItem.Text = txtSumItems.Text = txtAverageItems.Text = ""; // مسح المربعات النصية
        }

        //داله لإيجاد مجموع عناصر القائمة 
        private double SumListItems()
        {
            double sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sum += Convert.ToDouble(listBox1.Items[i]);
            }
            return sum;
        }

        private void btnSumItems_Click(object sender, EventArgs e)
        {
            txtSumItems.Text = (SumListItems()).ToString();
        }

        private void btnAverageItems_Click(object sender, EventArgs e)
        {
            if (txtSumItems.Text.Trim() != "")
                txtAverageItems.Text = ((Convert.ToDouble(txtSumItems.Text)) / listBox1.Items.Count).ToString();
            else
                txtAverageItems.Text = ((SumListItems()) / listBox1.Items.Count).ToString();
        }

    }
}
