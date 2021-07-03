
package Lista2;

public class Retangulo extends Forma{
    private double lado;
    private double altura;

    public double getLado() {
        return lado;
    }

    public void setLado(double lado) {
        this.lado = lado;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }
    @Override
     public double calcularArea(){
        return altura*lado;
    }
    @Override
    public double calcularPerimetro(){
        return ((2*altura)+(2*lado));
    }
    @Override
    public void imprimir(){
        System.out.println("Isto é um retangulo");
    }
}
