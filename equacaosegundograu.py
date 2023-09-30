print('vamos fazer uma equação de segundo grau')
a = int(input('digite o valor de a: '))
b = int(input('digite o valor de b: '))
c = int(input('digite o valor de c: '))

d = b**2-4*a*c
x1 = (-b+d**(1/2))/2*a
x2 = (-b-d**(1/2))/2*a

print('O delta é {}, x1 é igual a {} e x2 é igual a {}!'.format(d,x1,x2))