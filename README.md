# oirposproject

Gra zręcznościowa wykonana w środowisku Unity
1. Opis projektu
 Aplikacja jest grą, w której celem jest manipulacja mapą w taki sposób, by doprowadzić metalową kulkę do mety.
Gracz kontroluje mapę zmieniając jej kąty przechylenia.
2. Pliki aplikacji
Materiały:
• Ball material – definiuje zewnętrzny wygląd kulki.
• Ball physics material – definiuje właściwości fizyczne kulki (tarcie w stanie spoczynku i podczas ruchu oraz
sprężystość)
• Finishline material - definiuje zewnętrzny wygląd mety.
• Ground material - definiuje zewnętrzny wygląd powierzchni mapy
Skrypty:
• BallControls – Klasa kontrolująca ruch kulki po mapie
◦ metoda FixedUpdate() - uaktualnia położenie kulki ze stałą częstotliwością równą liczbie klatek na
sekundę
• BallRespawn – Klasa przywracająca początkowe położenie kulki i początkowe przechylenie mapy w razie
przekroczenia przez kulkę granic mapy
◦ metoda OnCollisionEnter() - powiadamia o kolizji kulki z granicami mapy
• HelpMenu – Klasa wyświetlająca menu pomocy podczas rozgrywki
◦ ShowHelpMenu() - wyświetla menu pomocy
◦ CloseHelpMenu() - ukrywa menu pomocy
• MainCamera – Klasa kontrolująca ruch kamery. Gracz może obracać kamerą w pionie i poziomie
• Mainmenubuttons – Klasa obsługuje przyciski w menu głównym
• PauseMenu – Klasa wyświetlająca menu pauzy podczas rozgrywki
• PlayerControls – Klasa odpowiedzialna za sterowanie i przechylenie mapy
• Timer – Uaktualnia czas i liczbę prób ukończenia poziomu oraz wyświetla je w formie tekstowej.
◦ metoda FinishLineReached() - definiuje czynności wykonywane w momencie ukończenia poziomu
• WinCondition – wykrywa moment pomyślnego ukończenia poziomu i informuje o tym gracza.
Sceny:
• Main menu – główne menu
• Level1 – pierwszy poziom
• Level2 - drugi poziom
Wymagania sprzętowe:
• Windows 8 lub nowszy
• 60Mb przestrzeni dyskowej
• Unity 2018.3.7f1 lub nowszy
Sterowanie:
• Przechyl mapę w dół: W
• Przechyl mapę w górę: S
• Przechyl mapę w lewo: D
• Przechyl mapę w prawo: A
• Otwórz okno pomocy: F1
• Wstrzymaj rozgrywkę / otwórz menu pauzy: Escape
Import plików do Unity:
1. Stworzyć pusty projekt
2. Usunąć z katalogu „Scenes” plik „Sample scene”
3. Z menu wybrać „Assets” → „Import package”→ „Custom package”
4. Wybrać pakiet z plikami projektu. Po załadowaniu pakietu pojawi się okno z listą plików.
5. Wybrać opcję „Import”
6. Wybrać scenę „Main menu” z katalogu „Scenes” i otworzyć ją
7. Z menu „File” → „Build settings” wybrać opcję „Add open scenes”. Spowoduje to dodanie sceny do projektu
podczas uruchamiania.
8. Powtórzyć krok 6 i 7 dla każdej sceny
9. Projekt jest gotowy do uruchomienia
Budowanie projektu:
1. Stworzyć nowy katalog dla aplikacji w dowolnym miejscu, np. „BuiltProjekt”
2. W menu „File” → „Build and run” wybrać stworzony katalog. Zapisane zostaną w nim pliki skompilowanej
aplikacji.
3. Plik ‘nazwaprojektu.exe’ uruchamia zbudowaną aplikację
