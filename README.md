# TowerDefenseTemplate
Dit is een template wat door jullie te gebruiken is voor het juist inleveren van alle producten voor de Towerdefense beroepsopdracht. **Verwijder uiteindelijk de template teksten!**

Mijn tower defense-game is een eenvoudige top-down strategiegame waarin spelers geld gebruiken om troepen in te huren en verschillende torens te bouwen om eindeloze golven van vijanden te stoppen voordat ze de kern van hun basis kunnen bereiken. Spelers moeten hun middelen verstandig beheren en strategisch nadenken om te overleven in dit spannende spel. De game biedt zowel uitdaging als plezier voor alle soorten spelers.

<div style="display:flex;">
    <img alt="thumbnail of my game" style="width:50%;" src="readmeVisuals/thumbnailgame.png"/>
    <img alt="sprite scheet of main red enemy" src="readmeVisuals/spritesheetenemy.png"/>
</div>

![thumbnail of my game](readmeVisuals/screenschotgame.JPG)



## Product 1: "DRY SRP Scripts op GitHub"

Plaats hier minimaal 1 link naar scripts die voldoen aan de eisen van **"Don't Repeat Yourself (DRY)"** en **"Single Responsibility Principle"**.
Omschrijf hier waarom jij denkt dat je in die scripts aan deze eisen voldoet.



In dit script heb ik een array genaamd targetTags gebruikt om de tags van de objecten te specificeren waartegen ik knockback wil toepassen. Deze aanpak minimaliseert herhaling van code (DRY-principe) omdat ik met een enkele for-each loop door alle doelobjecten kan gaan en knockback kan toepassen. Hierdoor hoef ik niet dezelfde code te herhalen voor elk type vijand, wat de code efficienter en onderhoudbaar maakt.
[link naar script](/towerdefense/Assets/scripts/enemy/Knockback.cs)"*


## Product 2: "Projectmappen op GitHub"

Je commit de mappenstructuur van je unity project op github en verwijst vanuit je readme naar de root map van je project. Met een netjes en goed gestructureerde mappenstructuur en benamingen van files toon je aan dat je dit leerdoel beheerst. 

Dit is de [ROOT](/towerdefense/) folder van mijn unity project.

Zorg dat deze verwijst naar je Develop branch.

## Product 3: Build op Github

Je maakt in Unity een stabiele “build” van je game waarbij bugs en logs eerst zijn verwijderd. Deze buildfiles upload je in je repository onder releases.  Bij eventuele afwijkingen moeten deze worden gedocumenteerd in de release. (Bijv controller nodig of spelen via netwerk etc..) 

[Release Voorbeeld](https://github.com/Jamydewaalmedia/TowerDefenseTemplate/releases)

## Product 4: Game met Sprites(animations) en Textures 

![Textures Sprites](readmeVisuals/towerdefense.gif)

## Product 5: Issues met debug screenshots op GitHub 

Zodra je bugs tegenkomt maak je een issue aan op github. In de issue omschrijf je het probleem en je gaat proberen via breakpoints te achterhalen wat het probleem is. Je maakt screenshot(s) van het debuggen op het moment dat je via de debugger console ziet wat er mis is. Deze screenshots met daarbij uitleg over het probleem en de bijhorende oplossing post je in het bijhorende github issue. 
[Hier de link naar mijn issues](https://github.com/Jamydewaalmedia/TowerDefenseTemplate/issues/)

## Product 6: Game design met onderbouwing 

Je gebruikt een game design tool om je game design vast te leggen en te communiceren. Daarnaast onderbouw je de design keuzes ten aanzien van “playability” en “replayability” voor je game schriftelijk. 

Voorbeeld van een one page design:
![one page](readmeVisuals/onepage.png)

Omschrijf per mechanic welke game design keuzes je hebt gemaakt en waarom je dit hebt gedaan.

*  **Je game bevat torens die kunnen mikken en schieten op een bewegend doel.** 

*mijn torens zijn units die enemies aan vallen wanneer ze in een collide met elkaar ze worden ingespawned met een knop*

*  **Je game bevat vernietigbare vijanden die 1 of meerderen paden kunnen volgen.**  

*ik heb 1 enemie die een to target script heeft waardoor hij loopt naar een aangegeven target*

*  **Je game bevat een “wave” systeem waarmee er onder bepaalde voorwaarden (tijd/vijanden op) nieuwe waves met vijanden het veld in komen.**

*mijn enemies worden gespawned met een interval van 10 seconds maar er zit een delaydevider die de 10 seconde steeds kleiner maakt door tedelen door een megeven getal*

*  **Een “health” systeem waarmee je levens kunt verliezen als vijanden hun doel bereiken en zodoende het spel kunt verliezen.** 

*ik heb een healthbar die damage krijgt als een enemie met mijn base/tower collide heb dit gedaan door een fill van een image aantepassen naar de amount van damage*

*  **Een “resource” systeem waarmee je resources kunt verdienen waarmee je torens kunt kopen en .evt upgraden.**

*ik heb een money system waarmee ik geld krijg als ik een enemie versla en verlies als ik units koop(inhuur)*

*  **een power up systeem**

*ik heb een powerup manager die kijkt of een enmie word verslagen en dan heb je een 0.08% kans dat een power up spawned *



## Product 7: Class Diagram voor volledige codebase (moet nog)

 [![classdiagram depend](readmeVisuals/classdiagramone.png)]
 [![classdiagram depend](readmeVisuals/classdiagramtwo.png)]
 


## Product 8: Prototype test video 
[![example test video](readmeVisuals/screenschotgame.JPG)](https://youtu.be/ZkOkZW0hAkw)

## Product 9: SCRUM planning inschatting 

[Link naar de openbare trello](https://trello.com/b/2ZdgNw5C/towerdefense)

## Product 10: Gitflow conventions

ik heb vaak feature branches gemaakt maar nooit gepushed.
ik ging eigenlijk full time aan een feature werken en niet switchen dus maakte ik de feature gelijk af en finishde hem waardoor hij naar develop werd gemerged.heb het zovaak mogelijk gebruikt.


