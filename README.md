# 🧮 Calculadora Pol — WinForms

```
    *          .            *          .            *           .           *          .            *          .        *
        .            *            .          *            .            *          .            *           .

          "Oh my God,                                                        "Screw you guys,
      they killed Kenny!"                "You bastards!"                     I'm going home!"                    "Mmmph mmph!"

              .--.                                                                 (@@)
             (####)                                                              .-'  '-.                                                  _____________
            .-'--'-.                                                          .-'        '-.                                              |             |
         .-'        '-.                  .--------------.                   .'              '.                    .-''''''''-.            |     BUS     |
       .'              '.              .'                '.               /                    \                .'            '.          |    STOP     |
      /                  \            /____________________\             |######################|             .'   .--------.   '.        |  _________  |
      |##################|           |======================|            |======================|            /   .'          '.   \       | |  [===]  | |
      |==================|          |##|                  |##|          /    .------..------.    \          /   /              \   \      | |_________| |
     /  .------..------.  \         |##| .------..------. |##|        |    /        \/        \    |       |   |  .----..----.  |   |     |_____________|
   |  /        \/        \  |      |##|/        \/        \|##|       |    |   ()   ||   ()   |    |       |   |  |    ||    |  |   |           | |
   |  |    ()  ||  ()    |  |      |##||   ()   ||   ()   ||##|       |    \        /\        /    |       |   |  | () || () |  |   |           | |
   |  \        /\        /  |      |##|\        /\        /|##|       |     '------'  '------'     |       |   |  '----''----'  |   |           | |
   |   '------'  '------'   |      |##| '------'  '------' |##|       |                            |       |    \              /    |           | |
   \                        /     '--'|                    |'--'       \         .------.         /         \    '.__________.'    /            | |
    \      \________/      /         \       \______/       /           \        '------'        /           \       \    /       /             | |
     '.                  .'           '.                  .'            '.     '----------'     .'            '.      \  /      .'              | |
       '-.____________.-'               '-.____________.-'               '-.__________________.-'               '-.___ )( ___.-'                | |
       .-'|    ||    |'-.               .-'|    ||    |'-.               .--'|      ||      |'--.              .-'|    ||    |'-.               | |
      /   |    ||    |   \             /   |    ||    |   \            /     |      ||      |     \           /   |    ||    |   \              | |
    / /|  |    ||    |  |\ \         / /|  |    ||    |  |\ \         /  /|  |      ||      |  |\  \        / /|  |    ||    |  |\ \            | |
   (_/ |  |    ||    |  | \_)       (_/ |  |    ||    |  | \_)       (__/ |  |      ||      |  | \__)      (_/ |  |    ||    |  | \_)           | |
  (MM) |  |    ||    |  | (MM)     (MM) |  |    ||    |  | (MM)      (MM) |  |      ||      |  | (MM)     (MM) |  |    ||    |  | (MM)          | |
       |__|____||____|__|               |__|____||____|__|                |__|______||______|__|               |__|____||____|__|               | |
        |      ||      |                 |      ||      |                  |        ||        |                 |      ||      |                | |
        |      ||      |                 |      ||      |                  |        ||        |                 |      ||      |                | |
        |______||______|                 |______||______|                  |________||________|                 |______||______|                | |
       (_______)(_______)               (_______)(_______)                (_________)(_________)               (_______)(_______)             __| |__
========================================================================================================================================================
            S T A N                          K Y L E                          C A R T M A N                        K E N N Y
```

Práctica de **M07 – Desenvolupament d'interfícies** (MONLAU, 2DAM).
Aplicación de escritorio en **C# / Windows Forms (.NET 10)** con dos pestañas: una calculadora clásica y una calculadora de IVA con descuentos.

---

## ✨ Funcionalidades

### Pestaña *Calculadora*
- Suma, resta, multiplicación y división
- Potencia (`xʸ`) y raíz cuadrada (`√`)
- Números decimales con coma
- Operaciones encadenadas (`2 + 3 + 4 =`)
- Control de errores: división entre cero y raíz de números negativos

### Pestaña *IVA*
- Precio unitario y cantidad
- Tipo de IVA: **0 %, 4 %, 10 %, 21 %**
- Descuento: **0 %, 5 %, 10 %, 20 %**
- Opción **Partner**: aplica un **30 %** fijo y desactiva el descuento
- Primero se aplica el descuento y después el IVA
- Resultados en euros con dos decimales (`93,60 €`)
- Validación de entradas vacías, no numéricas, negativas o con cantidad menor que 1

---

## 🗂️ Estructura

```
CalculadoraConInterfazPol/
├── Calculadora.cs        → operaciones básicas (sumar, restar, potencia, raíz...)
├── CalculadoraIVA.cs     → cálculo de cuota de IVA y total
├── Form1.cs              → lógica de los botones (eventos)
├── Form1.Designer.cs     → diseño de la interfaz
└── Program.cs            → punto de entrada
```

---

## ▶️ Cómo ejecutarlo

1. Clona el repositorio:
   ```
   git clone https://github.com/polcanros/CalculadoraConInterfazIVAPol.git
   ```
2. Abre `CalculadoraConInterfazPol.slnx` con **Visual Studio 2022** o superior.
3. Pulsa **F5**.

> Requiere el workload *Desarrollo de escritorio con .NET* y .NET 10.

---

## 🧪 Prueba rápida (IVA)

| Precio | Cantidad | IVA | Descuento | Partner | Sin IVA | Con IVA |
|---|---|---|---|---|---|---|
| 25 | 4 | 4 % | 10 % | No | 90,00 € | 93,60 € |
| 25 | 4 | 21 % | 0 % | No | 100,00 € | 121,00 € |
| 25 | 4 | 21 % | — | Sí | 70,00 € | 84,70 € |

---

👤 **Autor:** Pol — [@polcanros](https://github.com/polcanros)
