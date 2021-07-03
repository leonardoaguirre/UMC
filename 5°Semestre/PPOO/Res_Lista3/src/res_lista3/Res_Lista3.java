/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package res_lista3;

/**
 *
 * @author PTOLEDO
 */
public class Res_Lista3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        Venda v = new Venda();

        RegraDePagamento rp;

        v.setTotalvendido(350);
        
        if (v.getTotalvendido() >300) {
            
            if (v.getTotalvendido() > 300 && v.getTotalvendido() <=500) {
                rp = new PgVista300();
                v.setPagamento(rp);

                System.out.println("Total.. " + v.getTotalvendido() + "| Total no dinheiro: " + v.calcularTotal());
            }

            if (v.getTotalvendido() >= 500 && v.getTotalvendido() <=1000) {
                //v.setTotalvendido(500);
                rp = new PgVista500();
                v.setPagamento(rp);

                System.out.println("Total.. " + v.getTotalvendido() + "| Total no dinheiro: " + v.calcularTotal());
            }
            if (v.getTotalvendido() >1000) {
                //v.setTotalvendido(1000);
                rp = new PgVista1000();
                v.setPagamento(rp);

                System.out.println("Total.. " + v.getTotalvendido() + "| Total no dinheiro: " + v.calcularTotal());
            }
            
        } else {
            System.out.println("Total.. " + v.getTotalvendido());
        }
        //v.setTotalvendido(500);
        rp = new PgCC();
        v.setPagamento(rp);

        System.out.println("Total.. " + v.getTotalvendido() + "| Total no cartão de crédito: " + v.calcularTotal());

        //v.setTotalvendido(500);
        rp = new PgCD();
        v.setPagamento(rp);

        System.out.println("Total.. " + v.getTotalvendido() + "| Total no cartão de débito: " + v.calcularTotal());

    }

}
