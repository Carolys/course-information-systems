package xuxu;

import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;

import javax.xml.namespace.QName;
import javax.xml.ws.BindingProvider;
import javax.xml.ws.Service;
import javax.xml.ws.handler.MessageContext;

import edu.up.bsi.conv.soap.ListaUsuarios;
import edu.up.bsi.conv.soap.Login;
import edu.up.bsi.conv.soap.Usuario;

public class Main {

	private static final String WS_URL = "http://localhost:9090/login?wsdl";

	public static void main(String[] args) throws MalformedURLException {

		URL url = new URL(WS_URL);

		QName qname = new QName("http://soap.conv.bsi.up.edu/", "LoginImpService");

		Service service = Service.create(url, qname);
		Login login = service.getPort(Login.class);

		BindingProvider provider = (BindingProvider) login;

		Map<String, Object> req_ctx = provider.getRequestContext();

		req_ctx.put(BindingProvider.ENDPOINT_ADDRESS_PROPERTY, WS_URL);

		Scanner teclado = new Scanner(System.in);
		String r = "S";
		String msg = "";
		int op = 0;
		Usuario user = new Usuario();

		System.out.println("-----Login-----");
		Map<String, List<String>> headers = new HashMap<String, List<String>>();

		System.out.println("Insira seu id: ");
		user.setNome(teclado.next());
		headers.put("Username", Collections.singletonList(user.getNome()));
		System.out.println("Insira sua senha: ");
		user.setSenha(teclado.next());
		headers.put("Password", Collections.singletonList(user.getSenha()));

		req_ctx.put(MessageContext.HTTP_REQUEST_HEADERS, headers);

		msg = login.getMessageLogin();

		if (!msg.equalsIgnoreCase("n")) {

			System.out.println("\n" + msg);

			while (r.trim().equalsIgnoreCase("S")) {
				System.out.println("\n----Menu-----");
				System.out.println("1 - Listar todos os usuários");
				System.out.println("2 - Mostrar todos os seus dados");
				System.out.println("3 - Mostrar idade");
				System.out.println("4 - Mostrar cpf");
				System.out.println("5 - Mostrar telefone\n");

				System.out.println("Escolha uma opção: ");
				op = teclado.nextInt();

				switch (op) {
				case 1:
					ListaUsuarios lista = login.getAll();
					// List<Usuario> lista = (List<Usuario>) login.getAll();
					for (int u = 0; u < 5; u++) {
						System.out.println("Nome: "+lista.getUsuarios().get(u).getNome());
						System.out.println("Idade: "+lista.getUsuarios().get(u).getIdade());
						System.out.println("Cpf: "+lista.getUsuarios().get(u).getCpf());
						System.out.println("Telefone: "+lista.getUsuarios().get(u).getTelefone()+"\n");
					}

					System.out.println("\n");

					break;
				case 2:
					user = login.getTodosOsDados(user);
					System.out.println("\nSua idade é: " + user.getIdade());
					System.out.println("Seu cpf é: " + user.getCpf());
					System.out.println("Seu telefone é: " + user.getTelefone() + "\n");
					break;
				case 3:
					user.setIdade(login.getIdade(user));
					System.out.println("\nSua idade é: " + user.getIdade() + "\n");
					break;
				case 4:
					user.setCpf(login.getCpf(user));
					System.out.println("\nSeu cpf é: " + user.getCpf() + "\n");
					break;
				case 5:
					user.setTelefone(login.getTelefone(user));
					System.out.println("\nSeu telefone é: " + user.getTelefone() + "\n");
					break;
				default:

				}

				System.out.println("Deseja continuar? (s/n)");
				r = teclado.next();
			}
		} else {

			System.out.println("Usuário inválido brow! Tente de novo!");

		}
		// Map<String, List<String>> headers = new HashMap<String,
		// List<String>>();
		// headers.put("Username", Collections.singletonList("Jasmin"));
		// headers.put("Password", Collections.singletonList("batata"));

		// req_ctx.put(MessageContext.HTTP_REQUEST_HEADERS, headers);

		// System.out.println(login.getMessageLogin());

	}

}
