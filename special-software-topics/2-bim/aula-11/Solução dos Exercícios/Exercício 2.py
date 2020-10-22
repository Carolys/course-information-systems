from datetime import datetime

import cv2
import serial

conexao = serial.Serial('COM3', 9600)

data_e_hora_atuais = datetime.now()
data_e_hora_em_texto = data_e_hora_atuais.strftime("%d%m%Y_%H%M")

captura = cv2.VideoCapture(0)
         
print ("Digite <ESC> para sair / <s> para Salvar")

i=0

while(1):
    result = conexao.readline()
    result = result.decode("utf-8")
    result = result[:(len(result)-2)]
    print(result, "\n")
    ret, frame = captura.read()
    cv2.imshow("Video", frame)

    valor = "c:\python\images\imagem_%04i_" %i
    file = valor + data_e_hora_em_texto + ".png"
   
    k = cv2.waitKey(30)
    if k == 27:
        conexao.write(b'F') # Fim da conexão
        conexao.close()
        break
    elif k == ord('s'):
        cv2.imwrite(file,frame)
        i+=1
    elif result == "X":
        cv2.imwrite(file,frame)
        i+=1

captura.release()
cv2.destroyAllWindows()
