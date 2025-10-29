Also found on Brightspace


*Work on this in ones or twos.*

Download the given C# solution (https://github.com/hkirk/vector-escape-room-code). This solution is structured in the following way

```
VectorCalculator/
  VectorCalculator.sln
  VectorCalculatorLib/
    VectorCalculatorLib.csproj
    Vector.cs
  VectorCalculatorTests/
    VectorCalculatorTests.csproj
    VectorAddTests.cs
    VectorSubtractTests.cs
    ...
```

*The old university server room was abandoned years ago after a failed AI experiment. Rumor has it that the ghost of a frustrated programmer still lingers, corrupting vector calculations in the dead of night. Your mission: Write tests to exorcise the bugs from the haunted Vector class before the ghost corrupts the entire system!*

*You’ll start by implementing basic vector operations from scratch—no starter code! Then, you’ll face the ghost’s cursed implementations, where hidden bugs lurk in the shadows. Only your tests can reveal the truth…*


## Part 1 - 🔦 Starter Challenges
Each of the task below unlocks a password, you will need to unlock code for Part 2, you can exchange your passcode to C# code her: https://hkirk.github.io/vector-escape-room/.

The ghost hasn’t touched these yet… but it’s watching. Implement these methods carefully, or it might sabotage your work later!

### 1) The Summoning (Vector Addition)

- Implement Vector.Add(Vector other) and write NUnit tests.
- Requirements:
  - Return a new Vector representing the sum of two vectors.
  - Throw an ArgumentException if the vectors have different lengths ("The ghost hates mismatched vectors!").

### 2) The Vanishing Act (Vector Subtraction)
- Implement Vector.Subtract(Vector other) and write NUnit tests.
- Requirements:
  - Return a new Vector representing the difference of two vectors.
  - Throw an ArgumentException if the vectors have different lengths ("The ghost will erase your work!").

### 3) The Shrinking Spell (Scalar Multiplication)
- Implement Vector.Scale(double scalar) and write NUnit tests.
- Requirements:
   - Return a new Vector where each component is multiplied by the scalar.
   - Handle scaling by zero ("The ghost turns your vector to dust!").

## Part 2 - 👻 Code Provided should be used

*The ghost has cursed these methods! Write tests to expose its tricks and fix the code before it’s too late…*


### 4) The Whispering Magnitude

- Write tests to uncover the ghost’s mistakes and fix the method.
- Passkey Unlock: Revealed only if tests cover:
  - Non-zero vectors ("The ghost muffles the true magnitude!").
  - Zero vector ("The ghost hides in the silence of zero!").

### 5)The Cursed Dot Product

- Write tests to expose the ghost’s sabotage and fix the method.
- Passkey Unlock: Revealed only if tests cover:
  - Non-zero dot product ("The ghost dilutes the truth!").
  - Zero dot product ("The ghost vanishes orthogonal vectors!").

### 6) The Phantom Normalizer

- Write tests to reveal the ghost’s oversight and fix the method.
- Passkey Unlock: Revealed only if tests cover:
  - Normalization of a non-zero vector ("The ghost stretches your vectors!").
  - Zero vector ("The ghost howls at division by zero!").


## Part 3 - 💀 Boss Challenge: The Poltergeist Cross Product

The ghost saved its worst trick for last! This method is so corrupted, it might break your sanity…


- Write tests to uncover the ghost’s final curse and fix the method.
  - Cross product of two 3D vectors ("The ghost twists space itself!").
  - Non-3D vectors ("The ghost cackles at invalid dimensions!").

## 📜 Epilogue: The Exorcism

*If you’ve made it this far, congratulations! You’ve banished the ghost from the Vector class… for now. But beware — it might return next semester. Keep your tests sharp!*