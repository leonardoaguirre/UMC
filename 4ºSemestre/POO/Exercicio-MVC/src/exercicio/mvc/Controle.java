package exercicio.mvc;

import javax.swing.JOptionPane;

public class Controle {
    Usuario u = new Usuario();
    Login log = new Login();
    MenuPrincipal mp = new MenuPrincipal(); 
    
    public boolean login(String login ,String senha){
        u.setLogin(login);
        u.setSenha(senha);
        if(u.valida()){
            JOptionPane.showMessageDialog(null,"Login realizado com sucesso!");
            mp.setVisible(true);
        }else{
            JOptionPane.showMessageDialog(null,"Login ou senha inválidos!");
            log.setVisible(true);
        }
        return u.valida();
    }
    
}
