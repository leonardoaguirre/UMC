#include <stdio.h>
/* Fun��o do programa   receba a op��o do
usu�rio e os dados necess�rios para executar cada opera��o.
 Menu de op��es:
1- Somar dois n�meros.
2- Multiplicar dois n�meros
3- Subtrair dois n�meros
4- Dividir dois n�meros
Programador: Leonardo
Data:08/03/18*/
main ()
{
	int num,num1,num2;
	float result;
	printf("1- Somar dois numeros\n2- Multiplicar dois numeros\n3- Subtrair dois numeros\n4- Dividir dois numeros\n\t");
	printf ("Digite o numero correspondente do menu desejado: ");
	scanf ("%d", &num);
	if(num >= 1 && num <= 4){
	
		if(num == 1){
				printf("\n1- Somar dois numeros\n Digite o primeiro numero:");
				scanf("%d",&num1);
				printf("Digite o segundo numero:");
				scanf("%d",&num2);
				result = num1+num2;
				printf("O resultado e: %1.f",result);
		}
		if(num == 2){
				printf("\n2- Multiplicar dois numeros\n Digite o primeiro numero:");
				scanf("%d",&num1);
				printf("Digite o segundo numero:");
				scanf("%d",&num2);
				result = num1*num2;
				printf("O resultado e: %1.f",result);
		}
			if(num == 3){
				printf("\n3- Subtrair dois numeros\n Digite o primeiro numero:");
				scanf("%d",&num1);
				printf("Digite o segundo numero:");
				scanf("%d",&num2);
				result = num1-num2;
				printf("O resultado e: %1.f",result);
		}
			if(num == 4){
				printf("\n4- dividir dois numeros\n Digite o primeiro numero:");
				scanf("%d",&num1);
				printf("Digite o segundo numero:");
				scanf("%d",&num2);
				if(num2 ==0){
					printf("Nao e possivel dividir por 0");
				}else{
				result = num1/num2;
				printf("O resultado e: %2.f",result);
			}
		}
	
	}
	else{
		printf("Numero incorreto");
	}

}
