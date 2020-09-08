package edu.up.bsi.conv.fib.soap;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import edu.up.bsi.conv.fib.soap.server.Fibonacci;
import edu.up.bsi.conv.fib.soap.server.FibonacciService;

public class Main {

	public static Fibonacci fibonacci;

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		fibonacci = new FibonacciService().getFibonacciPort();
		String r = "S";
		int op = 10;
		
		System.out.println("-----Menu-----");
		System.out.println("1 - Fibonacci");
		System.out.println("0 - Sair");
		
		System.out.println("\nInsira uma opção:");
		op = teclado.nextInt();

		while (op != 0) {
						
			while (r.trim().equalsIgnoreCase("S")) {
				switch (op) {
				case 1:

					System.out.println("Insira o valor inicial: ");
					int valor = teclado.nextInt();
					System.out.println("Insira a quantidade de elementos: ");
					int quant = teclado.nextInt();
					List<Integer> lista = fibonacci.fibonacci(valor, quant);

					if (!lista.isEmpty()) {
						System.out.println("\nSequência Fibonacci até " + quant + ".");

						for (int i = 0; i < lista.size(); i++) {

							System.out.println(lista.get(i));
						}

					} else {
						System.out.println("Valores incorretos, tente novamente!");
					}

					break;

				default:

					System.out.println("Opção inválida!");

				}
				System.out.println("\nDeseja continuar?(S/N)");
				r = teclado.next();
				if (r.trim().equalsIgnoreCase("N")) {

					op=0;
				}
			}


		}

	}

}