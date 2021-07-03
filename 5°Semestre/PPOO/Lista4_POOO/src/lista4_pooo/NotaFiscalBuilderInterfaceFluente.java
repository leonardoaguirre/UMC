package lista4_pooo;

import java.util.Calendar;
import java.util.List;

public class NotaFiscalBuilderInterfaceFluente {
    private String razaoSocial;
    private String cnpj;
    private Calendar dataEmissao;
    private double valorBruto;
    private double impostos;
    private List<ItemDaNota>itens;
    private String observacoes;

    public NotaFiscalBuilderInterfaceFluente comRazaoSocial(String razaoSocial) {
        this.razaoSocial = razaoSocial;
        return this;
    }

    public NotaFiscalBuilderInterfaceFluente comCnpj(String cnpj) {
        this.cnpj = cnpj;
        return this;
    }

    public NotaFiscalBuilderInterfaceFluente comDataEmissao() {
        Calendar data = Calendar.getInstance();
        this.dataEmissao = data;
        return this;
    }

    public NotaFiscalBuilderInterfaceFluente comValorBruto(double valorBruto) {
        this.valorBruto = valorBruto;
        return this;
    }

    public NotaFiscalBuilderInterfaceFluente comImpostos(double impostos) {
        this.impostos = impostos;
        return this;
    }

    public NotaFiscalBuilderInterfaceFluente comItens(ItemDaNota itens) {
        this.itens.add(itens);
        return this;
    }

    public NotaFiscalBuilderInterfaceFluente comObservacoes(String observacoes) {
        this.observacoes = observacoes;
        return this;
    }

    public NotaFiscalBuilderInterfaceFluente(String razaoSocial, String cnpj, Calendar dataEmissao, double valorBruto, double impostos, List<ItemDaNota> itens, String observacoes) {
        this.razaoSocial = razaoSocial;
        this.cnpj = cnpj;
        this.dataEmissao = dataEmissao;
        this.valorBruto = valorBruto;
        this.impostos = impostos;
        this.itens = itens;
        this.observacoes = observacoes;
    }

    public NotaFiscalBuilderInterfaceFluente() {
    }

    public NotaFiscal constroi() {
        return new NotaFiscal(this.razaoSocial,this.cnpj,this.dataEmissao ,this.valorBruto ,this.impostos,this.itens,this.observacoes);
    }
    
    
}
