
package Exercicio1;

/**
 *
 * @author Leonardo
 */
public class Aplicacao {
    public static void main(String[] args) {
         Endereco end1 = new Endereco();
        end1.setBairro("Morumbi");
        end1.setCidade("São Paulo");
        end1.setNumero(105);
        end1.setRua("Rua dois");
        
        Pessoa pe = new Pessoa();
        pe.setNome("Leonardo");
        pe.setCpf(123456789);
        
        pe.setEndereco(end1);
        
        Aplicacao.imprime(pe);
    }
    public static void imprime(Pessoa pes){
        System.out.println("O(a) "+pes.getNome()+" que tem o CPF "+pes.getCpf()+", mora na "+pes.getEndereco().getRua()+", "+pes.getEndereco().getNumero()+", "+
                pes.getEndereco().getBairro()+", "+pes.getEndereco().getCidade());    
    }
}
