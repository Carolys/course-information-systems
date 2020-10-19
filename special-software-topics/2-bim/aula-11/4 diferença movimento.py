import cv2

##def calculaDiferenca(img1, img2, img3):
##  d1 = cv2.absdiff(img3, img2)
##  d2 = cv2.absdiff(img2, img1)
##  return cv2.bitwise_and(d1, d2)

def calculaDiferenca(img1, img2, img3):
  d1 = cv2.absdiff(img3, img2)
  d2 = cv2.absdiff(img2, img1)
  imagem = cv2.bitwise_and(d1, d2)
  s,imagem = cv2.threshold(imagem, 35, 255, cv2.THRESH_BINARY)
  return imagem

captura = cv2.VideoCapture(0)

#faz a leitura inicial de imagens
ultima        = cv2.cvtColor(captura.read()[1], cv2.COLOR_RGB2GRAY)
penultima     = ultima
antepenultima = ultima

while(1):
  antepenultima = penultima
  penultima     = ultima
  ultima        = cv2.cvtColor(captura.read()[1], cv2.COLOR_RGB2GRAY)

  cv2.imshow("video", calculaDiferenca(antepenultima,penultima,ultima))
  
  k = cv2.waitKey(30) 
  if k == 27:
      break

captura.release()
cv2.destroyAllWindows()
