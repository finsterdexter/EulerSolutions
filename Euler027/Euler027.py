import primes

def binomial (n, a, b):
    return n**2 + a*n + b

largest_n = [1,0,0]

# some_primes = primes.atkin_sieve(1001)

for b in range(-1000, 1000):
    # if b is not prime, there's no point in going further with this value of b
    if not primes.fermat_check(b):
        continue

    print b
    
    for a in range(-1000, 1000):
        if not primes.fermat_check(binomial(1, a, b)):
            continue
        if not primes.trial_division(binomial(1, a, b)):
            continue
        n = 1
        while primes.trial_division(binomial(n, a, b)):
            if n > largest_n[0]:
                largest_n = [n, a, b]
            n += 1

        # print "n^2 + %d * n + %d : %d" % (a, b, n)

print "n^2 + %d * n + %d gives %d consecutive primes!" % (largest_n[0], largest_n[1], largest_n[2])

raw_input()