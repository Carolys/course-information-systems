package edu.up.bsi.conv.fib.soap.server;

import javax.xml.ws.Endpoint;

/**
 * Classe para inicializar o serviço do servidor
 * @author Carol
 *
 */

public class Main {

	public static void main(String[] args) {


		Endpoint.publish("http://localhost:8080/fibonacci", new Fibonacci());
		System.out.println("Servidor disponível, aguarde conexões.");

	}

}
