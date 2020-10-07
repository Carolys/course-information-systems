
package edu.up.bsi.conv.soap;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the edu.up.bsi.conv.soap package. 
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

    private final static QName _ListaUsuarios_QNAME = new QName("http://soap.conv.bsi.up.edu/", "listaUsuarios");
    private final static QName _Usuario_QNAME = new QName("http://soap.conv.bsi.up.edu/", "usuario");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: edu.up.bsi.conv.soap
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link ListaUsuarios }
     * 
     */
    public ListaUsuarios createListaUsuarios() {
        return new ListaUsuarios();
    }

    /**
     * Create an instance of {@link Usuario }
     * 
     */
    public Usuario createUsuario() {
        return new Usuario();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListaUsuarios }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://soap.conv.bsi.up.edu/", name = "listaUsuarios")
    public JAXBElement<ListaUsuarios> createListaUsuarios(ListaUsuarios value) {
        return new JAXBElement<ListaUsuarios>(_ListaUsuarios_QNAME, ListaUsuarios.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Usuario }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://soap.conv.bsi.up.edu/", name = "usuario")
    public JAXBElement<Usuario> createUsuario(Usuario value) {
        return new JAXBElement<Usuario>(_Usuario_QNAME, Usuario.class, null, value);
    }

}
