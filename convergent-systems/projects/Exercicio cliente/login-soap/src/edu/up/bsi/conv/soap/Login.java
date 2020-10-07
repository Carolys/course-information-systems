package edu.up.bsi.conv.soap;

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
	
	Usuario getTodosOsDados(Usuario user);
	
}
