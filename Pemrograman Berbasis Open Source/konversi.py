# Soal 3
def celtofah(c):
    result = ((9 / 5) * c) + 32
    return result

def celtokel(c):
    result = c + 273
    return result

def celtorea(c):
    result = ((4 / 5) * c)
    return result

def fahtocel(f):
    result = (5 / 9) * (f - 32)
    return result

def fahtokel(f):
    result = (5 / 9) * (f - 32) + 273
    return result

def fahtorea(f):
    result = (4 / 9) * (f - 32)
    return result

def keltocel(k):
    result = k - 273
    return result

def keltofah(k):
    result = ((9 / 5) * (k - 273)) + 32
    return result

def keltorea(k):
    result = (4 / 5) * (k - 273)
    return result

def reatocel(r):
    result = (5 / 4) * r
    return result

def reatofah(r):
    result = ((9 / 4) * r) + 32
    return result

def reatokel(r):
    result = ((5 / 4) * r) + 273
    return result