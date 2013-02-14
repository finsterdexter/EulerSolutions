import math

n = math.factorial(100)

nstr = str(n)

o = 0
for c in nstr:
    o += int(c)

print o
raw_input()
