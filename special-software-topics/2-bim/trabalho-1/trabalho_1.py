
import serial
# Configuração da conexão
conexao = serial.Serial('COM3', 9600)
print("__Menu Principal__")
print("[ 0 ] Modo Automatico")
print("[ 1 ] Modo Manual")
print("[ 2 ] Ir para a Esquerda(+5°)")
print("[ 3 ] Ir para a Direita(+5°)")
print("[ 4 ] Ir ao centro(90°)")
print("[ 5 ] Finalizar")
while True:
  opcao = int(input("Opção desejada: "))
  if (opcao == 5):
     break
  elif ((opcao == 0) or (opcao == 1) or (opcao == 2) or (opcao == 3) or (opcao == 4)):
     if (opcao == 0):
         # Modo Automatico
         conexao.write(b'A')
     elif (opcao == 1):
         # Modo Manual
         conexao.write(b'M')
     elif (opcao == 2):
         # Ir para a Esquerda(+5°)
         conexao.write(b'E')
     elif (opcao == 3):
         # Ir para a Direita(+5°)
         conexao.write(b'D')
     else:
         # Ir ao centro(90°)
         conexao.write(b'C')  
result = conexao.readline()
result = result.decode("utf-8")
print("Resultado:", result[:(len(result)-2)], "\n")
conexao.write(b'F') # Fim da conexão
conexao.close()
