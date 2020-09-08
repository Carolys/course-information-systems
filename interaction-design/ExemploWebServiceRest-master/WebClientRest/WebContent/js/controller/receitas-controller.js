angular.module('livroreceitas').
controller('ReceitasController', function($scope, $http){
	
	//vou utilizar para colocar o que receber do $http
	$scope.listaReceitas = [];
	
	//vou utilizar para filtrar os dados por ele
	$scope.filtro='';
	
	//busca no link utilizando o método get. Caso consiga acessar,
	// irá criar uma função recebedo o retorno e jogando o retorno
	// no array da listaReceitas. Se algo de errado ocorrer, mostrará
	// o erro no console
	$http.get('http://localhost:8080/WebServiceRest/rest/service/'+
			'todasReceitas').
    success(function(retorno) {
        $scope.listaReceitas = retorno;
    }).error(function(erro) {
        console.log(erro);
    });
	
});

