# Algorithms

# 💻 C# Computer Science & Advanced Algorithms Laboratory

An academic repository dedicated to low-level computer architecture, automata theory, dynamic programming, and advanced data structures implemented in C#.

---

## 🚀 Core Modules & Covered Algorithms

### 1. Bitwise Manipulation & Architecture
*   Low-level bit masking (`&`, `|`, `~`) and shifting (`<<`, `>>`) for memory optimization.
*   Mathematical multiplication and division simulation using bitwise operations.
*   Sign-bit and 2's complement arithmetic analysis via `sbyte` and `byte` data conversions.
*   Fast custom Binary-to-Decimal and Decimal-to-Binary converters.

### 2. Recursion & Time Complexity
*   Designing deeply recursive algorithms and managing call-stack states.
*   String-to-integer ASCII transformation algorithms based on mathematical offsets.
*   Comparative analysis of Iterative vs. Recursive Fibonacci design and its $O(2^n)$ Time Complexity bottlenecks.

### 3. Combinatorics & Complexity Theory (NP-Hard)
*   Solving the **Subset Sum Problem** using dynamic bit-masks.
*   Designing flexible binary counters utilizing **Carry-Flag** logic to avoid nested loops.
*   Theoretical exploration of **NP-Hard** problems and applying **Backtracking** to prune unviable solution spaces.

### 4. Dynamic Programming
*   **LCS (Longest Common Subsequence):** Matrix-based memoization solver for gap-tolerant string alignment with $O(n \times m)$ complexity.
*   **Longest Common Substring:** Continuous sequence matching algorithm utilizing dynamic state arrays.

### 5. Automata Theory & State Machines
*   Designing **DFA (Deterministic Finite Automata)** transition matrices for string matching and stream verification.
*   Dead-state tracking logic for strict pattern validation.
*   **Binary Modulo-5 Automaton:** A 5-state dynamic DFA machine recalculating binary stream remainders on-the-fly using the $(State \times 2 + Bit) \pmod 5$ transition formula.

### 6. Data Compression & Trees
*   Full implementation of **Lossless Huffman Coding** algorithm from scratch.
*   Custom Binary Tree structural management using a dedicated nested `btree` class.
*   Dynamic array management using custom Lambda comparers (`Array.Sort`) to handle merged `null` nodes.
*   Recursive depth-first traversal for generating variable-length prefix codes (`0` for left, `1` for right).

---

## 📁 Repository Structure

```text
├── Ders_29_03_Bitwise_Basics/      # Bitwise operators & mask foundations
├── Ders_05_04_Bitwise_Recursive/  # Recursive bitwise applications
├── Ders_06_03_Fibonacci_BigO/     # Time Complexity & Fibonacci
├── Ders_12_04_Subset_Sum/         # Combinatorics & Power Set
├── Ders_20_04_Carry_Substring/    # Carry flag logic & Substring LCS
├── Ders_10_05_LCS_DFA_Intro/      # Subsequence LCS & First DFA
├── Ders_17_05_DFA_Mod5_Theory/    # Modulo-5 state machine & Huffman theory
└── Ders_31_05_Huffman_Tree_Code/  # Binary Tree Huffman encoder application



TR

# 💻 C# Bilgisayar Bilimleri ve İleri Algoritmalar Laboratuvarı

C# dilinde geliştirilmiş; alt seviye bilgisayar mimarisi, otomata teorisi, dinamik programlama ve ileri düzey veri yapılarını barındıran akademik bir kod havuzudur.

---

## 🚀 Ana Modüller ve İşlenen Algoritmalar

### 1. Bitsel İşlemler ve Mimari
*   Bellek optimizasyonu için alt seviye bit maskeleme (`&`, `|`, `~`) ve bit kaydırma (`<<`, `>>`) işlemleri.
*   Bitsel operatörler kullanılarak matematiksel çarpma ve bölme simülasyonları.
*   `sbyte` ve `byte` veri dönüşümleri üzerinden işaret biti (sign-bit) ve 2'ye tümleyen (2's complement) aritmetiği analizleri.
*   Özel olarak tasarlanmış hızlı İkilik-Onluk (Binary-to-Decimal) ve Onluk-İkilik dönüşüm araçları.

### 2. Özyineleme (Recursion) ve Zaman Karmaşıklığı
*   İleri düzey özyinelemeli (recursive) algoritma tasarımı ve çağrı yığını (call-stack) durumlarının yönetimi.
*   Matematiksel indeks farklarına dayalı, metinden tamsayıya (string-to-integer) ASCII dönüşüm algoritmaları.
*   Döngüsel (Iterative) ve Özyinelemeli (Recursive) Fibonacci tasarımlarının karşılaştırmalı analizi ve $O(2^n)$ Zaman Karmaşıklığı darboğazları.

### 3. Kombinasyon ve Karmaşıklık Teorisi (NP-Hard)
*   Dinamik bit maskeleri kullanarak **Alt Küme Toplamı Probleminin (Subset Sum Problem)** çözümü.
*   İç içe döngülerden kaçınmak için **Elde (Carry-Flag)** mantığını kullanan esnek ikilik sayaç tasarımları.
*   **NP-Hard** problemlerin teorik olarak incelenmesi ve çözümsüz alanları budamak için **Backtracking (Geriye Doğru İzleme)** algoritmasının uygulanması.

### 4. Dinamik Programlama
*   **LCS (Longest Common Subsequence - En Uzun Ortak Alt Dizi):** Boşluklu/kopuk metin eşleşmeleri için $O(n \times m)$ karmaşıklığa sahip, matris tabanlı hafızalama (memoization) çözücü.
*   **En Uzun Ortak Alt Metin (Longest Common Substring):** Dinamik durum dizileri kullanan kesintisiz karakter dizisi eşleştirme algoritması.

### 5. Otomata Teorisi ve Durum Makineleri
*   Metin eşleme ve veri akışı doğrulaması için **DFA (Deterministic Finite Automata)** geçiş matrislerinin tasarlanması.
*   Sıkı kural denetimi ve kalıp doğrulama için ölü durum (`Dead-State`) takip mantığı.
*   **Binary Modulo-5 Otomatı:** $(Durum \times 2 + Bit) \pmod 5$ geçiş formülünü kullanarak anlık gelen binary veri akışının 5'e bölümünden kalanını dinamik olarak hesaplayan 5 durumlu DFA makinesi.

### 6. Veri Sıkıştırma ve Ağaç Yapıları
*   **Kayıpsız Huffman Kodlaması (Lossless Huffman Coding)** algoritmasının sıfırdan tam teşekküllü uygulanması.
*   Özel olarak oluşturulmuş bağımsız bir `btree` sınıfı ile İkili Ağaç (Binary Tree) yapısal yönetimi.
*   Birleşen ve `null` durumuna düşen düğümleri yönetmek için özel Lambda karşılaştırıcıları (`Array.Sort`) ile dinamik dizi yönetimi.
*   Değişken uzunluklu önek kodları üretmek için derinlemesine özyinelemeli ağaç tarama mekanizması (sola `0`, sağa `1`).

---

## 📁 Havuz Yapısı

```text
├── Ders_29_03_Bitwise_Basics/      # Bitsel operatörler ve maskeleme temelleri
├── Ders_05_04_Bitwise_Recursive/  # Özyinelemeli bitsel uygulamalar
├── Ders_06_03_Fibonacci_BigO/     # Zaman Karmaşıklığı ve Fibonacci serisi
├── Ders_12_04_Subset_Sum/         # Kombinasyonlar ve Alt Kümeler (Power Set)
├── Ders_20_04_Carry_Substring/    # Elde mantığı ve Kesintisiz LCS (Substring)
├── Ders_10_05_LCS_DFA_Intro/      # Ortak Alt Dizi (Subsequence) ve DFA'e Giriş
├── Ders_17_05_DFA_Mod5_Theory/    # Modulo-5 durum makinesi ve Huffman teorisi
└── Ders_31_05_Huffman_Tree_Code/  # İkili Ağaç ile Huffman kodlayıcı uygulaması
