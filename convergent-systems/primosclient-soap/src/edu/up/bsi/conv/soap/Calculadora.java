
package edu.up.bsi.conv.soap;

import java.util.List;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.Action;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.9-b130926.1035
 * Generated source version: 2.2
 * 
 */
@WebService(name = "Calculadora", targetNamespace = "http://soap.conv.bsi.up.edu/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface Calculadora {


    /**
     * 
     * @param numero
     * @return
     *     returns java.util.List<java.lang.Integer>
     */
    @WebMethod(operationName = "acha_primos")
    @WebResult(name = "primos", targetNamespace = "")
    @RequestWrapper(localName = "acha_primos", targetNamespace = "http://soap.conv.bsi.up.edu/", className = "edu.up.bsi.conv.soap.AchaPrimos")
    @ResponseWrapper(localName = "acha_primosResponse", targetNamespace = "http://soap.conv.bsi.up.edu/", className = "edu.up.bsi.conv.soap.AchaPrimosResponse")
    @Action(input = "http://soap.conv.bsi.up.edu/Calculadora/acha_primosRequest", output = "http://soap.conv.bsi.up.edu/Calculadora/acha_primosResponse")
    public List<Integer> achaPrimos(
        @WebParam(name = "numero", targetNamespace = "")
        Numero numero);

}
