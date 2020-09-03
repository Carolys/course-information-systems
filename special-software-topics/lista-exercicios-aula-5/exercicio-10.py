t1l1 = int(input("Insira o valor do lado 1 do triangulo"))
t1l2 = int(input("Insira o valor do lado 2 do triangulo"))
t1l3 = int(input("Insira o valor do lado 3 do triangulo"))

if(t1l1 == t1l2 && t1l2 == t1l3):
    print("Equilatero")
elif((t1l1 == t1l2 && t1l2 != t1l3) || (t1l2 == t1l3 && t1l1 != t1l2)):
    print("Isosceles")
else:
    print("Escaleno")
