# Zadání: Návrh a implementace aplikace pro výpočet BMI

Vaším úkolem je navrhnout a vytvořit jednoduchou aplikaci v MAUI, která bude sloužit k výpočtu Body Mass Indexu (BMI). Cílem je procvičit si návrh rozvržení uživatelského rozhraní, změnu barevného schématu aplikace a práci s komponentami Grid a StackLayout.

## Co je BMI a proč se počítá?
Body Mass Index (BMI) je ukazatel používaný pro odhad množství tělesného tuku na základě poměru tělesné hmotnosti a výšky. Vzorec pro výpočet BMI je:

BMI = {hmotnost v kg} / {výška v m}^2

BMI se následně hodnotí podle následujících kategorií:

| Kategorie            | BMI (kg/m²)    | Zdravotní rizika                          |
|----------------------|----------------|-------------------------------------------|
| Podváha              | < 18.5         | Zvýšené riziko zdravotních komplikací     |
| Normální váha        | 18.5–24.9      | Nízké riziko                              |
| Nadváha              | 25–29.9        | Zvýšené riziko                           |
| Obezita I. stupně    | 30–34.9        | Vyšší riziko                             |
| Obezita II. stupně   | 35–39.9        | Výrazně zvýšené riziko                   |
| Obezita III. stupně  | ≥ 40           | Vysoké riziko                            |

## Požadavky na aplikaci
1. **Změna primární barvy**: Změňte výchozí primární barvu aplikace na jinou dle vašeho výběru.
2. **Vytvoření layoutu**:
   - Použijte **Grid** pro hlavní rozdělení rozvržení na dvě části (levý sloupec pro vstupy a pravý sloupec pro výsledky).
   - Použijte **StackLayout** pro vnitřní uspořádání komponent v jednotlivých částech, aby byly položky zobrazeny pod sebou.
3. **Implementace funkcionality**:
   - Přidejte vstupní pole pro hmotnost a výšku, tlačítko pro výpočet BMI a výstupní zobrazení hodnoty BMI, popisu a hodnocení.
   - Zobrazte obrázek odpovídající kategorii BMI (např. podváha, normální váha, nadváha, atd.).

## Napověda k layoutu
- Použijte **Grid** s dvěma sloupci pro rozdělení vstupní a výstupní části aplikace.
- V jednotlivých částech použijte **StackLayout** pro srovnání komponent (např. popisky a vstupní pole).

## Screenshoty
Pro inspiraci a lepší pochopení rozvržení můžete využít screenshoty uložené ve složce `/screenshots`:

![01.png](/screenshots/01.png)

![02.png](/screenshots/02.png)

![03.png](/screenshots/03.png)

![04.png](/screenshots/04.png)

![05.png](/screenshots/05.png)

![06.png](/screenshots/06.png)