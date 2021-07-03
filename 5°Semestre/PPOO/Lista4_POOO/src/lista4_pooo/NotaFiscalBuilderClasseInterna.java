package lista4_pooo;

import java.util.Calendar;

public class NotaFiscalBuilderClasseInterna {

    private NotaFiscal nf;

    public NotaFiscalBuilderClasseInterna comRazaoSocial(String razaoSocial) {
        nf.razaoSocial = razaoSocial;
        return this;
    }

    public NotaFiscalBuilderClasseInterna comCnpj(String cnpj) {
        nf.cnpj = cnpj;
        return this;
    }

    public NotaFiscalBuilderClasseInterna comDataEmissao() {
        Calendar data = Calendar.getInstance();
        nf.dataEmissao = data;
        return this;
    }

    public NotaFiscalBuilderClasseInterna comValorBruto(double valorBruto) {
        nf.valorBruto = valorBruto;
        return this;
    }

    public NotaFiscalBuilderClasseInterna comImpostos(double impostos) {
        nf.impostos = impostos;
        return this;
    }

    public NotaFiscalBuilderClasseInterna comItens(ItemDaNota itens) {
        nf.itens.add(itens);
        return this;
    }

    public NotaFiscalBuilderClasseInterna comObservacoes(String observacoes) {
        nf.observacoes = observacoes;
        return this;
    }

    public NotaFiscal constroi() {
        return nf;
    }

    public NotaFiscalBuilderClasseInterna() {
    }
    
    
}
