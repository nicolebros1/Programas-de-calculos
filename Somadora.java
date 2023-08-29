package Soma;

import java.util.Scanner;

public class somar {

	public int som (int nu1, int nu2) {
		return (nu1 + nu2);
	}

public static void main (String args []) {
	somar c = new somar ();
	int nu1;
	int nu2;
			Scanner input = new Scanner (System.in);
	System.out.println ("Digite o primeiro numero:");
	nu1 = input.nextInt ();
	System.out.println ("digite o segundo numero:");
	nu2 = input.nextInt ();
	
	int somatoria = c.som (nu1, nu2);
	System.out.println (somatoria);


}
}
