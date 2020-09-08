package edu.up.bsi.conv.soap;

import java.util.ArrayList;
import java.util.List;


public class UsuarioDAOFake {

	public List<Usuario> getAllUsuarios() {
		List<Usuario> lista_users = new  ArrayList<Usuario>();
		lista_users.add(new Usuario("matheus", "zeus", 20, "09873754634", "41975349876"));
		lista_users.add(new Usuario("jasmin", "batata", 34, "02576349512", "41975382456"));
		lista_users.add(new Usuario("gilberto", "pizzacomazeitona", 30, "09825741685", "31978457281"));
		lista_users.add(new Usuario("gabriel", "luvascoloridas", 19, "02459873682", "41985276248"));
		lista_users.add(new Usuario("maria", "mandioquinha", 50, "08523669852", "41996358245"));
		
		return lista_users;
				
	}
}
