package edu.up.bsi.bichinho.entity;

import java.util.ArrayList;
import java.util.List;

public class BichinhoDAOFake {

	public List<Bichinho> getAllBichinhos() {
		List<Bichinho> lista_bichinhos = new  ArrayList<Bichinho>();
		lista_bichinhos.add(new Bichinho("dengosa", "Siames", 2, "Femea", "79002210", "(67) 997686453"));
		lista_bichinhos.add(new Bichinho("sansao", "Himalaia", 10, "Macho", "22720185", "(21) 987685749"));
		lista_bichinhos.add(new Bichinho("leo", "Maine Coon", 5, "Macho","22770495", "(21) 998568566"));
		lista_bichinhos.add(new Bichinho("mirna", "Siberiano", 7, "Femea","82600080", "(41) 996385999"));
		lista_bichinhos.add(new Bichinho("lua", "Ragdoll", 3, "Femea","03264150", "(11) 998588784"));
		
		return lista_bichinhos;
				
	}
}
