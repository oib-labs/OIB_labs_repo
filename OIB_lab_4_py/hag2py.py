# -*- coding: utf-8 -*-
text = "11000000"
#Контрольная сумма
K=0
for i in range (len(text)):
    K+=ord(text[i])
KRes = K%256
print (f"text = {text}, KSumm = {KRes}")    
#Гаммирование
a =31
b = 7
c =256
t0 = 126
t = [t0]
y = []
for i in range (len(text)-1):
    t.append((a*t[i]+b)%c)
for i in range (len(text)-1):
    x = int(text[i])
    x &= 0b1111111
    ti = t[i]
    ti = 0b1111111
    y.append(x^ti)
Gamm = sum(y)%256
print (f"text = {text}, SummKodBukvOtkr = {Gamm}")   