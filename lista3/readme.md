<!-- indeks: 347818 -->
<!-- Patryk Nogaś -->

używam mono-complete na linuxie w versji `6.8.0.105+dfsg-3.5`, nie wiem czy działa to na dotnecie na windowsie

## zad 1

mcs -target:library zad11.cs && mcs -r:zad11.dll zad12.cs && mono zad12.exe

## zad 3


mcs -target:library zad31.cs && mcs -r:zad31.dll zad32.cs && mono zad32.exe
