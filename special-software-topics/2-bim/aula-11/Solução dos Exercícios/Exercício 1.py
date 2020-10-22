from datetime import datetime

import cv2
import serial

conexao = serial.Serial('COM3', 9600)

data_e_hora_atuais = datetime.now()
data_e_hora_em_texto = data_e_hora_atuais.strftime("data%d%m%Y_hora%H%M")

captura = cv2.VideoCapture(0)
file = "c:\python\images\imagem_" + data_e_hora_em_texto + ".png"
         
print ("Digite <ESC> para sair / <s> para Salvar")

while(1):
    result = conexao.readline()
    result = result.decode("utf-8")
    result = result[:(len(result)-2)]
    print(result, "\n")
    ret, frame = captura.read()
    cv2.imshow("Video", frame)
   
    k = cv2.waitKey(30)
    if k == 27:
        conexao.write(b'F') # Fim da conexão
        conexao.close()
        break
    elif k == ord('s'):
        cv2.imwrite(file,frame)
        conexao.write(b'F') # Fim da conexão
        conexao.close()
        break
    elif result == "X":
        cv2.imwrite(file,frame)
        conexao.write(b'F') # Fim da conexão
        conexao.close()
        break    
    
captura.release()
cv2.destroyAllWindows()
