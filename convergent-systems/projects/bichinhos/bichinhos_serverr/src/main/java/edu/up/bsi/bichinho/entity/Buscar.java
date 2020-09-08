package edu.up.bsi.bichinho.entity;

import java.util.ArrayList;

import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;
import javax.jws.soap.SOAPBinding.Style;

@WebService
@SOAPBinding(style = Style.RPC)
public interface Buscar {

	
	ListaBichinhos getAll();
	
	String getRaca(Bichinho bichinho);
	
	int getIdade(Bichinho bichinho);
	
	String getGenero(Bichinho bichinho);
	
	String getCep(Bichinho bichinho);
	
	String getTelefone(Bichinho bichinho);
	
	String getImg();
	
	boolean verificar(Bichinho bichinho);
	
	Bichinho getTodosOsDados(Bichinho bichinho);
	
	ArrayList<String> getImgs();
	

	
}
