namespace Task_01
{
    partial class PhoneForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLoading = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDraft = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewOrigin = new System.Windows.Forms.DataGridView();
            this.ColmSurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrigin)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemDraft,
            this.MenuItemSearch});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLoading,
            this.MenuItemSave,
            this.MenuItemClose});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(59, 24);
            this.MenuItemFile.Text = "Файл";
            // 
            // MenuItemLoading
            // 
            this.MenuItemLoading.Name = "MenuItemLoading";
            this.MenuItemLoading.Size = new System.Drawing.Size(224, 26);
            this.MenuItemLoading.Text = "Загрузить";
            this.MenuItemLoading.Click += new System.EventHandler(this.MenuItemLoading_Click);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Size = new System.Drawing.Size(224, 26);
            this.MenuItemSave.Text = "Сохранить";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // MenuItemClose
            // 
            this.MenuItemClose.Name = "MenuItemClose";
            this.MenuItemClose.Size = new System.Drawing.Size(224, 26);
            this.MenuItemClose.Text = "Выход";
            this.MenuItemClose.Click += new System.EventHandler(this.MenuItemClose_Click);
            // 
            // MenuItemDraft
            // 
            this.MenuItemDraft.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemDelete,
            this.MenuItemSort});
            this.MenuItemDraft.Name = "MenuItemDraft";
            this.MenuItemDraft.Size = new System.Drawing.Size(137, 24);
            this.MenuItemDraft.Text = "Редактирование";
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(197, 26);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.Size = new System.Drawing.Size(197, 26);
            this.MenuItemDelete.Text = "Удалить";
            this.MenuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // MenuItemSort
            // 
            this.MenuItemSort.Name = "MenuItemSort";
            this.MenuItemSort.Size = new System.Drawing.Size(197, 26);
            this.MenuItemSort.Text = "Отсортировать";
            this.MenuItemSort.Click += new System.EventHandler(this.MenuItemSort_Click);
            // 
            // MenuItemSearch
            // 
            this.MenuItemSearch.Name = "MenuItemSearch";
            this.MenuItemSearch.Size = new System.Drawing.Size(66, 24);
            this.MenuItemSearch.Text = "Поиск";
            this.MenuItemSearch.Click += new System.EventHandler(this.MenuItemSearch_Click);
            // 
            // dataGridViewOrigin
            // 
            this.dataGridViewOrigin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewOrigin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrigin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColmSurName,
            this.ColmAddress,
            this.ColmPhone});
            this.dataGridViewOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrigin.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewOrigin.Name = "dataGridViewOrigin";
            this.dataGridViewOrigin.RowHeadersWidth = 51;
            this.dataGridViewOrigin.RowTemplate.Height = 24;
            this.dataGridViewOrigin.Size = new System.Drawing.Size(800, 422);
            this.dataGridViewOrigin.TabIndex = 1;
            // 
            // ColmSurName
            // 
            this.ColmSurName.HeaderText = "Фамилия";
            this.ColmSurName.MinimumWidth = 6;
            this.ColmSurName.Name = "ColmSurName";
            // 
            // ColmAddress
            // 
            this.ColmAddress.HeaderText = "Адрес";
            this.ColmAddress.MinimumWidth = 6;
            this.ColmAddress.Name = "ColmAddress";
            // 
            // ColmPhone
            // 
            this.ColmPhone.HeaderText = "Телефон";
            this.ColmPhone.MinimumWidth = 6;
            this.ColmPhone.Name = "ColmPhone";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOrigin);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "PhoneForm";
            this.Text = "Телефоны";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrigin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLoading;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDraft;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSort;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSearch;
        private System.Windows.Forms.DataGridView dataGridViewOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColmSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColmPhone;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

