
package edu.up.bsi.conv.fib.soap.server;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the edu.up.bsi.conv.fib.soap.server package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _Fibonacci2_QNAME = new QName("http://server.soap.fib.conv.bsi.up.edu/", "fibonacci2");
    private final static QName _SomaResponse_QNAME = new QName("http://server.soap.fib.conv.bsi.up.edu/", "somaResponse");
    private final static QName _Fibonacci_QNAME = new QName("http://server.soap.fib.conv.bsi.up.edu/", "fibonacci");
    private final static QName _FibonacciResponse_QNAME = new QName("http://server.soap.fib.conv.bsi.up.edu/", "fibonacciResponse");
    private final static QName _Soma_QNAME = new QName("http://server.soap.fib.conv.bsi.up.edu/", "soma");
    private final static QName _Fibonacci2Response_QNAME = new QName("http://server.soap.fib.conv.bsi.up.edu/", "fibonacci2Response");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: edu.up.bsi.conv.fib.soap.server
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link Fibonacci_Type }
     * 
     */
    public Fibonacci_Type createFibonacci_Type() {
        return new Fibonacci_Type();
    }

    /**
     * Create an instance of {@link FibonacciResponse }
     * 
     */
    public FibonacciResponse createFibonacciResponse() {
        return new FibonacciResponse();
    }

    /**
     * Create an instance of {@link Soma }
     * 
     */
    public Soma createSoma() {
        return new Soma();
    }

    /**
     * Create an instance of {@link Fibonacci2Response }
     * 
     */
    public Fibonacci2Response createFibonacci2Response() {
        return new Fibonacci2Response();
    }

    /**
     * Create an instance of {@link Fibonacci2 }
     * 
     */
    public Fibonacci2 createFibonacci2() {
        return new Fibonacci2();
    }

    /**
     * Create an instance of {@link SomaResponse }
     * 
     */
    public SomaResponse createSomaResponse() {
        return new SomaResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Fibonacci2 }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://server.soap.fib.conv.bsi.up.edu/", name = "fibonacci2")
    public JAXBElement<Fibonacci2> createFibonacci2(Fibonacci2 value) {
        return new JAXBElement<Fibonacci2>(_Fibonacci2_QNAME, Fibonacci2 .class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link SomaResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://server.soap.fib.conv.bsi.up.edu/", name = "somaResponse")
    public JAXBElement<SomaResponse> createSomaResponse(SomaResponse value) {
        return new JAXBElement<SomaResponse>(_SomaResponse_QNAME, SomaResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Fibonacci_Type }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://server.soap.fib.conv.bsi.up.edu/", name = "fibonacci")
    public JAXBElement<Fibonacci_Type> createFibonacci(Fibonacci_Type value) {
        return new JAXBElement<Fibonacci_Type>(_Fibonacci_QNAME, Fibonacci_Type.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link FibonacciResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://server.soap.fib.conv.bsi.up.edu/", name = "fibonacciResponse")
    public JAXBElement<FibonacciResponse> createFibonacciResponse(FibonacciResponse value) {
        return new JAXBElement<FibonacciResponse>(_FibonacciResponse_QNAME, FibonacciResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Soma }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://server.soap.fib.conv.bsi.up.edu/", name = "soma")
    public JAXBElement<Soma> createSoma(Soma value) {
        return new JAXBElement<Soma>(_Soma_QNAME, Soma.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Fibonacci2Response }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://server.soap.fib.conv.bsi.up.edu/", name = "fibonacci2Response")
    public JAXBElement<Fibonacci2Response> createFibonacci2Response(Fibonacci2Response value) {
        return new JAXBElement<Fibonacci2Response>(_Fibonacci2Response_QNAME, Fibonacci2Response.class, null, value);
    }

}
