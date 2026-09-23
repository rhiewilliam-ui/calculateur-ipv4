# Calculateur d'adressage IPv4

Application de bureau Windows qui calcule toutes les informations d'un réseau IPv4 à partir d'une
adresse IP et de son masque : adresse réseau, broadcast, plage d'hôtes, nombre de machines et classe.

## Le problème

Calculer à la main l'adresse réseau ou le broadcast d'un sous-réseau est long et source d'erreurs,
surtout avec un masque qui ne tombe pas sur un octet entier (un /20, un /27…). L'outil fait le
calcul instantanément et accepte les formats que l'on rencontre en pratique : notation décimale,
binaire ou CIDR.

## Fonctionnalités

- Saisie de l'adresse IP en **décimal** ou en **binaire**, avec conversion automatique dans l'autre format
- Saisie du masque en **notation standard** (255.255.240.0) ou en **CIDR** (/20)
- Calcul de l'**adresse réseau**, de l'**adresse de broadcast**, de la **première** et de la **dernière adresse** utilisables
- Nombre total d'adresses et nombre de machines adressables, avec une jauge visuelle
- Détection de la **classe** (A, B, C, D) et alerte si le CIDR est inhabituel pour cette classe
- Contrôle des saisies : octets limités à 255, champs binaires limités à 0 et 1, masque non contigu refusé

## Technologies

- **Langage** : C#
- **Interface** : Windows Forms (.NET Framework 4.7.2), avec des contrôles personnalisés (panneaux et champs arrondis, jauges circulaires)
- **Outils** : Visual Studio

## Comment ça marche

Le cœur du calcul repose sur des opérations bit à bit, octet par octet :

```csharp
int reseau    = ip & masque;                // ET logique : on garde la partie réseau
int broadcast = reseau | (~masque & 255);  // OU avec l'inverse du masque : tous les bits hôte à 1
```

Le nombre de machines se déduit du nombre de bits à 0 dans le masque : `2^bitsHôte − 2`
(on retire l'adresse réseau et le broadcast).

Un masque est valide seulement si ses bits à 1 sont **contigus** : `255.255.128.0` est valide,
`255.254.255.0` ne l'est pas. L'application vérifie cette règle avant tout calcul.

## Installation

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/rhiewilliam-ui/calculateur-ipv4.git
   ```
2. Ouvrir `Calculateur de Masque Réseau.slnx` avec **Visual Studio**
3. Lancer avec **F5**

**Prérequis :** Windows, Visual Studio avec le développement .NET Desktop, .NET Framework 4.7.2.

## Mon rôle

Projet réalisé en équipe de 6 dans le cadre du BUT Informatique.
J'ai pris en charge les **algorithmes de conversion et de calcul** : passage d'un format à l'autre
(décimal, binaire, CIDR, masque), validation des saisies et calcul des résultats affichés.

---

*SAÉ Réseaux — BUT Informatique, IUT d'Amiens, 2026.*
