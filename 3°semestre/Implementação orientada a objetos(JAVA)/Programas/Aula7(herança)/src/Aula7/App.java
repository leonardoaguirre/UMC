
package Aula7;


public class App {
    public static void main(String[] args) {
        Funcionario funcionario = new Funcionario("joao",2000.00);
        
        System.out.println(funcionario.getNome());
        System.out.println(funcionario.getSalario());
        System.out.println("Bônus do funcionario: "+funcionario.calcularBonificacao());
        
        //criando objeto da classe gerente(subtipo, classe filha, subclasse)
        Gerente gerente = new Gerente("Paulo",5000.00,"TI");
        
        System.out.println(gerente.getNome());
        System.out.println(gerente.getSalario());
        System.out.println(gerente.getSetor());
        System.out.println("Bônus Gerente: "+gerente.calcularBonificacao());
    }
    
}
