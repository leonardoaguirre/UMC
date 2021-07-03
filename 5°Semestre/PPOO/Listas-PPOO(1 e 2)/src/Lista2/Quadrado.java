
package Lista2;


public class Quadrado extends Retangulo{
    private double lado;

    @Override
    public double getLado() {
        return lado;
    }

    @Override
    public void setLado(double lado) {
        this.lado = lado;
    }
        @Override
     public double calcularArea(){
        return this.lado*this.lado;
    }
    @Override
    public double calcularPerimetro(){
        return this.lado*4;
    }
    @Override
    public void imprimir(){
        System.out.println("Isto é um quadrado");
    }
}
