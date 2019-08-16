c = int(input('max numb: '))
a , b = 0 , 1
fibo = [0,1]
while True:
    a , b = b , a+b
    if b > c:
        break
    fibo.append(b)
print(fibo)