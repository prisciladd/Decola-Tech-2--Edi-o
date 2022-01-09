programa
{
	
	funcao inicio()
	{
		cadeia frutas[4]

		frutas[0] = "Maçã"
		frutas[1] = "Pêra"
		frutas[2] = "Uva"
		frutas[3] = "Banana"

		escreva ("Exemplo 1: " + frutas[2] + "\n")

		cadeia cesta [][]={
			{"Maçã","100"},
			{"Pêra","560"},
			{"Uva","76"},
			{"Banana","4500"}
		}

		escreva("Exemplo 2: " + "Fruta: " + cesta[0][0] + "\n")
		
		inteiro contador = 0
		inteiro limite = 3
		
		faca{
			escreva("Produto: " + cesta[contador][0] + " " + "Quantidade em estoque: "  + cesta[contador][1] + "\n")
			contador ++
			
		}enquanto(contador<=limite)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 457; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */