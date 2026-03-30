# APBD-cw1-wypozyczalnia
Repository for the first homework - APBD class

Dla łatwości odnalezienia klas, projekt został podzielony na 4 główne foldery:
- Enums zawierający wszystkie klasy enumeryczne
- Exceprions zawierajacy wszystkie wyjąctki
- Models zawierający wszystkie modele domeny
- Services zawierający serwisy egzekwujące reguły biznesowe

Podjęte decyzje:
- Reguły biznesowe (limity wypożyczeń, sposób naliczania kary) zostały wyodrębnione do osobnych klas lub stałych dla łatwości zmiany w jednym miejscu oraz czytelności.
- Również dla czytelności i łatwości debugowania możliwe nieudane operacje dostały przypisane dedykowane wyjątki.
- Commity zostały podzielone na 4 branche z głównymi elementami projektu dla łatwości przywrócenia zmian poszczególnych elementów bez koniecznosci cofania wszystkich zmian. Też dzięki temu do brancha main trafił już gotowy, działający program
do którego została tylko dodana klasa z prezentacją działania.
