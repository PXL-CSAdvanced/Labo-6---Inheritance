In dit labo ga je een error logging bouwen.

## 1. Basis

Maak een class `Log` aan die zal dienen als base class.
- Variabele (private)
    - Dictionary<DateTime, string> _log
- Methods:
    - Write(string message)<br>Voegt een entry toe aan de Dictionary *_log*
    - DisplayLog()<br>Toont de volledige log (Dictionary)

Maak een class `ActivityLog` aan die overerft van de base class `Log`:
- Override *Write(string message)*<br>Roep de base class functionaliteit op en breidt deze uit zodat de message in de console getoond wordt in de vorm "ACTIVITY [message]".

Maak een class `ErrorLog` aan die overerft van de base class `Log`:
- Override *Write(string message)*<br>Roep de base class functionaliteit op en breidt deze uit zodat de message in de console getoond wordt in de vorm "ERROR [message]".

Test je code door in de console van elke class een instance te maken en telkens de *Write* method op te roepen. Als laatste roep je de *DisplayLog* method op van de `Log` klasse. Wat valt je op? Hoe kan je dit oplossen?

## 2. Fysieke file

Breidt de `Log` class uit met een private variabele `_fileName` van het type string en zorg dat je de filename als een parameter kan doorgeven aan de constructor. Zorg ervoor dat eventuele fouten die hierdoor ontstaan worden opgelost.
> [!TIP] 
> Kijk naar de constructors van de subclasses.

Wijzig de *Write* method zodat de log messages naar een file worden weggeschreven.

Wijzig je code in de console zodat je de nieuwe constructors gebruikt en bekijk de output van de files.

## 3. Uitbreiding

Voor de `ErrorLog` class moet er niet weggeschreven worden naar een file, maar naar een tabel in een database database. Maak hiervoor een nieuwe constructor aan in de `Log` (!) class en zorg ervoor dat deze gebruikt wordt in de `ErrorLog` class. In deze nieuwe constructor geef je een SQLConnection object mee.

Wijzig de *Write* method zodat er naar de file OF naar de DB wordt weggeschreven, afhankelijk van de gebruikte constructor. Waar doe je deze aanpassing?

## 4. Abstract class

Maak van de `Log` class een abstracte klasse. Welk effect heeft dit?
