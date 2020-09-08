package br.edu.up.guardaAmigoRest.resources;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import br.edu.up.guardaAmigoRest.models.Amigo;
import br.edu.up.guardaAmigoRest.repository.AmigoRepository;

@RestController
@RequestMapping("/amigo")
public class AmigoResource {

	@Autowired
	private AmigoRepository repository;
	
	@GetMapping(produces="application/json")
	public @ResponseBody Iterable<Amigo> listaAmigos() {
		Iterable<Amigo> listaAmigos = repository.findAll();
		return listaAmigos;
	}
	
	@PostMapping()
	public Amigo cadastraAmigo(@RequestBody @Valid Amigo amigo) {
		return repository.save(amigo);
	}
	
	@DeleteMapping()
	public Amigo deletaAmigo(@RequestBody Amigo amigo) {
		repository.delete(amigo);
		return amigo;
	}
}
