#include <stdio.h>
/* Fun��o do programareceba as duas dimens�es de um c�modo (em metros). Calcule e mostre a sua
�rea (em m2) e a pot�ncia de ilumina��o que dever� ser utilizada.
Programador: Leonardo
Data:08/03/18*/
main ()
{
	float LadoA, LadoB, Pot, M2;
	printf ("Programa para calcular a potencia da lampada por comodo\n");
	printf ("Digite a comprimento do comodo: ");
	scanf ("%f", &LadoA);
    printf ("Digite a largura do comodo: ");
    scanf ("%f", &LadoB);
    M2 = LadoA*LadoB;
    Pot = M2*18;
    printf ("O tamanho do comodo em m2 e: %.2f e a pontencia de lampada a ser usada e de: %.2f", M2, Pot);
    
}
