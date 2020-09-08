package edu.up.bsi.usuario.server;

import javax.xml.ws.Endpoint;

import edu.up.bsi.usuario.entity.LoginImp;


public class Main {
	
	public static void main(String[] args) {
		Endpoint.publish("http://localhost:9090/login", new LoginImp());
		System.out.println("Servidor disponível");

	}

}
