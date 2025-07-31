import cv2


cap =  cv2.VideoCapture(0)
cap.set(3, 1200)
cap.set(4, 720)

while True:
    sucess, img = cap.read()
    cv2.imshow("Image", img)
    cv2.waitKey(1)


