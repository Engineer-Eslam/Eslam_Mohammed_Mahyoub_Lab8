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
    public partial class Form2 : Form
    {
        private string clipboard = ""; // لحفظ النصوص المنسوخة أو المقتصة التي تم تحديدها
        private List<string> undoList = new List<string>(); // قائمة لتخزين النصوص السابقة
        private const int MaxUndoCount = 10; // الحد الأقصى لعدد العمليات المحفوظة
        private bool isUndoing = false; // لمنع تخزين النص أثناء التراجع

        public Form2()
        {
            InitializeComponent();
            SaveUndoOperation(textBox2.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length > 0)
            {
                clipboard = textBox1.SelectedText; // نسخ النص المحدد
            }
            else
            {
                MessageBox.Show("لا يوجد نص محدد", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length > 0)
            {
                clipboard = textBox1.SelectedText; // قص النص المحدد
                textBox1.SelectedText = null; // حذف النص المحدد
            }
            else
            {
                MessageBox.Show("لا يوجد نص محدد", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            
        }

        private void SaveUndoOperation(string newText)
        {
            // إذا تجاوز عدد العمليات الحد الأقصى، قم بحذف الأقدم
            if (undoList.Count >= MaxUndoCount)
            {
                undoList.RemoveAt(0); // حذف أول عملية
            }
            // إضافة النص الحالي إلى نهاية القائمة
            undoList.Add(newText);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (clipboard.Trim() != "")
            {
                textBox2.Text += clipboard; // لصق النص في المربع الثاني
                SaveUndoOperation(textBox2.Text); // حفظ العملية في قائمة العمليات
            }
            else
            {
                MessageBox.Show("لا يوجد نص ليتم لصقه ", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (isUndoing)
                return; // إذا كان التغيير ناتجًا عن عملية تراجع، لا تخزن النص
            SaveUndoOperation(textBox2.Text); // حفظ النص الجديد في قائمة العمليات
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (undoList.Count > 1) // يجب أن يكون هناك عملية للتراجع
            {
                isUndoing = true; // لمنع تخزين النص أثناء التراجع
                // حذف آخر عملية واستعادة النص السابق
                undoList.RemoveAt(undoList.Count - 1); // إزالة آخر عملية من قائمة حفظ العمليات
                textBox2.Text = undoList[undoList.Count - 1]; // الرجوع عن أخر عمليه تم اجرائها
                isUndoing = false;
            }  
            else
            {
                MessageBox.Show("لا توجد عمليات تراجع ", "   خطأ   ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // الخروج من التطبيق
        }

        
    }
}
