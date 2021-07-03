/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lista3;
import java.text.SimpleDateFormat;
/**
 *
 * @author alunocmc
 */
public class Relogio {
        private int hora;
	private int minuto;
	private int segundo;
        
        //SimpleDateFormat forma = SimpleDateFormat("hh:mm:ss");
	//construtor #1
	public Relogio()
	{
            
		hora = 0;
		minuto = 0;
		segundo = 0;
                //forma.format(hora);
                if((hora<0 || hora>23) || (minuto<0 || minuto>59) || (segundo<0 || segundo>59)){
                    System.out.println("Valor de tempo invalido!");
                }
	}
	
	//construtor #2
	public Relogio(int h)
	{
		hora = h;
		minuto = 0;
		segundo = 0;
                if((hora<0 || hora>23)){
                    System.out.println("Valor de tempo invalido!");
                }
	}
	
	//construtor #3
	public Relogio(int h, int m)
	{
		hora = h;
		minuto = m;
		segundo = 0;
                if((hora<0 || hora>23) || (minuto<0 || minuto>59)){
                    System.out.println("Valor de tempo invalido!");
                }
	}

	//construtor #4
	public Relogio(int h, int m, int s)
	{
		hora = h;
		minuto = m;
		segundo = s;
                if((hora<0 || hora>23) || (minuto<0 || minuto>59) || (segundo<0 || segundo>59)){
                    System.out.println("Valor de tempo invalido!");
                }
	}

	//métodos de acesso
	public void setHora(int x)
	{
            
		hora = x;
                if((hora<0 || hora>23)){
                    System.out.println("Valor de hora invalido!");
                }
	}

	public int getHora()
	{
		return hora;
	}

	public void setMinuto(int x)
	{
		minuto = x;
                if((minuto<0 || minuto>59)){
                    System.out.println("Valor de minuto invalido!");
                }
	}

	public int getMinuto()
	{
		return minuto;
	}

	public void setSegundo(int x)
	{
		segundo = x;
                if((segundo<0 || segundo>59)){
                    System.out.println("Valor de segundo invalido!");
                }
	}

	public int getSegundo()
	{
		return segundo;
	}
}  
//final da classe Relogio
