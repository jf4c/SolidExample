# 🛠️ S.O.L.I.D com .NET

> Esse repositorio tem como objetivo documentar o aprendizado sobre os princípios SOLID com .NET.

---

## 🎯 Single Responsability Principle (SRP)
- O princípio da responsabilidade única afirma que uma classe deve ter uma, e apenas uma, responsabilidade.
- Se uma classe tem mais de uma responsabilidade, ela deve ser dividida em classes menores.

### Exemplo:
❌ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/01_SRP/Bad) <br/>
✅ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/01_SRP/Good) 


## 🔒 Open/Closed Principle (OCP)
- O princípio aberto/fechado afirma que uma classe deve ser aberta para extensão, mas fechada para modificação.
- Ou seja, você deve conseguir estender um comportamento de uma classe sem modificá-lo.
- Isso torna o código manutenível e extensivel evitando quebrar o código existente.

### Exemplo:
❌ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/02_OCP/Bad) <br/>
✅ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/02_OCP/Good)

## 👨🏼‍🧒🏼 Liskov Substitution Principle (LSP)
- O princípio foi proposto por Barbara Liskov em 1987.
- Se F é filho de P, então objetos do tipo P em um programa pode ser substituídos por objetos do tipo F sem alterar as propriedades do programa.
- O filho herda do pai, logo o pai, pode ser substituído pelo filho sem alterar o funcionamento do programa.
### Exemplo:
❌ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/03_LSP/Bad) <br/>
✅ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/03_LSP/Good)

## 🔎 Interface Segregation Principle (ISP)
- Uma classe não deve ser forçada a implementar interfaces que ela não utiliza.
- Interfaces devem ser coesas.
### Exemplo:
❌ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/04_ISP/Bad) <br/>
✅ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/04_ISP/Good)

## 🧩 Dependency Inversion Principle (DIP)
- Dependa de abstrações e não de implementações.
- Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações.
- Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.
### Exemplo:
❌ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/05_DIP/Bad) <br/>
✅ [SRP](https://github.com/jf4c/SolidExample/tree/main/src/Solid/05_DIP/Good) 
