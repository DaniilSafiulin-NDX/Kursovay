namespace CourseWork
{
    partial class Main
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
            this.Searchtextbox = new System.Windows.Forms.TextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ShowTable = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBuyer = new System.Windows.Forms.ToolStripMenuItem();
            this.добаватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Searchtextbox
            // 
            this.Searchtextbox.Location = new System.Drawing.Point(0, 0);
            this.Searchtextbox.Name = "Searchtextbox";
            this.Searchtextbox.Size = new System.Drawing.Size(100, 22);
            this.Searchtextbox.TabIndex = 0;
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.GridColor = System.Drawing.Color.Silver;
            this.DataGrid.Location = new System.Drawing.Point(21, 95);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.Size = new System.Drawing.Size(1132, 581);
            this.DataGrid.TabIndex = 13;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.White;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowTable,
            this.добаватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1179, 28);
            this.MainMenu.TabIndex = 32;
            this.MainMenu.Text = "menuStrip1";
            // 
            // ShowTable
            // 
            this.ShowTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.notesToolStripMenuItem});
            this.ShowTable.Name = "ShowTable";
            this.ShowTable.Size = new System.Drawing.Size(87, 24);
            this.ShowTable.Text = "Показать";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // ChangeItem
            // 
            this.ChangeItem.Name = "ChangeItem";
            this.ChangeItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ChangeWorker
            // 
            this.ChangeWorker.Name = "ChangeWorker";
            this.ChangeWorker.Size = new System.Drawing.Size(32, 19);
            // 
            // ChangeBuyer
            // 
            this.ChangeBuyer.Name = "ChangeBuyer";
            this.ChangeBuyer.Size = new System.Drawing.Size(32, 19);
            // 
            // добаватьToolStripMenuItem
            // 
            this.добаватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem1,
            this.bookToolStripMenuItem,
            this.notesToolStripMenuItem1});
            this.добаватьToolStripMenuItem.Name = "добаватьToolStripMenuItem";
            this.добаватьToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.добаватьToolStripMenuItem.Text = "Добавать";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem2,
            this.bookToolStripMenuItem1,
            this.notesToolStripMenuItem2});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить ";
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.usersToolStripMenuItem1.Text = "Users";
            this.usersToolStripMenuItem1.Click += new System.EventHandler(this.usersToolStripMenuItem1_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // notesToolStripMenuItem1
            // 
            this.notesToolStripMenuItem1.Name = "notesToolStripMenuItem1";
            this.notesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.notesToolStripMenuItem1.Text = "Notes";
            // 
            // usersToolStripMenuItem2
            // 
            this.usersToolStripMenuItem2.Name = "usersToolStripMenuItem2";
            this.usersToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.usersToolStripMenuItem2.Text = "Users";
            // 
            // bookToolStripMenuItem1
            // 
            this.bookToolStripMenuItem1.Name = "bookToolStripMenuItem1";
            this.bookToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.bookToolStripMenuItem1.Text = "Book";
            // 
            // notesToolStripMenuItem2
            // 
            this.notesToolStripMenuItem2.Name = "notesToolStripMenuItem2";
            this.notesToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.notesToolStripMenuItem2.Text = "Notes ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Searchtextbox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowTable;
        private System.Windows.Forms.ToolStripMenuItem ChangeItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeWorker;
        private System.Windows.Forms.ToolStripMenuItem ChangeBuyer;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добаватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem2;
    }
}

