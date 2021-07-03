
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
 *         &lt;element name="depositarContaReturn" type="{http://www.w3.org/2001/XMLSchema}double"/>
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
    "depositarContaReturn"
})
@XmlRootElement(name = "depositarContaResponse")
public class DepositarContaResponse {

    protected double depositarContaReturn;

    /**
     * Obtém o valor da propriedade depositarContaReturn.
     * 
     */
    public double getDepositarContaReturn() {
        return depositarContaReturn;
    }

    /**
     * Define o valor da propriedade depositarContaReturn.
     * 
     */
    public void setDepositarContaReturn(double value) {
        this.depositarContaReturn = value;
    }

}
