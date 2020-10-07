package br.com.viacep;


public class ValidaCep{
	

	public static boolean Valida(String cep1, String cep2) {
		Endereco end1 = new Endereco();
		Endereco end2 = new Endereco();
		end1 = ClienteWs.getEnderecoPorCep(cep1);
		end2 = ClienteWs.getEnderecoPorCep(cep2);
		if(end1.getLocalidade().equals( end2.getLocalidade())) {
			return true;
		}else 
		{
			return false;
		}
	}

}