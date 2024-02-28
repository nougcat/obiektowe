## indeks: 347818
## Patryk Nogaś


def dodaj(tab, indeks, val):
    if tab == None:
        tab = [[]]
    while tab[0][0] < indeks:
        index = tab[0][0]
        tab = [[index-1, 0]] + tab
    

    if tab[0][0] < 0: 
        ix =-tab[0][0]
    else: 
        ix = tab[0][0]
    current_max = tab[-1][0]
    while tab[current_max][0] > indeks:
        index = tab[0][0]
        tab = [[index-1, 0]] + tab
    print(ix + indeks)

def show(tab):
    for x in tab:
        print(x[1], end=' ')


def indeks(tab, index):
    if tab[0][0] < 0: 
        ix =-tab[0][0]
    else: 
        ix = tab[0][0]
    try: print(tab[ix+index])
    except IndexError: print("nie ma takiego indeksu")
    


tab = [[-3,-6],[-2,-5],[-1,-1],[0,0], [1,1], [2,2], [3,3]]

indeks(tab, int(input()))