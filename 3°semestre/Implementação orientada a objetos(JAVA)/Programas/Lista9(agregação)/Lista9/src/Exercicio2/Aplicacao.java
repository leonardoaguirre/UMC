
package Exercicio2;

public class Aplicacao {
    public static void main(String[] args) {
      
        Endereco end1 = new Endereco();
        end1.setBairro("Morumbi");
        end1.setCidade("São Paulo");
        end1.setNumero(105);
        end1.setRua("Rua dois");
        
        Apartamento ap1 = new Apartamento();
        ap1.setAreaConstruida(100);
        ap1.setNumero(1);
        ap1.setQuartos(3);
        ap1.setVenda(false);
         Apartamento ap2 = new Apartamento();
        ap2.setAreaConstruida(150);
        ap2.setNumero(2);
        ap2.setQuartos(3);
        ap2.setVenda(true);
         Apartamento ap3 = new Apartamento();
        ap3.setAreaConstruida(100);
        ap3.setNumero(1);
        ap3.setQuartos(2);
        ap3.setVenda(false);
        
        Apartamento[] apar = new Apartamento[3];
        apar[0]=ap1;
        apar[1]=ap2;
        apar[2]=ap3;

        Edificio edi1 = new Edificio();
        edi1.setAreaComum(2000);
        edi1.setNome("Prédio de luxo");
        
        edi1.setApartamento(apar);
        edi1.setEndereco(end1);
        
        Aplicacao.imprime(edi1);
    }
    public static void imprime(Edificio edi){
        System.out.println("Edificio: "+edi.getNome()+", com área comum de: "+edi.getAreaComum());
        System.out.println("Localizado em: "+edi.getEndereco().getRua()+","+edi.getEndereco().getNumero()+","+edi.getEndereco().getBairro()+","+edi.getEndereco().getCidade());
        
        Apartamento[] ap = edi.getApartamento();
        for (int i = 0; i <ap.length; i++) {
            System.out.println("Apartamento nº"+ap[i].getNumero()+",com "+ap[i].getQuartos()+" quartos e "+(ap[i].isVenda()?"está a venda":"não está a venda"));
        }
        
    }
}
