## indeks: 347818
## Patryk Nogaś


def dodaj(tab, indeks, val):
    if tab == None or tab == [] or tab == [[]]:
        tab = [[indeks, val]]
        return tab
    while tab[0][0] > indeks:
        index = tab[0][0]
        tab = [[index-1, 0]] + tab
    
    if tab[0][0] < 0: 
        ix =-tab[0][0]
    else: 
        ix = tab[0][0]
    
    current_max = tab[-1][0]
    if current_max < 0: current_max=0
    
    while tab[current_max+ix][0] < indeks+ix:
        index = tab[0][0]
        tab = tab + [[current_max+ix+1, 0]]
        current_max += 1

    tab[indeks+ix][1] = val
    return tab

def show(tab):
    for x in tab:
        print(x[1], end=' ')
    print("\n")


def indeks(tab, index):
    if tab[0][0] < 0: 
        ix =-tab[0][0]
    else: 
        ix = tab[0][0]

    if tab[0][0] > index: 
        print("nie ma takiego indeksu")
    elif tab[-1][0] < index: 
        print("nie ma takiego indeksu")
    else:
        print(tab[ix+index])
    
    


tab = [[-3,-6],[-2,-5],[-1,-1],[0,0], [1,1], [2,2], [3,3]]

tab = dodaj(tab, 6, 6)

show(tab)