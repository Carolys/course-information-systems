package edu.up.bsi.conv.soap;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import javax.annotation.Resource;
import javax.jws.WebMethod;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.ws.WebServiceContext;
import javax.xml.ws.handler.MessageContext;

@WebService(endpointInterface = "edu.up.bsi.conv.soap.Login")
public class LoginImp implements Login {
	/*
	 * @Resource injeção da inversão de dependencia
	 */

	private UsuarioDAOFake dao = new UsuarioDAOFake();

	@Resource
	WebServiceContext wsctx;

	@Override
	public String getMessageLogin() {

		MessageContext mctx = wsctx.getMessageContext();

		Map http_header = (Map) mctx.get(MessageContext.HTTP_REQUEST_HEADERS);

		List<String> userList = (List<String>) http_header.get("Username");
		List<String> passList = (List<String>) http_header.get("Password");

		String username = "";
		String password = "";

		if (userList != null) {
			username = userList.get(0);
		}

		if (passList != null) {
			password = passList.get(0);
		}

		List<Usuario> usuarios = dao.getAllUsuarios();

		for (int i = 0; i < usuarios.size(); i++) {
			if (username.equals(usuarios.get(i).getNome()) && password.equals(usuarios.get(i).getSenha())) {
				return "Bem vindo " + username + " ao sistema X.";
			}

		}

		return "n";
		// if (username.equals("admin") && password.equals("admin123")) {
		// return "Bem vindo " + username + " ao sistema X.";
		// } else {
		// return "Usuário inválido brow! Tente de novo!";
		// }

	}

	@WebMethod(operationName = "todos_os_usuarios")
	@WebResult(name = "todos_usuarios_resultado")
	public ListaUsuarios getAll() {
		return new ListaUsuarios(dao.getAllUsuarios());
	}

	@WebMethod(operationName = "idade_do_usuario")
	@WebResult(name = "idade_resultado")
	public int getIdade(Usuario user) {

		List<Usuario> ListaUsuarios = dao.getAllUsuarios();
		for (int i = 0; i < ListaUsuarios.size(); i++) {
			if (user.getNome().equals(ListaUsuarios.get(i).getNome())) {
				return ListaUsuarios.get(i).getIdade();
			}
		}
		return 0;

	}

	@WebMethod(operationName = "cpf_do_usuario")
	@WebResult(name = "cpf_resultado")
	public String getCpf(Usuario user) {

		List<Usuario> ListaUsuarios = dao.getAllUsuarios();
		for (int i = 0; i < ListaUsuarios.size(); i++) {
			if (user.getNome().equals(ListaUsuarios.get(i).getNome())) {
				return ListaUsuarios.get(i).getCpf();
			}
		}
		return "";

	}

	@WebMethod(operationName = "telefone_do_usuario")
	@WebResult(name = "telefone_resultado")
	public String getTelefone(Usuario user) {

		List<Usuario> ListaUsuarios = dao.getAllUsuarios();
		for (int i = 0; i < ListaUsuarios.size(); i++) {
			if (user.getNome().equals(ListaUsuarios.get(i).getNome())) {
				return ListaUsuarios.get(i).getTelefone();
			}
		}
		return "";

	}

	
	@WebMethod(operationName = "dados_do_usuario")
	@WebResult(name = "dados_resultado")
	public Usuario getTodosOsDados(Usuario user) {

		List<Usuario> ListaUsuarios = dao.getAllUsuarios();
		for (int i = 0; i < ListaUsuarios.size(); i++) {
			if (user.getNome().equals(ListaUsuarios.get(i).getNome())) {
				user.setIdade(ListaUsuarios.get(i).getIdade());
				user.setCpf(ListaUsuarios.get(i).getCpf());
				user.setTelefone(ListaUsuarios.get(i).getTelefone());
			}
		}
		return user;

	}

}
