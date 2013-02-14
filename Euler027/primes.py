from random import random
import math
import numpy

def fermat_check (n, iterations = 10):
    if n == 0:
        return False

    p = int(math.fabs(n))
    a = 0
    for i in range(iterations):
        a = int(math.floor(random() * p))
        if a**(p-1) % p != 1:
            return False
    return True

def trial_division(n):
    """Return a list of the prime factors for a natural number."""
    n = math.fabs(n)
    if n == 1: return [1]
    primes = atkin_sieve(int(n**0.5) + 1)
    prime_factors = []
 
    for p in primes:
        if p*p > n: break
        while n % p == 0:
            prime_factors.append(p)
            n //= p
    if n > 1: prime_factors.append(n)
 
    if len(prime_factors) > 1:
        return False
    else:
        return True

def atkin_sieve(limit):
    results = [2, 3]
    is_prime = []
    for i in range(limit + 1):
        is_prime.append(False)

    for x in range(int(math.floor(math.sqrt(limit)))):
        for y in range(int(math.floor(math.sqrt(limit)))):
            
            n = 4 * x**2 + y**2
            if n <= limit and (n % 12 == 1 or n % 12 == 5):
                is_prime[n] ^= True

            n = 3 * x**2 + y**2
            if n <= limit and n % 12 == 7:
                is_prime[n] ^= True

            n = 3 * x**2 - y**2
            if n <= limit and n % 12 == 11:
                is_prime[n] ^= True

    for n in range(5, int(math.floor(math.sqrt(limit)))):
        if is_prime[n]:
            for k in range(n*n, int(math.floor(math.sqrt(limit))), n*n):
                is_prime[k] = False

    for n in range(5, limit):
        if is_prime[n]:
            results.append(n)

    return results