
package defaultnamespace;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Classe Java de anonymous complex type.
 * 
 * <p>O seguinte fragmento do esquema especifica o conteúdo esperado contido dentro desta classe.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="idConta" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="valorDeDeposito" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "idConta",
    "valorDeDeposito"
})
@XmlRootElement(name = "depositarConta")
public class DepositarConta {

    protected int idConta;
    protected double valorDeDeposito;

    /**
     * Obtém o valor da propriedade idConta.
     * 
     */
    public int getIdConta() {
        return idConta;
    }

    /**
     * Define o valor da propriedade idConta.
     * 
     */
    public void setIdConta(int value) {
        this.idConta = value;
    }

    /**
     * Obtém o valor da propriedade valorDeDeposito.
     * 
     */
    public double getValorDeDeposito() {
        return valorDeDeposito;
    }

    /**
     * Define o valor da propriedade valorDeDeposito.
     * 
     */
    public void setValorDeDeposito(double value) {
        this.valorDeDeposito = value;
    }

}
