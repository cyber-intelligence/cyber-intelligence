a = []
while True:
    var = input('=> ')
    if var  == 'finish':
        break
    a.append(int(var))
    

javabs = [(x * (9/5) + 3) for x in a]
print('C list: ' + str(a))
print('F list: ' + str(javabs))