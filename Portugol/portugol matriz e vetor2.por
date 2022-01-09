programa
{
	
	funcao inicio()
	{
		cadeia agenda [][]={
			{"João","São Paulo","(11)9999-1234"},
			{"Maria","Ribeirão Preto","(12)9459-3034"},
			{"Ana","Manaus","(13)9954-3434"}
		}

		inteiro contador = 0
		inteiro limite = 2

		faca{
			escreva ("Registro: " + agenda[contador][0] +" " + "Cidade: " + agenda[contador][1] +" " + "Telefone: " + agenda[contador][2] + "\n")
			contador++
		}enquanto(contador<=limite)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 430; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */