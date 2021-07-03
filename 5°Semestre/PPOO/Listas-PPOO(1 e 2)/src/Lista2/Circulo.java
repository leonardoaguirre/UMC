
package Lista2;


public class Circulo extends Forma{
    private double raio;

    public double getRaio() {
        return raio;
    }

    public void setRaio(double raio) {
        this.raio = raio;
    }

    @Override
     public double calcularArea(){
        return Math.PI*(Math.pow(this.raio, 2));
    }
    @Override
    public double calcularPerimetro(){
        return 2*Math.PI*this.raio;
    }
    @Override
    public void imprimir(){
        System.out.println("Isto é um circulo");
    }
}
