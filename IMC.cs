using System;

    class CalcIMC{ 
        public double peso;
        public double altura;
    
        public CalcIMC(double peso, double altura){
            this.peso = peso;
            this.altura = altura;
        }
        
        public void operação(){
            double IMC;
            IMC = peso /(altura*altura);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Dados\npeso : {0}\naltura : {1} \nIMC : {2}",peso,altura,IMC);
        }

        public void VerificarIMC(double resIMC){
            if(resIMC < 18.5){
                Console.WriteLine("Classificação: Abaixo Do peso");
            }
            else if(resIMC >= 18.5 && resIMC <= 24.9){
                Console.WriteLine("Classificação: Peso Normal");
            }
            else if(resIMC >= 25 && resIMC <= 29.9){
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else if(resIMC >= 30 && resIMC <= 34.9){
                Console.WriteLine("Classificação: Obesidade Grau I");
            }
            else if(resIMC >= 35 && resIMC <= 39.9){
                Console.WriteLine("Classificação: Obesidade Grau II");
            }
            else if(resIMC > 40){
                Console.WriteLine("Classificação: Obesidade Grau III");
            }
        }
    }

    class Info{
        static void Main(){
            double p,a;

            Console.Clear();// <- Ignore

                Console.Write("insira seu peso:  ");
                p = double.Parse(Console.ReadLine());

                Console.Write("insira sua altura:  ");
                a = double.Parse(Console.ReadLine());
                
                CalcIMC CALCULO = new CalcIMC(p,a);

                double ImcParaVeri = p/(a*a);

                CALCULO.operação();
                Console.WriteLine("------------------------");
                CALCULO.VerificarIMC(ImcParaVeri);
            
                Console.ReadLine();// <- Ignore
        }
    }