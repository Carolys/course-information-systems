
package edu.up.bsi.entity;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.9-b130926.1035
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "LoginImpService", targetNamespace = "http://entity.bsi.up.edu/", wsdlLocation = "http://localhost:9090/login?wsdl")
public class LoginImpService
    extends Service
{

    private final static URL LOGINIMPSERVICE_WSDL_LOCATION;
    private final static WebServiceException LOGINIMPSERVICE_EXCEPTION;
    private final static QName LOGINIMPSERVICE_QNAME = new QName("http://entity.bsi.up.edu/", "LoginImpService");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://localhost:9090/login?wsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        LOGINIMPSERVICE_WSDL_LOCATION = url;
        LOGINIMPSERVICE_EXCEPTION = e;
    }

    public LoginImpService() {
        super(__getWsdlLocation(), LOGINIMPSERVICE_QNAME);
    }

    public LoginImpService(WebServiceFeature... features) {
        super(__getWsdlLocation(), LOGINIMPSERVICE_QNAME, features);
    }

    public LoginImpService(URL wsdlLocation) {
        super(wsdlLocation, LOGINIMPSERVICE_QNAME);
    }

    public LoginImpService(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, LOGINIMPSERVICE_QNAME, features);
    }

    public LoginImpService(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public LoginImpService(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns Login
     */
    @WebEndpoint(name = "LoginImpPort")
    public Login getLoginImpPort() {
        return super.getPort(new QName("http://entity.bsi.up.edu/", "LoginImpPort"), Login.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns Login
     */
    @WebEndpoint(name = "LoginImpPort")
    public Login getLoginImpPort(WebServiceFeature... features) {
        return super.getPort(new QName("http://entity.bsi.up.edu/", "LoginImpPort"), Login.class, features);
    }

    private static URL __getWsdlLocation() {
        if (LOGINIMPSERVICE_EXCEPTION!= null) {
            throw LOGINIMPSERVICE_EXCEPTION;
        }
        return LOGINIMPSERVICE_WSDL_LOCATION;
    }

}
