package edu.up.bsi.bichinho.entity;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import javax.annotation.Resource;
import javax.jws.WebMethod;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.ws.WebServiceContext;
import javax.xml.ws.handler.MessageContext;

import com.thecatapi.api.PegarImg;

@WebService(endpointInterface = "edu.up.bsi.bichinho.entity.Buscar")
public class BuscarImp implements Buscar{
	/*
	 * @Resource injeção da inversão de dependencia
	 */

	private BichinhoDAOFake dao = new BichinhoDAOFake();


	@WebMethod(operationName = "todos_os_bichinhos")
	@WebResult(name = "todos_bichinhos_resultado")
	public ListaBichinhos getAll() {
		return new ListaBichinhos(dao.getAllBichinhos());
	}

	@WebMethod(operationName = "raca_do_bichinho")
	@WebResult(name = "raca_resultado")
	public String getRaca(Bichinho bichinho) {

		List<Bichinho> ListaBichinhos = dao.getAllBichinhos();
		for (int i = 0; i < ListaBichinhos.size(); i++) {
			if (bichinho.getNome().equals(ListaBichinhos.get(i).getNome())) {
				return ListaBichinhos.get(i).getRaca();
			}
		}
		return "";

	}
	
	@WebMethod(operationName = "idade_do_bichinho")
	@WebResult(name = "idade_resultado")
	public int getIdade(Bichinho bichinho) {

		List<Bichinho> ListaBichinhos = dao.getAllBichinhos();
		for (int i = 0; i < ListaBichinhos.size(); i++) {
			if (bichinho.getNome().equals(ListaBichinhos.get(i).getNome())) {
				return ListaBichinhos.get(i).getIdade();
			}
		}
		return 0;

	}

	@WebMethod(operationName = "genero_do_bichinho")
	@WebResult(name = "genero_resultado")
	public String getGenero(Bichinho bichinho) {

		List<Bichinho> ListaBichinhos = dao.getAllBichinhos();
		for (int i = 0; i < ListaBichinhos.size(); i++) {
			if (bichinho.getNome().equals(ListaBichinhos.get(i).getNome())) {
				return ListaBichinhos.get(i).getGenero();
			}
		}
		return "";

	}
	
	@WebMethod(operationName = "cep_do_bichinho")
	@WebResult(name = "cep_resultado")
	public String getCep(Bichinho bichinho) {

		List<Bichinho> ListaBichinhos = dao.getAllBichinhos();
		for (int i = 0; i < ListaBichinhos.size(); i++) {
			if (bichinho.getNome().equals(ListaBichinhos.get(i).getNome())) {
				return ListaBichinhos.get(i).getCep();
			}
		}
		return "";

	}
	
	@WebMethod(operationName = "telefone_do_bichinho")
	@WebResult(name = "telefone_resultado")
	public String getTelefone(Bichinho bichinho) {

		List<Bichinho> ListaBichinhos = dao.getAllBichinhos();
		for (int i = 0; i < ListaBichinhos.size(); i++) {
			if (bichinho.getNome().equals(ListaBichinhos.get(i).getNome())) {
				return ListaBichinhos.get(i).getTelefone();
			}
		}
		return "";

	}

	@WebMethod(operationName = "dados_do_bichinho")
	@WebResult(name = "dados_resultado")
	public Bichinho getTodosOsDados(Bichinho bichinho) {

		List<Bichinho> ListaBichinhos = dao.getAllBichinhos();
		for (int i = 0; i < ListaBichinhos.size(); i++) {
			if (bichinho.getNome().equals(ListaBichinhos.get(i).getNome())) {
				bichinho.setRaca(ListaBichinhos.get(i).getRaca());
				bichinho.setIdade(ListaBichinhos.get(i).getIdade());
				bichinho.setGenero(ListaBichinhos.get(i).getGenero());
				bichinho.setTelefone(ListaBichinhos.get(i).getTelefone());
			}
		}
		return bichinho;

	}
	
	@WebMethod(operationName = "img_do_bichinho")
	@WebResult(name = "img_resultado")
	public String getImg() {


		String img = PegarImg.getImgPorUrl();
			

		return img;

	}
	
	@WebMethod(operationName = "imgs_dos_bichinhos")
	@WebResult(name = "imgs_resultado")
	public ArrayList<String> getImgs() {

		ArrayList<String> ListaImgs = new ArrayList<String>();
		for (int i = 0; i < 5; i++) {
			ListaImgs.add(PegarImg.getImgPorUrl());
			
		}
		return ListaImgs;

	}
	
	@WebMethod(operationName = "verificar_bichinho")
	@WebResult(name = "bichinho_verificado")
	public boolean verificar(Bichinho bichinho) {
		String achou = "";
		List<Bichinho> ListaBichinhos = dao.getAllBichinhos();
		for (int i = 0; i < ListaBichinhos.size(); i++) {
			if (bichinho.getNome().equals(ListaBichinhos.get(i).getNome())) {
				achou = "S";
			}
			
		}
		if(achou.equalsIgnoreCase("S")) {
			return true;
		}else {
			return false;
		}
		
	}

}
