using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    internal class Errors : llkGrammatiks
    {
        public static void errorForAndVariables()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидалось for или идентификатор", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errorFor()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидалось for", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorVariables()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался идентификатор", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorIn()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался in", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorOpenScob()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидалась [", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorCloseScob()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидалась ]", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorRavno()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался =", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorPunct()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался ;", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorVariablesAndLiterals()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался идентификатор или литерал", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorVariablesAndLiteralsandScob()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался идентификатор или литерал или скобка", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorOutputScob()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался ]", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorEnd()
        {
            MessageBox.Show("Ошибка. После лексемы: " + lexeme + " ожидался end", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorSain()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался знак(+,-,/,*)", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorZap()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался ,", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //public static void errorSintax()
        //{
        //    MessageBox.Show("Ошибка в синтаксисе программы", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        public static void errorZapOROutputScob()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался , или ]", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorMinZap()
        {
            MessageBox.Show("Лишняя ;", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorEndOrPunct()
        {
            MessageBox.Show("Ошибка в лексеме: " + lexeme + ". Ожидался end или ;", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void errorMinusEnd()
        {
            MessageBox.Show("Лишний end", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void errorMinusLexem()
        {
            MessageBox.Show("В конце программы лишняя лексема", "Синтаксический анализ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
   
}
