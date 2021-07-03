
package lista4_pooo;


public class TesteCriador {
    public static void main(String[] args) {
        NotaFiscalBuilder builder = new NotaFiscalBuilder();
        
        builder.comRazaoSocial("empresa");
        builder.comCnpj("1234586");
        builder.comItens(new ItemDaNota("item 1",100));
        builder.comItens(new ItemDaNota("item 2",200));
        builder.comItens(new ItemDaNota("item 3",300));
        builder.comObservacoes("entregar nf pessoalmente");
        builder.comDataEmissao();
        
        NotaFiscal nf = builder.constroi();
        
        NotaFiscalBuilderInterfaceFluente builder2 = new NotaFiscalBuilderInterfaceFluente();
        
        builder2.comRazaoSocial("empresa");
        builder2.comCnpj("1234586");
        builder2.comItens(new ItemDaNota("item 1",100));
        builder2.comItens(new ItemDaNota("item 2",200));
        builder2.comItens(new ItemDaNota("item 3",300));
        builder2.comObservacoes("entregar nf pessoalmente");
        builder2.comDataEmissao();
        
        nf=builder2.constroi();
        
        
        NotaFiscal builder3 =  NotaFiscal.getBuilder().comCnpj("1236");
    }
}
