import cv2
import serial

conexao = serial.Serial('COM3', 9600)

arqCasc = 'haarcascade_frontalface_default.xml'
faceCascade = cv2.CascadeClassifier(arqCasc)

webcam = cv2.VideoCapture(0)  #instancia o uso da webcam

while True:
    s, imagem = webcam.read() #pega efetivamente a imagem da webcam
    imagem = cv2.flip(imagem,180) #espelha a imagem

    faces = faceCascade.detectMultiScale(
        imagem,
        minNeighbors=5,
        minSize=(30, 30),
	maxSize=(200,200)
    )

    print("Found {0} faces!".format(len(faces)))
    if (len(faces) == 0):
        # Escreve Z no arduino
        conexao.write(b'Z')

    # Desenha um retângulo nas faces detectadas
    for (x, y, w, h) in faces:
        cv2.rectangle(imagem, (x, y), (x+w, y+h), (0, 255, 0), 2)
        cx = (x+w)//2
        print (cx)
        if (cx <= 160):
             # Escreve E no arduino
             conexao.write(b'E')
        else:
             # Escreve D no arduino
             conexao.write(b'D')
    

    cv2.imshow('Video', imagem) #mostra a imagem captura na janela

    #o trecho seguinte é apenas para parar o código e fechar a janela
    if cv2.waitKey(1) & 0xFF == ord('q'):
        conexao.write(b'F') # Fim da conexão
        conexao.close()
        break

webcam.release() #dispensa o uso da webcam
cv2.destroyAllWindows() #fecha todas a janelas abertas
