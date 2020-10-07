package br.edu.up.guardaAmigoRest.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import br.edu.up.guardaAmigoRest.models.Amigo;

public interface AmigoRepository extends JpaRepository<Amigo, String>{

}
