
package Aparelho;

public class AparelhoEletronico {
    private String marca;
    private String modelo;
    private int voltagem;

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public int getVoltagem() {
        return voltagem;
    }

    public void setVoltagem(int voltagem) {
        this.voltagem = voltagem;
    }
    
    public void getInformacoes(){
        System.out.println("Marca: "+marca);
        System.out.println("Modelo: "+modelo);
        System.out.println("Voltagem:"+voltagem);
    }
    public void ligar(){
        System.out.println("Aparelho ligado!");
    }
    public void desligar(){
        System.out.println("Aparelho desligado!");
    }
}
