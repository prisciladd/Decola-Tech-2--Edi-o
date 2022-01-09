//função para calcular media
//Autora: Priscila Da Dalt

programa
{
	
	funcao inicio()
	{
		real nota1,nota2,nota3,nota4,media
		cadeia aluno

		escreva ("Olá, qual seu nome?")
		leia(aluno)
		escreva("Bem vindo " + aluno+" ")
		escreva("Vamos calcular sua média? Digite a nota 1: ")
		leia(nota1)
		escreva("Digite a nota 2: ")
		leia(nota2)
		escreva("Digite a nota 3: ")
		leia(nota3)
		escreva("Digite a nota 4: ")
		leia(nota4)

		media = (nota1+nota2+nota3+nota4)/4

		escreva (aluno+" Sua media foi: "+media)

		se(media>=7){			//verifica se a media é maior ou igual a 7
			escreva("\n" + "Parabéns você foi Aprovado!!!!") 		//"\n" para quebra de linha
		}
		senao{
			escreva("\n" + "Infelizmente você ficou de Recuperação.")
		}
	}	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 582; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */