/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lista3;

/**
 *
 * @author alunocmc
 */
public class Horario {
    public static void main(String[] args) 
	{
		//instancia objeto da classe Relogio
		//utilizando construtor vazio
		/*Relogio r = new Relogio();		
		System.out.println("utilizando construtor vazio");
		System.out.println("horario: " + r.getHora() + ":" + r.getMinuto() + ":" + r.getSegundo());
		System.out.println("\n\n");//pula duas linhas

		//instancia objeto da classe Relogio
		//utilizando construtor que requer hora, minuto e segundo
		Relogio r2 = new Relogio(115,70,98);		
		System.out.println("utilizando construtor que requer hora, minuto e segundo");
		System.out.println("horario: " + r2.getHora() + ":" + r2.getMinuto() + ":" + r2.getSegundo());
		System.out.println("\n\n");//pula duas linhas

		//instancia objeto da classe Relogio
		//utilizando construtor que requer apenas a hora
		Relogio r3 = new Relogio(20);		
		System.out.println("utilizando construtor que requer apenas a hora");
		System.out.println("horario: " + r3.getHora() + ":" + r3.getMinuto() + ":" + r3.getSegundo());
		System.out.println("\n\n");//pula duas linhas

		//instancia objeto da classe Relogio
		//utilizando construtor que requer hora e minuto
		Relogio r4 = new Relogio(10,30);		
		System.out.println("utilizando construtor que requer hora e minuto");
		System.out.println("horario: " + r4.getHora() + ":" + r4.getMinuto() + ":" + r4.getSegundo());
		System.out.println("\n\n");//pula duas linhas

		//instancia objeto da classe Relogio
		//utilizando construtor vazio,
		Relogio r5 = new Relogio();		
		System.out.println("utilizando construtor vazio,");
		System.out.println("mas atribuindo valores atraves dos metodos de acesso");
		//mas atribuindo valores atraves dos metodos de acesso
		r5.setHora(13);
		r5.setMinuto(40);
		r5.setSegundo(10);
		System.out.println("horario: " + r5.getHora() + ":" + r5.getMinuto() + ":" + r5.getSegundo());
		System.out.println("\n\n");//pula duas linhas*/

                Relogio r;
                r= new Relogio();
                System.out.println("utilizando construtor vazio");
		System.out.println("horario: " + r.getHora() + ":" + r.getMinuto() + ":" + r.getSegundo());
		System.out.println("\n\n");//pula duas linhas
                
                r = new Relogio(12);
                
                System.out.println("utilizando construtor que requer apenas a hora");
		System.out.println("horario: " + r.getHora() + ":" + r.getMinuto() + ":" + r.getSegundo());
		System.out.println("\n\n");//pula duas linhas
                r = new Relogio(24,55);
                
                System.out.println("utilizando construtor que requer hora e minuto");
		System.out.println("horario: " + r.getHora() + ":" + r.getMinuto() + ":" + r.getSegundo());
		System.out.println("\n\n");//pula duas linhas
                
                r = new Relogio(12,50,1);
                System.out.println("utilizando construtor que requer hora, minuto e segundo");
		System.out.println("horario: " + r.getHora() + ":" + r.getMinuto() + ":" + r.getSegundo());
		System.out.println("\n\n");//pula duas linhas
                
	}
}//final da classe Horário
