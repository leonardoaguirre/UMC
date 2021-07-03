
package Exer4;

import javax.swing.JOptionPane;

public class ControleCliente {
    public void cadCliente(String endereco,String nome,String telefone) {
        Cliente cliente = new Cliente();
        cliente.setEndereco(endereco);
        cliente.setNome(nome);
        cliente.setTelefone(telefone);

        JOptionPane.showMessageDialog(null,"Cliente cadastrado com sucesso!");
        GUI_Pedido frame = new GUI_Pedido();
        frame.setCli(cliente);
        frame.setVisible(true);
    }
}
