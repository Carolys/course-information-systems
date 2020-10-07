package edu.up.bsi.usuario.entity;

import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;
import javax.jws.soap.SOAPBinding.Style;


@WebService
@SOAPBinding(style = Style.RPC)
public interface Login {

	String getMessageLogin();
	
	ListaUsuarios getAll();
	
	int getIdade(Usuario user);
	
	String getCpf(Usuario user);
	
	String getTelefone(Usuario user);
	
	String getCep(Usuario user);
	
	String getCidade(String cep);
	
	Usuario getTodosOsDados(Usuario user);
	
	boolean validaCep(String cep1, String cep2);
	
}
