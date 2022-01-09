programa
{
	
	funcao inicio()
	{
		real jan,fev,mar,abr,soma,media
		cadeia funcionario

		escreva("Funcionário: ")
		leia (funcionario)
		escreva("Bem vindo! " + funcionario + " " + "Será que você atingiu a meta de vendas?")
		escreva(" Digite o total de vendas de Janeiro:")
		leia(jan)
		escreva("Digite o total de vendas de Fevereiro:")
		leia(fev)
		escreva("Digite o total de vendas de Março:")
		leia(mar)
		escreva("Digite o total de vendas de Abril:")
		leia(abr)

		soma = jan+fev+mar+abr
		media = soma/4

		escreva ("Vejamos... o somatório de suas vendas foi: " + soma)
		escreva (" e a média foi: " + media)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 600; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */