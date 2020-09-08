package edu.up.bsi.bichinho.server;

import javax.xml.ws.Endpoint;

import edu.up.bsi.bichinho.entity.BuscarImp;


public class Main {

	public static void main(String[] args) {


		Endpoint.publish("http://localhost:8080/buscar", new BuscarImp());
		System.out.println("Servidor disponível, aguarde conexões.");

	}

}
