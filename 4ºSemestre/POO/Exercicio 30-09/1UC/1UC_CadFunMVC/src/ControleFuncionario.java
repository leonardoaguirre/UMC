
import javax.swing.JOptionPane;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author eduardo.ferreira
 */
public class ControleFuncionario {
    
    Funcionario f = new Funcionario();
    
    
    public void CadFunc(String nm,String sex,String rg,String end){
        f.setNome(nm);
        f.setSexo(sex);
        f.setRg(rg);
        f.setEnd(end);
        JOptionPane.showMessageDialog(null,"Cadastro realizado com sucesso !!!");
        
       
        
    }
        
    public String ExibFunc(){
        String msg=f.getNome()+","+f.getSexo()+","+f.getRg()+","+f.getEnd();
        return msg;
    }
}
