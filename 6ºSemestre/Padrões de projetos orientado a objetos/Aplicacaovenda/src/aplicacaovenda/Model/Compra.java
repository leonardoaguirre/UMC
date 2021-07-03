package aplicacaovenda.Model;

public class Compra {

    private String data;
    private Cliente cliente;
    private Produto[] produtos;

    public Compra(String data, Cliente cliente, Produto[] produtos) {
        this.data = data;
        this.cliente = cliente;
        this.produtos = produtos;
    }

    public Compra() {
    }

    public String getData() {
        return data;
    }

    public void setData(String data) {
        this.data = data;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Produto[] getProdutos() {
        return produtos;
    }

    public void setProdutos(Produto[] produtos) {
        this.produtos = produtos;
    }

    int qtdProd;

    public void setQuantidadeProdutos(int quantidadeProdutos) {
        this.qtdProd = quantidadeProdutos;
        //ja define o tamanho do vetor
        produtos = new Produto[this.qtdProd];
    }

    public void addProduto(Produto produto) {
        boolean inserido = false;
        
        for (int i = 0; i < this.qtdProd; i++) {
            if(produtos[i]==null && inserido==false){
               produtos[i] = produto;
                inserido = true; 
            }
        }
       
    }

    public boolean finalizar() {
        boolean flag = true;
        //verfica se data e cliente estao vazios
        if (this.data.isEmpty() || this.cliente.getNome().isEmpty()) {
            flag = false;
        }
        for (Produto p : this.produtos) {
            //verifica se nome, preco ou id do produto estao vazios
            if (p.getNome().isEmpty() || p.getPreco() == 0 || p.getId() == 0) {
                flag = false;
            }
        }
        // se nao estiverem infos vazias e a flag continuar true exibe as infos  da compra
        if (flag == true) {
            System.out.println("Cliente: " + this.cliente.getNome());
            System.out.println("Data: " + this.data);
            for (Produto p : this.produtos) {
                System.out.println("---------------------------------------");
                System.out.println("Id: " + p.getId());
                System.out.println("Produto: " + p.getNome());
                System.out.println("Preco: " + p.getPreco());
            }
        }
        return flag;
    }
}
