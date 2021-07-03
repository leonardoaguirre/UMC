
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
 *         &lt;element name="criarContaReturn" type="{http://www.w3.org/2001/XMLSchema}boolean"/>
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
    "criarContaReturn"
})
@XmlRootElement(name = "criarContaResponse")
public class CriarContaResponse {

    protected boolean criarContaReturn;

    /**
     * Obtém o valor da propriedade criarContaReturn.
     * 
     */
    public boolean isCriarContaReturn() {
        return criarContaReturn;
    }

    /**
     * Define o valor da propriedade criarContaReturn.
     * 
     */
    public void setCriarContaReturn(boolean value) {
        this.criarContaReturn = value;
    }

}
