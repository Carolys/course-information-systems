package edu.up.bsi.conv.fib.soap.server;

import java.util.ArrayList;
import java.util.List;

import javax.jws.WebService;

@WebService
public class Fibonacci {

	public int soma(int a, int b) {
		int result = a + b;
		System.out.println("Resultado de " + a + "+" + b + "é igual a " + result);
		return result;
	}

	public List<Integer> fibonacci(int a, int b) {

		List<Integer> listafib = new ArrayList<>();
		List<Integer> lista = new ArrayList<>();

		int n1 = 0, n2 = 1, n3 = 0;
		int m1 = 0, m2 = 1, m3 = 0;
		int v[] = new int[3];
		v[0] = 0;
		v[1] = 1;
		
		if(a ==0 && b==0){
			return listafib;
		}
		else if (a == 0 && b == 1) {
			listafib.add(n1);
			return listafib;
			
		} else if (a == 0 && b == 1) {
			listafib.add(1);
			return listafib;

		} else if (a < 2 && a >= 0 && b < 3) {
			listafib.add(n1);
			listafib.add(n2);
			return listafib;

		} else if (a == 0 && b == 3) {
			listafib.add(n1);
			listafib.add(n2);
			listafib.add(1);
			return listafib;

		} else if (a >= 0 && b > 0) {

			int valor = 0;
			while (a > valor && a > m3) {

				m3 = m1 + m2;
				if (a > m3) {
					n3 = n1 + n2;
					valor = n3;
					v[0] = n1;
					v[1] = n2;
					v[2] = n3;

					n1 = n2;
					n2 = n3;
					m1 = m2;
					m2 = m3;
					System.out.println(m3);
				}

			}

			if (a == 0 && b > 0) {
				listafib.add(0);
				listafib.add(1);
				b = b - 2;
			}
			for (int i = 0; i < b; i++) {
				n3 = n1 + n2;
				listafib.add(n3);
				// System.out.print(" "+n3);
				n1 = n2;
				n2 = n3;
			}

			return listafib;
		}
		return listafib;
	}

	public List<Integer> fibonacci2(int a, int b) {
		List<Integer> listafib = new ArrayList<>();
		List<Integer> lista = new ArrayList<>();

		int n1 = 0, n2 = 1, n3 = 0;
		listafib.add(n1);
		listafib.add(n2);

		for (int i = 2; i < b; i++) {
			n3 = n1 + n2;
			listafib.add(n3);
			System.out.print(" " + n3);
			n1 = n2;
			n2 = n3;
		}
		return listafib;
	}

}
