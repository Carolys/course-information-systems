aprovado = int(input("Insira o valor limite para aprovado: "))
recuperacao = int(input("Insira o valor limite para recuperação: "))
reprovado = int(input("Insira o valor limite para reprovado: "))
nota1 = int(input("Insira sua primeira nota: "))
nota2 = int(input("Insira sua segunda nota: "))
nota3 = int(input("Insira sua terceira nota: "))
nota4 = int(input("Insira sua quarta nota: "))
mediaaluno = (nota1 + nota2 + nota3 + nota4) / 4

if(mediaaluno < reprovado):
    print("Reprovado!")
elif(mediaaluno < recuperacao):
    print("Recuperação!")
else:
    print("Aprovado!")
