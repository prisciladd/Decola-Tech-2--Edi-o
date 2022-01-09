programa
{
	
	funcao inicio()
	{
		escreva("Menu Inicial: 1 - Abrir Netflix 2 - Abrir Globo Play 3 - Abrir Amazon Prime 4 - Sair")
		inteiro menu = 0
		escreva ("\n" + "Escolha uma das opções: ")
		leia(menu)

		escolha (menu)
		{
			caso 1:
			escreva ("OK! Abrindo Netflix")
			pare
			
			caso 2:
			escreva ("OK! Abrindo Globo Play")
			pare

			caso 3:
			escreva ("OK! Abrindo Amazon Prime")
			pare

			caso 4:
			escreva ("OK! Saindo....!!!")
			pare
			
			caso contrario:
			escreva ("Escolha uma das opções 1,2,3,4")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 174; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */