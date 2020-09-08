package edu.up.bsi.conv.soap;

import javax.xml.ws.Endpoint;

public class Main {

	public static void main(String[] args) {
		Endpoint.publish("http://localhost:9090/login", new LoginImp());
		System.out.println("Servidor disponível");

	}

}
