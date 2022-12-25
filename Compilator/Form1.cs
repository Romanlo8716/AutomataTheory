using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Laba1
{
    public partial class Form1 : Form
    {

        public List<string> keyWords = new List<string> { "for", "in", "end" };
        public List<string> separators = new List<string> {"*=", "-=", "+=", "*", ";", "-", "+", "/", "=", ",", "[", "]" , "(", ")" };
        public List<string> literals = new List<string>();
        public List<string> variables = new List<string>();
        ListWithDuplicates listSymbolTable = new ListWithDuplicates();


        public Form1()
        {
            InitializeComponent();
        }

        private void bPerform_Click_1(object sender, EventArgs e)
        {
            createLexem();
           
        }

        public void createLexem()
        {
            rMatrixText.Clear();

            llkGrammatiks.listMatrix.Clear();
            llkGrammatiks.E.Clear();
            llkGrammatiks.T.Clear();
          

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
                //MessageBox.Show(code[i].ToString());
                if (!((code[i] >= 48 && code[i] <= 62) || (code[i] >= 65 && code[i] <= 90) || (code[i] == 32) || (code[i] >= 97 && code[i] <= 122) || (code[i] >= 60 && code[i] <= 62) || (code[i] >= 40 && code[i] <= 47) || (code[i] == 44) || (code[i] == 46) || (code[i] == 91) || (code[i] == 93) || code[i] == 10))
                {
                    MessageBox.Show($"Ошибка компиляции в символе {code[i]}");
                    return;
                }

                if (code[i] == 10)
                {
                    if (code[i - 1] == 10)
                    {
                        continue;
                    }
                }

                if (buffer != "")
                {

                    if (Convert.ToString(code[i]).Trim().Equals("")) //если нет пробелов
                    {
                        //if (!addToList(buffer))
                        addToList(buffer);
                        /* return;*///добавляем лексемы в список
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
                            if (!addToList(buffer))
                                return; // добавление лексемы в список
                            buffer = Convert.ToString(code[i]); // буфер становится равным символу
                        }
                    }
                    else
                    {
                        if (separators.Contains(Convert.ToString(buffer[0])))
                        {//если первый элемент буфера относится к символу
                            if (!addToList(buffer))
                                return; // добавление лексемы в список
                            buffer = ""; //обнуление буфера
                        }
                        buffer += code[i];// сложение элементов к буферу
                    }
                }
                else
                {
                    if (code[i] != 10 || code[i] != ' ')
                    {
                        buffer += code[i];// сложение элементов к буферу
                        //MessageBox.Show(code[i].ToString());
                    }
                }

                if (i == code.Length - 1)
                {
                    if (!addToList(buffer))
                        return;
                }

            }

            PrintKeyWord(dLiteralsTable, literals);
            PrintKeyWord(dIndentifiersTable, variables);


            tableStandSimbol(dLiteralsTable, "3");
            tableStandSimbol(dIndentifiersTable, "4");
            tableStandSimbol(dSeparatorsTable, "2");
            tableStandSimbol(dKeyWordsTable, "1");




            PrintSymdolTable();



            if (rText.Text != "")
            {
                if (checkIdent())
                    llkGrammatiks.Program(listSymbolTable, keyWords, separators, literals, variables);
                else
                {
                    literals.Clear();
                    variables.Clear();
                    listSymbolTable.Clear();
                    llkGrammatiks.number = 0;
                    MessageBox.Show("Ошибка. Длина идентификатора должна быть меньше 8 символов!!!", "Лексический анализ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    llkGrammatiks.listMatrix.Clear();

                    return;
                }
                literals.Clear();
                variables.Clear();
                listSymbolTable.Clear();
                llkGrammatiks.number = 0;
                llkGrammatiks.listMatrix.Clear();

            }
            else
            {
                MessageBox.Show("Ошибка. Введите данные в поле!!!", "Лексический анализ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            listSymbolTable.Clear();
            llkGrammatiks.number = 0;
            llkGrammatiks.listMatrix.Clear();
            literals.Clear();
            variables.Clear();
        }

        public bool checkIdent()
        {
            for (int i = 0; i < variables.Count;i++)
            {
                if (variables[i].Length > 8)
                {
                    return false;
                } 
            }
            
            if (true)
                return true;
  
        }

        public void tableStandSimbol(DataGridView dataGridView, string numbers)
        {
           
            foreach (DataGridViewRow row1 in dStandSymbolTable.Rows)
            {
                foreach(DataGridViewRow row2 in dataGridView.Rows)
                {
                    if (row1.Cells[0].Value.ToString() == row2.Cells[1].Value.ToString())
                    {
                       
                        row1.Cells[1].Value = row2.Cells[0].Value;
                        row1.Cells[0].Value = numbers;
                        break;
                        

                    }
                }
            }

           
        }



        public void PrintSymdolTable()
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

        
        public bool addToList(string lexem)
        {
          
            if (int.TryParse(lexem, out int numericValue)) //если число
            {
                    var list = new ListWithDuplicates();
                if (!literals.Contains(lexem.Replace(" ", "")))
                    literals.Add(lexem);
                list.Add(lexem.Replace(" ", ""), "L");
                PrintLeksem(list);
                dStandSymbolTable.Rows.Add(lexem.Replace(" ", ""));



            }
            else
            {
               
                if (separators.Contains(Convert.ToString(lexem.Replace(" ", ""))))
                {
                    var list = new ListWithDuplicates();
                    list.Add(lexem.Replace(" ", ""), "R");
                    PrintLeksem(list);
                    dStandSymbolTable.Rows.Add(lexem.Replace(" ", ""));

                }

                else
                {
                  
                  

                        if ((lexem[0] >= 48 && lexem[0] <= 57) && (lexem.Length == 0))
                        {
                            MessageBox.Show($"Ошибка в лексеме: {lexem}", "Вывод лексем", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            return false;
                        }

                        else
                        {
                            if (lexem == " ")
                            {
                                return true;
                            }
                            lexem = lexem.Trim();
                            if ((lexem[0] >= 65 && lexem[0] <= 90) || (lexem[0] >= 97 && lexem[0] <= 122))
                            {

                                var list = new ListWithDuplicates();
                                list.Add(lexem.Replace(" ", ""), "I");
                                if (!keyWords.Contains(lexem.Replace(" ", "")) && !variables.Contains(lexem.Replace(" ", "")))
                                {
                                    variables.Add(lexem);

                                }

                                PrintLeksem(list);
                                dStandSymbolTable.Rows.Add(lexem.Replace(" ", ""));

                            }
                            else
                            {
                                MessageBox.Show($"Ошибка в лексеме: {lexem}", "Вывод лексем", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return false;
                            }

                        }
                    

                }

            }
            return true;
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
