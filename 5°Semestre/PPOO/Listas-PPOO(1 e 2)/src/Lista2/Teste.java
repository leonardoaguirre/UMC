/*
1. As afirmativas abaixo são verdadeiras ou falsas
( ) Uma classe abstrata serve apenas como modelo para uma classe concreta.
( ) Como classes abstratas são modelos de classes, então, não podem ser instanciadas, devem sempre ser
herdadas por classes concretas.
( ) Todos os métodos abstratos de uma classe abstrata devem obrigatoriamente ser implementados
(sobrescritos) em uma classe concreta.
( ) Um método abstrato possui corpo, ou seja uma lógica interna.
( ) Classes abstratas são úteis quando uma classe define métodos a serem implementados apenas pelas
suas subclasses.
( ) Usamos o modificador de acesso public para se criar classes abstratas.
( ) Toda classe que possui pelo menos um método abstrato é automaticamente abstrata e deve ser declarada
como tal.
( ) Uma classe não pode ser declarada abstrata mesmo se ela não possuir métodos abstratos.
( ) Existem atributos abstratos

 */
package Lista2;

public class Teste {
    public static void main(String[] args) {
            Retangulo retangulo = new Retangulo();
            retangulo.setAltura(2);
            retangulo.setLado(3);
            retangulo.imprimir();
            System.out.println("Sua area: "+retangulo.calcularArea()+" Seu perimetro: "+ retangulo.calcularPerimetro());
            
            
            Quadrado quadrado = new Quadrado();
            quadrado.setLado(3);
            quadrado.imprimir();
            System.out.println("Sua area: "+quadrado.calcularArea()+" Seu perimetro: "+quadrado.calcularPerimetro());
            
            
            
            Circulo circulo = new Circulo();
            circulo.setRaio(5);
            circulo.imprimir();
            System.out.println("Sua area: "+circulo.calcularArea()+" Seu perimetro: "+circulo.calcularPerimetro());
            
            
            
            Forma forma = new Forma();
            forma.imprimir();
    }
}
