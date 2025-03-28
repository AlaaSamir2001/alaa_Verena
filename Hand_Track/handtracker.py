import cv2
import mediapipe as mp


capTURE = cv2.VideoCapture(0)
mpHands = mp.solutions.hands
hands = mpHands.Hands()
mpDraw = mp.solutions.drawing_utils
tipIds = [4, 8, 12 , 16 , 20]

while True :
    success, img = capTURE.read()
    img = cv2.flip(img, 1)
    imgRGB = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)

    results = hands.process(imgRGB)
    lmList = []
    if results.multi_hand_landmarks:
        for handlms in results.multi_hand_landmarks:
         for id, lm in enumerate (handlms.landmark):
          h,w,c = img.shape
          cx, cy = int(lm.x * w), int(lm.y * h)
          lmList.append([id, cx , cy])
          print(lmList)
          mpDraw.draw_landmarks(img, handlms, mpHands.HAND_CONNECTIONS)
          if id == 8:
               cv2.circle(img, (cx, cy), 20, (0, 0, 255), cv2.FILLED)

          if len(lmList) == 21:
               fingers = []
               if lmList[tipIds[0]][1] < lmList[tipIds[0] - 2][1]:
                  fingers.append(1)
               else:
                  fingers.append(0)

               for tip in range(1, 5):
                  if lmList[tipIds[tip]][2] < lmList[tipIds[tip] - 2][2]:
                     fingers.append(1)
                  else:
                     fingers.append(0)

               totalFingers = fingers.count(1)
               print(totalFingers)
               cv2.putText(img, f'{totalFingers}', (40, 80), cv2.FONT_HERSHEY_SIMPLEX,
               3, (0, 0, 255), 6)


              

        print("Hand Detect")

    cv2.imshow('HandTracker', img)
    if cv2.waitKey(5) & 0xff == 27:
        break