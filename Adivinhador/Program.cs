
    //Adivinhador
    //gerar um número de 1 a 10
    //pedir para a pessoa usuária adivinhar o número
    //salvar a resposta
    //comparar a resposta e dizer se acertou ou errou
    //se errou, dizer se o número é maior ou menor

    Random random = new Random();
    int numeroPensado = random.Next(1, 11);

    var acertou = false;

    while (!acertou)
    {
        Console.WriteLine("Estou pensando em um número de 1 a 10. Qual número estou pensando?");
        string resposta = Console.ReadLine();
        int respostaConvertida = Convert.ToInt32(resposta);
        //Console.WriteLine(numeroPensado);

    if (respostaConvertida >= 1 && respostaConvertida <= 10)
            {
        
                if (respostaConvertida == numeroPensado)
                {
                    Console.WriteLine("Parabéns! Você acertou o número.");
                    acertou = true;
            }
                else if (respostaConvertida < numeroPensado)
                {
                    Console.WriteLine("O número pensado é maior. Tente novamente.");
            }
                else
                {
                    Console.WriteLine("O número pensado é menor. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido de 1 a 10.");
            }
    } 
