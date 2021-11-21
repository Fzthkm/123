
namespace testRcomr
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.Button();
            this.StuffName = new System.Windows.Forms.TextBox();
            this.Organisation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.to = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.selectAll = new System.Windows.Forms.Button();
            this.Complete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docs = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Docs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 219);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Документы";
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.White;
            this.filter.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filter.Location = new System.Drawing.Point(7, 328);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(253, 45);
            this.filter.TabIndex = 11;
            this.filter.Text = "Найти";
            this.filter.UseVisualStyleBackColor = false;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // StuffName
            // 
            this.StuffName.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StuffName.Location = new System.Drawing.Point(7, 195);
            this.StuffName.Name = "StuffName";
            this.StuffName.Size = new System.Drawing.Size(253, 27);
            this.StuffName.TabIndex = 10;
            // 
            // Organisation
            // 
            this.Organisation.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Organisation.Location = new System.Drawing.Point(7, 140);
            this.Organisation.Name = "Organisation";
            this.Organisation.Size = new System.Drawing.Size(253, 27);
            this.Organisation.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Организация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Наименование груза";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "по";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата c";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.to);
            this.panel2.Controls.Add(this.from);
            this.panel2.Controls.Add(this.selectAll);
            this.panel2.Controls.Add(this.Complete);
            this.panel2.Controls.Add(this.filter);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.StuffName);
            this.panel2.Controls.Add(this.Organisation);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 430);
            this.panel2.TabIndex = 1;
            // 
            // to
            // 
            this.to.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.to.Location = new System.Drawing.Point(71, 89);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(95, 27);
            this.to.TabIndex = 16;
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.from.Location = new System.Drawing.Point(71, 57);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(95, 27);
            this.from.TabIndex = 15;
            // 
            // selectAll
            // 
            this.selectAll.BackColor = System.Drawing.Color.White;
            this.selectAll.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectAll.Location = new System.Drawing.Point(7, 277);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(253, 45);
            this.selectAll.TabIndex = 14;
            this.selectAll.Text = "Выбрать всё";
            this.selectAll.UseVisualStyleBackColor = false;
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // Complete
            // 
            this.Complete.BackColor = System.Drawing.Color.White;
            this.Complete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Complete.Location = new System.Drawing.Point(7, 379);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(253, 45);
            this.Complete.TabIndex = 13;
            this.Complete.Text = "Копировать";
            this.Complete.UseVisualStyleBackColor = false;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Груз";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Grid1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(266, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 430);
            this.panel3.TabIndex = 2;
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Date,
            this.Org,
            this.gridName,
            this.Path});
            this.Grid1.Location = new System.Drawing.Point(3, 37);
            this.Grid1.Name = "Grid1";
            this.Grid1.RowTemplate.Height = 25;
            this.Grid1.Size = new System.Drawing.Size(716, 387);
            this.Grid1.TabIndex = 2;
            // 
            // Check
            // 
            this.Check.HeaderText = "_";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Check.Width = 20;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // Org
            // 
            this.Org.HeaderText = "Организация";
            this.Org.Name = "Org";
            this.Org.Width = 200;
            // 
            // gridName
            // 
            this.gridName.HeaderText = "Наименование";
            this.gridName.Name = "gridName";
            this.gridName.Width = 300;
            // 
            // Path
            // 
            this.Path.HeaderText = "Путь к каталогу";
            this.Path.Name = "Path";
            this.Path.Visible = false;
            // 
            // Docs
            // 
            this.Docs.FormattingEnabled = true;
            this.Docs.Items.AddRange(new object[] {
            "Дарственный документ (договор, письмо) - оригинал",
            "Заключение МЗ РБ об освобождении от налогов, пошлин и сборов - копия",
            "Акт приемки - оригинал",
            "План целевого использования - копия",
            "Заключение о целевом использовании - оригинал",
            "О проведении испытаний (экспертизы, регистрации) - оригинал, либо разрешение на п" +
                "рименение из ЦЭИЗ - копия",
            "Удостоверение из ДГД - оригинал",
            "Приказ о распределении - копия",
            "Отчет в ДГД - оригинал",
            "Отчет поставщику - оригинал"});
            this.Docs.Location = new System.Drawing.Point(12, 31);
            this.Docs.Name = "Docs";
            this.Docs.Size = new System.Drawing.Size(973, 184);
            this.Docs.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Фильтры";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 649);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.TextBox StuffName;
        private System.Windows.Forms.TextBox Organisation;
        private System.Windows.Forms.Button Complete;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Org;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.CheckedListBox Docs;
        private System.Windows.Forms.Label label7;
    }
}

