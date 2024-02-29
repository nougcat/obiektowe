## indeks: 347818
## Patryk Nogaś

def nowy_ulamek(a:int,b:int):
    if b == 0: pass
    elif b<0: b * -1 and a * -1
    return [a,b]


def NWD(a, b):
    if(b == 0):
        return a
    else:
        return NWD(b, a % b)

def uprosczenie(ulamek):
    gcd = NWD(ulamek[0], ulamek[1])
    return [int(ulamek[0]/gcd), int(ulamek[1]/gcd)]

# <operacja_matematyczna>  == zwraca nową strukturę
# <operacja_matematyczna>_dwa == modyfikuje pierwszą strukturę (nie jest upraszczane, ale o ile rozumiem treść zadania nie musi być)

def dodawanie(ulamek1, ulamek2):
    mianownik = ulamek1[1] * ulamek2[1]
    licznik = ulamek1[0]*ulamek2[1] + ulamek2[0]*ulamek1[1]
    ulamek = uprosczenie([licznik, mianownik])

    return ulamek

def dodawanie_dwa(ulamek1, ulamek2):
    ulamek1[0] = ulamek1[0]*ulamek2[1] + ulamek2[0]*ulamek1[1]
    ulamek1[1] = ulamek1[1] * ulamek2[1]
    return ulamek1

    
def odejmowanie(ulamek1, ulamek2):
    mianownik = ulamek1[1] * ulamek2[1]
    licznik = ulamek1[0]*ulamek2[1] - ulamek2[0] * ulamek1[1]
    ulamek = uprosczenie([licznik, mianownik])

    return ulamek

def odejmowanie_dwa(ulamek1, ulamek2):
    ulamek1[0] = ulamek1[0] * ulamek2[1] - ulamek2[0] * ulamek1[1]
    ulamek1[1] = ulamek1[1] * ulamek2[1]
    return ulamek1


def mnozenie(ulamek1, ulamek2):
    mianownik = ulamek1[1] * ulamek2[1]
    licznik = ulamek2[0] * ulamek2[0]
    ulamek = uprosczenie([licznik, mianownik])

    return ulamek

def mnozenie_dwa(ulamek1, ulamek2):
    ulamek1[1] = ulamek1[1] * ulamek2[1]
    ulamek1[0] = ulamek2[0] * ulamek2[0]
    return ulamek1

def dzielenie(ulamek1, ulamek2):
    licznik = ulamek2[0] * ulamek1[1]
    mianownik = ulamek2[1] * ulamek1[0]
    ulamek = uprosczenie([licznik, mianownik])

    return ulamek

def dzielenie_dwa(ulamek1, ulamek2):
    licznik = ulamek2[0] * ulamek1[1]
    mianownik = ulamek2[1] * ulamek1[0]
    ulamek1[0] = licznik
    ulamek1[1] = mianownik
    return ulamek1

def show(ulamek):
    print(f'{ulamek[0]}/{ulamek[1]}')



ulamek1 = nowy_ulamek(3,7)
ulamek2 = nowy_ulamek(1,7)



# tworzenie_nowego_ulamka
new_ulamek=dodawanie(ulamek1, ulamek2)
show(new_ulamek)

new_ulamek=odejmowanie(ulamek1, ulamek2)
show(new_ulamek)

new_ulamek=mnozenie(ulamek1, ulamek2)
show(new_ulamek)

new_ulamek=dzielenie(ulamek1, ulamek2)
show(new_ulamek)

# dzialanie_bezposrednio_na_strukturach (na tyle na ile się da)

ulamek1 = dodawanie_dwa(ulamek1, ulamek2)
show(ulamek1)

ulamek1 = odejmowanie_dwa(ulamek1, ulamek2)
show(ulamek1)

ulamek1 = mnozenie_dwa(ulamek1, ulamek2)
show(ulamek1)

dzielenie_dwa(ulamek1, ulamek2)
show(ulamek1)