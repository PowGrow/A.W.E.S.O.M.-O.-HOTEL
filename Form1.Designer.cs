
namespace ExcelParcer
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.fileselectButton = new System.Windows.Forms.Button();
            this.fileselectTextbox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.StatusLable = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.OptionToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImport = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(3, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 58);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(795, 392);
            this.dataGridView.TabIndex = 1;
            // 
            // fileselectButton
            // 
            this.fileselectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileselectButton.Location = new System.Drawing.Point(660, 29);
            this.fileselectButton.Name = "fileselectButton";
            this.fileselectButton.Size = new System.Drawing.Size(138, 23);
            this.fileselectButton.TabIndex = 2;
            this.fileselectButton.Text = "Выбрать файл";
            this.fileselectButton.UseVisualStyleBackColor = true;
            this.fileselectButton.Click += new System.EventHandler(this.FileselectButton_Click);
            // 
            // fileselectTextbox
            // 
            this.fileselectTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileselectTextbox.Location = new System.Drawing.Point(383, 29);
            this.fileselectTextbox.Name = "fileselectTextbox";
            this.fileselectTextbox.Size = new System.Drawing.Size(271, 23);
            this.fileselectTextbox.TabIndex = 3;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(84, 29);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(293, 23);
            this.SearchTextBox.TabIndex = 4;
            // 
            // StatusLable
            // 
            this.StatusLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLable.AutoSize = true;
            this.StatusLable.Location = new System.Drawing.Point(12, 453);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(10, 15);
            this.StatusLable.TabIndex = 5;
            this.StatusLable.Text = " ";
            // 
            // menuStrip
            // 
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 6;
            // 
            // OptionToolStrip
            // 
            this.OptionToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExport,
            this.toolStripMenuItemImport});
            this.OptionToolStrip.Name = "OptionToolStrip";
            this.OptionToolStrip.Size = new System.Drawing.Size(56, 20);
            this.OptionToolStrip.Text = "Опции";
            // 
            // toolStripMenuItemExport
            // 
            this.toolStripMenuItemExport.Name = "toolStripMenuItemExport";
            this.toolStripMenuItemExport.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemExport.Text = "Экспорд в БД";
            this.toolStripMenuItemExport.Click += new System.EventHandler(this.StripMenuItemExport_Click);
            // 
            // toolStripMenuItemImport
            // 
            this.toolStripMenuItemImport.Name = "toolStripMenuItemImport";
            this.toolStripMenuItemImport.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItemImport.Text = "Импорт в БД";
            this.toolStripMenuItemImport.Click += new System.EventHandler(this.StripMenuItemImport_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.fileselectTextbox);
            this.Controls.Add(this.fileselectButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "A.W.E.S.O.M.-O HOTEL";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button fileselectButton;
        private System.Windows.Forms.TextBox fileselectTextbox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label StatusLable;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem importDbToolStrip;
        private System.Windows.Forms.ToolStripMenuItem OptionToolStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImport;
    }
}

