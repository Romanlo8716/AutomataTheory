using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Laba1
{
    public partial class Form1 : Form
    {

        public List<string> keyWords = new List<string> { "for", "in", "end" };
        public List<string> separators = new List<string> { ":", ":=", "*=", "-=", "+=", "<=", ">=", "&", "&&", "*", ";", "-", "+", "/", "{", "}", "(", ")", "=", "<", ">", ",", "()", "[", "]" };
        public List<string> literals = new List<string>();
        public List<string> variables = new List<string>();
        ListWithDuplicates listSymbolTable = new ListWithDuplicates();


        public Form1()
        {
            InitializeComponent();
        }

        private void bPerform_Click_1(object sender, EventArgs e)
        {
            
            dLexicalAnalysisTable.Rows.Clear();
            dLexicalAnalysisTable.Refresh();

            dStandSymbolTable.Rows.Clear();
           dStandSymbolTable.Refresh();

            dLiteralsTable.Rows.Clear();
            dLiteralsTable.Refresh();

            dIndentifiersTable.Rows.Clear();
            dIndentifiersTable.Refresh();

            string code = rText.Text.TrimStart().TrimEnd();

            string buffer = "";
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == 39 || code[i] == 126 || code[i] == 35)
                {
                    MessageBox.Show($"Ошибка в лексеме: {code[i]}", "Вывод лексем", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (buffer != "")
                {

                    if (Convert.ToString(code[i]).Trim().Equals("")) //если нет пробелов
                    {
                        addToList(buffer); //добавляем лексемы в список
                        buffer = ""; //очищаем буфер от лексемы
                    }
                    else if (separators.Contains(Convert.ToString(code[i]))) // если лексема относится к списку знаков
                    {
                        if (separators.Contains(Convert.ToString(buffer) + Convert.ToString(code[i]))) // если в буфере есть символы знаков и любой другой символ
                        {
                            buffer += code[i]; //сложение к буферу
                        }
                        else
                        {
                            addToList(buffer); // добавление лексемы в список
                            buffer = Convert.ToString(code[i]); // буфер становится равным символу
                        }
                    }
                    else
                    {
                        if (separators.Contains(Convert.ToString(buffer[0])))
                        {//если первый элемент буфера относится к символу
                            addToList(buffer); // добавление лексемы в список
                            buffer = ""; //обнуление буфера
                        }
                        buffer += code[i];// сложение элементов к буферу
                    }
                }
                else
                {
                    buffer += code[i];// сложение элементов к буферу
                }

                if (i == code.Length - 1)
                {
                    addToList(buffer);
                }

            }

            PrintKeyWord(dLiteralsTable, literals);
            PrintKeyWord(dIndentifiersTable, variables);
            

            tableStandSimbol(dLiteralsTable, 3);
            tableStandSimbol(dSeparatorsTable, 2);
            tableStandSimbol(dKeyWordsTable, 1);
            tableStandSimbol(dIndentifiersTable, 4);

           PrintSymdolTable(listSymbolTable);
        }


        public void tableStandSimbol(DataGridView dataGridView, int numbers)
        {
           
            foreach (DataGridViewRow row1 in dStandSymbolTable.Rows)
            {
                foreach(DataGridViewRow row2 in dataGridView.Rows)
                {
                    if (row1.Cells[0].Value.ToString() == row2.Cells[1].Value.ToString())
                    {
                        row1.Cells[0].Value = numbers;
                        row1.Cells[1].Value = row2.Cells[0].Value;

                    }
                }
            }

        }

        public void PrintSymdolTable(ListWithDuplicates list)
        {
            foreach (DataGridViewRow row1 in dStandSymbolTable.Rows)
            {
                    listSymbolTable.Add(row1.Cells[0].Value.ToString(), row1.Cells[1].Value.ToString()); 
            }
        }


        /// <summary>
        /// метод добавление лексемы в список лексем
        /// </summary>
        /// <param name="list"> список лексем </param>
        public void PrintLeksem(ListWithDuplicates list)
        {
           
            foreach (KeyValuePair<string, string> listItem in list)
            {

                this.dLexicalAnalysisTable.Rows.Add(listItem.Key, listItem.Value);
                
               
            }

        }

        public void PrintKeyWord(DataGridView dataGridView, List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView.Rows.Add(i, list[i]);
            }
        }

        
        public void addToList(string lexem)
        {

            if (int.TryParse(lexem, out int numericValue)) //если число
            {
                var list = new ListWithDuplicates();
                if (!literals.Contains(lexem))
                    literals.Add(lexem);
                list.Add(lexem, "L");
                PrintLeksem(list);
                dStandSymbolTable.Rows.Add(lexem);



            }
            else
            {

                if (separators.Contains(Convert.ToString(lexem)))
                {
                    var list = new ListWithDuplicates();
                    list.Add(lexem, "R");
                    PrintLeksem(list);
                    dStandSymbolTable.Rows.Add(lexem);

                }

                else
                {
                 
                    if ((lexem[0] >= 48 && lexem[0] <= 57))
                    {
                        MessageBox.Show($"Ошибка в лексеме: {lexem}", "Вывод лексем", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        return;
                    }
                  
                    else 
                    {
                    
                        if((lexem[0] >= 65 && lexem[0] <= 90) || (lexem[0] >= 97 && lexem[0] <= 122))
                        {
                            
                            var list = new ListWithDuplicates();
                            list.Add(lexem, "I");
                            if (!keyWords.Contains(lexem) && !variables.Contains(lexem))
                            {
                                variables.Add(lexem);

                            }
                           
                            PrintLeksem(list);
                            dStandSymbolTable.Rows.Add(lexem);

                        }
                        else
                        {
                            MessageBox.Show($"Ошибка в лексеме: {lexem}", "Вывод лексем", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            return;
                        }

                    }

                }

            }

        }

        private void PrintText()
        {
            StreamReader sr = new StreamReader("C:\\3 курс\\Теория автоматов и формальных языков\\Курсовая работа\\Compilator.txt", Encoding.UTF8);
            string text = sr.ReadToEnd();
            rText.AppendText(text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintText();

            PrintKeyWord(dKeyWordsTable, keyWords);
            PrintKeyWord(dSeparatorsTable, separators);

        }  
    }
}
