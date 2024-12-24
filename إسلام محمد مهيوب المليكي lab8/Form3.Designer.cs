namespace إسلام_محمد_مهيوب_المليكي_lab8
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAddItem = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtSumItems = new System.Windows.Forms.TextBox();
            this.txtAverageItems = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnSumItems = new System.Windows.Forms.Button();
            this.btnAverageItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddItem
            // 
            this.txtAddItem.Location = new System.Drawing.Point(21, 12);
            this.txtAddItem.Name = "txtAddItem";
            this.txtAddItem.Size = new System.Drawing.Size(212, 30);
            this.txtAddItem.TabIndex = 0;
            this.txtAddItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddItem_MouseClick);
            this.txtAddItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddItem_KeyPress);
            this.txtAddItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddItem_KeyUp);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(21, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 234);
            this.listBox1.TabIndex = 1;
            // 
            // txtSumItems
            // 
            this.txtSumItems.BackColor = System.Drawing.Color.Azure;
            this.txtSumItems.Location = new System.Drawing.Point(21, 312);
            this.txtSumItems.Name = "txtSumItems";
            this.txtSumItems.ReadOnly = true;
            this.txtSumItems.Size = new System.Drawing.Size(212, 30);
            this.txtSumItems.TabIndex = 2;
            // 
            // txtAverageItems
            // 
            this.txtAverageItems.BackColor = System.Drawing.Color.Azure;
            this.txtAverageItems.Location = new System.Drawing.Point(21, 361);
            this.txtAverageItems.Name = "txtAverageItems";
            this.txtAverageItems.ReadOnly = true;
            this.txtAverageItems.Size = new System.Drawing.Size(212, 30);
            this.txtAverageItems.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(275, 9);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(113, 37);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "إضافة";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.LightCyan;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(275, 94);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(113, 37);
            this.btnDeleteItem.TabIndex = 10;
            this.btnDeleteItem.Text = "حذف";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.LightCyan;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Location = new System.Drawing.Point(275, 148);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(113, 37);
            this.btnDeleteAll.TabIndex = 11;
            this.btnDeleteAll.Text = "حذف الكل";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnSumItems
            // 
            this.btnSumItems.BackColor = System.Drawing.Color.LightCyan;
            this.btnSumItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSumItems.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumItems.Location = new System.Drawing.Point(275, 309);
            this.btnSumItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSumItems.Name = "btnSumItems";
            this.btnSumItems.Size = new System.Drawing.Size(113, 37);
            this.btnSumItems.TabIndex = 12;
            this.btnSumItems.Text = "المجموع";
            this.btnSumItems.UseVisualStyleBackColor = false;
            this.btnSumItems.Click += new System.EventHandler(this.btnSumItems_Click);
            // 
            // btnAverageItems
            // 
            this.btnAverageItems.BackColor = System.Drawing.Color.LightCyan;
            this.btnAverageItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAverageItems.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverageItems.Location = new System.Drawing.Point(275, 358);
            this.btnAverageItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAverageItems.Name = "btnAverageItems";
            this.btnAverageItems.Size = new System.Drawing.Size(113, 37);
            this.btnAverageItems.TabIndex = 13;
            this.btnAverageItems.Text = "المعدل";
            this.btnAverageItems.UseVisualStyleBackColor = false;
            this.btnAverageItems.Click += new System.EventHandler(this.btnAverageItems_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 406);
            this.Controls.Add(this.btnAverageItems);
            this.Controls.Add(this.btnSumItems);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtAverageItems);
            this.Controls.Add(this.txtSumItems);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtAddItem);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtSumItems;
        private System.Windows.Forms.TextBox txtAverageItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnSumItems;
        private System.Windows.Forms.Button btnAverageItems;
    }
}