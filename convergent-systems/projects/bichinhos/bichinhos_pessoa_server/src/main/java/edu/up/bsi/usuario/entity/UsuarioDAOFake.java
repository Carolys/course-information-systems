package edu.up.bsi.usuario.entity;

import java.util.ArrayList;
import java.util.List;


public class UsuarioDAOFake {

	public List<Usuario> getAllUsuarios() {
		List<Usuario> lista_users = new  ArrayList<Usuario>();
		lista_users.add(new Usuario("matheus", "zeus", 20, "09873754634", "41975349876", "82220562"));
		lista_users.add(new Usuario("jasmin", "batata", 34, "02576349512", "41975382456","05797310"));
		lista_users.add(new Usuario("gilberto", "pizzacomazeitona", 30, "09825741685", "31978457281","81830020"));
		lista_users.add(new Usuario("gabriel", "luvascoloridas", 19, "02459873682", "41985276248", "21932150"));
		lista_users.add(new Usuario("maria", "mandioquinha", 50, "08523669852", "41996358245", "79004391"));
		
		return lista_users;
				
	}
}
