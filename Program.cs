using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod_user; int op = 2; int pass;
            int cod_user_target = 1234;
            int pass_user_target = 9999;

            do{
                Console.WriteLine("Qual o código do usuário?");
                cod_user = Convert.ToInt32(Console.ReadLine());
                
                if (cod_user == cod_user_target){
                    Console.WriteLine("Digite a senha: ");
                    pass = Convert.ToInt32(Console.ReadLine());
                
                        if(pass == pass_user_target){
                            Console.WriteLine("Acesso permito!");
                            break;
                        }
                        else{
                            Console.WriteLine("Acesso negado!\n\n1 - Tentar novamente\n0 - Encerrar o sistema");
                            op = Convert.ToInt32(Console.ReadLine());
                        }
                }
                else{
                    Console.WriteLine("Usuário inválido!\n");
                }
            }while(op != 0);
        }
    }
}