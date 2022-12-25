
namespace Laba1
{
    partial class Form1
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
            this.rText = new System.Windows.Forms.RichTextBox();
            this.bPerform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dLexicalAnalysisTable = new System.Windows.Forms.DataGridView();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dKeyWordsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSeparatorsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLiteralsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIndentifiersTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dStandSymbolTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            rMatrixText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dLexicalAnalysisTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKeyWordsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSeparatorsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLiteralsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIndentifiersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStandSymbolTable)).BeginInit();
            this.SuspendLayout();
            // 
            // rText
            // 
            this.rText.Location = new System.Drawing.Point(539, 30);
            this.rText.Margin = new System.Windows.Forms.Padding(4);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(265, 215);
            this.rText.TabIndex = 0;
            this.rText.Text = "";
            // 
            // bPerform
            // 
            this.bPerform.Location = new System.Drawing.Point(577, 491);
            this.bPerform.Margin = new System.Windows.Forms.Padding(4);
            this.bPerform.Name = "bPerform";
            this.bPerform.Size = new System.Drawing.Size(188, 59);
            this.bPerform.TabIndex = 1;
            this.bPerform.Text = "Выполнить";
            this.bPerform.UseVisualStyleBackColor = true;
            this.bPerform.Click += new System.EventHandler(this.bPerform_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код";
            // 
            // dLexicalAnalysisTable
            // 
            this.dLexicalAnalysisTable.AllowUserToAddRows = false;
            this.dLexicalAnalysisTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dLexicalAnalysisTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.text,
            this.type});
            this.dLexicalAnalysisTable.Location = new System.Drawing.Point(13, 30);
            this.dLexicalAnalysisTable.Margin = new System.Windows.Forms.Padding(4);
            this.dLexicalAnalysisTable.Name = "dLexicalAnalysisTable";
            this.dLexicalAnalysisTable.RowHeadersWidth = 51;
            this.dLexicalAnalysisTable.Size = new System.Drawing.Size(256, 520);
            this.dLexicalAnalysisTable.TabIndex = 3;
            // 
            // text
            // 
            this.text.HeaderText = "Лексема";
            this.text.MinimumWidth = 6;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Width = 70;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 50;
            // 
            // dKeyWordsTable
            // 
            this.dKeyWordsTable.AllowUserToAddRows = false;
            this.dKeyWordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dKeyWordsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dKeyWordsTable.Location = new System.Drawing.Point(812, 30);
            this.dKeyWordsTable.Margin = new System.Windows.Forms.Padding(4);
            this.dKeyWordsTable.Name = "dKeyWordsTable";
            this.dKeyWordsTable.RowHeadersWidth = 51;
            this.dKeyWordsTable.Size = new System.Drawing.Size(334, 242);
            this.dKeyWordsTable.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ключевое слово";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dSeparatorsTable
            // 
            this.dSeparatorsTable.AllowUserToAddRows = false;
            this.dSeparatorsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dSeparatorsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dSeparatorsTable.Location = new System.Drawing.Point(1154, 30);
            this.dSeparatorsTable.Margin = new System.Windows.Forms.Padding(4);
            this.dSeparatorsTable.Name = "dSeparatorsTable";
            this.dSeparatorsTable.RowHeadersWidth = 51;
            this.dSeparatorsTable.Size = new System.Drawing.Size(334, 242);
            this.dSeparatorsTable.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Разделители";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dLiteralsTable
            // 
            this.dLiteralsTable.AllowUserToAddRows = false;
            this.dLiteralsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dLiteralsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dLiteralsTable.Location = new System.Drawing.Point(812, 296);
            this.dLiteralsTable.Margin = new System.Windows.Forms.Padding(4);
            this.dLiteralsTable.Name = "dLiteralsTable";
            this.dLiteralsTable.RowHeadersWidth = 51;
            this.dLiteralsTable.Size = new System.Drawing.Size(334, 254);
            this.dLiteralsTable.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Литерал";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dIndentifiersTable
            // 
            this.dIndentifiersTable.AllowUserToAddRows = false;
            this.dIndentifiersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dIndentifiersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dIndentifiersTable.Location = new System.Drawing.Point(1154, 296);
            this.dIndentifiersTable.Margin = new System.Windows.Forms.Padding(4);
            this.dIndentifiersTable.Name = "dIndentifiersTable";
            this.dIndentifiersTable.RowHeadersWidth = 51;
            this.dIndentifiersTable.Size = new System.Drawing.Size(334, 254);
            this.dIndentifiersTable.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Переменные";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(914, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "1 Ключевые слова";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1271, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "2 Разделители";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1261, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "4 Идентификаторы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "3 Литералы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Лексический анализ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Таблица стандартных символов";
            // 
            // dStandSymbolTable
            // 
            this.dStandSymbolTable.AllowUserToAddRows = false;
            this.dStandSymbolTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dStandSymbolTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dStandSymbolTable.Location = new System.Drawing.Point(277, 30);
            this.dStandSymbolTable.Margin = new System.Windows.Forms.Padding(4);
            this.dStandSymbolTable.Name = "dStandSymbolTable";
            this.dStandSymbolTable.RowHeadersWidth = 51;
            this.dStandSymbolTable.Size = new System.Drawing.Size(254, 520);
            this.dStandSymbolTable.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Таблица";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Строка";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Матрица действий";
            // 
            // rMatrixText
            // 
            rMatrixText.Location = new System.Drawing.Point(539, 269);
            rMatrixText.Name = "rMatrixText";
            rMatrixText.Size = new System.Drawing.Size(266, 215);
           rMatrixText.TabIndex = 17;
            rMatrixText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 574);
            this.Controls.Add(rMatrixText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dStandSymbolTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dIndentifiersTable);
            this.Controls.Add(this.dLiteralsTable);
            this.Controls.Add(this.dSeparatorsTable);
            this.Controls.Add(this.dKeyWordsTable);
            this.Controls.Add(this.dLexicalAnalysisTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPerform);
            this.Controls.Add(this.rText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Транслятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dLexicalAnalysisTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKeyWordsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSeparatorsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dLiteralsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIndentifiersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStandSymbolTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rText;
        private System.Windows.Forms.Button bPerform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dLexicalAnalysisTable;
        private System.Windows.Forms.DataGridView dKeyWordsTable;
        private System.Windows.Forms.DataGridView dSeparatorsTable;
        private System.Windows.Forms.DataGridView dLiteralsTable;
        private System.Windows.Forms.DataGridView dIndentifiersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        public System.Windows.Forms.DataGridView dStandSymbolTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label8;
        public static System.Windows.Forms.RichTextBox rMatrixText;
    }
}

