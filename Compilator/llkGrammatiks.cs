using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Laba1
{
    public class llkGrammatiks
    {
        public static int number = 0;





        public static string GetLexem(ListWithDuplicates keyValuePairs, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables, int i)
        {
            string lexem = "";
            

                if (keyValuePairs.ElementAt(i).Key == "1")
                {
                    lexem = keyWords.ElementAt(Convert.ToInt32(keyValuePairs.ElementAt(i).Value));
                }
                else if (keyValuePairs.ElementAt(i).Key == "2")
                {
                    lexem = separators.ElementAt(Convert.ToInt32(keyValuePairs.ElementAt(i).Value));
                }
                else if (keyValuePairs.ElementAt(i).Key == "3")
                {
                    lexem = literals.ElementAt(Convert.ToInt32(keyValuePairs.ElementAt(i).Value));
                }
                else if (keyValuePairs.ElementAt(i).Key == "4")
                {
                  
                    lexem = variables.ElementAt(Convert.ToInt32(keyValuePairs.ElementAt(i).Value));
                
                }
                
         

            

            return lexem;
        }
        public static string lexeme = "";
        public static void Next(ListWithDuplicates keyValuePairs, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {

                number++;

            if(number < keyValuePairs.Count)
            {
                
                lexeme = GetLexem(keyValuePairs, keyWords, separators, literals, variables, number);
            }
         

        }

        public static void Back()
        {
            number--;

        }

       

        public static bool LoopOperator(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
           
            if (lexeme != "for")
            {
                Errors.errorFor();
                return false;
            }

           
            Next(keyValuePairs, keyWords, separators, literals, variables);
           
            if (!variables.Contains(lexeme))
            {
                Errors.errorVariables();
                return false;
            }
           
                Next(keyValuePairs, keyWords, separators, literals, variables);

            if (lexeme != "in")
            {
                Errors.errorIn();
                return false;
            }
          
                Next(keyValuePairs, keyWords, separators, literals, variables);


            if (lexeme != "[")
            {
                Errors.errorOpenScob();
                return false;
            }
           
                Next(keyValuePairs, keyWords, separators, literals, variables);



            if(!listOfVariables(keyValuePairs, number, keyWords, separators, literals, variables))
                return false;

            

            if (!ListOfAction(keyValuePairs, number, keyWords, separators, literals, variables))
                return false;

           
          
            if (lexeme != "end")
            {
                Errors.errorEnd();
                return false;
            }


            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool assignment(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
            if(number < keyValuePairs.Count)
            {
                if (!variables.Contains(lexeme))
                {
                    Errors.errorVariables();
                    return false;
                }
               
                Next(keyValuePairs, keyWords, separators, literals, variables);
                if (number < keyValuePairs.Count)
                {
                    if (lexeme != "=")
                    {
                        Errors.errorRavno();
                        return false ;
                    }
                  
                        Next(keyValuePairs, keyWords, separators, literals, variables);

                    if(literals.Contains(lexeme) || variables.Contains(lexeme) || lexeme == "(")
                    {
                        if(!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                        {
                            return false;
                        }
                       
                    }
                    else
                    {
                        Errors.errorVariablesAndLiteralsandScob();
                        return false;
                    }
                   

                    if(lexeme != ";")
                    {
                        Errors.errorPunct();
                        return false;
                    }
                  
                }
                else
                {
                    Errors.errorSintax();
                    return false;
                }
            }
            else
            {
                Errors.errorSintax();
                return false;
            }
            
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
       public static Stack<string> E = new Stack<string>(); // для хранения операндов
        public static Stack<string> T = new Stack<string>(); // для хранения знаков

        public static void kID(ListWithDuplicates keyValuePairs, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
           
           
            E.Push(lexeme);
            
            Next(keyValuePairs, keyWords, separators, literals, variables);
           
        }


       public static List<string> listMatrix = new List<string>();

        public static bool kOP(ListWithDuplicates keyValuePairs, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
           
            if(E.Count > 1)
            {
                string operand = T.Pop();
                string firstOp = E.Pop();
                string secondOp = E.Pop();
                string matrix = $"Операция: {listMatrix.Count +1}";

                listMatrix.Add($"{matrix}: {operand} {secondOp} {firstOp}");
                E.Push(matrix);
                
                return true;
            }
            else
            {
                MessageBox.Show("Ошибка выражения","Анализ сложных выражений", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public static void D1(ListWithDuplicates keyValuePairs, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
            
            T.Push(lexeme);
            Next(keyValuePairs, keyWords, separators, literals, variables);
        }

        public static bool D2(ListWithDuplicates keyValuePairs, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
           if (!kOP(keyValuePairs, keyWords, separators, literals, variables))
            return false;
            else
            {
                T.Push(lexeme);
                Next(keyValuePairs, keyWords, separators, literals, variables);
                return true;
            }
           
        }

        public static void D3(ListWithDuplicates keyValuePairs, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
            T.Pop();
            Next(keyValuePairs, keyWords, separators, literals, variables);
        }

        public static bool D4(ListWithDuplicates keyValuePairs, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
            if (!kOP(keyValuePairs, keyWords, separators, literals, variables)){
                return false;
            }
            else
            {
                return true;
            }
           
        }

        public static bool D5()
        {
            MessageBox.Show("Ошибка выражения", "Анализ сложных выражений", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            return false;
        }

        public static bool D6()
        {
           
            foreach(string item in listMatrix)
            {
                Form1.rMatrixText.Text += $"{item}\n";
            }



            return true;
        }

        public static bool expr(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
            
            if (number < keyValuePairs.Count)
            {
               
                if (variables.Contains(lexeme) || literals.Contains(lexeme))
                {
                    kID(keyValuePairs, keyWords, separators, literals, variables);

                    if(literals.Contains(lexeme) || variables.Contains(lexeme)){
                        MessageBox.Show("Ошибка. Ожидался знак операций", "Анализ сложных выражений", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return false;
                    }

                    if(!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                    {
                        return false;
                    }

                    
               
                }
                else if (lexeme == "*" || lexeme == "/" || lexeme == "-" || lexeme == "+" || lexeme == "(" || lexeme == ")" || lexeme == ";")
                {
                    
                    if (lexeme == "(")
                    {
                        D1(keyValuePairs, keyWords, separators, literals, variables);

                        if (!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                        {
                            return false;
                        }

                    }
                    else if(lexeme == "-" || lexeme == "+")
                    {
                        if(T.Count == 0 || T.Peek() == "(")
                        {
                            D1(keyValuePairs, keyWords, separators, literals, variables);
                            if (!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                            {
                                return false;
                            }

                        }
                        
                       else if (T.Peek() == "+" || T.Peek() == "-")
                        {

                           if(!D2(keyValuePairs, keyWords, separators, literals, variables)){
                                return false;
                            }
                            if (!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                            {
                                return false;
                            }

                        }
                        else if (T.Peek() == "*" || T.Peek() == "/")
                        {
                            if (!D4(keyValuePairs, keyWords, separators, literals, variables))
                                return false;
                            if (!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                            {
                                return false;
                            }

                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if(lexeme == "*" || lexeme == "/")
                    {
                        if (T.Count == 0 || T.Peek() == "(" || T.Peek() == "+" || T.Peek() == "-")
                        {
                            D1(keyValuePairs, keyWords, separators, literals, variables);
                            if (!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                            {
                                return false;
                            }

                        }
                        else if (T.Peek() == "*" || T.Peek() == "/")
                        {
                            if (!D2(keyValuePairs, keyWords, separators, literals, variables))
                                return false;
                            if (!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                            {
                                return false;
                            }

                        }
                        else
                        {
                            return false;
                        }

                    }
                    else if (lexeme == ")")
                    {
                       if(T.Count == 0)
                        {
                            if (!D5())
                            {
                                return false;
                            }
                        
                       
                           
                           
                        }
                       else if(T.Peek() == "(")
                        {
                            D3(keyValuePairs, keyWords, separators, literals, variables);
                            if (!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                            {
                                return false;
                            }

                        }
                        else if (T.Peek() == "+" || T.Peek() == "-" || T.Peek() == "*" || T.Peek() == "/")
                        {
                            if (!D4(keyValuePairs, keyWords, separators, literals, variables))
                                return false;
                            if (!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                            {
                                return false;
                            }

                        }
                     
                      
                       

                    }
                    else if (lexeme == ";")
                    {
                        if(T.Count == 0)
                        {
                            if (D6())
                            {
                                return true;
                            }
                         
                        }
                        else if(lexeme == "(")
                        {
                            if (!D5())
                            {
                                return false;
                            }

                        }
                        else if(T.Peek() == "+" || T.Peek() == "-" || T.Peek() == "*" || T.Peek() == "/")
                        {
                            if (!D4(keyValuePairs, keyWords, separators, literals, variables))
                                return false;
                            if (!expr(keyValuePairs, number, keyWords, separators, literals, variables))
                            {
                                return false;
                            }

                        }
                        else
                        {
                            if (!D5())
                            {
                                return false;
                            }
                        }
                     

                    }
                    else
                    {
                        return false;
                    }
                  
                    
                }
                listMatrix.Clear();
                E.Clear();
                T.Clear();


            }
            else
            {
                Errors.errorSintax();
                return false;
            }

            
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool action(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
            

            if (lexeme == "for")
            {
                
                
                if(!LoopOperator(keyValuePairs, number, keyWords, separators, literals, variables))
                {
                    return false;
                }
            }
            else if (variables.Contains(lexeme))
            {
                
              if(!assignment(keyValuePairs, number, keyWords, separators, literals, variables))
                {
                    return false;
                }
            }
            else
            {
                Errors.errorForAndVariables();
                return false;
            }

            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operand(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
            if (!variables.Contains(lexeme) && !literals.Contains(lexeme))
            {
                Errors.errorVariablesAndLiterals();
                return false;
            }
           
            Next(keyValuePairs, keyWords, separators, literals, variables);

            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool fixingReferences(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
            
            if (lexeme != ",")
            {
                Errors.errorZap();
                return false;
            }
            Next(keyValuePairs, keyWords, separators, literals, variables);
           
            if(!operand(keyValuePairs, number, keyWords, separators, literals, variables))
            {
                return false;
            }


            if (!UstrLevFactorSpisPermen(keyValuePairs, number, keyWords, separators, literals, variables))
            {
                return false;
            }
               
           

            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

       


        public static bool listOfVariables(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
              
            if (!variables.Contains(lexeme) && !literals.Contains(lexeme))
            {
                Errors.errorVariablesAndLiterals();
                return false;
            }
           
            if (!operand(keyValuePairs, number, keyWords, separators,literals, variables))
                return false;

            if (!UstrLevFactorSpisPermen(keyValuePairs, number, keyWords, separators, literals, variables))
                return false;


            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool UstrLevFactorSpisPermen(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
      
                if (lexeme == "]" || lexeme == ",")
                {
                    if (lexeme == ",")
                    {
                    if (!fixingReferences(keyValuePairs, number, keyWords, separators, literals, variables))
                        return false;
                    }
                    else if (lexeme == "]")
                    {
                      
                        Next(keyValuePairs, keyWords, separators, literals, variables);
                    }
                    else
                    {
                    Errors.errorZapOROutputScob();
                        return false;
                    }
                }
                else
                {
                    Errors.errorOutputScob();
                    return false;
                }
       

            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool UstrLevFactorSpisAction(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {

            if (lexeme == "end")
                {
                
                Next(keyValuePairs, keyWords, separators, literals, variables);
                    
                    if (number > keyValuePairs.Count - 1)
                    {
                 
                    return true;
                    }
                    
                    else if(lexeme == "for" || variables.Contains(lexeme))
                    {
                    if (!UstrRecDeistv(keyValuePairs, number, keyWords, separators, literals, variables))
                       
                    return false;
                    }
                 
                }
                else if (lexeme == ";")
                {
                
                Next(keyValuePairs, keyWords, separators, literals, variables);
                    if(lexeme == "for" || variables.Contains(lexeme))
                    {
                    if (!UstrRecDeistv(keyValuePairs, number, keyWords, separators, literals, variables))
                        return false;
                    }
                    else if(number > keyValuePairs.Count - 1)
                    {
                    
                    return true;
                    }
                    else if (lexeme == ";")
                    {
                    Errors.errorMinZap();
                        return false;
                    }

                   

                }



            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool UstrRecDeistv(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {

            if (!action(keyValuePairs, number, keyWords, separators, literals, variables))
                return false;
         
            if(number < keyValuePairs.Count)
            {
                if (!UstrLevFactorSpisAction(keyValuePairs, number, keyWords, separators, literals, variables))
                    return false;
                else
                    return true;
            }
            else
            {
                Errors.errorZap();
                return false;
            }

           
        }


        public static bool ListOfAction(ListWithDuplicates keyValuePairs, int k, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
           

            if (number < keyValuePairs.Count)
            {
                if (lexeme != "for" && !variables.Contains(lexeme))
                {
                    Errors.errorForAndVariables();
                    return false;
                }

                if (!action(keyValuePairs, number, keyWords, separators, literals, variables))
                {
                    return false;
                }
                

                if (!UstrLevFactorSpisAction(keyValuePairs, number, keyWords, separators, literals, variables))
                {
                    return false;
                }
            }
            else
            {
                Errors.errorPunct();
                return false;
            }

            if (true)
                return true;
            else 
                return false;

         
        }

        public static void Program(ListWithDuplicates keyValuePairs, List<string> keyWords, List<string> separators, List<string> literals, List<string> variables)
        {
            lexeme = GetLexem(keyValuePairs, keyWords, separators, literals, variables, number);
 
            if (lexeme != "for" && !variables.Contains(lexeme))
            {
                Errors.errorForAndVariables();
                return;
            }
            

            if (!ListOfAction(keyValuePairs, number, keyWords, separators, literals, variables))
            {
                
                return;
            }
            else
            {
                
                Complete(keyValuePairs);
            }



            keyValuePairs.Clear();



        }

        public static void Complete(ListWithDuplicates keyValuePairs)
        {
            

            if(number == keyValuePairs.Count)
            {

                MessageBox.Show("Синтаксический анализ выполнен успешно!!!", "Лексический анализ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (number > keyValuePairs.Count)
            {


                MessageBox.Show("Ошибка. Не хватает end");
                return;
            }
            if(number < keyValuePairs.Count)
            {
                Errors.errorMinusEnd();
                return;
            }
        }


    }
}



        





    
 

