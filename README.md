Calculadora – Case Engenharia de Software JR

Projeto em C# que demonstra o uso de fila para organizar operações e pilha para armazenar resultados,
com foco em correção de overflow e fluxo sem loop infinito.

Funcionalidades implementadas:

Processamento completo da fila.
Divisão com tratamento de erro.
Precisão e segurança numérica.
Impressão dinâmica da fila.
Pilha de resultados.

Saída real do programa:

```
Operações que serão realizadas:
14 - 8
5 * 6
2147483647 + 2
18 / 3

Operação atual:
14 - 8 = 6

Operações restantes na fila:
5 * 6
2147483647 + 2
18 / 3

Operação atual:
5 * 6 = 30

Operações restantes na fila:
2147483647 + 2
18 / 3

Operação atual:
2147483647 + 2 = 2147483649

Operações restantes na fila:
18 / 3

Operação atual:
18 / 3 = 6

Operações restantes na fila:
Não há operações restantes na fila.

Pilha de resultados:
6
2147483649
30
6
```
---
Desenvolvido como case técnico para processo seletivo para posição de Engenharia de Software JR.
