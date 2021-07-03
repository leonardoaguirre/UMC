/*
1. Associe os conceitos relacionados à herança na orientação a objetos localizados na coluna da esquerda com
as suas definições na coluna da direita:

A) extends
B) classe Object
C) hierarquia de classes
D) protected 
E) método toString()
F) método clone()
G) super
H) superclasse
I) subclasse
J) final
K) herança--
L) polimorfismo--

(K) Relacionamento É-UM entre duas classes
(B) Superclasse de todas as classes do Java
(G) Palavra reservada usada para se referir a um membro da superclasse
(D) Define membros que podem ser acessados pela própria classe e suas subclasses
(E) Método da classe Object que imprime uma versão String de qualquer objeto
(H) Classe mãe em um relacionamento de herança
(J) Palavra reservada para impedir que um membro da classe seja sobrescrito
(L) Capacidade de desacoplar a referencia de um objeto de sua implementação
(A) Palavra reservada que indica que uma subclasse irá herdar de uma superclasse
(F) Método da classe Object que cria uma cópia do objeto que o chamou
(C) Um grupo de classes relacionadas em vários níveis de herança
(I) Classe filha em um relacionamento de herança
 */
package Lista1;


public class Venda {
    private double valor;

    public double getValor() {
        return valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }
    public double calcularTotal(Promocao desconto){
        double total=this.valor;
        if (desconto.estaAtiva()) {
            total = this.valor-desconto.getValorDesconto();
        }else{
            System.out.print("A promoção selecionada não esta ativa!" );
        }
         
        return total;
    }
    
}
