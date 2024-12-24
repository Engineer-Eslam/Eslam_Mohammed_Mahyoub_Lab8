using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace إسلام_محمد_مهيوب_المليكي_lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAll.SelectedText.Length > 0)
            {
                txtSelectLength.Text = txtAll.SelectionLength.ToString();
            }
            else
            {
                MessageBox.Show("قم بتحديد النص");
                txtSelectLength.Text = "";
            }
        }

        private void word_Click(object sender, EventArgs e)
        {
            string[] strword = txtAll.Text.Trim().Split(' ','\n','\r');
            int x = 0;
            for (int i = 0; i < strword.Length; i++)
            {
                if (strword[i] != "")
                    x++;
            }
            txtWordCount.Text = x.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAllLength.Text = txtAll.Text.Trim().Length.ToString();
            //txtAllLength.Text = txtAll.TextLength.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtAll.SelectionLength > 0)
            {
                txtAll.SelectedText = "";
            }
            else
            {
                MessageBox.Show("قم بتحديد نص");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtAll.SelectionLength = 0;
        }

        string myselectedtext = "";

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtAll.SelectedText.Length > 0)
            {
                myselectedtext = txtAll.SelectedText;
            }
            else
            {
                MessageBox.Show("لا يوجد نص محدد");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtAll.SelectedText.Length > 0)
            {
                myselectedtext = txtAll.SelectedText;
                txtAll.SelectedText = null;
            }
            else
            {
                MessageBox.Show("لا يوجد نص محدد");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtAll.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < txtAll.Text.Length; i++)
            {
                if (txtAll.Text[i] != ' ')
                {
                    x++;
                }
            }
            MessageBox.Show(x.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < txtAll.SelectedText.Length; i++)
            {
                if (txtAll.SelectedText[i] != ' ')
                {
                    x++;
                }
            }
            MessageBox.Show(x.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtAll.SelectionLength > 0)
            {
                if (textreplace.Text.Trim() != "")
                {
                    txtAll.SelectedText = textreplace.Text;
                }
                else
                    MessageBox.Show("ادخل النص الجديد");
            }
            else

                MessageBox.Show("حدد النص المراد تعديلة");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonretreat_Click(object sender, EventArgs e)
        {
            txtAll.Undo();
            txtCopyPast.Undo();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                int index = txtAll.Text.IndexOf(txtSearch.Text, 0);
                if (index > -1)
                {
                    txtAll.SelectionStart = index;
                    txtAll.SelectionLength = txtSearch.Text.Length;
                    txtAll.Focus();
                }
                else
                    MessageBox.Show("not fond");
            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنه");
                txtSearch.Focus();

            }
        }

        private void buttonsearch1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {

                int index = txtAll.Text.IndexOf(txtSearch.Text, txtAll.SelectionStart + txtAll.SelectionLength);
                if (index > -1)
                {
                    txtAll.Focus();
                    txtAll.Select(index, txtSearch.Text.Length);
                }
                else
                    MessageBox.Show("not fond");
            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنه");
                txtSearch.Focus();
            }
        }
        
        private void buttonsearch2_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                if (txtAll.SelectionStart - txtAll.SelectionLength < 0)
                {
                    MessageBox.Show("لا توجد تطابقات سابقة");
                    return;
                }
                int index = txtAll.Text.LastIndexOf(txtSearch.Text, txtAll.SelectionStart - txtAll.SelectionLength);
                if (index > -1)
                {
                    txtAll.Focus();
                    txtAll.Select(index, txtSearch.Text.Length);
                }
                else
                    MessageBox.Show("not fond");
            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنة");
                txtSearch.Focus();
            }
        }

        private void buttonchar_Click(object sender, EventArgs e)
        {
            listBoxchar.Items.Clear();
            string s = txtAll.SelectedText;
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
                listBoxchar.Items.Add(ch[i]);
        }

        private void buttonword_Click(object sender, EventArgs e)
        {
            listBoxword.Items.Clear();
            string[] s = txtAll.SelectedText.Split(' ', '\n', '\r');
            for (int i = 0; i < s.Length; i++)
                if (s[i] != "")
                    listBoxword.Items.Add(s[i]);
        }

        private void buttonpaste_Click(object sender, EventArgs e)
        {
            txtCopyPast.Text += myselectedtext.Trim();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                string searchText = txtSearch.Text;
                string allText = txtAll.Text;
                int startIndex = 0;
                bool found = false;
                // البحث عن جميع التطابقات
                while ((startIndex = allText.IndexOf(searchText, startIndex)) != -1)
                {
                    txtAll.SelectionStart = startIndex;
                    txtAll.SelectionLength = searchText.Length;
                    txtAll.Focus();
                    found = true;
                    // انتظار قصير لرؤية التحديد
                    System.Threading.Thread.Sleep(2000); // 2s
                    startIndex += searchText.Length; // الانتقال إلى الجزء التالي
                }
                if (!found)
                {
                    MessageBox.Show("لم يتم العثور على النص المطلوب");
                }
            }
            else
            {
                MessageBox.Show("الرجاء إدخال النص المراد البحث عنه");
                txtSearch.Focus();
            }
        }

        private void txtAll_TextChanged(object sender, EventArgs e)
        {
            txtAllLength.Text = txtWordCount.Text = "";
        }

    }
}