package lista4_pooo;

import java.util.Calendar;
import java.util.List;

public class NotaFiscalBuilder {
    private String razaoSocial;
    private String cnpj;
    private Calendar dataEmissao;
    private double valorBruto;
    private double impostos;
    private List<ItemDaNota>itens;
    private String observacoes;


    public void comRazaoSocial(String razaoSocial) {
        this.razaoSocial = razaoSocial;
    }

    public void comCnpj(String cnpj) {
        this.cnpj = cnpj;
    }

    public void comDataEmissao() {
        Calendar data = Calendar.getInstance();
        this.dataEmissao = data;
    }

    public void comValorBruto(double valorBruto) {
        this.valorBruto = valorBruto;
    }

    public void comImpostos(double impostos) {
        this.impostos = impostos;
    }

    public void comItens(ItemDaNota itens) {
        this.itens.add(itens);
    }

    public void comObservacoes(String observacoes) {
        this.observacoes = observacoes;
    }

    public NotaFiscalBuilder() {
    }

    public NotaFiscalBuilder(String razaoSocial, String cnpj, Calendar dataEmissao, double valorBruto, double impostos, List<ItemDaNota> itens, String observacoes) {
        this.razaoSocial = razaoSocial;
        this.cnpj = cnpj;
        this.dataEmissao = dataEmissao;
        this.valorBruto = valorBruto;
        this.impostos = impostos;
        this.itens = itens;
        this.observacoes = observacoes;
    }

    public NotaFiscal constroi() {
        return new NotaFiscal(this.razaoSocial,this.cnpj,this.dataEmissao ,this.valorBruto ,this.impostos,this.itens,this.observacoes);
    }
    
    
}
