from datetime import datetime

import cv2

data_e_hora_atuais = datetime.now()
data_e_hora_em_texto = data_e_hora_atuais.strftime("data%d%m%Y_hora%H%M")

captura = cv2.VideoCapture(0)
file = "./images/imagem_" + data_e_hora_em_texto + ".png"
         
print ("Digite <ESC> para sair / <s> para Salvar")

while(1):
    ret, frame = captura.read()
    cv2.imshow("Video", frame)
   
    k = cv2.waitKey(30)
    if k == 27:
        break
    elif k == ord('s'):
        cv2.imwrite(file,frame)
        break
    
captura.release()
cv2.destroyAllWindows()
