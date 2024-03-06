using System;
using System.Threading.Channels;

namespace TesteTarget
{
    class Program
    {
        static void Main(string[] args)
        {

            int esc = 0;

            do
            {


                Console.WriteLine("--- MENU --- ");
                Console.WriteLine("1 - QUESTION 1");
                Console.WriteLine("2 - QUESTION 2");
                Console.WriteLine("3 - QUESTION 5");
                Console.WriteLine("9 - EXIT");
                Console.WriteLine("OBS.: QUESTIONS 3 and 4 are commented in the code...");

                Console.Write("Select on option: ");

                esc = int.Parse(Console.ReadLine());

                switch (esc)
                {

                    case 1:
                        //Question 1

                        int index = 13, sum = 0, k = 0;


                        while (k < index)
                        {
                            k += 1;
                            sum += k;
                        }

                        Console.WriteLine(sum);
                        //Sum = 91

                        break;
                    case 2:
                        //Question 2
                        int a = 0, b = 1, fib = 0;

                        Console.Write("Enter number: ");
                        int number = int.Parse(Console.ReadLine());

                        while (fib < number)
                        {
                            int temp = a; // Variable of help
                            a = b; // next value
                            b = temp + b; // sum of number
                            fib = b;

                        }

                        if (fib == number)
                        {
                            Console.WriteLine($"{number} belongs to the Fibonacci sequence");
                        }
                        else
                        {
                            Console.WriteLine($"{number} does not belong to the Fibonacci sequence");
                        }

                        break;
                    case 3:
                        
                        //Question 5
                        Console.Write("Enter with one word: ");

                        string word = Console.ReadLine();
                        char[] reverseWord = word.ToCharArray();
                        string drow;

                        int start = 0; // First letter 
                        int finish = reverseWord.Length - 1; // Size of word


                        while (start < finish)
                        {
                            char temp = reverseWord[start];
                            reverseWord[start] = reverseWord[finish];
                            reverseWord[finish] = temp;


                            start++;
                            finish--;

                        }

                        drow = new string(reverseWord);

                        Console.WriteLine($"To reverse word is: {drow}");
                        break;
                    case 9:
                        
                        Console.WriteLine("Bye!");
                        
                        
                        break;
                    default:
                        Console.WriteLine("Select a valid option:");
                        break;

                }





            } while (esc != 9);
            
            
            /*
            QUESTION 3
            
            a)
            Lógica: soma de 2 elementos. 1 + 2 = 3 -> 3 + 2 = 5 -> 5 + 2 = 7 -> 7 + 2 = 9
            resposta: 1,3,5,7,9
            
            b)
            Lógica: potência de 2 elevado a n, sendo n a posição da lista. 2^1 = 2 / 2^2 = 4/ ... /2^7=128
            resposta: 2,4,8,16,32,64,128
            
            c) 
            Lógica: o numero elevado a ele mesmo n^n. Sendo n a posição da lista(nesse caso iniciando o indíce em 0)
            0^0 = 0 / 1^1 = 1/ 2^2 = 4/.../7^7=49
            Resposta: 0,1,4,9,16,25,36,49
            
            d) 
            Lógica: Números pares ao quadrado. 2^2 = 4/4^2 = 16/ 6^2 = 36/8^2 = 64/10^2 = 100
            Resposta: 4,16,36,64,100
            
            e) 
            Lógica: Frequência de Fibonacci.
            Resposta: 1,1,2,3,5,8,13 
            
            f)
            Lógica: Não consigo pensar em nenhuma lógica matemática para tal.
            Resposta: Sem resposta
            
            */
            
            /*
            QUESTION 4
            Vamos supor que os inteterruptores estejam dispostos de forma horizontal, representado por (|)
            ESQUEMA DOS INTERUPTORES: [ | | |]
            Sendo assim, ligaria o primeiro interruptor da esquerda para direita e iria ver qual lâmpada ele está controlando
            e marcaria. 
            qtd. de voltas = 1;
            Depois, ligaria a o interruptor mais a direita e veria qual lâmpada ele controla. 
            qtd. de voltas = 1;
            Por fim, a lâmpada que não foi acessa por dedução será a controlada pelo interruptor do meio. 
            */
            
            
         



















        }
    }
}