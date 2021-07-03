
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
 *         &lt;element name="sacarContaReturn" type="{http://www.w3.org/2001/XMLSchema}double"/>
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
    "sacarContaReturn"
})
@XmlRootElement(name = "sacarContaResponse")
public class SacarContaResponse {

    protected double sacarContaReturn;

    /**
     * Obtém o valor da propriedade sacarContaReturn.
     * 
     */
    public double getSacarContaReturn() {
        return sacarContaReturn;
    }

    /**
     * Define o valor da propriedade sacarContaReturn.
     * 
     */
    public void setSacarContaReturn(double value) {
        this.sacarContaReturn = value;
    }

}
