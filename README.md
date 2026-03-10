# Casino 21 – Blackjack Game

A **Blackjack (21) casino game** built in **C# using Windows Forms**
The project implements the core Blackjack mechanics, player management, betting system, and card logic using classic data structures such as **Stack** and **List**

---

# Features

## Gameplay
- Complete **Blackjack game logic**
- Player vs Dealer
- Card distribution and score calculation
- Bust and win detection
- Tie handling with bet refund

## Betting System
- Casino chips: **1, 5, 10, 25, 50, 100**
- Balance management
- Bet validation (cannot bet more than available balance)
- Automatic payout system

## Player System
- Register or login with:
  - Username
  - Password
- Player balance stored in **JSON file**

## Deposit System
- Top-up interface to add funds
- Card input simulation
- Balance update saved to JSON

## User Experience
- Animated cards
- Casino background music
- Visual feedback for win / lose
- Firework animation when the player wins

---

# Architecture

The project follows a **layered structure**:

```
Casino_21
│
├── UI
│   ├── FormStart
│   ├── FormRegister
│   ├── FormPlay
│   └── FormTopUp
│
├── Business
│   ├── Card
│   ├── Deck
│   └── Joueur
│
└── Data
    └── GestionJoueurs (JSON management)
```

- **UI Layer** → Handles all Windows Forms interfaces  
- **Business Layer** → Game logic and card management  
- **Data Layer** → Player storage and JSON handling

---

# Blackjack Rules

**Goal:**  
Get a hand **closer to 21 than the dealer without exceeding it**

## Card Values

| Card | Value |
|-----|------|
| 2–10 | Face value |
| Jack / Queen / King | 10 |
| Ace | 11 or 1 |

If the score exceeds **21**, the Ace automatically becomes **1**

---

# Game Flow

1. Player launches the game from **FormStart**
2. Player registers or logs in
3. Player deposits funds using **Top Up**
4. Player selects chips to place a bet
5. Dealer and player receive **2 cards**
6. Player chooses:
   - **Hit** → draw another card
   - **Stand** → keep current hand
7. Dealer draws until reaching **17 or more**
8. Scores are compared

## Results

| Result | Outcome |
|------|------|
| Player wins | Bet × 2 |
| Tie | Bet refunded |
| Player loses | Bet lost |

---

# Data Structures

## Stack – Deck

The deck is implemented using:

```
Stack<Card>
```

Cards are drawn using:

```
Pop()
```

This simulates the behavior of a real card deck

---

## List – Player and Dealer Hands

Hands are stored using:

```
List<Card>
```

This allows cards to be dynamically added when the player chooses **Hit**

---

# Shuffle Algorithm

The deck uses the **Fisher–Yates Shuffle algorithm** to ensure fair and random card distribution

---

# Score Calculation Example

Example hand:

```
♠ Ace
♥ 9
♣ 5
```

Initial calculation:

```
11 + 9 + 5 = 25
```

Since the score exceeds **21**, Ace becomes **1**:

```
1 + 9 + 5 = 15
```

---

# Data Storage

Player data is stored in a **JSON file**

Stored information:

- Username
- Password
- Balance

Data is automatically updated after each round

---

# Main Interfaces

## Start Menu
Main entry screen with a **Play button** leading to the login/register page

## Register / Login
Allows players to create an account or log in
User data is stored in JSON

## Game Screen (FormPlay)

Main gameplay interface including:

- Player name
- Balance display
- Betting chips
- Card display
- Hit / Stand / Deal buttons

## Top Up
Allows players to deposit funds

Features:
- Card input simulation
- Amount selection
- Balance update
